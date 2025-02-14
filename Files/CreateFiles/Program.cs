// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Creating and Deleting Files

const string ClassFile = "TextFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream
using (StreamWriter sw = File.CreateText(ClassFile)) {
    sw.WriteLine("This is a text file.");
 }
// // TODO: Determine if a file exists
Console.WriteLine(File.Exists(ClassFile));
if (File.Exists(ClassFile)) {
    File.Delete(ClassFile);
}else {
    using (StreamWriter sw = File.CreateText(ClassFile)) {
        sw.WriteLine("This is a text file.");
    }
}
Console.WriteLine(File.Exists(ClassFile));
