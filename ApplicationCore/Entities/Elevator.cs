using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApplicationCore.Models.RequestModel;

namespace ApplicationCore.Entities
{
    public class Elevator
    {
        public int currFloor = 0;
        public Direction elevatorDirection = new Direction();
        public bool isIdle = new bool();
        public Queue<RequestModel>? upQueue = new Queue<RequestModel>();
        public Queue<RequestModel>? downQueue = new Queue<RequestModel>();
    }
}
