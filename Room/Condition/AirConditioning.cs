namespace HW3
{
    public class AirConditioning
    {
        public RemoteControl Power;
        
        public string PowerOnOrOff(RemoteControl Power)
        {
            if (Power.Power == "On")
		        {
			        return $"Air conditioner on";
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
        public string ShowInfo(RemoteControl Power)
        {
			if (Power.Power == "On")
		        {
			        return $"The air conditioner keeps the temperature:{Power.FutureTamperature} degrees";
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