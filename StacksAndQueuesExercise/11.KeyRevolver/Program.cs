using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
	class Program
	{
		static void Main(string[] args)
		{
			int priceOfBullet = int.Parse(Console.ReadLine());
			int gunBarrelSize = int.Parse(Console.ReadLine());
			int[] bullets = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();

			int[] locks = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();

			int intelligenceValue = int.Parse(Console.ReadLine());
			var lockQueue = new Queue<int>(locks);
			var bulletsStack = new Stack<int>(bullets);
			int totalBullets = bullets.Count();
			int usedBullets = 0;

			while (lockQueue.Any() && bulletsStack.Any())
			{
				int currentBullet = bulletsStack.Pop();
				int currentLock = lockQueue.Peek();

				if (currentBullet <= currentLock)
				{
					Console.WriteLine("Bang!");
					lockQueue.Dequeue();
				}
				else
				{
					Console.WriteLine("Ping!");
				}

				usedBullets++;

				if (usedBullets == gunBarrelSize && bulletsStack.Any())
				{
					Console.WriteLine("Reloading!");
					usedBullets = 0;
				}
			}

			if (!lockQueue.Any())
			{
				int leftBullets = bulletsStack.Count();
				int totalUsedBullets = totalBullets - leftBullets;
				int moneyEarned = intelligenceValue - (totalUsedBullets * priceOfBullet);
				Console.WriteLine($"{leftBullets} bullets left. Earned ${moneyEarned}");
			}
			else if (!bulletsStack.Any())
			{
				int leftLocks = lockQueue.Count();
				Console.WriteLine($"Couldn't get through. Locks left: {leftLocks}");
			}
		}
	}
}
