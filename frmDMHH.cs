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

namespace LopPTUD2022_sang
{
    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable(); //combo box
        DataTable dtn = new DataTable();
        DataTable dtBC = new DataTable();
        string sql, constr;
        int i;
        Boolean AddnewFlag = false;
        
        public frmDMHH()
        {
            InitializeComponent();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-KRKLR7M\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select MaNHom,MaHH,TenHH,dvt,dgVnd,sanxuat from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            sql = "select distinct manhom from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dtn);
            txtmanhom.DataSource = dtn;
            txtmanhom.DisplayMember = "manhom";
            NapCT();

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0]; //đưa ô hiện thời về tọa độ cột 0,dòng 0
            NapCT();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            i = grdData.RowCount; //đếm được bnh dòng
            grdData.CurrentCell = grdData[0, i-1];
            NapCT();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i==grdData.RowCount-1)
            {
                grdData.CurrentCell = grdData[0, 0];
                NapCT();
            } 
            else
            {
                grdData.CurrentCell = grdData[0, i+1];
                NapCT();
            }
          
        }

        private void btnprv_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i == 0)
            {
                grdData.CurrentCell = grdData[0, grdData.RowCount-1];
                NapCT();
            }
            else
            {
                grdData.CurrentCell = grdData[0, i - 1];
                NapCT();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comtentruong.Text + " From tblDMHH ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comgt.DataSource = comdt;
            comgt.DisplayMember = comtentruong.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            sql = "select MaNHom,MaHH,TenHH,dvt,dgVnd,sanxuat from tblDMHH " + 
                " where " + comtentruong.Text + " =N'" + comgt.Text + "'";
            da = new SqlDataAdapter(sql, conn);
           
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
        }

        private void btnrf_Click(object sender, EventArgs e)
        {
            sql = "select MaNHom,MaHH,TenHH,dvt,dgVnd,sanxuat from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?(Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes) 

            {
                MessageBox.Show("Bạn vừa chọn nút YES, tôi sẽ xóa ngay đây!");
                sql = "delete from tblDMHH where mahh= '" + txtmahh.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                i = grdData.CurrentRow.Index;
                grdData.Rows.RemoveAt(i);
                NapCT();
            }
            else
            {
                MessageBox.Show("Bạn đã chọn NO, vậy chào nhé!");
            }    
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            AddnewFlag = true;
            i = grdData.RowCount; //đếm được bnh dòng
            grdData.CurrentCell = grdData[0, i - 1];
            NapCT();
            txtmanhom.Focus(); //chuyển con trỏ chuột về ô mã nhóm

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(AddnewFlag==true)
            {
                MessageBox.Show("Bạn vừa thêm mới đúng không? Giờ tôi sẽ chạy lệnh Insert into");
                AddnewFlag = false;
                sql = "insert into tblDMHH (manhom,mahh,tenhh,dvt,dgVnd,sanxuat)" +
                    "values('" + txtmanhom.Text + "','" + txtmahh.Text + "',N'" + txttenhh.Text + "',N'" +
                    txtdvt.Text + "','" + txtdgvnd.Text + "',N'" + txtnuocsx.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }  
            else
            {
                  MessageBox.Show("Bạn vừa sửa chữa đúng không? Giờ tôi sẽ chạy lệnh Update");
                 sql = "Update tblDMHH Set tenhh=N'" + txttenhh.Text + "',dvt=N'" + txtdvt.Text +
                 "', dgVnd='" + txtdgvnd.Text + "', sanxuat=N'" + txtnuocsx.Text + "'Where mahh='" + txtmahh.Text+"'";
                 cmd.Connection = conn;
                 cmd.CommandText = sql;
                 cmd.ExecuteNonQuery();
                 grdData.Rows[i].Cells["manhom"].Value=txtmanhom.Text; //cập nhật gt của dòng hiện thời
                 grdData.Rows[i].Cells["MaHH"].Value=txtmahh.Text;
                 grdData.Rows[i].Cells["TenHH"].Value =txttenhh.Text;
                 grdData.Rows[i].Cells["dvt"].Value=txtdvt.Text;
                 grdData.Rows[i].Cells["dgVnd"].Value= txtdgvnd.Text;
                 grdData.Rows[i].Cells["sanxuat"].Value= txtnuocsx.Text;


                /*cmd.Connection = conn;
                for (i = 0; i <= grdData.RowCount - 2; i++)
                {
                    txtmanhom.Text = grdData.Rows[i].Cells["manhom"].Value.ToString(); //tên ô lưới.dòng i.ở cột mã nhóm.chuyên text
                    txtmahh.Text = grdData.Rows[i].Cells["MaHH"].Value.ToString();
                    txttenhh.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();
                    txtdvt.Text = grdData.Rows[i].Cells["dvt"].Value.ToString();
                    txtdgvnd.Text = grdData.Rows[i].Cells["dgVnd"].Value.ToString();
                    txtnuocsx.Text = grdData.Rows[i].Cells["sanxuat"].Value.ToString();
                    sql = "Update tblDMHH Set tenhh=N'" + txttenhh.Text + "',dvt=N'" + txtdvt.Text +
                 "', dgVnd='" + txtdgvnd.Text + "', sanxuat=N'" + txtnuocsx.Text + "'Where mahh='" + txtmahh.Text+"'";
                 
                 cmd.CommandText = sql;
                 cmd.ExecuteNonQuery();
                } */
            }    
        }

        private void frmDMHH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("\t"); //t đại diện cho phím Tab, b=backspace
            }    
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy sửa trực tiếp tại ô lưới. Kết thúc bằng cách bấm nút Cập nhật.");
        }

        private void btnrp_Click(object sender, EventArgs e)
        {
            sql = "select manhom, maHH, TenHH, dvt, dgVnd, sanxuat from tblDMHH "+ 
                " where "+ comtentruong.Text + "=N'" + comgt.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dtBC.Clear();
            da.Fill(dtBC);
            rptDMHH bc = new rptDMHH();
            bc.SetDataSource(dtBC);
            bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + comtentruong.Text + "'";
            bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + comgt.Text + "'";
            frmrptDMHH f = new frmrptDMHH(bc);
            f.Show();
            
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index; //chứa được stt của bản ghi hiện thời
            txtmanhom.Text = grdData.Rows[i].Cells["manhom"].Value.ToString(); //tên ô lưới.dòng i.ở cột mã nhóm.chuyên text
            txtmahh.Text = grdData.Rows[i].Cells["MaHH"].Value.ToString();
            txttenhh.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtdvt.Text = grdData.Rows[i].Cells["dvt"].Value.ToString();
            txtdgvnd.Text = grdData.Rows[i].Cells["dgVnd"].Value.ToString();
            txtnuocsx.Text = grdData.Rows[i].Cells["sanxuat"].Value.ToString();
        }
    }
}
