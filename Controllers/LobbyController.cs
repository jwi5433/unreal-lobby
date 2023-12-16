using Microsoft.AspNetCore.Mvc;
using UnrealLobby.Models;
using UnrealLobby.Services;
namespace UnrealLobby.Controllers;

[ApiController]
[Route("[controller]")]
public class LobbyController : ControllerBase
    {
        private readonly LobbyService _lobbyService;
        
        public LobbyController(LobbyService lobbyService) 
    {
        _lobbyService = lobbyService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Lobby>>> GetAllLobbies()
    {
        var lobbies = await _lobbyService.GetAllAsync();
        return Ok(lobbies);
    }

    [HttpPost("create")]
    public ActionResult<Lobby> CreateLobby([FromBody] string lobbyName)
    {
        var newLobby = _lobbyService.CreateLobby(lobbyName);
        return Ok(newLobby);
    }
}
