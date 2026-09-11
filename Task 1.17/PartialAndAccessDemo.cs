using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvancedConcepts.FeatureApp
{
    public class PartialAndAccessDemo
    {

        public void Demonstrate()
        {
            
            try
            {
                /* Partial Class Demonstration */
                Employee emp = new Employee("Sanjanaa", "Software Engineer");
                emp.DisplayEmpInfo();
                

                /*Access Modifier Demonstrates the access levels of different members*/
                AccessModifierMatrix matrix = new AccessModifierMatrix(
                    "Public Value", 
                    "Private Value", 
                    "Protected Value", 
                    "Internal Value"
                    );
                matrix.DisplayAccessModifiers();



                /*Record*/
                Console.WriteLine("\nRecord Demonstration:");
                Address add1 = new Address ("Vellore", "Gajalakshmi Street", 632009 );
                Address add2 = new Address("Chennai", "Mylapore", 600004);
                Address add3 = new Address ("Bangalore", "K R Puram", 560036);

                Console.WriteLine($"Compare add1 and add2: {add1 == add2}");
                Console.WriteLine($"Compare add1 and add3: {add1 == add3}");                
                

                /*Copy records with "with"*/
                Address add4 = add1 with { StreetName = "KPK Nagar" };
                Console.WriteLine($"\nOriginal data of add1 Record: \n{add1}");
                Console.WriteLine($"Copied and Modified data of add4 Record: \n{add4}");



                /*Playlist Indexer*/    
                Console.WriteLine("\nPlaylist Indexer Demonstration:");
                Playlist mySong = new Playlist(4);
                mySong[0] = "Song 1";
                mySong[1] = "Song 2";
                mySong[2] = "Song 3";
                mySong[3] = "Song 4";

                for(int i = 0; i < mySong.Length; i++)
                {
                    Console.WriteLine($"Podcast {i}: {mySong[i]}");
                }

                try
                {
                    Console.WriteLine(
                        $"Invalid Song: {mySong[6]}"
                    );
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(
                        $"Playlist Error: {ex.Message}"
                    );
                }



                /*String Indexer*/
                Console.WriteLine("\nString Indexer Demonstration:");
                StringIndexer text = new StringIndexer("CSharp");

                Console.WriteLine($"Character at index 0: {text[0]}");
                Console.WriteLine($"Character at index 3: {text[3]}");

                try
                {
                    Console.WriteLine(text[10]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(
                        $"String Error: {ex.Message}"
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn error occurred: {ex.Message}");
            }
        }
    }
}
