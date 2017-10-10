using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ////if values needed are known
            //List<int> testScores = new List<int>() { 98, 100, 76, 84, 93 };

            ////to add values to the list afterward, these are added to the end
            //testScores.Add(80);
            //testScores.Add(99);

            ////.Count is the .Length of lists
            //List<int> luckyNumbers = new List<int>();
            //luckyNumbers.Add(2);
            //luckyNumbers.Add(3);
            //luckyNumbers.Add(5);
            //luckyNumbers.Add(7);
            //Console.WriteLine(luckyNumbers.Count);

            ////to print out elements from a list
            //List<string> faveFoods = new List<string>() { "steak", "pizza", "chicken", "seafood" };
            //Console.WriteLine(faveFoods[0]);
            //Console.WriteLine(faveFoods[1]);
            //Console.WriteLine(faveFoods[2]);
            //Console.WriteLine(faveFoods[3]);

            //List<string> leastFaveFoods = new List<string>();
            //leastFaveFoods.Add("Pork chops");
            //leastFaveFoods.Add("Mushrooms");
            //leastFaveFoods.Add("Tomatoes");
            //Console.WriteLine(leastFaveFoods[1]);
            ////Replaces the index given
            //leastFaveFoods[1] = "Gravy";
            //Console.WriteLine(leastFaveFoods[1]);

            ////looping a list
            //List<string> faveFilms = new List<string>() { "Inception", "Interstellar", "The Matrix", "Back to the Future" };
            //for (int i = 0; i < faveFilms.Count; i++)
            //{
            //    Console.WriteLine(faveFilms[i]);
            //}

            ////inserting into an established list
            //faveFilms.Insert(0, "Star Wars");
            //faveFilms.Insert(1, "Kingsman");
            //faveFilms.Insert(2, "James Bond");

            //foreach (string film in faveFilms)
            //{
            //    Console.WriteLine(film);
            //}

            ////removing from a list
            //faveFilms.Remove("Back to the Future");
            //faveFilms.Remove("Interstellar");
            //Console.WriteLine();

            //foreach (string film in faveFilms)
            //{
            //    Console.WriteLine(film);
            //}

            //Problem 1
            List<string> animals = new List<string>();
            animals.Add("Platypus");
            animals.Add("Otter");
            animals.Add("Kangaroo");
            animals.Add("Oppossum");
            animals.Add("Raccoon");

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            //Problem 2
            Console.WriteLine();
            List<bool> boolList = new List<bool>() { true, false, false, true, false };
            foreach (bool result in boolList)
            {
                if (result == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun");
                }
            }

            //Problem 3
            Console.WriteLine();
            List<int> numbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));

            numbers.Remove(27);
            numbers.Remove(77);
            numbers.Remove(32);
            numbers.Remove(6);

            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));
        }
    }
}
