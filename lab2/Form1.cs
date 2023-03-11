using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        private int[] arr;
        private int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            listArray.Items.Clear();

            Random random = new Random();
            n = Convert.ToInt32(textBoxN.Text);
            arr = new int[n];
            int min = Convert.ToInt32(textBoxMin.Text);
            int max = Convert.ToInt32(textBoxMax.Text);

            for (int i = 0; i < n; i++)
                arr[i] = random.Next(min, max);

            printArray(listArray.Items);
        }

        private void printArray(ListBox.ObjectCollection collection)
        {
            for (int i = 0; i < n; i++) collection.Insert(i, arr[i]);
        }

        private void printSteps(ListBox.ObjectCollection collection, List<string> steps)
        {
            collection.Add(steps.ElementAt(0));
            collection.Add("");
            int i = 0;
            for (i = 1; i < steps.Count() - 1; i++)
                collection.Add("Step " + i + ":   " + steps.ElementAt(i));
            collection.Add("");
            collection.Add("Time taken: " + steps.ElementAt(steps.Count() - 1));
            collection.Add("---------------------------------------------");
        }

        private string getTime(Stopwatch timer)
        {
            TimeSpan ts = timer.Elapsed;
            return String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);
        }

        private void radioButtonBubble_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                progressBar.Refresh();
                progressBar.Value = 0;
                listSortedArray.Items.Clear();
                List<string> steps = new List<string>();

                Stopwatch timer = new Stopwatch();
           
                timer.Start();
                progressBar.Value = 100 - timer.Elapsed.Milliseconds * 10;
                Sorting.bubbleSort(arr, n, steps);
                timer.Stop();

                steps.Add(getTime(timer));
                printArray(listSortedArray.Items);
                printSteps(listBoxSteps.Items, steps);
            }
        }

        private void radioButtonSelection_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                progressBar.Refresh();
                progressBar.Value = 0;
                listSortedArray.Items.Clear();
                List<string> steps = new List<string>();

                Stopwatch timer = new Stopwatch();
                timer.Start();
                progressBar.Value = 100 - timer.Elapsed.Milliseconds * 10;
                Sorting.selectionSort(arr, n, steps);
                timer.Stop();

                steps.Add(getTime(timer));
                printArray(listSortedArray.Items);
                printSteps(listBoxSteps.Items, steps);
            }
        }

        private void radioInsertion_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                progressBar.Refresh();
                progressBar.Value = 0;
                listSortedArray.Items.Clear();
                List<string> steps = new List<string>();

                Stopwatch timer = new Stopwatch();
                timer.Start();
                progressBar.Value = 100 - timer.Elapsed.Milliseconds * 10;
                Sorting.insertionSort(arr, n, steps);
                timer.Stop();

                steps.Add(getTime(timer));
                printArray(listSortedArray.Items);
                printSteps(listBoxSteps.Items, steps);
            }
        }
    }
}
