using FinalExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Specific
{
  public  interface IRoomService
    {
        List<Room> GetRooms();
    }
}
