using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Jtrade
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			Init();
		}
#region Actions Interface		
		void Init()
		{
			RemplirComboTitre();
			ViderChamps();
		}
		
		void QuitterToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void RemplirComboTitre () 
		{
			var list = new List<string>();
			comboBox1.Items.Clear();
			list = SQL.Read("Select Distinct * from titres");
			list.Sort();
			foreach (string element in list)
			{
				comboBox1.Items.Add(element);
			}
			comboBox1.SelectedIndex = 0;
		}
		void ViderChamps() 
		{
			txt_ValCourante.Text = "";
			txt_ValModifiee.Text = "";
			textBox1.Text = "";
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			txt_ValCourante.Text = comboBox1.Text;
		}
		bool VerifierSaisie(string value) 
		{
			bool result;
			result = value != "";
			return result;
		}
#endregion		
		
#region cmdSQL		
				
		void btn_AjouterTitreClick(object sender, EventArgs e)
		{
			bool result = VerifierSaisie(textBox1.Text);
			if (result)
			{
				SQL.Write("Insert into titres (id, titre) values (4, '" + textBox1.Text + "')");
				Init();
			}
			else 
			{
			MessageBox.Show("Le texte ne doit pas être vide !", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			SQL.Delete("Delete from titres where titre like '" + comboBox1.Text + "'");
			Init();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			SQL.Update("UPDATE titres SET titre = '" + txt_ValModifiee.Text + "' WHERE titre like '"+ txt_ValCourante.Text + "'");
			Init();
		}
#endregion

	}
}
