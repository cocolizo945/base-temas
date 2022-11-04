using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Wind
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn = conexion.conex();
        public Form1()
        {
            InitializeComponent();
            MySqlCommand cmdtbs = new MySqlCommand("show tables;", conn);
            conn.Open();
            MySqlDataReader dR = cmdtbs.ExecuteReader();
            while (dR.Read() == true)
            {
                cboTables.Items.Add(dR[0]);
            }

        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            String strRgx = "^[T][0-9]+";
            string id_tema = txtID.Text;
            string nom_tema = txtName.Text.ToUpper();

            string insert_bd = "insert into tb_temas values('" + id_tema + "','" + nom_tema + "');";
            Regex rg = new Regex(strRgx);
            Match c = rg.Match(id_tema);

            if (c.Success)
            {
                try
                {
                    MySqlCommand cmdin = new MySqlCommand(insert_bd, conn);
                    cmdin.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Tema insertado");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
            else
                MessageBox.Show("No cumple con el formato TXXXX ");

            txtName.Text = "";
            txtID.Text = "";
            conn.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            // MessageBox.Show("text" + cboTables.Text + " selected text" + cboTables.SelectedText);
            string tabla = cboTables.Text;
            String load = "select * from "+tabla+";";
            MySqlCommand cmdld = new MySqlCommand(load,conn);
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmdld;
            DataTable tabla1 = new DataTable();
            adp.Fill(tabla1);
            dvgData.DataSource = tabla1;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}