using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ArrayConvertor
{
    public partial class frmMain : Form
    {
        enum LineFormat
        {
            WithHexPrefix = 0x0001,
            WithoutHexPrefix = 0x0002,

            SepratedBySpace = 0x0010,
            SepratedByComma = 0x0020,

        }


        public frmMain()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtBinary_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void txtBinary_DragDrop(object sender, DragEventArgs e)
        {
            // Handle FileDrop data.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Assign the file names to a string array, in 
                // case the user has selected multiple files.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                try
                {
                    if (files.Length > 1)
                    {
                        MessageBox.Show("複数のファイルを同時に開けません!一つにしてください。");
                        return;
                    }

                    loadBinaryFile(files[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void txtBinary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCArray_TextChanged(object sender, EventArgs e)
        {

        }

        private void numDataNumberInLine_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnToBinary_Click(object sender, EventArgs e)
        {
            // get data
            byte[] data = dataFormatConvert(txtCArray.Lines);
            if (data == null || data.Length == 0) return;

            // convert
            int numInLine = 16;
            List<string> outputBuffer = new List<string>();
            for (int i = 0; i < data.Length; i += numInLine)
            {
                int remainByte = data.Length - i < numInLine ? data.Length - i : numInLine;
                byte[] lineData = new byte[remainByte];
                Buffer.BlockCopy(data, i, lineData, 0, remainByte);

                string line = lineFormatConvert(lineData, LineFormat.WithoutHexPrefix | LineFormat.SepratedBySpace);

                outputBuffer.Add(line);
            }

            // set 
            txtBinary.Lines = outputBuffer.ToArray();
        }

        private void btnToCArray_Click(object sender, EventArgs e)
        {
            // get data
            byte[] data = dataFormatConvert(txtBinary.Lines);
            if (data == null || data.Length == 0) return;

            // convert
            int numInLine = (int)numDataNumberInLine.Value;
            List<string> outputBuffer = new List<string>();
            for (int i = 0; i < data.Length; i += numInLine)
            {
                int remainByte = data.Length - i < numInLine ? data.Length - i : numInLine;
                byte[] lineData = new byte[remainByte];
                Buffer.BlockCopy(data, i, lineData, 0, remainByte);

                string line = lineFormatConvert(lineData, LineFormat.WithHexPrefix | LineFormat.SepratedByComma);
                if (i + remainByte >= data.Length)
                {
                    // last line
                    line = line.TrimEnd(new char[] { ',' });
                }

                outputBuffer.Add(line);
            }

            // set
            txtCArray.Lines = outputBuffer.ToArray();
        }

        private void btnSaveBinary_Click(object sender, EventArgs e)
        {
            // get data
            byte[] data = dataFormatConvert(txtBinary.Lines);
            if (data == null || data.Length == 0) return;

            // get filename
            SaveFileDialog sfd = new SaveFileDialog();
            
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = sfd.FileName;

                using (BinaryWriter binWriter = new BinaryWriter(File.Open(filename, FileMode.Create)))
                {
                    binWriter.Write(data);

                    binWriter.Close();
                }
            }
        }
        #endregion

        #region PrivateFunction
        private void loadBinaryFile(string filename)
        {
            FileInfo fi = new FileInfo(filename);
            long fileSize = fi.Length;
            Console.WriteLine("Load binary file {0}, {1}bytes", filename, fileSize);

            int fileSizeLength = 1;
            while (fileSize > 16)
            {
                fileSize /= 16;
                fileSizeLength++;
            }
            if (fileSizeLength < 2) fileSizeLength = 2;
            string lineOffsetFormat = "x" + fileSizeLength.ToString();

            using (BinaryReader binReader = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                long lineOffset = 0;
                List<string> outputLines = new List<string>();
                List<string> outputLineNo = new List<string>();
                    
                do
                {
                    byte[] lineData = binReader.ReadBytes(16);
                    if (lineData.Length == 0) break;

                    string dispayLine = lineFormatConvert(lineData, LineFormat.WithoutHexPrefix | LineFormat.SepratedBySpace);
                    outputLines.Add(dispayLine);

                    string lineNo = lineOffset.ToString(lineOffsetFormat);
                    outputLineNo.Add(lineNo);

                    lineOffset += 16;

                } while (true);

                txtBinary.Lines = outputLines.ToArray();
                txtBinLineNo.Lines = outputLineNo.ToArray();

                binReader.Close();
            }
        }

        private string lineFormatConvert(byte[] data, LineFormat outputFormat)
        {
            string formatter = "";
            // prefix
            if ((outputFormat & LineFormat.WithHexPrefix) == LineFormat.WithHexPrefix)
            {
                formatter += "0x{0,2:x2}";
            }
            else
            {
                formatter += "{0,2:x2}";
            }
            // seprator
            if ((outputFormat & LineFormat.SepratedByComma) == LineFormat.SepratedByComma)
            {
                formatter += ", ";
            }
            else
            {
                formatter += " ";
            }

            // convert line
            string outString = "";
            foreach (byte ch in data)
            {
                outString += String.Format(formatter, ch);
            }
            return outString.Trim();
        }

        private byte[] dataFormatConvert(string[] lines)
        {
            try
            {
                List<byte> outputBuffer = new List<byte>();
                foreach (string line in lines)
                {
                    string[] byteDatas = line.Split(new Char[] { ' ', ',', '.', ':', '\t' });

                    foreach (string byteData in byteDatas)
                    {
                        if (byteData.Length == 0) continue;

                        string numberString = byteData;
                        if (numberString.Length > 2 && numberString[0] == '0' && numberString[1] == 'x')
                        {
                            numberString = numberString.Substring(2);
                        }

                        byte data = byte.Parse(numberString, System.Globalization.NumberStyles.AllowHexSpecifier);
                        outputBuffer.Add(data);
                    }
                }

                return outputBuffer.ToArray();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(String.Format("データ変換失敗：{0}", fe.Message));
                return null;
            }
        }
        #endregion
    }
}
