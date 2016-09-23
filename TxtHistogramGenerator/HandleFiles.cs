/*
    Word Count Histogram Generator
    Fizzworks Studios - Fizzworks Futuristics (Experimental)

    Code Poet: Anthony McKeever
    Date: 9/16/2016 to 9/22/2016
    Language: C#
    Framework: .Net 4.6.1

    Generates a histogram based on word counts.
    Crawls all zip files to collect word counts.

    Class: HandleFiles.cs
    This class works with the files to get the word counts for the histogram.
    It also crawls each zip file (and child zip files) recursively until all items are collected.
*/

using amExtensibility;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;

namespace TxtHistogramGenerator
{
    public class HandleFiles
    {
        private string folderPath;
        private List<string> folderContents;
        private string currentFolder;

        public HandleFiles(string folder)
        {
            folderPath = folder;
            currentFolder = Path.GetTempPath();

            folderContents = new List<string>();
            DirectoryInfo dInfo = new DirectoryInfo(folderPath);

            foreach (FileInfo file in dInfo.GetFiles())
            {
                string fileName = file.FullName;
                string fileExt = fileName.Split('.').Last();

                if (fileExt == "txt" || fileExt == "zip") folderContents.Add(fileName);
            }
        }

        public List<KeyValuePair<string, int>> GetWordCounts(List<string> folderFiles = null)
        {
            List<KeyValuePair<string, int>> files = new List<KeyValuePair<string, int>>();
            folderFiles = folderFiles == null ? folderContents : folderFiles;

            foreach (string file in folderFiles)
            {
                if (file.EndsWith("txt"))
                {
                    files.Add(getContents(file));
                }
                else if (file.EndsWith("zip"))
                {
                    currentFolder = Path.Combine(currentFolder, "txtHisto");
                    if (!Directory.Exists(currentFolder))
                        Directory.CreateDirectory(currentFolder);

                    List<string> zipFiles = HandleZipFile(file);

                    files.JoinList(GetWordCounts(zipFiles));

                    currentFolder = Directory.GetParent(currentFolder).FullName;
                    Directory.Delete(Path.Combine(currentFolder, "txtHisto"), true);
                }
            }

            return files;
        }

        private List<string> HandleZipFile(string file)
        {
            List<string> zipFiles = new List<string>();
            using (FileStream zipFile = new FileStream(file, FileMode.Open))
            {
                using (ZipArchive openZip = new ZipArchive(zipFile))
                {
                    foreach (var compressedFile in openZip.Entries)
                    {
                        if (compressedFile.FullName.EndsWith(".txt") || compressedFile.FullName.EndsWith(".zip"))
                        {
                            string filePath = string.Format("{0}\\{1}", currentFolder, compressedFile.FullName);
                            compressedFile.ExtractToFile(filePath, true);
                            zipFiles.Add(filePath);
                        }
                    }
                }
            }

            return zipFiles;
        }

        private KeyValuePair<string, int> getContents(string path)
        {
            string contents = File.ReadAllText(path);
            string name = path.Split('\\').Last();
            int wordCount = Regex.Matches(contents, @"\b\w+\b").Count;
            return new KeyValuePair<string, int>(name, wordCount);
        }
    }
}
