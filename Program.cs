using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room(26);
            TemperatureSensor sensor = new TemperatureSensor(room);
            RemoteControl controller = new RemoteControl("On", 15);
            User user = new User();
            AirConditioning condition = new AirConditioning();


            Console.WriteLine($"{user.RemoteControlOperation(controller)}");
            Console.WriteLine($"{controller.PowerOnOrOff()}");
            Console.WriteLine($"{condition.PowerOnOrOff(controller)}");
            Console.WriteLine($"{sensor.GetInfo(controller)}");
            Console.WriteLine($"{controller.SetTheDesiredTemperature()}");
            Console.WriteLine($"{condition.ShowInfo(controller)}");
            

            Console.Read();
        }
    }
}
