using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace Tests
{
    class Demon
    {
        public Demon(string name, int health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            List<Demon> demons = new List<Demon>();

            string patternHealth = @"[^\+\-\*\/\.0-9]";
            Regex rgHealth = new Regex(patternHealth);
            string patternDamage = @"[-+]*([0-9]+(\.[0-9]+)*)";
            Regex rgDamage = new Regex(patternDamage);


            for (int i = 0; i < input.Length; i++)
            {
                string demon = input[i];
                int countMultiply = 0;
                foreach (var symb in demon)
                {
                    if (symb == '*')
                    {
                        countMultiply++;
                    }    
                }

                int countDivide = 0;
                foreach (var symb in demon)
                {
                    if (symb == '/')
                    {
                        countDivide++;
                    }
                }

                int health = 0;
                MatchCollection characters = rgHealth.Matches(demon);
                foreach (Match match in characters)
                {
                    health += match.Value[0];
                }

                double damage = 0;
                MatchCollection numbers = rgDamage.Matches(demon);
                foreach (Match match in numbers)
                {
                    damage += double.Parse(match.Value);
                }

                for (int j = 0; j < countMultiply; j++)
                {
                    damage *= 2;
                }

                for (int j = 0; j < countDivide; j++)
                {
                    damage /= 2;
                }

                Demon newDemon = new Demon(demon, health, damage);
                demons.Add(newDemon);
            }

            foreach (var demon in demons.OrderBy(d=>d.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
    }
}
