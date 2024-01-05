// // See https://aka.ms/new-console-template for more information




using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Call the method and log information
        LogMethodInformation("Hello, this is a log entry.");

        // Read and display the log from the file
        string logContent = ReadLogFile();
        Console.WriteLine("Log content: " + logContent);
    }

    static void LogMethodInformation(string information)
    {
        // Log information within the method
        Console.WriteLine(information);

        // Write the log to a file using StreamWriter
        using (StreamWriter writer = new StreamWriter("log.txt", true))
        {
            writer.WriteLine(DateTime.Now + ": " + information);
        }
    }

    static string ReadLogFile()
    {
        // Read the log from the file using StreamReader
        using (StreamReader reader = new StreamReader("log.txt"))
        {
            return reader.ReadToEnd();
        }
    }
}

// //Console.WriteLine("Hello, World!");
// using System;  
// using System.IO;  
// using System.Runtime.Serialization.Formatters.Binary;  
// [Serializable]  
// class Student  
// {  
//     int rollno;  
//     string name;  
//     public Student(int rollno, string name)  
//     {  
//         this.rollno = rollno;  
//         this.name = name;  
//     }  
// }  
// public class SerializeExample  
// {  
//     public static void Main(string[] args)  
//     {  
//         FileStream stream = new FileStream("e:\\sss.txt", FileMode.OpenOrCreate);  
//         BinaryFormatter formatter=new BinaryFormatter();  
          
//         Student s = new Student(101, "sonoo");  
//         formatter.Serialize(stream, s);  
  
//         stream.Close();  
//     }  
// }  