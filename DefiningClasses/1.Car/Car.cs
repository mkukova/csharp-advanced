using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Car
{
	class Car
	{
		private int year;
		private string make;
		private string model;
		public string Make
		{
			get
			{
				return make;
			}
			set
			{
				this.make = value;
			}
		}
		public string Model { get; set; }
		public int Year { get; set; }
	}
}
