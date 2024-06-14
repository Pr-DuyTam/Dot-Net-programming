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

namespace DoAnLTnet
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("dsQLGV");
        public SqlDataAdapter daChucVu;
        public SqlDataAdapter daGiaoVien;
        public SqlConnection conn =new SqlConnection();
        public void loaddatagrid()
        {
            if (dgvTTGiaoVien.Rows.Count>1)
            {
                ds.Tables["tblGiaoVien"].Clear();
               
            }
            
            string Slgv = @"select giaovien.*,  ChucVu.chucvu from giaovien,chucvu where giaovien.MaCV=ChucVu.MaCV";
            daGiaoVien = new SqlDataAdapter(Slgv, conn);
            daGiaoVien.Fill(ds, "tblGiaoVien");
            dgvTTGiaoVien.DataSource = ds.Tables["tblGiaoVien"];
        }
        public void loadCV()
        {
            string SLcv = @"select * from chucvu";
            daChucVu = new SqlDataAdapter(SLcv, conn);
            daChucVu.Fill(ds, "tblChucVu");
            cmbCV.DataSource = ds.Tables["tblChucVu"];
            cmbCV.DisplayMember = "chucvu";
            cmbCV.ValueMember = "MaCV";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            /*DataRow row = ds.Tables["tblGiaoVien"].NewRow();
            row["MaGV"] = txtMaGV.Text;
            row["Hoten"] = txtHT.Text;
            row["DiaChi"] = txtDiaChi.Text;
            if (radNam.Checked == true)
            {
                row["gioitinh"] = "Nam";
            }
            else
            {
                row["gioitinh"] = "Nữ";
            }
            row["ngaysinh"] = dtmNS.Text;
            row["MaCV"] = cmbCV.SelectedValue;
            row["SDT"] = txtSDT.Text;
           row["chucvu"] = cmbCV.Text;
           row["HSL"] = nudHSL.Value;         
           ds.Tables["tblGiaoVien"].Rows.Add(row);
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            
*/
            flat = 1;
            chucnang();
            
           
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            chucnang();
            conn.ConnectionString = @" Data Source =LAPTOP-C31736L6\SQLEXPRESS; Initial Catalog = QLGV; Integrated Security = True";

            nudHSL.DecimalPlaces = 2;
            nudHSL.Increment = 0.1m;
            dgvTTGiaoVien.AutoGenerateColumns = false;
            loadCV();
            loaddatagrid();
            



            /* string sThemNV = @"insert into giaovien values(@MaGV, @Hoten, @MaCV,@HSL,@GioiTinh,@DiaChi,@SDT)";
             SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
             cmThemNV.Parameters.Add("@MaGV", SqlDbType.NChar, 10, "magv");
             cmThemNV.Parameters.Add("@Hoten", SqlDbType.NVarChar, 50, "hoten");
             cmThemNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 50, "macv");
             cmThemNV.Parameters.Add("@HSL", SqlDbType.Float,50, "HSL");
             cmThemNV.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 50, "GioiTinh");
             cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.NVarChar, 50, "ngaysinh");

             cmThemNV.Parameters.Add("@SDT", SqlDbType.NVarChar, 50, "SDT");
             cmThemNV.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50, "DiaChi");
             daGiaoVien.InsertCommand = cmThemNV;*/




        }
        public int flat=0;
        
        
        
        public void chucnang()
        { 
            if(flat==0)
            {
                txtMaGV.Text = "";
                txtHT.Text = "";
                dtmNS.Text = "";

                txtSDT.Text = "";
                cmbCV.Text = "";
                nudHSL.Value = 0;
                txtDiaChi.Text = "";
                txtMaGV.Enabled = false;
                txtHT.Enabled = false;
                dtmNS.Enabled = false;
                radNam.Enabled = false;
                radNu.Enabled = false;
                txtSDT.Enabled = false;
                cmbCV.Enabled = false;
                nudHSL.Enabled = false;
                txtDiaChi.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnThoat.Enabled = true;
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                dgvTTGiaoVien.Enabled = true;
            }
            else if(flat==1)
            {
                txtMaGV.Enabled = true;
                txtHT.Enabled = true;
                dtmNS.Enabled = true;
                radNam.Enabled = true;
                radNu.Enabled = true;
                txtSDT.Enabled = true;
                cmbCV.Enabled = true;
                nudHSL.Enabled = true;
                txtDiaChi.Enabled = true;
                txtMaGV.Text = "";
                txtHT.Text = "";
                dtmNS.Text = "";
                
                txtSDT.Text = "";
                cmbCV.Text = "";
                nudHSL.Value = 0;
                txtDiaChi.Text = "";
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnThoat.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
                dgvTTGiaoVien.Enabled = false;

            }
            else if (flat == 2)
            {
                txtMaGV.Enabled = true;
                txtHT.Enabled = true;
                dtmNS.Enabled = true;
                radNam.Enabled = true;
                radNu.Enabled = true;
                txtSDT.Enabled = true;
                cmbCV.Enabled = true;
                nudHSL.Enabled = true;
                txtDiaChi.Enabled = true;
                txtMaGV.Enabled = false;
                
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnThoat.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
                dgvTTGiaoVien.Enabled = true;

            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("thoát???", "xác nhân", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /* if (this.dgvTTGiaoVien.SelectedRows.Count > 0)
             {
                 dgvTTGiaoVien.Rows.RemoveAt(this.dgvTTGiaoVien.SelectedRows[0].Index);
             }*/

            conn.Open();
            string sqlinsert = "delete from giaovien where magv=@MaGV";
            SqlCommand ins = new SqlCommand(sqlinsert, conn);
            ins.Parameters.AddWithValue("@MaGV", txtMaGV.Text);           
            ins.ExecuteNonQuery();
            conn.Close();
            loaddatagrid();
            flat = 0;
            chucnang();

        }

        private void dgvTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* DataGridViewRow dr = dgvTTGiaoVien.SelectedRows[0];
            txtMaGV.Text = dr.Cells["magv"].Value.ToString();
            txtHT.Text = dr.Cells["hoten"].Value.ToString();
            if (dr.Cells["gioitinh"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtmNS.Text = dr.Cells["ngaysinh"].Value.ToString();
            cmbCV.SelectedItem = dr.Cells["macv"].Value.ToString();
            txtSDT.Text = dr.Cells["SDT"].Value.ToString();
            nudHSL.Value = decimal.Parse( dr.Cells["HSL"].Value.ToString());*/
        }

        private void btnSua_Click(object sender, EventArgs e)
        {/*
           int stt = dgvTTGiaoVien.CurrentRow.Index;
           
            dgvTTGiaoVien.Rows[stt].Cells["magv"].Value = txtMaGV.Text;
            dgvTTGiaoVien.Rows[stt].Cells["hoten"].Value = txtHT.Text;
            dgvTTGiaoVien.Rows[stt].Cells["ngaysinh"].Value = dtmNS.Text;
            dgvTTGiaoVien.Rows[stt].Cells["SDT"].Value = txtSDT.Text;          
            dgvTTGiaoVien.Rows[stt].Cells["chucvu"].Value = cmbCV.Text;
            dgvTTGiaoVien.Rows[stt].Cells["diachi"].Value = txtDiaChi.Text;
            dgvTTGiaoVien.Rows[stt].Cells["gioitinh"].Value = radNam.Text;
            if(radNam.Checked==true)
            {
                dgvTTGiaoVien.Rows[stt].Cells["gioitinh"].Value = radNam.Text;
            }    
            else
            {
                dgvTTGiaoVien.Rows[stt].Cells["gioitinh"].Value = radNu.Text;
            }    */

            flat = 2;
            chucnang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            /*try
            {
                daGiaoVien.Update(ds, "tblGiaoVien");
                MessageBox.Show("đã lưu", "thông báo");
               dgvTTGiaoVien.Refresh();
            }
            catch
            {
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }*/
            if(flat==1)
            {
                conn.Open();
                string sqlinsert = "insert into giaovien(MaGV, Hoten, MaCV, ngaysinh,HSL,GioiTinh,DiaChi,SDT) values(@MaGV, @Hoten, @MaCV, @ngaysinh,@HSL,@GioiTinh,@DiaChi,@SDT)";
                SqlCommand ins = new SqlCommand(sqlinsert, conn);
                ins.Parameters.AddWithValue("@MaGV", txtMaGV.Text);
                ins.Parameters.AddWithValue("@Hoten", txtHT.Text);
                ins.Parameters.AddWithValue("@MaCV", cmbCV.SelectedValue.ToString());
                ins.Parameters.AddWithValue("@HSL", nudHSL.Value);
                ins.Parameters.AddWithValue("@ngaysinh", dtmNS.Text);
                if (radNam.Checked == true)
                {
                    ins.Parameters.AddWithValue("@GioiTinh", radNam.Text);
                }
                else
                {
                    ins.Parameters.AddWithValue("@GioiTinh", radNu.Text);
                }
                ins.Parameters.AddWithValue("@Diachi", txtDiaChi.Text);
                ins.Parameters.AddWithValue("@SDT", txtSDT.Text);

                ins.ExecuteNonQuery();
                conn.Close();
                loaddatagrid();
                flat = 0;
                btnThem.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnThoat.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            else if (flat==2)
            {
                conn.Open();
                string sqlinsert = "update giaovien set hoten=@Hoten,macv=@MaCV,ngaysinh=@ngaysinh,hsl=@HSL,gioitinh=@GioiTinh,diachi=@DiaChi,sdt=@SDT where magv=@MaGV";
                SqlCommand ins = new SqlCommand(sqlinsert, conn);
                ins.Parameters.AddWithValue("@MaGV", txtMaGV.Text);
                ins.Parameters.AddWithValue("@Hoten", txtHT.Text);
                ins.Parameters.AddWithValue("@MaCV", cmbCV.SelectedValue.ToString());
                ins.Parameters.AddWithValue("@HSL", nudHSL.Value);
                ins.Parameters.AddWithValue("@ngaysinh", dtmNS.Text);
                if (radNam.Checked == true)
                {
                    ins.Parameters.AddWithValue("@GioiTinh", radNam.Text);
                }
                else
                {
                    ins.Parameters.AddWithValue("@GioiTinh", radNu.Text);
                }
                ins.Parameters.AddWithValue("@Diachi", txtDiaChi.Text);
                ins.Parameters.AddWithValue("@SDT", txtSDT.Text);

                ins.ExecuteNonQuery();
                conn.Close();
                loaddatagrid();
                flat = 0;
                btnThem.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnThoat.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            chucnang();
        }

        private void dgvTTGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            DataGridViewRow slr = dgvTTGiaoVien.CurrentRow;
           

            txtMaGV.Text = slr.Cells["magv"].Value.ToString(); 
            txtHT.Text = slr.Cells["hoten"].Value.ToString();
            nudHSL.Value = decimal.Parse(slr.Cells["HSL"].Value.ToString());
            txtSDT.Text = slr.Cells["SDT"].Value.ToString();          
            cmbCV.Text = slr.Cells["chucvu"].Value.ToString();
            txtDiaChi.Text = slr.Cells["diachi"].Value.ToString();
            if (slr.Cells["gioitinh"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblGiaoVien"].RejectChanges();
            flat = 0;
            chucnang();
        }
    }
}
