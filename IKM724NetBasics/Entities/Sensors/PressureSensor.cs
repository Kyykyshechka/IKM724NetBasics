using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Sensors
{
    public class PressureSensor : Sensor
    {
		public PressureSensor(string name, string description)
			: base(name, description) { }

		public override void ReadValue()
		{
			Value = 140 + new Random().NextDouble() * (200 - 140);
			Console.WriteLine($"{Name}: Pressure = {Value:F2} KPa");
		}
	}
}
