using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApplicationCore.Models.RequestModel;

namespace Infrastructure.Services
{
    public class ElevatorService : IElevatorService
    {
        Elevator elevator;
        public ElevatorService(Elevator _elevator)
        {
            elevator = _elevator;
        }
        public RequestModel[] RequestAllFloors()
        {
            RequestModel[] dataArray = new RequestModel[] { };
            dataArray = elevator.upQueue.ToArray<RequestModel>();
            dataArray.Concat<RequestModel>(elevator.downQueue.ToArray<RequestModel>());
            return dataArray;
        }

        public int RequestNextFloor()
        {
            if (elevator.elevatorDirection == Direction.up)
            {
                var dataArray = elevator.upQueue.FirstOrDefault<RequestModel>();
                return dataArray.nextFloor;
            }
            else
            {
                var dataArray = elevator.downQueue.FirstOrDefault<RequestModel>();
                return dataArray.nextFloor;
            }
        }
    }
}
