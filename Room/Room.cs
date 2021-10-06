namespace HW3
{
    public class Room
    {
        int TamperatureRoom { get; set; }

        public  Room(int _TamperatureRoom) 
        {
            this.TamperatureRoom = _TamperatureRoom;
        }
        public string  getTamperatureRoom()
	    {
            return $"{TamperatureRoom}";
	    }
    }
}