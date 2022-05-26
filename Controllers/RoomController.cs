using HostelNaUOA.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelNaUOA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomServices _roomServices;
        public RoomController(IRoomServices roomServices)
        {
            _roomServices = roomServices;
        }
        [HttpGet]
        public IActionResult GetRoom()
        {
            return Ok(_roomServices.GetRoom());
        }

        [HttpGet("{id}", Name = "GetRoom")]
        public IActionResult GetRoom(string id)
        {
            return Ok(_roomServices.GetRoom(id));
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomServices.AddRoom(room);
            return CreatedAtRoute("GetRoom", new { id = room.Id }, room);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(string id)
        {
            _roomServices.DeleteRoom(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            return Ok(_roomServices.UpdateRoom(room));
        }
    }
}