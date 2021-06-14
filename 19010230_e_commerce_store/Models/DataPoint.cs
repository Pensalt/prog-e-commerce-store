using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace _19010230_e_commerce_store.Models
{
	// The following code has been attributed from Canva.js
	// Author: Canva.js
	// Available at: https://canvasjs.com/asp-net-mvc-charts/bar-chart/

	//DataContract for Serializing Data - required to serve in JSON format
	[DataContract]
    public class DataPoint
    {
		public DataPoint(string label, double y)
		{
			this.Label = label;
			this.Y = y;
		}

		//Explicitly setting the name to be used while serializing to JSON.
		[DataMember(Name = "label")]
		public string Label = "";

		//Explicitly setting the name to be used while serializing to JSON.
		[DataMember(Name = "y")]
		public Nullable<double> Y = null;
	}
}
