// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var directoryName = "Student";
Directory.CreateDirectory(directoryName);
var filename = "Student.txt";
 var filePath =Path.Combine(directoryName,filename);
using (File.Create(filePath))
{
    
}

    
        // Define an Action delegate for the void method
        Action logDelegate = AnotherClass.VoidMethod;

        // Call the LogMethodInformation and pass the Action delegate
        LogMethodInformation(logDelegate);

        // Read and display the log from the file
        string logContent = ReadLogFile();
        Console.WriteLine("Log content: " + logContent);
    

    static void LogMethodInformation(Action voidMethod)
    {
        // Log information within the method
        Console.WriteLine("Calling void method...");

        // Invoke the provided void method
        voidMethod?.Invoke();

        // Write the log to a file using StreamWriter
        using (StreamWriter writer = new StreamWriter("log.txt", true))
        {
            writer.WriteLine(DateTime.Now + ": Void method called");
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


class AnotherClass
{
    public static void VoidMethod()
    {
        // Your void method's implementation
        Console.WriteLine("Void method in AnotherClass");
    }
}
// string readText = File.ReadAllText("data.txt");
// Console.WriteLine(readText);
// //read text line by line
// string[]names = File.ReadAllLines("data.txt");
// foreach (var item in names)
// {
//     Console.WriteLine(item);
// }

 //To change the text in file
// string writeText = "This is a new year!";
// File.WriteAllText("filename.txt",writeText);
// string readfililtxt = File.ReadAllText("filename.txt");
// Console.WriteLine(readfililtxt); 

// //TO COPY A FILE

// //File.Copy("fileName", "copiedfile");

// //STREAMING

// // Create a StreamReader connected to a file
// //StreamReader reader = new StreamReader("data.txt");
// // Read the file here …
// // Close the reader resource after you've finished using it
// //reader.Close();

// // Create an instance of StreamReader to read from a file
// // StreamReader reader = new StreamReader("data.txt");
// // int lineNumber = 0;
// // // Read first line from the text file
// // string line = reader.ReadLine();
// // // Read the other lines from the text file
// // while (line != null)
// // {
// // lineNumber++;
// // Console.WriteLine("Type {0}: {1}", lineNumber, line);
// // line = reader.ReadLine();
// // }
// // // Close the resource after you've finished using it
// // reader.Close();


// //WRITING IN STREAM
// ///333333333333333333333333333333333333
// StreamWriter writer = new StreamWriter("data.txt");
// using (writer)   
// {
//      for (int i = 1; i < 20; i++)
//     {
//         writer.WriteLine(i);
//     }
// }
// //Catching an Exception when Opening a File

// string fileName =  "data.txt";
// try
// {
//     StreamReader reader = new StreamReader("fileName");
//     Console.WriteLine("the file {0} is succesfullyy opened", fileName);
//     Console.WriteLine("File Contents");

//     using (reader)
//     {
//         Console.WriteLine(reader.ReadToEnd());
//     }
// }
// catch (FileNotFoundException)
// {
//      Console.Error.WriteLine("File can not be found {0}.",fileName);
// }
// catch(DirectoryNotFoundException)
// {
//     Console.Error.WriteLine("Invalid directory in the file part.");
// }
// catch(IOException)
// {
//     Console.Error.WriteLine("File can not be found {0}.", fileName);
// }