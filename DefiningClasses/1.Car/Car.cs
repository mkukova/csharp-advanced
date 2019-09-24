﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Car
{
	class Car
	{
		private int year;
		private string make;
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
		public int Year
		{
			get
			{
				if (year < 5)
				{
					return year;
				}

				return year - 3;
			}
		}

		public Car()
		{
			year = 1;
		}

		 public Car(int years)
		{
			this.year = years;
		}

		public int RealAge()
		{
			return year;
		}

		public void GetOld(int years)
		{
			year += years; 
		}
	}
}
