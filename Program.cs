using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CSConsoleApplication11
{
	class Program
	{
		static void Main(string[] args)
		{
			string url = "https://api.openweathermap.org/data/2.5/weather?id=554840&units=metric&appid=b89307b85c4a07b3400ffc4e972271f7";

			HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
			HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

			string response;

			using (StreamReader strReader = new StreamReader(webResponse.GetResponseStream()))
			{
				response = strReader.ReadToEnd();
			}

			weatherResponse OWMResponse = JsonConvert.DeserializeObject<weatherResponse>(response);

			Console.WriteLine("Temperature in {0}: {1} °C", OWMResponse.Name, OWMResponse.Main.Temp);

		}
	}
}
