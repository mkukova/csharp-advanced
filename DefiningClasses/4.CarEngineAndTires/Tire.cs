﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _4.CarEngineAndTires
{
	class Tire
	{
		private int year;
		private double pressure;

		public int Year { get; set; }
		public double Pressure { get; set; }

		public Tire(int year, double pressure)
		{
			this.Year = year;
			this.Pressure = pressure;
		}
	}
}
