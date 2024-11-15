using Microsoft.AspNetCore.Mvc;

[ApiController]
public class LedApiController : ControllerBase {
    private readonly LedController ledController;

    public LedApiController(LedController _ledController) {
        ledController = _ledController;
    }

    [HttpGet("api/state")]
    public ActionResult<bool> GetLedState() {
        return Ok(ledController.IsLedOn);
    }

    [HttpPost("api/toggle")]
    public ActionResult<bool> ToggleLed() {
        ledController.ToggleLed();
        return Ok(ledController.IsLedOn);
    }
}
