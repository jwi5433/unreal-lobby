namespace UnrealLobby.Models
{
    public class Lobby
    {
        public string LobbyId { get; set; }
        public string Name { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
    }
}
