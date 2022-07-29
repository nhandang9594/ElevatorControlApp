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
    public class PersonService : IPersonService
    {
        Person person;
        Elevator elevator;
        public PersonService(Person _person, Elevator _elevator)
        {
            person = _person;
            elevator = _elevator;
        }
        public int RequestElevator(int _nextFloor)
        {
            if (person.currFloor > elevator.currFloor)
            {
                RequestModel requestModel = new RequestModel(person.currFloor, _nextFloor, (Direction)0) { };
                elevator.upQueue.Enqueue(requestModel);
                return 1;
            }
            else if (person.currFloor < elevator.currFloor)
            {
                RequestModel requestModel = new RequestModel(person.currFloor, _nextFloor, (Direction)1) { };
                elevator.downQueue.Enqueue(requestModel);
                return 1;
            }
            return 0;
        }

        public int RequestFloor(int currFloor, int nextFloor)
        {
            if (nextFloor > currFloor)
            {
                elevator.currFloor = nextFloor;
                elevator.elevatorDirection = (Direction)0;
                return 1;
            }
            else if (nextFloor < currFloor)
            {
                elevator.currFloor = nextFloor;
                elevator.elevatorDirection = (Direction)1;
                return 1;
            }
            return 0;
        }
    }
}
