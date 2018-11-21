using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Movie
{
    public struct customDate
    {
        public int day;
        public int month;
        public int year;
    }


    public class Movie {
        private string movieName;
        private string movieGenre;
        private customDate releaseDate;
        public Movie() {
            Console.WriteLine("default Construction");
        }
        
        public Movie(string movieName,string movieGenre,customDate release)
        {
            this.movieName = movieName;
            this.movieGenre = movieGenre;
            releaseDate.day = release.day;
            releaseDate.month = release.month;
            releaseDate.year = release.year;
        }
        
        public void setName(string movieName)
        {
            this.movieName = movieName;
        }

        public void setGenre(string movieGenre)
        {
            this.movieGenre = movieGenre;
        }

        public void setdate(customDate release)
        {
            releaseDate.day = release.day;
            releaseDate.month = release.month;
            releaseDate.year = release.year;
        }

        public string getName()
        {
            return movieName;
        }

        public string getGenre()
        {
            return movieGenre;
        }

        public customDate getdate()
        {
            return releaseDate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            customDate abc, xyz;
            abc.day = 1;
            abc.month = 2;
            abc.year = 1990;
            xyz.day = 3;
            xyz.month = 4;
            xyz.year = 1995;
            Movie m1= new Movie();
            m1.setName("Hello");
            m1.setGenre("Comady");
            m1.setdate(abc);

            Console.WriteLine("Movie Name = {0}; Movie Genre = {1}; Movie Release date = {2}/{3}/{4}", m1.getName(),m1.getGenre(),m1.getdate().day,m1.getdate().month,m1.getdate().year);

            Movie m2 = new Movie("World","Adventure",xyz);

            Console.WriteLine("Movie Name = {0}; Movie Genre = {1}; Movie Release date = {2}/{3}/{4}", m2.getName(),m2.getGenre(),m2.getdate().day,m2.getdate().month,m2.getdate().year);
        }
    }
}
