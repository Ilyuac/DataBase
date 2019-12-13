using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDApp
{
    public partial class TableStudent : Form
    {
        List<DataRow> rows = new List<DataRow>();
        List<DataRow> Specialtys = new List<DataRow>();
        int nomber = 0;
        string ids;
        public TableStudent()
        {
            InitializeComponent();

            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;

            butNext.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            butLast.Enabled = true;
            butFrist.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            butPrevios.Enabled = false;

            foreach (DataTable table in DataBase.Tables)
            {
                if (table.TableName == "Students")
                {
                    foreach (DataRow row in table.Rows)
                    {
                        rows.Add(row);
                    }
                }

                if (table.TableName == "Specialty")
                {
                    cBSpetialty.DataSource = table;
                    foreach (DataRow row in table.Rows)
                    {
                        Specialtys.Add(row);
                       
                    }
                }
            }

            cBSpetialty.ValueMember = "IDSpecial";
            cBSpetialty.DisplayMember = "Specialty";

            bindingNavigatorCountItem.Text = string.Format("для {0}", rows.Count);

            LoadInfo(nomber);
        }

        private void LoadInfo(int i)
        {
            bindingNavigatorPositionItem.Text = (nomber+1).ToString();

            tBSecondName.Text = rows[i]["Family"].ToString();
            tBName.Text = rows[i]["Name"].ToString();
            tBMiddlName.Text = rows[i]["MiddleName"].ToString();
            tBGroup.Text = rows[i]["Group"].ToString();

            foreach(DataRow specialty in Specialtys)
            {
                if (specialty["IDSpecial"].ToString() == rows[i]["IDSpecial"].ToString())
                {
                    cBSpetialty.Text = specialty["Specialty"].ToString();
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void butFrist_Click(object sender, EventArgs e)
        {
            nomber = 1;
            LoadInfo(nomber);
        }

        private void butLast_Click(object sender, EventArgs e)
        {
            nomber = rows.Count - 2;
            Next();
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void butPrevios_Click(object sender, EventArgs e)
        {
            Previos();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            AddChange();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            nomber = 1;
            Previos();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            Previos();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            nomber = rows.Count-2;
            Next();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddChange();
        }

        private void toolStripSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Next()
        {
            if (nomber < rows.Count-1)
            {
                nomber++;

                LoadInfo(nomber);

                butFrist.Enabled = true;
                bindingNavigatorMoveFirstItem.Enabled = true;
                bindingNavigatorMovePreviousItem.Enabled = true;
                butPrevios.Enabled = true;
            }
            if (nomber == rows.Count-1)
            {
                butNext.Enabled = false;
                bindingNavigatorMoveNextItem.Enabled = false;
                butLast.Enabled = false;
                bindingNavigatorMoveLastItem.Enabled = false;
            }
        }

        private void Save()
            {
            System.Data.OleDb.OleDbCommand command =
            new System.Data.OleDb.OleDbCommand("UPDATE Students SET Family = @Family, Name = @Name, MiddleName = @MiddleName, [Group] = @Group, IDSpecial=" + ids+ " WHERE IDStudent=@n",
            DataBase.connection);
            command.Parameters.AddWithValue("Family", tBSecondName.Text);
            command.Parameters.AddWithValue("Name", tBName.Text);
            command.Parameters.AddWithValue("MiddleName", tBMiddlName.Text);
            command.Parameters.AddWithValue("Group", tBGroup.Text);
            command.Parameters.AddWithValue("n", rows[nomber]["IDStudent"].ToString());
            
            DataBase.DBCommand(command);


            }

        private void AddChange()
        { //, [Group], [IDSpecial]  , @Group, IDSpecial="+ids  , [Name], [MiddleName]   , @Name, @MiddleName
            System.Data.OleDb.OleDbCommand command =
            new System.Data.OleDb.OleDbCommand("INSERT INTO Students ([Family], [Name], [MiddleName], [Group], [IDSpecial]) VALUES (@Family, @Name, @MiddleName, @Group, "+ids+")",
            DataBase.connection);
            command.Parameters.AddWithValue("Family", tBSecondName.Text);
            command.Parameters.AddWithValue("Name", tBName.Text);
            command.Parameters.AddWithValue("MiddleName", tBMiddlName.Text);
            command.Parameters.AddWithValue("Group", tBGroup.Text);
            DataBase.DBCommand(command);


            }

        private void Delete()
        {
            System.Data.OleDb.OleDbCommand command =
           new System.Data.OleDb.OleDbCommand("DELETE FROM Students WHERE IDStudent=@n",
           DataBase.connection);
           command.Parameters.AddWithValue("n", rows[nomber]["IDStudent"].ToString());
           DataBase.DBCommand(command);
        }

        private void Previos()
        {
            if (nomber > 0)
            {
                nomber--;

                LoadInfo(nomber);
                butNext.Enabled = true;
                bindingNavigatorMoveNextItem.Enabled = true;
                bindingNavigatorMoveLastItem.Enabled = true;
                butLast.Enabled = true;
            }
            if(nomber==0)
            {
                butFrist.Enabled = false;
                bindingNavigatorMoveFirstItem.Enabled = false;
                bindingNavigatorMovePreviousItem.Enabled = false;
                butPrevios.Enabled = false;
            }
        }

        private void CBSpetialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            ids = cBSpetialty.SelectedValue.ToString();
        }

        private void butTable_Click(object sender, EventArgs e)
        {

            TablesForm tables = new TablesForm();
            tables.Show();
        }
    }
}
