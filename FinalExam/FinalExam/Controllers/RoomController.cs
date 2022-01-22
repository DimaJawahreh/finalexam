using FinalExam.data;
using FinalExam.Specific;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        IRoomService roomService;
        public RoomController(IRoomService _roomService)
        {
            roomService = _roomService;
        }
        [HttpGet]
        [Route("rooms")]
        public List<Room> GetRooms()
        {
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }
    }
}
