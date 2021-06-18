using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeWindowsForm
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-SUR74UG;Database=DBv1;Trusted_Connection=true");

        public Form1()
        {
            InitializeComponent();
            fillCombobox();
            BindData();

        }
        public void fillCombobox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Cinsiyet", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Cinsiyet.ValueMember = "Id";
            Cinsiyet.DisplayMember = "CinsiyetTuru";
            Cinsiyet.DataSource = dt;
            SqlCommand cmdDep = new SqlCommand("select * from Departman", con);
            SqlDataAdapter sdaDep = new SqlDataAdapter(cmdDep);
            DataTable dtDep = new DataTable();
            sdaDep.Fill(dtDep);
            Departman.ValueMember = "Id";
            Departman.DisplayMember = "DepartmanAdi";
            Departman.DataSource = dtDep;
            SDepartman.ValueMember = "Id";
            SDepartman.DisplayMember = "DepartmanAdi";
            SDepartman.DataSource = dtDep;

            con.Close();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool durum = true;
            foreach (Control tb in this.Controls)
            {
                if (tb != Id) {
                    if (tb is TextBox && tb.Text == String.Empty) { durum = false; break; }
                }
                
            }
            if (durum) {
                con.Open();
                SqlCommand insertCalisan = new SqlCommand("Insert into Calisan (SicilNo,Ad,Soyad,GirisTarihi,CikisTarihi,CinsiyetId, DepartmentId) values (@SicilNo,@Ad,@Soyad,@GirisTarihi,@CikisTarihi,@CinsiyetId,@DepartmanId)SELECT SCOPE_IDENTITY()", con);
                insertCalisan.Parameters.AddWithValue("@SicilNo", SicilNo.Text);
                insertCalisan.Parameters.AddWithValue("@Ad", Ad.Text);
                insertCalisan.Parameters.AddWithValue("@Soyad", Soyad.Text);
                insertCalisan.Parameters.AddWithValue("@GirisTarihi", GirisTarihi.Value.Date);
                insertCalisan.Parameters.AddWithValue("@CikisTarihi", CikisTarihi.Value.Date);
                insertCalisan.Parameters.AddWithValue("@CinsiyetId", Convert.ToInt32(Cinsiyet.SelectedValue.ToString()));
                insertCalisan.Parameters.AddWithValue("@DepartmanId", Convert.ToInt32(Departman.SelectedValue.ToString()));
                int lastInsertEmployeeKey = Convert.ToInt32(insertCalisan.ExecuteScalar());
                SqlCommand insertIletisim = new SqlCommand("Insert into Iletisim (CalisanId,Mail,CepTelefonu,EvTelefonu) values (@CalisanId,@Mail,@CepTelefonu,@EvTelefonu)", con);
                insertIletisim.Parameters.AddWithValue("@CalisanId", lastInsertEmployeeKey);
                insertIletisim.Parameters.AddWithValue("@Mail", Mail.Text);
                insertIletisim.Parameters.AddWithValue("@CepTelefonu", CepTel.Text);
                insertIletisim.Parameters.AddWithValue("@EvTelefonu", EvTel.Text);
                insertIletisim.ExecuteNonQuery();

                MessageBox.Show("Kaydedildi");
                con.Close();
                BindData();
            }
            else
            {
                MessageBox.Show("Bos alanlari doldurunuz");
            }
       
        }
        public void BindData()
        {
            SqlCommand command = new SqlCommand("select c.Id,c.SicilNo, c.Ad, c.Soyad,i.Mail,i.CepTelefonu,i.EvTelefonu,d.DepartmanAdi,ct.CinsiyetTuru, c.GirisTarihi,c.CikisTarihi from calisan c " +
            "inner join Iletisim i on i.calisanId = c.Id " +
            "inner join Departman d on d.Id = c.DepartmentId " +
            "inner join Cinsiyet ct on ct.Id = c.CinsiyetId", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            Id.Text = row.Cells[0].Value.ToString();
            SicilNo.Text = row.Cells[1].Value.ToString();
            Ad.Text = row.Cells[2].Value.ToString();
            Soyad.Text = row.Cells[3].Value.ToString();
            Mail.Text = row.Cells[4].Value.ToString();
            CepTel.Text = row.Cells[5].Value.ToString();
            EvTel.Text = row.Cells[6].Value.ToString();
            Departman.Text = row.Cells[7].Value.ToString();
            Cinsiyet.Text = row.Cells[8].Value.ToString();
           
            GirisTarihi.Value = row.Cells[9].Value.ToString().Length>0 ? DateTime.Parse(row.Cells[9].Value.ToString()):DateTime.Now;
            CikisTarihi.Value = row.Cells[10].Value.ToString().Length > 0 ? DateTime.Parse(row.Cells[10].Value.ToString()) : DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool durum = true;
            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox && tb.Text == String.Empty) { durum = false; break; }
            }
            if (durum)
            {
                if (Id.Text != "")
                {
                    con.Open();
                    SqlCommand insertCalisan = new SqlCommand("Update Calisan set SicilNo=@SicilNo,Ad=@Ad,Soyad=@Soyad,GirisTarihi=@GirisTarihi,CikisTarihi=@CikisTarihi,CinsiyetId=@CinsiyetId,DepartmentId=@DepartmanId Where Id=@Id", con);
                    insertCalisan.Parameters.AddWithValue("@Id", Convert.ToInt32(Id.Text));
                    insertCalisan.Parameters.AddWithValue("@SicilNo", SicilNo.Text);
                    insertCalisan.Parameters.AddWithValue("@Ad", Ad.Text);
                    insertCalisan.Parameters.AddWithValue("@Soyad", Soyad.Text);
                    insertCalisan.Parameters.AddWithValue("@GirisTarihi", GirisTarihi.Value.Date);
                    insertCalisan.Parameters.AddWithValue("@CikisTarihi", CikisTarihi.Value.Date);
                    insertCalisan.Parameters.AddWithValue("@CinsiyetId", Convert.ToInt32(Cinsiyet.SelectedValue.ToString()));
                    insertCalisan.Parameters.AddWithValue("@DepartmanId", Convert.ToInt32(Departman.SelectedValue.ToString()));
                    insertCalisan.ExecuteNonQuery();
                    SqlCommand insertIletisim = new SqlCommand("Update Iletisim set Mail=@Mail,CepTelefonu=@CepTelefonu,EvTelefonu=@EvTelefonu  Where CalisanId=@Id", con);
                    insertIletisim.Parameters.AddWithValue("@Id", Convert.ToInt32(Id.Text));
                    insertIletisim.Parameters.AddWithValue("@Mail", Mail.Text);
                    insertIletisim.Parameters.AddWithValue("@CepTelefonu", CepTel.Text);
                    insertIletisim.Parameters.AddWithValue("@EvTelefonu", EvTel.Text);
                    insertIletisim.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();
                    BindData();

                }
                else
                {
                    MessageBox.Show("Update Edilecek Kaydi Seciniz");
                }
            }
            else
            {
                MessageBox.Show("Bos alanlari doldurunuz");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Id.Text != "")
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("Delete from Iletisim where CalisanId=@Id", con);
                cmd2.Parameters.AddWithValue("@Id", Id.Text);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("Delete from calisan where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Id.Text);
            cmd.ExecuteNonQuery();
                MessageBox.Show("Kayit Silindi");
                BindData();
            }
            else
            {
                MessageBox.Show("Kayit silinirken bir hata olustu");

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SDepartman.SelectedValue.ToString());
            using (SqlCommand cmd = new SqlCommand("[lstCalisan]", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@departmanID", SqlDbType.Int).Value = Convert.ToInt32(SDepartman.SelectedValue.ToString()) ;
                cmd.Parameters.Add("@girisTarihi", SqlDbType.DateTime).Value = SGirisTarihi.Value.Date;

                con.Open();

                cmd.ExecuteNonQuery();
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }


}
