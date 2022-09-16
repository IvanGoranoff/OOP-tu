using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator videoeditor = new VideoEditor("Georgi");
            Creator programmer = new Programmer("Asen");
            programmer.Name = "Ivan";

            List<Creator> creators = new List<Creator>();
            creators.Add(videoeditor);
            creators.Add(programmer);

            List<Programmer> programmers = new List<Programmer>();

            //LINQ operation
            int programmersCount = creators.Where(p => p is Programmer).Count();

            foreach (var creator in creators)
            {
                Console.WriteLine(creator.GetType().Name);
                Console.WriteLine(creator.Name);
                creator.Act();
            }

            //LINQ operations
            creators = creators
                .OrderBy(c => c.Name)
                .ToList();
            creators = creators
                .OrderByDescending(c => c.Name)
                .ToList();
            var creators2 = creators
                .GroupBy(c => c.Name)
                .ToList();
           
           // Console.WriteLine(creators2.Count);

            // List<int> energies = creators
            //   .Select(c => c.Energy)
            // .ToList();
        }

    }
}