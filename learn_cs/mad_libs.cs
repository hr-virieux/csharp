using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program generates a Mad Libs story.
      Author: Henry Virieux
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Mad Libs has started.");

      // Give the Mad Lib a title:
      Console.WriteLine("Enter any title you like: ");
      string title = Console.ReadLine();

      // Define user input and variables:
      Console.WriteLine("Enter a name: ");
      string name = Console.ReadLine();

      Console.WriteLine("\nEnter 3 adjectives for your character:");
      Console.WriteLine("\nEnter a color: ");
      string color = Console.ReadLine();
      Console.WriteLine("\nEnter a feeling: ");
      string feeling = Console.ReadLine();
      Console.WriteLine("\nEnter a texture: ");
      string texture = Console.ReadLine();

      Console.WriteLine("\nEnter a verb for your character:");
      Console.WriteLine("\nEnter an action: ");
      string action = Console.ReadLine();

      Console.WriteLine("\nEnter 2 nouns for your character:");
      Console.WriteLine("\nEnter a place: ");
      string place = Console.ReadLine();
      Console.WriteLine("\nEnter a thing: ");
      string thing = Console.ReadLine();

      Console.WriteLine("\nEnter all of the following 7:");
      Console.WriteLine("\n1. Enter an animal: ");
      string animal = Console.ReadLine();
      Console.WriteLine("\n2. Enter a food: ");
      string food = Console.ReadLine();
      Console.WriteLine("\n3. Enter a fruit: ");
      string fruit = Console.ReadLine();
      Console.WriteLine("\n4. Enter a superhero: ");
      string superhero = Console.ReadLine();
      Console.WriteLine("\n5. Enter a country: ");
      string country = Console.ReadLine();
      Console.WriteLine("\n6. Enter a dessert: ");
      string dessert = Console.ReadLine();
      Console.WriteLine("\n7. Enter a year: ");
      int year = Int32.Parse(Console.ReadLine());


      // The template for the story:
      Console.WriteLine("\nThis is your poem:\n");

      string story = $"This morning {name} woke up feeling {feeling}. 'It is going to be a {texture} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {action} to the rhythm of the {place}, which made all the {fruit}s very {texture}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {feeling}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}
