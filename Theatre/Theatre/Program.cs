﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie terminator = new Movie("Terminator 2: Judgement Day", 1991, 105);
            terminator.AddActor("Arnold Schwarzenegger");
            terminator.SetGenre(GenreEnum.Horror | GenreEnum.Action);
            terminator.AddActor("Linda Hamilton");
            Show s1 = new Show(terminator, new Time(11, 35), DayEnum.Mon, 5.95);
            Console.WriteLine(s1.ToString());

            Theatre eglinton = new Theatre("Cineplex");
            eglinton.AddShow(s1);
            eglinton.PrintShows();

            Movie godzilla = new Movie("Godzilla 2014", 2014, 123);
            godzilla.AddActor("Aaron Johnson");
            godzilla.AddActor("Ken Watanabe");
            godzilla.AddActor("Elizabeth Olsen");
            godzilla.SetGenre(GenreEnum.Action | GenreEnum.Documentary | GenreEnum.Comedy);
            Movie trancendence = new Movie("Transendence", 2014, 120);
            trancendence.AddActor("Johnny Depp");
            trancendence.AddActor("Morgan Freeman");
            trancendence.SetGenre(GenreEnum.Comedy);
            eglinton.AddShow(new Show(trancendence, new Time(18, 5), DayEnum.Sun, 7.87));
            Movie m1 = new Movie("The Shawshank Redemption", 1994, 120);
            m1.AddActor("Tim Robbins");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(GenreEnum.Action);
            eglinton.AddShow(new Show(m1, new Time(14, 5), DayEnum.Sun, 8.87));
            Movie avengers = new Movie("Avengers: Endgame", 2019, 120);
            avengers.AddActor("Robert Downey Jr.");
            avengers.AddActor("Chris Evans");
            avengers.AddActor("Chris Hemsworth");
            avengers.AddActor("Scarlett Johansson");
            avengers.AddActor("Mark Ruffalo");
            avengers.SetGenre(GenreEnum.Action | GenreEnum.Fantasy | GenreEnum.Adventure);
            eglinton.AddShow(new Show(avengers, new Time(21, 5), DayEnum.Sat, 12.25));
            m1 = new Movie("Olympus Has Fallen", 2013, 120);
            m1.AddActor("Gerard Butler");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(GenreEnum.Action);
            eglinton.AddShow(new Show(m1, new Time(16, 5), DayEnum.Sun, 8.87));
            m1 = new Movie("The Mask of Zorro", 1998, 136);
            m1.AddActor("Antonio Banderas");
            m1.AddActor("Anthony Hopkins");
            m1.AddActor("Catherine Zeta-Jones");
            m1.SetGenre(GenreEnum.Action | GenreEnum.Romance);
            eglinton.AddShow(new Show(m1, new Time(16, 5), DayEnum.Sun, 8.87));
            m1 = new Movie("Four Weddings and a Funeral", 1994, 117);
            m1.AddActor("Hugh Grant");
            m1.AddActor("Andie MacDowell");
            m1.AddActor("Kristin Scott Thomas");

            m1.SetGenre(GenreEnum.Comedy | GenreEnum.Romance);
            eglinton.AddShow(new Show(m1, new Time(15, 5), DayEnum.Sat, 8.87));
            eglinton.AddShow(new Show(m1, new Time(16, 5), DayEnum.Tue, 6.50));
            m1 = new Movie("You've Got Mail", 1998, 119);
            m1.AddActor("Tom Hanks");
            m1.AddActor("Meg Ryan");
            m1.SetGenre(GenreEnum.Comedy | GenreEnum.Romance);
            eglinton.AddShow(new Show(m1, new Time(15, 5), DayEnum.Sat, 8.87));
            m1 = new Movie("The Poison Rose", 2019, 98);
            m1.AddActor("John Travolta");
            m1.AddActor("Morgan Freeman");
            m1.AddActor("Brendan Fraser");
            m1.SetGenre(GenreEnum.Action | GenreEnum.Romance);
            eglinton.AddShow(new Show(m1, new Time(22, 5), DayEnum.Sun, 10.25));
            Movie car3 = new Movie("Cars 3", 2017, 109);
            car3.AddActor("Owen Williams");
            car3.AddActor("Cristela Alonzo");
            car3.AddActor("Arnie Hammer");
            car3.AddActor("Chris Cooper");
            car3.SetGenre(GenreEnum.Comedy | GenreEnum.Animation | GenreEnum.Romance);
            eglinton.AddShow(new Show(car3, new Time(09, 55), DayEnum.Sat, 6.40));
            eglinton.AddShow(new Show(car3, new Time(11, 05), DayEnum.Sat, 6.50));
            Movie toys4 = new Movie("Toys Story 4", 2019, 89);
            toys4.AddActor("Keanu Reeves");
            toys4.AddActor("Christina Hendricks");
            toys4.AddActor("Tom Hanks");
            toys4.AddActor("Tim Allen");
            toys4.SetGenre(GenreEnum.Comedy | GenreEnum.Fantasy | GenreEnum.Animation);
            eglinton.AddShow(new Show(toys4, new Time(14, 10), DayEnum.Sat, 6.40));
            eglinton.AddShow(new Show(godzilla, new Time(13, 55), DayEnum.Mon, 6.89));
            eglinton.AddShow(new Show(avengers, new Time(21, 5), DayEnum.Sat, 12.25));
            eglinton.AddShow(new Show(godzilla, new Time(14), DayEnum.Sun, 6.89));
            eglinton.AddShow(new Show(toys4, new Time(14, 10), DayEnum.Sat, 6.40));
            eglinton.AddShow(new Show(avengers, new Time(21, 5), DayEnum.Sat, 12.25));
            eglinton.AddShow(new Show(godzilla, new Time(16, 55), DayEnum.Sun, 6.89));
            eglinton.AddShow(new Show(avengers, new Time(21, 5), DayEnum.Sat, 12.25));
            eglinton.AddShow(new Show(m1, new Time(20, 35), DayEnum.Sat, 10.25));
            eglinton.AddShow(new Show(godzilla, new Time(22, 5), DayEnum.Wed, 8.50));
            eglinton.AddShow(new Show(avengers, new Time(20, 30), DayEnum.Tue, 10.75));
            eglinton.AddShow(new Show(godzilla, new Time(20, 15), DayEnum.Thu, 8.50));
            eglinton.AddShow(new Show(avengers, new Time(20, 30), DayEnum.Wed, 10.75));
            eglinton.AddShow(new Show(godzilla, new Time(18, 25), DayEnum.Fri, 8.50));
            eglinton.AddShow(new Show(avengers, new Time(14, 15), DayEnum.Sun, 10.75));

            eglinton.PrintShows();
            Console.WriteLine();
            eglinton.PrintShows(DayEnum.Sun);
            Console.WriteLine();
            eglinton.PrintShows(GenreEnum.Action);
            Console.WriteLine();
            eglinton.PrintShows(GenreEnum.Romance);
            Console.WriteLine();
            eglinton.PrintShows(GenreEnum.Action | GenreEnum.Romance);
            Console.WriteLine();
            eglinton.PrintShows("Morgan Freeman");
            Console.WriteLine();
            Time time = new Time(14, 05);
            eglinton.PrintShows(time);
            Console.WriteLine();
            eglinton.PrintShows(DayEnum.Sun, time);
        }
    }
    public enum DayEnum
    {
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat
    }
    [Flags]
    public enum GenreEnum
    {
        Unrated = 0,
        Action = 1,
        Comedy = 2,
        Horror = 4,
        Fantasy = 8,
        Musical = 16,
        Mystery = 32,
        Romance = 64,
        Adventure = 128,
        Animation = 256,
        Documentary = 512
    }
    public struct Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public Time(int hours, int minutes = 0)
        {
            Hours = hours;
            Minutes = minutes;
        }
        public override string ToString()
        {
            return $"{Hours}:{Minutes}";
        }
        public static bool operator ==(Time lhs, Time rhs)
        {
            int lhsTotalMinutes = (lhs.Hours * 60) + lhs.Minutes;
            int rhsTotalMinutes = (rhs.Hours * 60) + rhs.Minutes;
            return Math.Abs(lhsTotalMinutes - rhsTotalMinutes) <= 15;
        }
        public static bool operator !=(Time lhs, Time rhs)
        {
            return !(lhs == rhs);
        }
    }
    public class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public GenreEnum Genre { get; private set; }
        public List<string> Cast { get; } = new List<string>();
        public Movie(string title,int year,int length)
        {
            Title = title;
            Year = year;
            Length = length;
        }
        public void AddActor (string actor)
        {
            Cast.Add(actor);
        }
        public void SetGenre (GenreEnum genre)
        {
            Genre |= genre;
        }
    }
    public struct Show
    {
        public double Price { get; }
        public DayEnum Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }
        public Show(Movie movie, Time time, DayEnum day, double price)
        {
            Movie = movie;
            Time = time;
            Day = day;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Day} | {Time} | {Movie.Title} | Duration {Movie.Length}mins | {Movie.Genre} | {string.Join(",", Movie.Cast) }| {Price:C}";
        }
    }
    public class Theatre
    {
        public List<Show> shows;
        public string Name { get; }
        public Theatre(string name)
        {
            Name = name;
            shows = new List<Show>();
        }
        public void AddShow(Show show)
        {
            shows.Add(show);
        }
        public void PrintShows()
        {
            Console.WriteLine($"Shows at {Name}: All shows");

            for (int i = 0; i < shows.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{shows[i].Day} | {shows[i].Time} | {shows[i].Movie.Title} | Duration {shows[i].Movie.Length}mins | {shows[i].Movie.Genre} | {string.Join(",", shows[i].Movie.Cast) }| {shows[i].Price:C}");
            }
        }
        public void PrintShows (GenreEnum genre)
        {
            Console.WriteLine($"Shows at {Name}: {genre}");

            for (int i = 0; i < shows.Count; i++)
            {
                if (shows[i].Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine($"{i + 1}. {shows[i].Day} | {shows[i].Time} | {shows[i].Movie.Title} | Duration {shows[i].Movie.Length}mins | {shows[i].Movie.Genre} | {string.Join(",", shows[i].Movie.Cast) }| {shows[i].Price:C}");
                }
            }
        }
        public void PrintShows(DayEnum day)
        {
            Console.WriteLine($"Shows at {Name}: {day}");

            for (int i = 0; i < shows.Count; i++)
            {
                if (shows[i].Day == day)
                {
                    Console.WriteLine($"{i + 1}. {shows[i].Day} | {shows[i].Time} | {shows[i].Movie.Title} | Duration {shows[i].Movie.Length}mins | {shows[i].Movie.Genre} | {string.Join(",", shows[i].Movie.Cast) }| {shows[i].Price:C}");
                }
            }
        }
        public void PrintShows(Time time)
        {
            Console.WriteLine($"Shows at {Name}: {time.Hours}:{time.Minutes}");

            for (int i = 0; i < shows.Count; i++)
            {
                if (shows[i].Time == time)
                {
                    Console.WriteLine($"{i + 1}. {shows[i].Day} | {shows[i].Time} | {shows[i].Movie.Title} | Duration {shows[i].Movie.Length}mins | {shows[i].Movie.Genre} | {string.Join(",", shows[i].Movie.Cast) }| {shows[i].Price:C}");
                }
            }
        }
        public void PrintShows(string actor)
        {
            Console.WriteLine($"Shows at {Name}: {actor}");

            for (int i = 0; i < shows.Count; i++)
            {
                if (shows[i].Movie.Cast.Contains(actor))
                {
                    Console.WriteLine($"{i + 1}. {shows[i].Day} | {shows[i].Time} | {shows[i].Movie.Title} | Duration {shows[i].Movie.Length}mins | {shows[i].Movie.Genre} | {string.Join(",", shows[i].Movie.Cast) }| {shows[i].Price:C}");
                }
            }
        }

        public void PrintShows(DayEnum day, Time time)
        {
            Console.WriteLine($"Shows at {Name}: {day} {time.Hours}:{time.Minutes}");

            for (int i = 0; i < shows.Count; i++)
            {
                if (shows[i].Day == day && shows[i].Time == time)
                {
                    Console.WriteLine($"{i + 1}. {shows[i].Day} | {shows[i].Time} | {shows[i].Movie.Title} | Duration {shows[i].Movie.Length}mins | {shows[i].Movie.Genre} | {string.Join(",", shows[i].Movie.Cast) }| {shows[i].Price:C}");
                }
            }
        }
    }
}
