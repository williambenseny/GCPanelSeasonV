using System;
using GCPanelSeasonV.Model;
using GCPanelSeasonV.Values;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCPanelSeasonV
{
	public partial class Painel : Form
	{

		public Painel()
		{
			InitializeComponent();
			combo_Grade.DataSource = ItemGrade.itemGrades;
			combo_Grade.DisplayMember = "name";
			combo_Grade.ValueMember = "grade";
		}


		private void Btn_AddItem_Click(object sender, EventArgs e)
		{
			DataAccess db = new DataAccess();
			var grade = combo_Grade.SelectedValue;
			Console.WriteLine(grade);
			//db.AddItem(txt_LoginUID.Text, txt_ItemID.Text);

		}

		//Métodos de preenchimento de combos
	}
}
