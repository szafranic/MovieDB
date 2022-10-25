using MovieDB.Models;

namespace MovieDB
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//fillDB();
			Movie m = new Movie();
			Console.WriteLine("would you like to search for a title or genre in our movie database :)");
			Console.WriteLine("please type 'movie' or 'genre'");
			string input = Console.ReadLine();
			if (input == "movie")
			{
				m.SearchByTitle();
			} else if (input == "genre")
			{
				m.SearchByGenre();
			}
		}
		public static void fillDB()
		{
			MoviesContext db = new MoviesContext();

			Movie x = new Movie();
			x.Title = "Bassweight"; x.Genre = "Documentary"; x.Runtime = 56;
			db.Add(x);

			Movie a = new Movie();
			a.Title = "Human Traffic"; a.Genre = "Drama"; a.Runtime = 99;
			db.Add(a);

			Movie b = new Movie();
			b.Title = "Y Tu Mamá También"; b.Genre = "Romance"; b.Runtime = 106;
			db.Add(b);

			Movie c = new Movie();
			c.Title = "Cars 3"; c.Genre = "Adventure"; c.Runtime = 102;
			db.Add(c);

			Movie d = new Movie();
			d.Title = "Cars"; d.Genre = "Adventure"; d.Runtime = 117;
			db.Add(d);

			Movie e = new Movie();
			e.Title = "I’m Thinking of Ending Things"; e.Genre = "Thriller"; e.Runtime = 135;
			db.Add(e);

			Movie f = new Movie();
			f.Title = "Used Cars"; f.Genre = "Comedy"; f.Runtime = 113;
			db.Add(f);

			Movie g = new Movie();
			g.Title = "The Fast and the Furious"; g.Genre = "Action"; g.Runtime = 106;
			db.Add(g);

			Movie h = new Movie();
			h.Title = "The Big Short"; h.Genre = "Comedy"; h.Runtime = 131;
			db.Add(h);

			Movie i = new Movie();
			i.Title = "Musically Mad"; i.Genre = "Documentary"; i.Runtime = 60;
			db.Add(i);

			db.SaveChanges();
		}
	}
}