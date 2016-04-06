﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Centuries = ");

            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            ulong hours = (ulong) days * 24;
            ulong minutes = hours * 60;

            ulong seconds = minutes * 60;
            ulong miliseconds = seconds * 1000;
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries= {years} years = {days} days= {hours} hours = {minutes} minutes= {seconds} seconds = {miliseconds} miliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            
             
        }
    }
}
