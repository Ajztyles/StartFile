﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// "How many Days Console Application".

using System;

class Program {

    static void Main(string[] args) {

        while (true) {

            Console.WriteLine($"Enter a date(MM-dd-yyyy) or type 'exit' to quit:");
            string response = Console.ReadLine();

            if (response.Trim().ToLower()== "exit") {
                Console.WriteLine($"Goodbye!");
                break;
            }
            if (DateTime.TryParse(response, out DateTime enteredDate))
             {
                DateTime currentDate = DateTime.Now;
                int daysDifference = (enteredDate - currentDate.Date).Days;
                if (daysDifference > 0) 
                {
                    Console.WriteLine($"The entered date is {daysDifference} days in the future.");
                    Console.WriteLine($"The date {response} is in the future!");
                }
                else if (daysDifference < 0) 
                {
                    Console.WriteLine($"The entered date was {daysDifference} days ago.");
                    Console.WriteLine($"The date {response} is in the past!");
                }
                else 
                {
                    Console.WriteLine($"The entered date is today!");
                    Console.WriteLine($"The date {response} is the present day today!");
                }
            }
            else{
                    Console.WriteLine($"Invalid date format . Please enter a valid date in the format MM-dd-yyyy.");
                }
            Console.WriteLine();
        }
    }
}