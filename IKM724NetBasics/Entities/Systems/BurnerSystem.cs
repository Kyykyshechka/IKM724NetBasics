using IKM724NetBasics.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Systems
{
    public class BurnerSystem : IControllable
	{
		public bool IsOn { get; private set; }

		public void TurnOn()
		{
			IsOn = true;
			Console.WriteLine("Burner is on.");
		}
		public void TurnOff()
		{
			IsOn = false;
			Console.WriteLine("Burner is off.");
		}
	}
}
