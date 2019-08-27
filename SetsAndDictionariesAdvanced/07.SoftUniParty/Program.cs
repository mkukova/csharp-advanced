using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
	class Program
	{
		static void Main(string[] args)
		{
			var vipGuests = new HashSet<string>();
			var regularGuests = new HashSet<string>();
			string input = Console.ReadLine();

			while (input != "PARTY")
			{
				if (char.IsDigit(input[0]))
				{
					vipGuests.Add(input);
				}
				else
				{
					regularGuests.Add(input);
				}

				input = Console.ReadLine();
			}

			while (input != "END")
			{
				if (vipGuests.Contains(input))
				{
					vipGuests.Remove(input);
				}

				if (regularGuests.Contains(input))
				{
					regularGuests.Remove(input);
				}

				input = Console.ReadLine();
			}

			int vipGuestCount = vipGuests.Count;
			int regularGuestCount = regularGuests.Count;
			int totalGuest = vipGuestCount + regularGuestCount;
			Console.WriteLine(totalGuest);

			if (vipGuestCount > 0)
			{
				foreach (string reservationNumber in vipGuests)
				{
					Console.WriteLine(reservationNumber);
				}
			}

			if (regularGuestCount > 0)
			{
				foreach (string reservationNumber in regularGuests)
				{
					Console.WriteLine(reservationNumber);
				}
			}
		}
	}
}
