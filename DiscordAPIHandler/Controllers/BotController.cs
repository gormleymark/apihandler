using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/bot")]
public class BotController : ControllerBase
{
    private readonly ILogger<BotController> _logger;

    public BotController(ILogger<BotController> logger)
    {
        _logger = logger;
    }

    [HttpPost("data")]
    public IActionResult ReceiveBotData([FromBody] BotDataModel data)
    {
        // Handle the incoming data from the bot
        // Example: Store data in the local database or perform other actions

        return Ok("Data received successfully");
    }
}

public class BotDataModel
{
    // Define the data model for data coming from the bot
    // Example: public string AccessToken { get; set; }
    public string AccessToken { get; set; }
}
