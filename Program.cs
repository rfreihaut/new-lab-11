using System;
using System.Collections.Generic;

namespace lab_11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Movie m = new Movie("Star Wars: A New Hope", "Sci-Fi");

            //Console.WriteLine(m.Title);

            m.Title = "Star Wars: The Empire Strikes Back";

            m.Genre = "Sci-Fi";

        //List<Student> students = new List<Student>();

            List<Movie> movies = new List<Movie>();

            //students.Add(new Student("Zeek", "A house", "Sausage"));


            movies.Add(new Movie("Star Wars: A New Hope", "Sci-Fi"));

            movies.Add(new Movie("Star Wars: The Empire Strikes Back", "Sci-Fi"));

            movies.Add(new Movie("Star Wars: Return of the Jedi", "Sci-Fi"));

            movies.Add(new Movie("Star Wars: The Force Awakens", "Sci-Fi" ));

            movies.Add(new Movie("Star Wars: The Last Jedi", "Sci-Fi"));

            movies.Add(new Movie("The Good, the Bad, and the Ugly", "Western"));

            movies.Add(new Movie("High Noon", "Western"));

            movies.Add(new Movie("Rio Bravo ", "Western"));

            movies.Add(new Movie("True Grit ", "Western"));

            movies.Add(new Movie("The Wild Bunch", "Western"));


            //string genresearch = "Sci-Fi";

            string genresearch = "Western";

            //int i;

            //for (int i = 0; i < movies.Count; i++;)

            for (int i = 0; i < 10; i++)

            {

                if (movies[i].Genre == genresearch)

                //if (genresearch == "Sci-Fi")
                {

                    //Console.WriteLine(i);
                    Console.WriteLine(movies[i].Title);
                    //Console.WriteLine(i);

                   

                }

                //else if (movies[i].Genre == "Western")

                ////else if (genresearch == "Western")

                //{

                //    Console.WriteLine(movies[i].Title);



                //}

                //else

                //{

                     

                //}
            }



        }

        //public static List<Movie> movies = new List<Movie>();

        ////students.Add(new Student("Zeek", "A house", "Sausage"));
        //movies.Add(new Movie("Star Wars: A New Hope", "Sci-Fi"));
        //movies.Add(new Movie("Star Wars: The Force Awakens", "Sci Fi" ));
        //movies.Add(new Movie("Star Wars: The Last Jedi", "Sci Fi"));

        //movies.Add(new Movie("The Good, the Bad, and the Ugly", "Western"));

        //movies.Add(new Movie("High Noon", "Western"));

        //movies.Add(new Movie("Rio Bravo ", "Western"));
        //movies.Add(new Movie("True Grit ", "Western"));
        //movies.Add(new Movie("The Wild Bunch", "Western"));

    }
}



//AddStudent("Star Wars: A New Hope", "Sci-Fi", "   ", "   ");
//AddStudent("Star Wars: The Empire Strikes Back", "Sci Fi", "   ", "   ");
//AddStudent("Star Wars: Return of the Jedi", "Sci Fi", "    ", "   ");
//AddStudent("Star Wars: The Force Awakens", "Sci Fi", "   ", "   ");
//AddStudent("Star Wars: The Last Jedi", "Sci Fi", "   ", "   ");
//AddStudent("The Good, the Bad, and the Ugly", "Western", "    ", "   ");
//AddStudent("High Noon", "Western", "   ", "    ");
//AddStudent("Rio Bravo ", "Western", "     ", "    ");
//AddStudent("True Grit ", "Western", "    ", "    ");
//AddStudent("The Wild Bunch", "Western", "    ", "    ");
//AddStudent("CHANCES ARE", "Rom-Com", "   ", "   ");
//AddStudent("CHOCOLAT", "Rom-Com", "   ", "   ");
//AddStudent("UNDER THE TUSCAN SUN ", "Rom-Com", "    ", "   ");
//AddStudent("PRETTY WOMAN ", "Rom-Com", "   ", "   ");
//AddStudent("10 THINGS I HATE ABOUT YOU", "Rom-Com", "   ", "   ");
//AddStudent("The Bride of Frankenstein", "Horror", "    ", "   ");
//AddStudent("King Kong ", "Horror", "   ", "    ");
//AddStudent("Psycho ", "Horror", "     ", "    ");
//AddStudent("Frankenstein", "Horror", "    ", "    ");
//AddStudent("Rosemary's Baby", "Horror", "    ", "    ");
//AddStudent("The Adventures of Robin Hood ", "Action", "    ", "   ");
//AddStudent("Seven Samurai (Shichinin no Samurai)", "Action", "   ", "    ");
//AddStudent("Lawrence of Arabia", "Action", "     ", "    ");
//AddStudent("The Treasure of the Sierra Madre ", "Action", "    ", "    ");
//AddStudent("Apocalypse Now ", "Action", "    ", "    ");
