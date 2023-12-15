using UnrealLobby.Models;
using System.Collections.Generic;
using System.Linq;

namespace UnrealLobby.Services
{
    public class LobbyService
    {
        private readonly List<Lobby> _lobbies = new List<Lobby>();

        public IEnumerable<Lobby> GetAll() => _lobbies;

        public Lobby Get(string id) => _lobbies.FirstOrDefault(l => l.LobbyId == id);
    }
}
