namespace NET22_Test_EventHandlers
{
    public class TemperatureEventArgs : EventArgs
    {
        public int OutsideTemp { get; set; }
        public int TargetTemp { get; set; }
    }
}
