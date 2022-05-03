using Newtonsoft.Json;
using System;

namespace Lib
{
    public class Event
    {
        public long eventId { get; set; }
        public string team { get; set; }
        public string type { get; set; }
        public string subType { get; set; }
        public int period { get; set; }
        public int startFrame { get; set; }
        public double startTime { get; set; }
        public int endFrame { get; set; }
        public double endTime { get; set; }
        public string eventBy { get; set; }
        public string eventTo { get; set; }
        public double startX { get; set; }
        public double startY { get; set; }
        public double endX { get; set; }
        public double endY { get; set; }
    }
}
