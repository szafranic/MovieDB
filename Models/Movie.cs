using System;
using System.Collections.Generic;

namespace MovieDB.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public double? Runtime { get; set; }

		public void SearchByGenre()
		{
			MoviesContext db = new MoviesContext();
			Console.WriteLine("what genre would you like to search for?");
			string input = Console.ReadLine().Trim();
			List<Movie> outp = db.Movies.Where(m => m.Genre.ToLower().Contains(input.ToLower())).ToList();
			int i = 0;
			foreach(Movie movie in outp)
			{
				i++;
				Console.WriteLine(i+" "+movie);
			}
		}
		public void SearchByTitle()
		{
			MoviesContext db = new MoviesContext();
			Console.WriteLine("what title would you like to search for?");
			string input = Console.ReadLine().Trim();
			List<Movie> outp = db.Movies.Where(m => m.Title.ToLower().Contains(input.ToLower())).ToList();
			int i = 0;
			foreach (Movie movie in outp)
			{
				i++;
				Console.WriteLine(i + " " + movie);
			}
		}

		public override string ToString()
		{
			return $"{Title}   |  Genre: {Genre}  |  Run Time of {Runtime} minutes.";
		}
	}
}