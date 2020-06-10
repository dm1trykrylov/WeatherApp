using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleApplication11
{
	class weatherResponse
	{
		private TemperatureInfo _main;
		private string _Name;

//		public TemperatureInfo Main { get; set; }
		public TemperatureInfo Main
		{
			get
			{
				return this._main;
			}
			set
			{
				this._main = value;
			}
		}


		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}
		
	}

}
