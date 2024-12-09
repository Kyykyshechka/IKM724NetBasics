using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Sensors
{
    public class FlowMeter : Sensor
    {
		public FlowMeter(string name, string description)
			: base(name, description) { }

		public override void ReadValue()
		{
			Value = 17 + new Random().NextDouble() * (40 - 17);
			Console.WriteLine($"{Name}: Flow Meter = {Value:F2} м3/год");
		}
	}
}
