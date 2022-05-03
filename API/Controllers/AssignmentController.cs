using Lib;
using Microsoft.AspNetCore.Mvc;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IGraphClient _client;
        public AssignmentController(IGraphClient client)
        {
            _client = client;
        }
        // GET: api/<AssignmentController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var items = await _client.Cypher.Match("(n:Event)")
                .Return(n => n.As<Event>()).Limit(5).ResultsAsync;

            return Ok(items);
        }

        // GET api/<AssignmentController>/5
        [HttpGet("activeplayer")]
        public async Task<ActionResult> ActivestPlayer()
        {
            var item = await _client.Cypher.Match("(n:Event),(m:Player)")
                .Where("n.eventBy = m.name or n.eventTo=m.name and n.type='PASS'")
                .Return(() => new
                {
                    Name = Return.As<string>("m.name"),
                    Actions = Return.As<int>("count(n)")
                }
               )
                .OrderByDescending("count(n)")
                .Limit(1).ResultsAsync;
            return Ok(item);
        }

        // POST api/<AssignmentController>
        [HttpGet("centralrole")]
        public async Task<ActionResult> CentralRole()
        {
            var items = await _client.Cypher.Match("(n:Event), (m:Player)")
                .Where("n.eventBy=m.name and not (n.type='SET PIECE' or n.type='CARD') ")
                .Return(() => new
                {
                    Name = Return.As<string>("m.name"),
                    AvgX = Return.As<double>("avg(n.startX)"),
                    AvgY = Return.As<double>("avg(n.startY)"),
                    AvgPos = Return.As<double>("avg(n.startX)+avg(n.startY)"),


                })
                .OrderBy("abs(avg(n.startX)+avg(n.startY)-1)").ResultsAsync;

            return Ok(items);
        }

        // PUT api/<AssignmentController>/5
        [HttpGet("mostshots")]
        public async Task<ActionResult> MostShots()
        {
            var items = await _client.Cypher.Match("(n:Event),(m:Player)")
                .Where("n.eventBy=m.name and n.type = 'SHOT' ")
                .Return(()=> new
                {
                    Name = Return.As<string>("m.name"),
                    AmountOfShots = Return.As<int>("count(n)")
                })
                .OrderByDescending("count(n)")
                .ResultsAsync;
            return Ok(items);
        }

        // DELETE api/<AssignmentController>/5
        [HttpGet("possession")]
        public async Task<ActionResult> Possession()
        {
            var items = await _client.Cypher
                .Match("(n:Event),(m:Team)")
                .Where("n.team=m.name")
                .Return(() => new
                {
                    TeamName = Return.As<string>("m.name"),
                    TimeWithTheBall = Return.As<double>("sum(n.endTime-n.startTime)")
                }).OrderByDescending("sum(n.endTime-n.startTime)")
                .ResultsAsync;
            return Ok(items);
        }

        [HttpGet("connection")]
        public async Task<ActionResult> ConnectionBetweenPlayers()
        {
            var items = await _client.Cypher.Match("(a:Player),(b:Player),(c:Event)")
                .Where("c.eventBy=a.name and c.eventTo=b.name and c.type='PASS'")
                .Return(() => new
                {
                    Player1 = Return.As<string>("a.name"),
                    Player2 = Return.As<string>("b.name"),
                    PassesBetween = Return.As<int>("count(c)")
                }).OrderByDescending("count(c)")
                .ResultsAsync;

            return Ok(items);
        }
    }
}
