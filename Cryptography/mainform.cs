using System;
using System.IO;
using System.Threading;
using System.Xml;
using System.Xml.XPath;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Cryptography.Properties;

namespace Cryptography
{
    public partial class mainform : Form
    {
        private HashAlgorithm mhash;

        public mainform()
        {
            InitializeComponent();
        }

        /// <summary>
        /// First Test
        /// </summary>
        /// <returns></returns>

        private HashAlgorithm SetHash()
        {
            return new SHA1CryptoServiceProvider();
        }

        private string HashString(string Value)
        {
            mhash = SetHash();
            // Convertit la chaîne originale en un tableau de Bytes
            byte[] bytValue = Encoding.UTF8.GetBytes(Value);
            // Procède au hashage et retourne un tableau de Bytes
            byte[] bytHash = mhash.ComputeHash(bytValue);
            mhash.Clear();
            // Retourne une chaîne de caractères en base 64 de la valeur hashée
            return Convert.ToBase64String(bytHash);
        }

        /// <summary>
        /// Second test
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public string Encrypt(string pwd)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA1CryptoServiceProvider sha1hasher = new SHA1CryptoServiceProvider();
            byte[] hashedDataBytes = sha1hasher.ComputeHash(encoder.GetBytes(pwd));
            return byteArrayToString(hashedDataBytes);
        }

        private string byteArrayToString(byte[] inputArray)
        {
            StringBuilder output = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++)
            {
                output.Append(inputArray[i].ToString("X2"));
            }
            return output.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                t1.Text = string.Empty;
                t2.Text = string.Empty;
                t3.Text = string.Empty;
            }
            catch (Exception x)
            {

                MessageBox.Show("can't be empty" + x.StackTrace);
            }
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            tssl1.Text = Settings.Default.Copyright;
            if (Directory.Exists("Data").Equals(false))
            {
                Directory.CreateDirectory("Data");
                DirectoryInfo di = new DirectoryInfo("Data");
                di.Attributes = FileAttributes.Hidden;
                return;
            }
            else
            {
                ListFiles();
                return;
            }
        }

        private void ListFiles()
        {
            string[] files = Directory.GetFiles("Data/");
            LB1.Items.Clear();
            foreach (string file in files)
            {
                LB1.Items.Add(Path.GetFileName(file));
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                InputBox IB = new InputBox();
                IB.ShowDialog();
                string result = IB.UserInput + ".xml";
                if (result != "")
                {
                    if (File.Exists(result).Equals(false))
                    {
                        SaveToFile("Data\\" + result);
                        tssl1.Text = "Saving [" + result + "]";
                        Application.DoEvents();
                        Thread.Sleep(2500);
                        tssl1.Text = "Save Done";
                        Application.DoEvents();
                        Thread.Sleep(2500);
                        tssl1.Text = Settings.Default.Copyright;
                        IB.Dispose();
                        ListFiles();
                        return;
                    }
                    else
                    {
                        tssl1.Text = "The File " + result + " AllReady Exists, choose another word.";
                        Application.DoEvents();
                        Thread.Sleep(2500);
                        tssl1.Text = Settings.Default.Copyright;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(this, "Impossible To Save Empty Case ", Application.ProductName + " - Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("" + x.StackTrace);
            }
        }

        private void SaveToFile(string strFilename)
        {
            XmlTextWriter writer = new XmlTextWriter(strFilename, null);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument(true);
            //Write the root element
            writer.WriteStartElement("Users");
            //Write sub-elements
            writer.WriteComment("The UserName");
            writer.WriteElementString("userName", "What ever");
            writer.WriteComment("UnHash_Password For You To Remember");
            writer.WriteElementString("Password", t1.Text);
            writer.WriteComment("Hash_Password");
            writer.WriteComment("First Choice.");
            writer.WriteElementString("Password1", t2.Text);
            writer.WriteComment("Second Choice.");
            writer.WriteElementString("Password2", t3.Text);
            // end the root element
            writer.WriteEndElement();
            //Write the XML to file and close the writer
            writer.Close();
        }
        private void hashButton_Click(object sender, EventArgs e)
        {
            if (t1.Text != string.Empty)
            {
                t2.Text = HashString(t1.Text);
                t3.Text = Encrypt(t1.Text);
            }
            else
            {
                tssl1.Text = "Oops An error occurred";
                Application.DoEvents();
                Thread.Sleep(2500);
                tssl1.Text = "Try Again";
                Application.DoEvents();
                Thread.Sleep(1500);
                tssl1.Text = Settings.Default.Copyright;
                return;
            }
        }

        private void LB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReadBaseFiles("Data\\" + LB1.SelectedItem.ToString());
            }
            catch (Exception x)
            {
                MessageBox.Show("the textBox could not be Empty" + x.StackTrace);
            }

        }

        private void ReadBaseFiles(string strFilename)
        {
            XPathDocument doc;
            XPathNavigator nav;
            XPathExpression expr;
            XPathNodeIterator iterator;

            doc = new XPathDocument(strFilename);
            nav = doc.CreateNavigator();

            // Compile a standard XPath expression
            expr = nav.Compile("/Users/Password");
            iterator = nav.Select(expr);
            while (iterator.MoveNext())
            {
                XPathNavigator nav1 = iterator.Current.Clone();
                t1.Text = nav1.Value;
            }

            expr = nav.Compile("/Users/userName");
            iterator = nav.Select(expr);
            while (iterator.MoveNext())
            {
                XPathNavigator nav2 = iterator.Current.Clone();
                string UName = nav2.Value;
            }

            expr = nav.Compile("/Users/Password1");
            iterator = nav.Select(expr);
            while (iterator.MoveNext())
            {
                XPathNavigator nav3 = iterator.Current.Clone();
                t2.Text = nav3.Value;
            }

            expr = nav.Compile("/Users/Password2");
            iterator = nav.Select(expr);
            while (iterator.MoveNext())
            {
                XPathNavigator nav4 = iterator.Current.Clone();
                t3.Text = nav4.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Do you really want to delete? " + "\r\n" + LB1.SelectedItem.ToString() + "\r\n" + "\r\n" + " To Delete Click Yes";
                string caption = Application.ProductName + " - Delete Files";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon Icon = MessageBoxIcon.Question;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(this, message, caption, buttons, Icon);
                if (result == DialogResult.Yes)
                {
                    File.Delete("Data\\" + LB1.SelectedItem.ToString());
                    t1.Text = string.Empty;
                    t2.Text = string.Empty;
                    t3.Text = string.Empty;
                    ListFiles();
                    return;
                }
                else
                {
                    return;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("the file do not exist " + " ----------------- " + x.StackTrace);
            }

        }
    }
}