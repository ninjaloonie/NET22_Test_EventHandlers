namespace NET22_Test_EventHandlers
{
    public class Thermostat
    {
        private readonly int _outsideTemperature;

        public Thermostat(int outsideTemperature)
        {
            _outsideTemperature = outsideTemperature;
        }

        public void ChangeTemperature(int temperature)
        {
            TemperatureEventArgs args = new TemperatureEventArgs();
            args.OutsideTemp = _outsideTemperature;
            args.TargetTemp = temperature;
            OnRequested(args);
        }
        
        public event EventHandler<TemperatureEventArgs> TemperatureChangeRequested;

        protected virtual void OnRequested(TemperatureEventArgs args) { 
            EventHandler<TemperatureEventArgs> handler = TemperatureChangeRequested;
            if (handler != null)
            {
                handler(this, args);
            }
        }
    }
}
