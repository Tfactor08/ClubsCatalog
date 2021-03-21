using System;
﻿using System.Data.Entity;

namespace ClubsCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            ClubDbContext db = new ClubDbContext();

            db.Players.Load();

            foreach (var club in db.Clubs) {
                Console.WriteLine($"{club}:");
                foreach (var player in club.Players) {
                    Console.WriteLine(player);
                }
            }
        }
    }
}
