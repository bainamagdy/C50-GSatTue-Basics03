using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace C50_GSatTue_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            //both title and upperTitle to show that title did not change.
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region Q02
            //Declare two separate string variables, both set to the literal "Clean Code".Use ReferenceEquals()
            //to check if they point to the same object in memory.

            //string name = "Clean Code";
            //string name2 = "Clean Code";
            //Console.Write(ReferenceEquals(name,name2));

            #endregion

            #region Q03
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result
            //StringBuilder s1 = new StringBuilder();
            //s1.Append("Book List");
            //s1.Append("Updated");
            //Console.WriteLine(s1);

            #endregion

            #region QO4
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            //s1.Replace("Book Lis", "Library");
            //Console.WriteLine(s1);


            #endregion

            #region Q05
            ////Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            ////Pages: 464" using the + operator.
            //string title = "Clean Code ";
            //int pages = 464;
            //Console.WriteLine("book: "+ title+ "pages:"+ pages);

            #endregion

            #region Q06
            ////Build the same sentence as above, but using string interpolation ($"...").
            //Console.WriteLine($"book:{title} pages:{pages}");

            #endregion
            #region Q07
            ////Build the same sentence again, but using string.Format().

            //string title = "Clean Code ";
            //int pages = 464;
            //Console.WriteLine(string.Format("book :{0}, pages:{1}", title, pages));
            #endregion
            #region Q08
            ////Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            ////300, otherwise prints "Short Book".
            //int pages = 464;
            //if (pages > 300) Console.WriteLine("long book");
            //else Console.WriteLine("short book");


            #endregion

            #region Q09
            ////Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            ////greater than 300 and isAvailable is true.Use the && operato
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable is true) Console.WriteLine("You can borrow this book");
            //else Console.WriteLine("you can't borrow this book");

            #endregion

            #region Q10
            ////Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            ////"Clean Code", "" if it's "Refactoring", and "Never heard of it" for anything else.
            //string title = "Refactoring";

            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;




            //}
            //;
            #endregion

            #region Q11
            ////Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            ////variable sizeLabel(same rule as question 8: long if pages > 300).
            //int pages = 464;
            //var res = pages > 300 ? "long book" : "short book";
            //Console.WriteLine(res);

            #endregion
            #region Q12
            ////Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
            ////to print each book with its position number, like 1.Clean Code.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for(int i =0; i<books.Length; i++)
            //{
            //    Console.WriteLine($"{books[i]} and it is postion number is {i}");
            //}
            #endregion

            #region Q13
            ////Using the same books array, use a while loop to print every book title.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while(books.Length >i)
            //{
            //    Console.WriteLine($"{books[i]} and it is postion number is {i}");
            //    i++;
            //}
            #endregion

            #region Q14
            ////Write a do-while loop that prints "Checking book..." exactly 3 times.
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;

            //} while (i <3);

            #endregion

            #region Q15
            ////Using the same books array, use a foreach loop to print every book title.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach(string title in books)
            //{
            //    Console.WriteLine(title);

            //}


            #endregion

            #region Q16
            ////Using the same books array, loop through it and print each title, but stop completely (break) once
            ////you reach "Refactoring".
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string title in books)
            //{
            //    if (title == "Refactoring") break;
            //    Console.WriteLine(title);

            //}


            #endregion


            #region Q17
            //Using the same books array, print every title except "The Pragmatic Programmer" (skip it with
            //continue, don't stop the loop).

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string title in books)
            {
                if (title == "The Pragmatic Programmer") continue;
                Console.WriteLine(title);

            }

            #endregion
        }
    }
}
