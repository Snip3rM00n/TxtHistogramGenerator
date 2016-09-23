/*
    Word Count Histogram Generator
    Fizzworks Studios - Fizzworks Futuristics (Experimental)

    Code Poet: Anthony McKeever '
    Language: C#
    Framework: .Net 4.6.1

    Generates a histogram based on word counts.
    Crawls all zip files to collect word counts.

    Class: HistogramDisplay.cs
    This class provides the form controls.
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TxtHistogramGenerator
{
    public partial class HistogramDisplay : Form
    {
        public HistogramDisplay()
        {
            InitializeComponent();
            genHisto.Enabled = false;
            saveHisto.Enabled = false;
            histogram.Series.Clear();
        }

        private void browseClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDiag = new FolderBrowserDialog();
            var folderDiagResult = folderDiag.ShowDialog();
            if (folderDiagResult == DialogResult.OK)
            {
                folderPath.Text = folderDiag.SelectedPath;
                genHisto.Enabled = true;
            }
        }

        private void folderPath_TextChanged(object sender, EventArgs e)
        {
            if (!pathNull(folderPath.Text)) genHisto.Enabled = true;
            else genHisto.Enabled = false;
        }

        private bool pathNull(string path)
        {
            return string.IsNullOrEmpty(path) && string.IsNullOrWhiteSpace(path);
        }

        private void genHisto_Click(object sender, EventArgs e)
        {
            histogram.Series.Clear();
            HandleFiles fileHandler = new HandleFiles(folderPath.Text);
            List<KeyValuePair<string, int>> wordCounts = fileHandler.GetWordCounts();

            if (wordCounts.Count > 0)
            {
                histogram.Series.Add(HistogramGenerator.makeChart(wordCounts));
                saveHisto.Enabled = true;
            }
            else
            {
                saveHisto.Enabled = false;
                MessageBox.Show("The selected folder does not contain text files.", "No Text Files Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saveHisto_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PNG Files (*.png)|*.png";
            DialogResult result = saveFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = saveFile.FileName;
                histogram.SaveImage(path, ChartImageFormat.Png);
            }
        }
    }
}
