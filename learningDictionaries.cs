using System;
using System.Collections.Generic;

/* Creating a dictionary
 * Following instructors example
 */

namespace learningDictionaries
{

    // Classes can have state and behavior (added to Methods)
    class Program
    {
        
        static void Main(string[] args)
        {

            // Instance creating a dictionary
            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {

                // Adding entries to the dictionary
                { 101, "Robert" },
                { 102, "Michael" },

                { 103, "Roxie" },
                { 104, "Shelly" }
            };

            // Changing values already in the dictionary
            dictionary[101] = "Rachel";
            dictionary[102] = "Michelle";

            // Allow user to input data into the dictionary
            Console.WriteLine("Your user ID is 105" +
                "\nWhen prompted, please enter it below.");
            Console.WriteLine("Please enter your User ID: ");
            int newKey = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welcome to class, " +
                "please enter your first name to continue: ");
            string newName;
            newName = Console.ReadLine();
            Console.WriteLine("Hello {0} welcome. " +
                "Confirm that you've been added to the chart below " +
                "and type 'ok'", newName);
            dictionary.Add(newKey, newName);

            /* To print the values inside the dictionary
             * "i" is just what we chose to call it, it could have been kvp as well or whatever we choose
             * For each row of data "KeyValuePair"...
             */
            foreach(KeyValuePair<int, string> i in dictionary)
            {
                Console.WriteLine(i);
            }

            string endMessage = Console.ReadLine();

            Console.WriteLine("Confirmation \"{0}\" received... " +
                "\nProgram ended", endMessage);

        } 

    }
}
