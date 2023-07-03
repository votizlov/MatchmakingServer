using MatchmakingServer.Services;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace MatchmakingServer.Controllers;

public class RoomController : ControllerBase
{
    private readonly IRoomService roomService;

    public RoomController(IRoomService roomService)
    {
        this.roomService = roomService;
    }

    [HttpGet("rooms")]
    public IActionResult GetRooms()
    {
        var rooms = roomService.GetAllRooms();
        return Ok(rooms);
    }

    [HttpGet("room/{roomId}")]
    public IActionResult GetRoom(string roomId)
    {
        var room = roomService.GetRoomById(roomId);
        if (room == null)
        {
            return NotFound();
        }

        return Ok(room);
    }

    [HttpPost("createRoom")]
    public IActionResult CreateRoom([FromBody] Room room)
    {
        var createdRoom = roomService.CreateRoom(room);
        return CreatedAtAction(nameof(GetRoom), new { roomId = createdRoom.Id }, createdRoom);
    }
}