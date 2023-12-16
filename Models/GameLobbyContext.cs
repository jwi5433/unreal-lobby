namespace UnrealLobby.Models;
using Microsoft.EntityFrameworkCore;
using UnrealLobby.Models;



public class GameLobbyContext : DbContext
{
    public GameLobbyContext(DbContextOptions<GameLobbyContext> options)
        : base(options)
    { 
    }
    
    public DbSet<Lobby> Lobbies { get; set; }   
    public DbSet<Player> Players { get; set; }
}
