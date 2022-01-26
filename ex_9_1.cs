using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Movie> movies = new List<Movie>() { };
        movies.Add(new Movie("Robocop", 102, 1987));
        movies.Add(new Movie("Robocop 2", 117, 1990));
        movies.Add(new Movie("Robocop 3", 104, 1993));

        foreach (var movie in movies)
        {
            Console.Write("Name: " + movie.Name + ", length: " + movie.Length + "min, year: " + movie.Year + "\n\r");
        }
    }
}


[Serializable]
public class Movie
{
    public Movie(string Name, int Length, int Year)
    {
        this.Name = Name;
        this.Length = Length;
        this.Year = Year;
    }

    public string Name { get; set; }
    public int Length { get; set; }
    public int Year { get; set; }
}