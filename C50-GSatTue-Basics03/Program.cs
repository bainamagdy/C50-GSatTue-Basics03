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
            StringBuilder s1 = new StringBuilder();
            s1.Append("Book List");
            s1.Append("Updated");
            Console.WriteLine(s1);

            #endregion

        }
    }
}
