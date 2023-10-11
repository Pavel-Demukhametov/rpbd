using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Table : Form
    {
        private DataTable dt = new DataTable();

        private string nameTable;
        private string query;

        private int CurrentIndex = 0;
        public Table(string nameF)
        {
            InitializeComponent();
            this.Text = nameF;
            switch(this.Text)
            {
                case "Здание":
                    {
                        query = "SELECT Building.BuildingCode, " +
                            "Building.Name AS [Название здания]," +
                            " Building.Address As [] FROM Building" +
                            " FROM Building;";
                        this.nameTable = "Building";
                        break;
                    }
                case "Помещение":
                    {
                        query = "SELECT Space.SpaceCode, " +
                            "Space.Name AS [Название помещения], " +
                            "Space.Area As [Площадь], " +
                            "Space.[код здания]" +
                            "Building.BuildingCode, Building.Name AS [Название здания] " +
                            "FROM Space " +
                            "INNER JOIN Building ON Space.SpaceCode = Building.BuildingCode;";
                        this.nameTable = "Space";
                        break;
                    }
                case "Арендатор":
                    {
                        query = "SELECT Space.SpaceCode, " +
                            "Space.Name AS [Название помещения], " +
                            "Space.Area As [Площадь], " +
                            "Space.[код здания]" +
                            "Building.BuildingCode, Building.Name AS [Название здания] " +
                            "FROM Space " +
                            "INNER JOIN Building ON Space.SpaceCode = Building.BuildingCode;";
                        this.nameTable = "Tenant";
                        break;
                    }
                case "Аренда":
                    {
                        this.nameTable = "Rent";
                        break;
                    }

            }
        }

        private void HideFields()
        {
            switch (this.Text)
            {
                case "Здание":
                    {
                        dataGridView1.Columns["BuildingCode"].Visible = false;
                        break;
                    }
                case "Помещение":
                    {
                        dataGridView1.Columns["SpaceCode"].Visible = false;
                        dataGridView1.Columns["BuildingCode"].Visible = false;
                        break;
                    }
                case "Арендатор":
                    {
                        dataGridView1.Columns["TenantCode"].Visible = false;

                        break;
                    }
                case "Аренда":
                    {
                        dataGridView1.Columns["RentalCode"].Visible = false;
                        dataGridView1.Columns["SpaceCode"].Visible = false;
                        dataGridView1.Columns["TenantCode"].Visible = false;
                        break;
                    }
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
