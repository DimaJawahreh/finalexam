using FinalExam.Context;
using FinalExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Specific
{
    public class RoomService: IRoomService
    {
        FinalContext context;
        public RoomService(FinalContext finalContext)
        {
            context = finalContext;
        }
        public List<Room> GetRooms()
        {
            List<Room> rooms = context.Room.ToList();
            return rooms;
        }
    }
}
