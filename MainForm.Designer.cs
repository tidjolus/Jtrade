/*
 * Created by SharpDevelop.
 * User: amandine
 * Date: 16/12/2021
 * Time: 21:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Jtrade
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btn_AjouterTitre;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txt_ValCourante;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox txt_ValModifiee;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btn_AjouterTitre = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txt_ValCourante = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.txt_ValModifiee = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fichierToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(417, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.quitterToolStripMenuItem});
			this.fichierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.fichierToolStripMenuItem.Text = "&Fichier";
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.quitterToolStripMenuItem.Text = "&Quitter";
			this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItemClick);
			// 
			// comboBox1
			// 
			this.comboBox1.CausesValidation = false;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(102, 54);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(117, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(102, 81);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(117, 20);
			this.textBox1.TabIndex = 4;
			// 
			// btn_AjouterTitre
			// 
			this.btn_AjouterTitre.Location = new System.Drawing.Point(225, 81);
			this.btn_AjouterTitre.Name = "btn_AjouterTitre";
			this.btn_AjouterTitre.Size = new System.Drawing.Size(66, 20);
			this.btn_AjouterTitre.TabIndex = 5;
			this.btn_AjouterTitre.Text = "Ajouter";
			this.btn_AjouterTitre.UseVisualStyleBackColor = true;
			this.btn_AjouterTitre.Click += new System.EventHandler(this.btn_AjouterTitreClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(225, 55);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(66, 20);
			this.button2.TabIndex = 6;
			this.button2.Text = "Supprimer";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// txt_ValCourante
			// 
			this.txt_ValCourante.Enabled = false;
			this.txt_ValCourante.Location = new System.Drawing.Point(102, 107);
			this.txt_ValCourante.Name = "txt_ValCourante";
			this.txt_ValCourante.ReadOnly = true;
			this.txt_ValCourante.Size = new System.Drawing.Size(117, 20);
			this.txt_ValCourante.TabIndex = 8;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(225, 133);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(66, 20);
			this.button3.TabIndex = 11;
			this.button3.Text = "Modifier";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// txt_ValModifiee
			// 
			this.txt_ValModifiee.Location = new System.Drawing.Point(102, 133);
			this.txt_ValModifiee.Name = "txt_ValModifiee";
			this.txt_ValModifiee.Size = new System.Drawing.Size(117, 20);
			this.txt_ValModifiee.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(417, 197);
			this.Controls.Add(this.txt_ValModifiee);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.txt_ValCourante);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btn_AjouterTitre);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Jtrade";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		}
	}

