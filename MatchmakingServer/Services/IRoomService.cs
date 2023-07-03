using SharedLibrary;

namespace MatchmakingServer.Services;

public interface IRoomService
{
    Room GetRoomById(string roomId);
    List<Room> GetAllRooms();
    Room CreateRoom(Room room);
}