using System;
using System.IO;
using System.Linq;

class OfficeFileEnumerator
{
    // This function checks if a file is an Office file based on its extension.
    //My Helper Function
    static bool IsOfficeFile(string extension)
    {
        
        string[] officeExtensions = { ".xlsx", ".docx", ".pptx" };
        return officeExtensions.Contains(extension.ToLower());
    }

    static void Main()
    {
        
        string directoryName = "FileCollection";
        string resultsFileName = "results.txt";

        if (!Directory.Exists(directoryName))
        {
            Directory.CreateDirectory(directoryName);
            Console.WriteLine($"The Directory '{directoryName}' has been created. Place some Office files in it and run the program again.");
            return;
        }

        
        DirectoryInfo directoryInfo = new DirectoryInfo(directoryName);

        
        int xlsxCount = 0, docxCount = 0, pptxCount = 0;
        long xlsxSize = 0, docxSize = 0, pptxSize = 0;

        
        foreach (FileInfo file in directoryInfo.GetFiles())
        {

            if (IsOfficeFile(file.Extension))
            {
                
                if (file.Extension.ToLower() == ".xlsx")
                {
                    xlsxCount++;
                    xlsxSize += file.Length;
                }
                else if (file.Extension.ToLower() == ".docx")
                {
                    docxCount++;
                    docxSize += file.Length;
                }
                else if (file.Extension.ToLower() == ".pptx")
                {
                    pptxCount++;
                    pptxSize += file.Length;
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(resultsFileName))
        {
            writer.WriteLine("Office Files Summary:");
            writer.WriteLine("=====================");
            writer.WriteLine($"Excel Files (.xlsx): Count = {xlsxCount}, Total Size = {xlsxSize} bytes");
            writer.WriteLine($"Word Files (.docx): Count = {docxCount}, Total Size = {docxSize} bytes");
            writer.WriteLine($"PowerPoint Files (.pptx): Count = {pptxCount}, Total Size = {pptxSize} bytes");
            writer.WriteLine("=====================");
            writer.WriteLine($"Total Files: {xlsxCount + docxCount + pptxCount}");
            writer.WriteLine($"Total Size: {xlsxSize + docxSize + pptxSize} bytes");
        }

        
        Console.WriteLine($"Summary written to '{resultsFileName}'");
    }
}
