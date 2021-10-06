namespace HW3
{
    public class RemoteControl
    {
        public string Power{ get; set; }
	    public int FutureTamperature{ get; set; }

       public RemoteControl(string _Power, int _FutureTamperature)
        {
            this.Power = _Power;
            this.FutureTamperature = _FutureTamperature;
        }

        public string SetTheDesiredTemperature()
	    {
		    return $"You entered {FutureTamperature} degrees on the controller";
	    }
        public string PowerOnOrOff()
	    {
		    if (Power == "On")
		    {
			    return $"You clicked on the controller: on";
		    }
		    else
		    {
			    if (Power == "Off")
			    {
				    return $"You clicked on the controller: off";
			    }
			    else
			    {
				    return $"You entered incorrectly";
			    }
		    }
	    }
    }
}