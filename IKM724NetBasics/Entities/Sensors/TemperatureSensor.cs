using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Sensors
{
    public class TemperatureSensor : Sensor
    {
        public TemperatureSensor(string name, string description)
            : base(name, description){}

		public override void ReadValue()
		{
			Value = new Random().NextDouble() * 2000;
			Console.WriteLine($"{Name}: Temperature = {Value:F2} °C");
		}

	}
}
