namespace HW3
{
    public class TemperatureSensor
    {
        public Room Temperature;
        public RemoteControl Power;

        public TemperatureSensor(Room _Temperature) 
            {
                this.Temperature = _Temperature; 
            }
         public string GetInfo(RemoteControl Power)
            {
                if (Power.Power == "On")
		        {
			       return $"Sensor shows in room, temperature : {Temperature.getTamperatureRoom()} degrees";
		        }
		        else
		        {
			        if (Power.Power == "Off")
			            {
				            return $"Air conditioner off";
			            }
			        else
			            {
				            return $"You entered incorrectly";
			            }
		        }
            }
                
    }
}