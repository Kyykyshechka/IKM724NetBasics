using IKM724NetBasics.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Systems
{
    public class AlarmSystem : IControllable
	{
		public bool IsOn { get; private set; }

		public void TurnOn()
		{
			IsOn = true;
			Console.WriteLine("Alarm is on.");
		}
		public void TurnOff()
		{
			IsOn = false;
			Console.WriteLine("Alarm is off.");
		}
	}
}
