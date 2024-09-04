namespace NET22_Test_EventHandlers
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat(new Random().Next(30));
            thermostat.TemperatureChangeRequested += (sender, e) =>
            {
                Console.WriteLine("Outside Temp = {0}, Target Temp = {1}. Requested HVAC to achieve target temp = {1}", e.OutsideTemp, e.TargetTemp);
            };

            thermostat.ChangeTemperature(10);
        }
    }
}
