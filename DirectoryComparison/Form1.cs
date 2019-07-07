using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace DirectoryComparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SizeColumns();
        }

        private void SizeColumns()
        {
            int wid = (int)((dgvFiles.Width - 50) / 2);
            if (wid < 10) wid = 10;
            dgvFiles.Columns[0].Width = wid;
            dgvFiles.Columns[1].Width = wid;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            var timer = new Stopwatch();

            dgvFiles.Rows.Clear();

            string dir1 = tbDir1.Text;
            if (!dir1.EndsWith("\\")) dir1 += "\\";
            string[] file_names1;

            if (cbDir.Checked == false)
            {
                file_names1 = Directory.GetFiles(dir1);
            }
            else
            {
                file_names1 = FindFileDir(dir1);
            }



            for (int i = 0; i < file_names1.Length; i++)
            {
                file_names1[i] = ReverseStringBuilder(file_names1[i]);
                file_names1[i] = file_names1[i].Remove(file_names1[i].IndexOf("\\"));
                file_names1[i] = ReverseStringBuilder(file_names1[i]);
            }


            Array.Sort(file_names1);



            string dir2 = tbDir2.Text;
            if (!dir2.EndsWith("\\")) dir2 += "\\";
            string[] file_names2;


            if (cbDir.Checked == false)
            {
                file_names2 = Directory.GetFiles(dir2);
            }
            else
            {
                file_names2 = FindFileDir(dir2);
            }

            for (int i = 0; i < file_names2.Length; i++)
            {
                file_names2[i] = ReverseStringBuilder(file_names2[i]);
                file_names2[i] = file_names2[i].Remove(file_names2[i].IndexOf("\\"));
                file_names2[i] = ReverseStringBuilder(file_names2[i]);
            }


            Array.Sort(file_names2);

            int i1 = 0, i2 = 0;
            var same = 0;

            timer.Start();
            while ((i1 < file_names1.Length) && (i2 < file_names2.Length))
            {
                if (file_names1[i1] == file_names2[i2])
                {
                    dgvFiles.Rows.Add(new Object[] { file_names1[i1], file_names2[i2] });
                    i1++;
                    i2++;
                    same++;
                }
                else if (file_names1[i1].CompareTo(file_names2[i2]) < 0)
                {
                    dgvFiles.Rows.Add(new Object[] { file_names1[i1], null });
                    i1++;
                }
                else
                {
                    dgvFiles.Rows.Add(new Object[] { null, file_names2[i2] });
                    i2++;
                }
            }
            timer.Stop();

            for (int i = i1; i < file_names1.Length; i++)
            {
                dgvFiles.Rows.Add(new Object[] { file_names1[i], null });
            }


            for (int i = i2; i < file_names2.Length; i++)
            {
                dgvFiles.Rows.Add(new Object[] { null, file_names2[i] });
            }

            tbTime.Text = timer.ElapsedMilliseconds.ToString();
            tbSame.Text = same.ToString();

        }

        private void btnDir1_Click(object sender, EventArgs e)
        {
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                tbDir1.Text = FBD.SelectedPath;
            }
        }

        private void btnDir2_Click(object sender, EventArgs e)
        {
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                tbDir2.Text = FBD.SelectedPath;
            }
        }


        private static string[] FindFileDir(string beginpath)
        {
            List<string> findlist = new List<string>();
            RecurseFind(beginpath, findlist);

            return findlist.ToArray();
        }

        private static void RecurseFind(string path, List<string> list)
        {
            string[] fl = Directory.GetFiles(path);
            string[] dl = Directory.GetDirectories(path);
            if (fl.Length > 0 || dl.Length > 0)
            {
                foreach (string s in fl)
                    list.Add(s);
                foreach (string s in dl)
                {
                    list.Add(s);
                    RecurseFind(s, list);
                }

            }
        }

        static string ReverseStringBuilder(string str)
        {
            StringBuilder sb = new StringBuilder(str.Length);
            for (int i = str.Length; i-- != 0;)
                sb.Append(str[i]);
            return sb.ToString();
        }

    }
}
