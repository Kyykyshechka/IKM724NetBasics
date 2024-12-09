using IKM724NetBasics.Entities.Sensors;
using IKM724NetBasics.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities
{
    public class Furnace
    {
		public List<Sensor> Sensors { get; set; }
		public AlarmSystem Alarm { get; set; }
		public BurnerSystem Burner { get; set; }
		public FanSystem Fan { get; set; }

		public Furnace() 
		{
			Sensors = new List<Sensor>();
			Alarm = new AlarmSystem();
			Burner = new BurnerSystem();
			Fan = new FanSystem();
		}
		public void Monitor()
		{
			foreach (var sensor in Sensors)
			{
				sensor.ReadValue();
			}
		}
	}
}
