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
    public ActionResult<IEnumerable<Lobby>> GetAllLobbies()
    {
        return Ok(_lobbyService.GetAll());   
    }
}
