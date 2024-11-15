public class LedController {
    private bool _isLedOn;

    public bool IsLedOn => _isLedOn;

    public void ToggleLed() {
        _isLedOn = !_isLedOn;
    }
}
