using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace KapitusAnagramForm
{
    public partial class frmAnagram : Form
    {
        Dictionary<string, List<string>> anagramList;
        long lLoadTime = 0;
        long lWords = 0;
        string sPath = "Words.txt";
        FileInfo oFileInfo;

        public frmAnagram()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFile();
        }

        void LoadFile()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var oFile = File.ReadAllLines(sPath);
            List<string> oList = new List<string>(oFile);

            oFileInfo = new FileInfo(sPath);
            txtFile.Text = oFileInfo.FullName;

            lWords = oList.Count;

            anagramList = new Dictionary<string, List<string>>();

            foreach (string str in oList)
            {
                string sKey = String.Concat(str.OrderBy(c => c));
                if (anagramList.ContainsKey(sKey))
                {
                    anagramList[sKey].Add(str);
                }
                else
                {
                    anagramList.Add(sKey, new List<string>(new string[] { str }));
                }
            }

            watch.Stop();

            lLoadTime = watch.ElapsedMilliseconds;

            RefreshResults();
        }

        void RefreshResults()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int i = 0;
            using (StreamWriter writer = new StreamWriter("anagrams.txt", false))
            {

                if (rbCount.Checked)
                {

                    foreach (KeyValuePair<string, List<string>> anagram in anagramList.OrderByDescending(key => key.Value.Count))
                    {
                        if (anagram.Value.Count >= udAtLeast.Value)
                        {
                            writer.WriteLine(string.Join(" ", anagram.Value.ToArray()));
                            i++;
                        }
                    }
                }
                else
                {
                    foreach (KeyValuePair<string, List<string>> anagram in anagramList.OrderByDescending(key => key.Key.Length))
                    {
                        if (anagram.Value.Count > 1 && anagram.Key.Length >= udAtLeast.Value)
                        {
                            writer.WriteLine(string.Join(" ", anagram.Value.ToArray()));
                            i++;
                        }
                    }
                }
            }

            watch.Stop();

            txtOutput.Text = File.ReadAllText("anagrams.txt");
            ssLoad.Text = "Load time: " + lLoadTime.ToString() + "ms";
            ssRefresh.Text = "Refresh time: " + watch.ElapsedMilliseconds + "ms";
            ssWords.Text = "Total words: " + lWords.ToString();
            ssCount.Text = "Total anagrams: " + i.ToString();
        }

        private void udAtLeast_ValueChanged(object sender, EventArgs e)
        {
            RefreshResults();
        }

        private void rbCount_CheckedChanged(object sender, EventArgs e)
        {
            RefreshResults();
        }

        private void rbLength_CheckedChanged(object sender, EventArgs e)
        {
            RefreshResults();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            odFile.InitialDirectory = oFileInfo.DirectoryName;
            odFile.FileName = sPath;
            odFile.ShowDialog();

            sPath = odFile.FileName;
            LoadFile();
        }
    }
}
