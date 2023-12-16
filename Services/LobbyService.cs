using UnrealLobby.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UnrealLobby.Services
{
    public class LobbyService
    {
        private readonly GameLobbyContext _context;
        private readonly List<Lobby> _lobbies = new List<Lobby>();

        public LobbyService(GameLobbyContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Lobby>> GetAllAsync()
        {
            return await _context.Lobbies.ToListAsync();
        }
        public Lobby Get(string id)
        {
            return _context.Lobbies.FirstOrDefault(l => l.LobbyId == id);
        }

        public Lobby CreateLobby(string name)
        {
            var newLobby = new Lobby { LobbyId = Guid.NewGuid().ToString(), Name = name };
            _context.Lobbies.Add(newLobby);
            _context.SaveChanges();
            return newLobby;
        }
    }
}
