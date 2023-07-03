using SharedLibrary;

namespace MatchmakingServer.Services;

public class RoomService : IRoomService
{
    private List<Room> rooms = new List<Room>();

    public Room GetRoomById(string roomId)
    {
        return rooms.FirstOrDefault(r => r.Id == roomId);
    }

    public List<Room> GetAllRooms()
    {
        return rooms;
    }

    public Room CreateRoom(Room room)
    {
        room.Id = System.Guid.NewGuid().ToString();
        rooms.Add(room);
        return room;
    }
}