using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services
{
    public interface IPersonService
    {
        public int RequestElevator(int currFloor);
        public int RequestFloor(int currFloor, int nextFloor);

    }
}
