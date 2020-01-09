namespace Cryptography
{
	partial class mainform
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.hashButton = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveButton = new System.Windows.Forms.Button();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hashButton
            // 
            resources.ApplyResources(this.hashButton, "hashButton");
            this.hashButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.hashButton.Name = "hashButton";
            this.hashButton.UseVisualStyleBackColor = true;
            this.hashButton.Click += new System.EventHandler(this.hashButton_Click);
            // 
            // t1
            // 
            this.t1.ForeColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.t1, "t1");
            this.t1.Name = "t1";
            // 
            // t2
            // 
            this.t2.ForeColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.t2, "t2");
            this.t2.Name = "t2";
            // 
            // t3
            // 
            this.t3.ForeColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.t3, "t3");
            this.t3.Name = "t3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Name = "label4";
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl1});
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            // 
            // tssl1
            // 
            resources.ApplyResources(this.tssl1, "tssl1");
            this.tssl1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssl1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tssl1.Name = "tssl1";
            this.tssl1.Spring = true;
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // LB1
            // 
            this.LB1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB1.FormattingEnabled = true;
            resources.ApplyResources(this.LB1, "LB1");
            this.LB1.Name = "LB1";
            this.LB1.Sorted = true;
            this.LB1.SelectedIndexChanged += new System.EventHandler(this.LB1_SelectedIndexChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoEllipsis = true;
            resources.ApplyResources(this.DeleteBtn, "DeleteBtn");
            this.DeleteBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.hashButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainform";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.mainform_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button hashButton;
		private System.Windows.Forms.TextBox t1;
		private System.Windows.Forms.TextBox t2;
		private System.Windows.Forms.TextBox t3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.ToolStripStatusLabel tssl1;
		private System.Windows.Forms.Button saveButton;
		protected internal System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Button DeleteBtn;
		protected internal System.Windows.Forms.ListBox LB1;
	}
}

