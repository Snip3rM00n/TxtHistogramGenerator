/*
    Word Count Histogram Generator
    Fizzworks Studios - Fizzworks Futuristics (Experimental)

    Code Poet: Anthony McKeever '
    Language: C#
    Framework: .Net 4.6.1

    Generates a histogram based on word counts.
    Crawls all zip files to collect word counts.

    Class: Program.cs
    Application's point of entry.
*/

using System;
using System.Windows.Forms;

namespace TxtHistogramGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HistogramDisplay());
        }
    }
}
