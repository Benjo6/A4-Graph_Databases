# How to make the program work.

1. Import football.json file into your database.

2. Either change the startup file to change the host name and password or call your host name: neo4j and password: 2wsxcde3.


# The results of the assignment: [Game 1]

**Question 1: Who is the most active player (in terms of passing and receiving the ball)?**

Answer: Player21 was the most active player in game 1 with 172 actions in the game. (Picture of the result is in the result folder under ActivestPlayer.png)

**Question 2: Who has had a central role in the match?**

Answer: The most central player is Player4 with an average position (Average X + Average Y) of 0.9968 (is the closest result to 1). (Picture of the result is in the result folder under CentralRole.png)

**Question 3: Which players have attempted to score?**

Answer: 

    "name": "Player9",
    "amountOfShots": 4
  
  
    "name": "Player10",
    "amountOfShots": 4
  
 
    "name": "Player8",
    "amountOfShots": 4
 
 
    "name": "Player7",
    "amountOfShots": 2
 
 
    "name": "Player5",
    "amountOfShots": 2
 

    "name": "Player21",
    "amountOfShots": 1
 
 
    "name": "Player19",
    "amountOfShots": 1

    "name": "Player12",
    "amountOfShots": 1
    
    "name": "Player14",
    "amountOfShots": 1
(Picture is in the result folder under the name MostShots.png)


**Question 4: Which team has kept the ball longer?**

Answer: The Home team had the ball for longer in this game.

 
    "teamName": "Home",
    "timeWithTheBall": 874.5600000000088
  
  
    "teamName": "Away",
    "timeWithTheBall": 768.7600000000036
   
(Picture is in the result folder under the name Possession.png)

**Question 5: Is there any close ‘societies’ between players (passing the ball to each other)?**

Answer: Look at the picture to see the graph 'soocities' between players (In result folder under the name GraphConnection.png) or enter this cypher script to see the graph yourself in your Neo4J browser:

MATCH (a:Player), (b:Player),(c:Event)
WHERE c.eventBy=a.name and c.eventTo=b.name and c.type='PASS'
RETURN a,b,c

**Question 6: How close is the connection between two specific players?

Answer: Here is the number of passes between players, you can also see the picture of the result in result folder under the name Connection.png.

    "player1": "Player19",
    "player2": "Player21",
    "passesBetween": 13
  
    "player1": "Player4",
    "player2": "Player8",
    "passesBetween": 13
  
    "player1": "Player7",
    "player2": "Player2",
    "passesBetween": 13
  
    "player1": "Player2",
    "player2": "Player7",
    "passesBetween": 12
  
    "player1": "Player5",
    "player2": "Player7",
    "passesBetween": 11
  
    "player1": "Player21",
    "player2": "Player19",
    "passesBetween": 11
  
    "player1": "Player3",
    "player2": "Player2",
    "passesBetween": 11
  
    "player1": "Player6",
    "player2": "Player10",
    "passesBetween": 10
  
    "player1": "Player10",
    "player2": "Player8",
    "passesBetween": 10
  
    "player1": "Player16",
    "player2": "Player21",
    "passesBetween": 10
  
    "player1": "Player4",
    "player2": "Player3",
    "passesBetween": 10
  
    "player1": "Player21",
    "player2": "Player17",
    "passesBetween": 10
  
    "player1": "Player8",
    "player2": "Player4",
    "passesBetween": 10
  
    "player1": "Player21",
    "player2": "Player22",
    "passesBetween": 9
  
    "player1": "Player16",
    "player2": "Player15",
    "passesBetween": 9
  
    "player1": "Player22",
    "player2": "Player21",
    "passesBetween": 9
  
    "player1": "Player12",
    "player2": "Player6",
    "passesBetween": 9
  
    "player1": "Player6",
    "player2": "Player12",
    "passesBetween": 9
  
    "player1": "Player7",
    "player2": "Player12",
    "passesBetween": 9
  
    "player1": "Player12",
    "player2": "Player10",
    "passesBetween": 9
  
    "player1": "Player22",
    "player2": "Player20",
    "passesBetween": 8
  
    "player1": "Player15",
    "player2": "Player21",
    "passesBetween": 8
  
    "player1": "Player17",
    "player2": "Player16",
    "passesBetween": 8
  
    "player1": "Player7",
    "player2": "Player5",
    "passesBetween": 8
  
    "player1": "Player22",
    "player2": "Player17",
    "passesBetween": 7
  
    "player1": "Player21",
    "player2": "Player20",
    "passesBetween": 7
  
    "player1": "Player3",
    "player2": "Player4",
    "passesBetween": 7
  
    "player1": "Player18",
    "player2": "Player19",
    "passesBetween": 7
  
    "player1": "Player20",
    "player2": "Player19",
    "passesBetween": 7
  
    "player1": "Player2",
    "player2": "Player3",
    "passesBetween": 7
  
    "player1": "Player10",
    "player2": "Player7",
    "passesBetween": 7
  
    "player1": "Player7",
    "player2": "Player10",
    "passesBetween": 7
  
    "player1": "Player8",
    "player2": "Player12",
    "passesBetween": 7
  
    "player1": "Player20",
    "player2": "Player21",
    "passesBetween": 7
  
    "player1": "Player21",
    "player2": "Player15",
    "passesBetween": 6
  
    "player1": "Player20",
    "player2": "Player22",
    "passesBetween": 6
  
    "player1": "Player21",
    "player2": "Player18",
    "passesBetween": 6
  
    "player1": "Player15",
    "player2": "Player16",
    "passesBetween": 6
  
    "player1": "Player6",
    "player2": "Player4",
    "passesBetween": 6
  
    "player1": "Player6",
    "player2": "Player3",
    "passesBetween": 6
  
    "player1": "Player12",
    "player2": "Player4",
    "passesBetween": 6
  
    "player1": "Player4",
    "player2": "Player12",
    "passesBetween": 6
  
    "player1": "Player12",
    "player2": "Player5",
    "passesBetween": 6
  
    "player1": "Player5",
    "player2": "Player10",
    "passesBetween": 6
  
    "player1": "Player19",
    "player2": "Player18",
    "passesBetween": 5
  
    "player1": "Player17",
    "player2": "Player22",
    "passesBetween": 5
  
    "player1": "Player4",
    "player2": "Player9",
    "passesBetween": 5
  
    "player1": "Player17",
    "player2": "Player21",
    "passesBetween": 5
  
    "player1": "Player20",
    "player2": "Player16",
    "passesBetween": 5
  
    "player1": "Player10",
    "player2": "Player5",
    "passesBetween": 5
  
    "player1": "Player19",
    "player2": "Player17",
    "passesBetween": 5
  
    "player1": "Player12",
    "player2": "Player2",
    "passesBetween": 5
  
    "player1": "Player12",
    "player2": "Player8",
    "passesBetween": 5
 
    "player1": "Player3",
    "player2": "Player12",
    "passesBetween": 5
  
    "player1": "Player16",
    "player2": "Player20",
    "passesBetween": 5
  
    "player1": "Player2",
    "player2": "Player12",
    "passesBetween": 5
  
    "player1": "Player15",
    "player2": "Player17",
    "passesBetween": 5
  
    "player1": "Player21",
    "player2": "Player16",
    "passesBetween": 5
  
    "player1": "Player19",
    "player2": "Player20",
    "passesBetween": 4
  
    "player1": "Player17",
    "player2": "Player20",
    "passesBetween": 4
  
    "player1": "Player20",
    "player2": "Player18",
    "passesBetween": 4
  
    "player1": "Player8",
    "player2": "Player10",
    "passesBetween": 4
  
    "player1": "Player6",
    "player2": "Player5",
    "passesBetween": 4

    "player1": "Player9",
    "player2": "Player4",
    "passesBetween": 4
  
    "player1": "Player2",
    "player2": "Player11",
    "passesBetween": 4
  
    "player1": "Player3",
    "player2": "Player8",
    "passesBetween": 4
  
    "player1": "Player3",
    "player2": "Player11",
    "passesBetween": 4
  
    "player1": "Player17",
    "player2": "Player18",
    "passesBetween": 4
  
    "player1": "Player12",
    "player2": "Player7",
    "passesBetween": 4
  
    "player1": "Player4",
    "player2": "Player6",
    "passesBetween": 4
  
    "player1": "Player8",
    "player2": "Player6",
    "passesBetween": 4
  
    "player1": "Player6",
    "player2": "Player8",
    "passesBetween": 4
  
    "player1": "Player12",
    "player2": "Player3",
    "passesBetween": 4
  
    "player1": "Player6",
    "player2": "Player7",
    "passesBetween": 4
 
    "player1": "Player17",
    "player2": "Player19",
    "passesBetween": 4
  
    "player1": "Player15",
    "player2": "Player19",
    "passesBetween": 3
  
    "player1": "Player2",
    "player2": "Player9",
    "passesBetween": 3
  
    "player1": "Player5",
    "player2": "Player6",
    "passesBetween": 3
  
    "player1": "Player22",
    "player2": "Player19",
    "passesBetween": 3
  
    "player1": "Player18",
    "player2": "Player21",
    "passesBetween": 3
  
    "player1": "Player18",
    "player2": "Player15",
    "passesBetween": 3
  
    "player1": "Player11",
    "player2": "Player5",
    "passesBetween": 3
  
    "player1": "Player19",
    "player2": "Player16",
    "passesBetween": 3
  
    "player1": "Player5",
    "player2": "Player9",
    "passesBetween": 3
  
    "player1": "Player4",
    "player2": "Player10",
    "passesBetween": 3
  
    "player1": "Player16",
    "player2": "Player17",
    "passesBetween": 3
  
    "player1": "Player15",
    "player2": "Player18",
    "passesBetween": 3
  
    "player1": "Player9",
    "player2": "Player6",
    "passesBetween": 3
  
    "player1": "Player7",
    "player2": "Player6",
    "passesBetween": 3
  
    "player1": "Player7",
    "player2": "Player9",
    "passesBetween": 3
  
    "player1": "Player11",
    "player2": "Player4",
    "passesBetween": 3
  
    "player1": "Player2",
    "player2": "Player5",
    "passesBetween": 3
  
    "player1": "Player18",
    "player2": "Player17",
    "passesBetween": 3
  
    "player1": "Player8",
    "player2": "Player9",
    "passesBetween": 3
  
    "player1": "Player18",
    "player2": "Player22",
    "passesBetween": 3
  
    "player1": "Player3",
    "player2": "Player7",
    "passesBetween": 3
  
    "player1": "Player5",
    "player2": "Player2",
    "passesBetween": 3
  
    "player1": "Player9",
    "player2": "Player12",
    "passesBetween": 3
  
    "player1": "Player2",
    "player2": "Player6",
    "passesBetween": 3
  
    "player1": "Player13",
    "player2": "Player14",
    "passesBetween": 3
  
    "player1": "Player14",
    "player2": "Player12",
    "passesBetween": 3
  
    "player1": "Player7",
    "player2": "Player14",
    "passesBetween": 3
  
    "player1": "Player16",
    "player2": "Player19",
    "passesBetween": 2
  
    "player1": "Player1",
    "player2": "Player10",
    "passesBetween": 2
  
    "player1": "Player1",
    "player2": "Player2",
    "passesBetween": 2
  
    "player1": "Player10",
    "player2": "Player6",
    "passesBetween": 2
  
    "player1": "Player8",
    "player2": "Player3",
    "passesBetween": 2
  
    "player1": "Player5",
    "player2": "Player1",
    "passesBetween": 2
  
    "player1": "Player1",
    "player2": "Player5",
    "passesBetween": 2
  
    "player1": "Player3",
    "player2": "Player1",
    "passesBetween": 2
  
    "player1": "Player6",
    "player2": "Player1",
    "passesBetween": 2
  
    "player1": "Player3",
    "player2": "Player6",
    "passesBetween": 2
  
    "player1": "Player16",
    "player2": "Player22",
    "passesBetween": 2
  
    "player1": "Player4",
    "player2": "Player2",
    "passesBetween": 2
  
    "player1": "Player5",
    "player2": "Player8",
    "passesBetween": 2
  
    "player1": "Player4",
    "player2": "Player7",
    "passesBetween": 2
  
    "player1": "Player15",
    "player2": "Player22",
    "passesBetween": 2
  
    "player1": "Player7",
    "player2": "Player8",
    "passesBetween": 2
  
    "player1": "Player6",
    "player2": "Player2",
    "passesBetween": 2
  
    "player1": "Player5",
    "player2": "Player12",
    "passesBetween": 2
  
    "player1": "Player10",
    "player2": "Player12",
    "passesBetween": 2
  
    "player1": "Player2",
    "player2": "Player4",
    "passesBetween": 2
  
    "player1": "Player11",
    "player2": "Player7",
    "passesBetween": 2
  
    "player1": "Player16",
    "player2": "Player18",
    "passesBetween": 2
  
    "player1": "Player11",
    "player2": "Player12",
    "passesBetween": 2
  
    "player1": "Player22",
    "player2": "Player16",
    "passesBetween": 2
  
    "player1": "Player17",
    "player2": "Player15",
    "passesBetween": 2
  
    "player1": "Player9",
    "player2": "Player8",
    "passesBetween": 2
  
    "player1": "Player12",
    "player2": "Player9",
    "passesBetween": 2
  
    "player1": "Player2",
    "player2": "Player14",
    "passesBetween": 2
  
    "player1": "Player14",
    "player2": "Player9",
    "passesBetween": 2
 
    "player1": "Player11",
    "player2": "Player9",
    "passesBetween": 2
  
    "player1": "Player14",
    "player2": "Player7",
    "passesBetween": 2
  
    "player1": "Player12",
    "player2": "Player13",
    "passesBetween": 2
  
    "player1": "Player9",
    "player2": "Player10",
    "passesBetween": 1
  
    "player1": "Player10",
    "player2": "Player9",
    "passesBetween": 1
  
    "player1": "Player2",
    "player2": "Player1",
    "passesBetween": 1
  
    "player1": "Player2",
    "player2": "Player8",
    "passesBetween": 1
  
    "player1": "Player9",
    "player2": "Player5",
    "passesBetween": 1
  
    "player1": "Player1",
    "player2": "Player6",
    "passesBetween": 1
  
    "player1": "Player11",
    "player2": "Player3",
    "passesBetween": 1
  
    "player1": "Player7",
    "player2": "Player4",
    "passesBetween": 1
  
    "player1": "Player9",
    "player2": "Player1",
    "passesBetween": 1
 
    "player1": "Player20",
    "player2": "Player15",
    "passesBetween": 1
  
    "player1": "Player20",
    "player2": "Player17",
    "passesBetween": 1
  
    "player1": "Player19",
    "player2": "Player22",
    "passesBetween": 1
  
    "player1": "Player1",
    "player2": "Player7",
    "passesBetween": 1
  
    "player1": "Player6",
    "player2": "Player9",
    "passesBetween": 1
  
    "player1": "Player9",
    "player2": "Player7",
    "passesBetween": 1
  
    "player1": "Player7",
    "player2": "Player1",
    "passesBetween": 1
  
    "player1": "Player15",
    "player2": "Player20",
    "passesBetween": 1
  
    "player1": "Player11",
    "player2": "Player2",
    "passesBetween": 1
  
    "player1": "Player19",
    "player2": "Player15",
    "passesBetween": 1
  
    "player1": "Player7",
    "player2": "Player3",
    "passesBetween": 1
    
    "player1": "Player18",
    "player2": "Player16",
    "passesBetween": 1
  
    "player1": "Player4",
    "player2": "Player5",
    "passesBetween": 1
  
    "player1": "Player11",
    "player2": "Player6",
    "passesBetween": 1
   
    "player1": "Player10",
    "player2": "Player4",
    "passesBetween": 1
  
    "player1": "Player7",
    "player2": "Player13",
    "passesBetween": 1
  
    "player1": "Player13",
    "player2": "Player7",
    "passesBetween": 1
  
    "player1": "Player2",
    "player2": "Player13",
    "passesBetween": 1
  
    "player1": "Player13",
    "player2": "Player5",
    "passesBetween": 1
  
    "player1": "Player5",
    "player2": "Player4",
    "passesBetween": 1
  
    "player1": "Player5",
    "player2": "Player3",
    "passesBetween": 1
  
    "player1": "Player9",
    "player2": "Player13",
    "passesBetween": 1
  
    "player1": "Player4",
    "player2": "Player13",
    "passesBetween": 1
  
    "player1": "Player13",
    "player2": "Player8",
    "passesBetween": 1
  
    "player1": "Player9",
    "player2": "Player14",
    "passesBetween": 1
  
    "player1": "Player9",
    "player2": "Player2",
    "passesBetween": 1
  
    "player1": "Player8",
    "player2": "Player13",
    "passesBetween": 1
  
    "player1": "Player11",
    "player2": "Player14",
    "passesBetween": 1
  
    "player1": "Player12",
    "player2": "Player14",
    "passesBetween": 1
  
    "player1": "Player11",
    "player2": "Player8",
    "passesBetween": 1
  
    "player1": "Player3",
    "player2": "Player14",
    "passesBetween": 1
  
    "player1": "Player14",
    "player2": "Player3",
    "passesBetween": 1
  
    "player1": "Player3",
    "player2": "Player13",
    "passesBetween": 1
  
    "player1": "Player3",
    "player2": "Player5",
    "passesBetween": 1
  
    "player1": "Player13",
    "player2": "Player4",
    "passesBetween": 1
 
