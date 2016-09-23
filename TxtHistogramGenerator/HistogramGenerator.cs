/*
    Word Count Histogram Generator
    Fizzworks Studios - Fizzworks Futuristics (Experimental)

    Code Poet: Anthony McKeever
    Date: 9/16/2016 to 9/22/2016
    Language: C#
    Framework: .Net 4.6.1

    Generates a histogram based on word counts.
    Crawls all zip files to collect word counts.

    Class: HistogramGenerator.cs
    This generates the series the histogram will use to display the values.
*/

using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace TxtHistogramGenerator
{
    public class HistogramGenerator
    {
        public static Series makeChart(List<KeyValuePair<string, int>> dataSet, string chartName = "Text File Word Counts")
        {
            Series chart = new Series(chartName);
            List<string> xAxis = new List<string>();
            List<int> yAxis = new List<int>();

            foreach(KeyValuePair<string, int> dataPoint in dataSet)
            {
                xAxis.Add(dataPoint.Key);
                yAxis.Add(dataPoint.Value);
            }

            chart.Points.DataBindXY(xAxis, yAxis);
            return chart;
        }
    }
}
