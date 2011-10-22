/*
* Copyright 2010 (C) Peter Gill <peter@majorsilence.com>
*
* This file is part of MajorSilence FileChecksumer
*
* MajorSilence FileChecksumer is free software; you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation; either version 3 of the License, or
* (at your option) any later version.
*
* MajorSilence FileChecksumer is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace FileChecksumer
{
    public partial class MainGui : Form
    {

        public MainGui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cboHashType.SelectedIndex = 0;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            txtOrigFile.Text = openFileDialogFile.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialogChecksum.FileName = System.IO.Path.GetFileName(txtCheckSumFile.Text.Trim());
            if (saveFileDialogChecksum.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            System.IO.File.WriteAllText(saveFileDialogChecksum.FileName, txtFileChecksum.Text + " *" + System.IO.Path.GetFileName(txtOrigFile.Text));
        }

        private void btnLoadComparisonFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogChecksum.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            // assumes the filename follows after a space

            string value = System.IO.File.ReadAllText(openFileDialogChecksum.FileName);
            value = value.Trim().Split(Convert.ToChar(" "))[0];

            txtCheckSumFile.Text = value;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtOrigFile.Text.Trim()) == false)
            {
                MessageBox.Show("Select a file to hash.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboHashType.SelectedIndex == -1)
            {
                MessageBox.Show("Select a hash type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            string value = "";
            string filePath = txtOrigFile.Text.Trim();
            Hashes h = new Hashes();
            if (cboHashType.Text.ToLower() == "md5")
            {
                
                value = h.GetMD5Hash(filePath);
                this.saveFileDialogChecksum.FilterIndex = 1;
            }
            else if (cboHashType.Text.ToLower() == "sha1")
            {
                value = h.GetSHA1Hash(filePath);
                this.saveFileDialogChecksum.FilterIndex = 2;
            }
            else if (cboHashType.Text.ToLower() == "sha512")
            {
                value = h.GetSHA512Hash(filePath);
                this.saveFileDialogChecksum.FilterIndex = 3;
            }

            
            txtFileChecksum.Text = value;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (txtCheckSumFile.Text.Trim() == "")
            {
                MessageBox.Show("Checksum must be loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (System.IO.File.Exists(txtOrigFile.Text.Trim()) == false)
            {
                MessageBox.Show("File to check against must be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboHashType.SelectedIndex == -1)
            {
                MessageBox.Show("Select a hash type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            btnCalculate_Click(sender, e);
            if (txtCheckSumFile.Text.Trim() == txtFileChecksum.Text.Trim())
            {
                MessageBox.Show("Checksums match", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not a match", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtOrigFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            txtOrigFile.Text = s[0];

            //string value = "";
            //int i;
            //for (i = 0; i < s.Length; i++)
            //{
            //    value = s[i];
            //}

 
        }

        private void txtOrigFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtCheckSumFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string value = System.IO.File.ReadAllText(s[0]);
            value = value.Trim().Split(Convert.ToChar(" "))[0];
            txtCheckSumFile.Text = value;
        }

        private void txtCheckSumFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


      


    }
}
