using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Gesttiune_Angajati
{
    public partial class Form1 : Form
    {
        
        SqlConnection connection = new SqlConnection("Server = DESKTOP-BBBBOLH; Database=Angajati;Trusted_Connection=True");
        SqlCommand comand = new SqlCommand();
             SqlDataReader datareader;
        public Form1()
        {
            InitializeComponent();
            loadlist();
        }
        private void loadlist()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            connection.Open();
            comand.CommandText = "select * from Angajatii";
            comand.Connection = connection;
            datareader = comand.ExecuteReader();
            if(datareader.HasRows)
            {
                while(datareader.Read())
                {
                    listBox1.Items.Add(datareader[0].ToString());
                    listBox2.Items.Add(datareader[1].ToString()+"  "+ datareader[2].ToString() +" "+ datareader[3].ToString() +" "+ datareader[4].ToString() + "  "+datareader[5].ToString() +" "+ datareader[6].ToString());
                }
            }
            connection.Close();
            NameT.Text = "";
            PrenumeT.Text = "";
            FunctieT.Text = "";
            CNPT.Text = "";
            ProiectT.Text = "";
            SalariuT.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            comand.CommandText = "insert into  Angajatii (Nume,Prenume,CNP,Functie,salariu,proiect) values('" + NameT.Text + "','" +PrenumeT.Text + "','" + CNPT.Text + "','" + FunctieT.Text + "','" + SalariuT.Text + "','" + ProiectT.Text + "')";
            comand.Connection = connection;
            comand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Inregistrat");
            loadlist();



        }
        //
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if(l.SelectedIndex!=-1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                textBox1.Text = listBox1.SelectedItem.ToString();
                connection.Open();
                comand.CommandText = "select * from Angajatii where id='" + textBox1.Text + "'";
                comand.Connection = connection;
                datareader = comand.ExecuteReader();
                if (datareader.HasRows)
                {
                    while (datareader.Read())
                    {
                        NameT.Text = datareader[1].ToString();
                        PrenumeT.Text = datareader[2].ToString();
                        FunctieT.Text = datareader[4].ToString();
                        CNPT.Text = datareader[3].ToString();
                        ProiectT.Text = datareader[6].ToString();
                        SalariuT.Text = datareader[5].ToString();
                    }
                }
                
            }
            connection.Close();

        }
        //Stergere angajat
        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            comand.CommandText = "delete from Angajatii where Id='"+textBox1.Text+"'";
            comand.Connection = connection;
            comand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Sters");
            loadlist();
        }
        //Modificare angajati
        private void button3_Click(object sender, EventArgs e)
        {

            connection.Open();
            comand.CommandText = "update Angajatii  set Nume='"+NameT.Text + "',Prenume='" + PrenumeT.Text + "' ,   Functie='" + FunctieT.Text + "',Salariu='" + SalariuT.Text + "' ,Proiect = '" + ProiectT.Text + "'    where Id='" + textBox1.Text + "'";
            comand.Connection = connection;
            comand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("modificat");
            loadlist();
        }
    }
}
