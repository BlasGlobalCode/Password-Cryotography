using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cryptography.Properties;

namespace Cryptography
{
	public partial class InputBox : Form
	{

		public InputBox()
		{
			InitializeComponent();
		}

		public string UserInput
		{
			get { return InputTxt.Text; }
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{

			if(InputTxt.Text != string.Empty)
			{
				DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Gib die Datei enen Name");
			}
			
		}

		private void PassBox_Load(object sender, EventArgs e)
		{
			this.Text = Application.ProductName + " - Name It.";
			InputTxt.Select();
		}

		private void PasswordTxt_TextChanged(object sender, EventArgs e)
		{
			if (InputTxt.Text != "")
			{
				btnOK.Enabled = true;
			}
			else
			{
				btnOK.Enabled = false;
			}
		}

	}
}
