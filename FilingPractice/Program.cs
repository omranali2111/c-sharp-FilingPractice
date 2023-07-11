using System.Diagnostics.Metrics;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{

    private static void Main(string[] args)
    {
        /*
        Console.WriteLine("enter a name for the file:");
        string fileName = Console.ReadLine();
        Console.WriteLine("enter a text to write it to a file");
        string text = Console.ReadLine();

        task1(fileName, text);

        Console.WriteLine("**********************************");
        Console.WriteLine("enter a name for the first file:");
        string file1 = Console.ReadLine();
        Console.WriteLine("enter a name for the second file:");
        string file2 = Console.ReadLine();
        Console.WriteLine("enter a text to write it to a file");
        string text1 = Console.ReadLine();

        task2(file1,file2, text1);
        */
        Console.WriteLine("**********************************");
        Console.WriteLine("enter a name for the file:");
        string fileName1 = Console.ReadLine();
        Console.WriteLine("enter a text to write it to a file");
        string text2 = Console.ReadLine();
        task3(fileName1, text2);

    }
    public static void task1(string fileName, string text)
    {

        /*
        1.Task: File Reader and File Writer
    Write a program:
    • That writes the content to a file
    • That can read contents of a file
    • If the file exist, it appends/adds the text to the file.
        */

        StreamWriter writer = null;

        try
        {
            using (writer = new StreamWriter(fileName))
                writer.WriteLine(text);

            using (StreamReader sr = File.OpenText(fileName))//using is to clear the buffer and close the file
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    // printing the file contents
                    Console.WriteLine(s);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    /*
     2. Task: File Copy
Implement a program that copies the content of one text file to another.
Handle cases where the source file does not exist or the destination file already exists.
    */

    public static void task2(string file1, string file2, string text)
    {
        StreamWriter writer = null;

        try
        {
            using (writer = new StreamWriter(file1))
                writer.WriteLine(text);
            File.Copy(file1, file2);
            using (StreamReader sr = File.OpenText(file2))//using is to clear the buffer and close the file
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    // printing the file contents
                    Console.WriteLine(s);
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
           



        
    }
    public static void task3(string file,string text)
        /*
          3. Task: File Statistics
        Create a program that reads a text file and provides statistics about its content.
        Count the number of lines, words, and characters in the file.
        Display the statistics on the console
        */
    {
        

        StreamWriter writer = null;
        var lineCount = 0;
        var wordCount = 0;
        var charcount=0;

        try
        {
            using (writer = new StreamWriter(file))
                writer.WriteLine(text);

            using (StreamReader sr = File.OpenText(file))//using is to clear the buffer and close the file
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    // printing the file contents
                    Console.WriteLine(s);
                    
                }
                lineCount=text.Split('\r').Length;
                wordCount=text.Split(" ").Length; 
                charcount = text.Replace(" ","").Length;//Replace is delete the spaces 
            }

            Console.WriteLine($"the number of lines in the file are/is: {lineCount}");
            Console.WriteLine($"the number of words is/are: {wordCount}");
            Console.WriteLine($"the number of char is/are: {charcount}");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }

}