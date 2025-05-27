using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace baitaplon
{
    public partial class quanlymonan : Form
        
    {
        
        public quanlymonan()
        {
            InitializeComponent();
        }

        
       

        

        private void btThem_Click(object sender, EventArgs e)
        {
            string TenMon = tbTenMon.Text;
            double giaMon = Convert.ToDouble(numGia.Text);
            string NhomMon = cbbNhom.SelectedItem.ToString();
            string TrangThai = cbbTrangThai.SelectedItem.ToString();
            if (string.IsNullOrEmpty(TenMon) || giaMon <= 0 || string.IsNullOrEmpty(NhomMon) || string.IsNullOrEmpty(TrangThai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin món ăn.");
                return;
            }
            dsMonAn.Rows.Add(TenMon, giaMon, NhomMon, TrangThai);
            tbTenMon.Clear();
            numGia.Clear();
            cbbNhom.SelectedIndex = -1; // Đặt lại lựa chọn nhóm món
            cbbTrangThai.SelectedIndex = -1; // Đặt lại lựa chọn trạng thái món
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            dsMonAn.CurrentRow.Cells[0].Value = tbTenMon.Text;
            dsMonAn.CurrentRow.Cells[1].Value = numGia.Text;
            dsMonAn.CurrentRow.Cells[2].Value = cbbNhom.SelectedItem.ToString();
            dsMonAn.CurrentRow.Cells[3].Value = cbbTrangThai.SelectedItem.ToString();
            tbTenMon.Clear();
            numGia.Clear();
            cbbNhom.SelectedIndex = -1;
            // Đặt lại lựa chọn nhóm món
            cbbTrangThai.SelectedIndex = -1; // Đặt lại lựa chọn trạng thái món


        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            dsMonAn.Rows.RemoveAt(dsMonAn.CurrentRow.Index);
        }

        private void dsMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dsMonAn_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dsMonAn.CurrentRow;
            tbTenMon.Text = row.Cells[0].Value.ToString();
            numGia.Text = row.Cells[1].Value.ToString();

            cbbNhom.SelectedItem = row.Cells[2].Value.ToString();
            cbbTrangThai.SelectedItem = row.Cells[3].Value.ToString();

        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string tk = tbTimKiem.Text.ToLower();
            foreach (DataGridViewRow row in dsMonAn.Rows)
            {
                if (row.IsNewRow) continue;

                string tenMon = row.Cells[0].Value.ToString().ToLower();
                string giaStr = row.Cells[1].Value.ToString().ToLower();
                string nhomMon = row.Cells[2].Value.ToString().ToLower();
                string trangThai = row.Cells[3].Value.ToString().ToLower();

                // Hiển thị dòng nếu TÊN MÓN hoặc GIÁ chứa từ khóa
                bool match = (tenMon != null && tenMon.Contains(tk)) ||
                             (giaStr != null && giaStr.Contains(tk)) || 
                             (nhomMon != null && nhomMon.Contains(tk)) || 
                             (trangThai != null && trangThai.Contains(tk));

                row.Visible = match;

            }

        }

        private void btXemMon_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dsMonAn.Rows)
            {
                if (row.IsNewRow) continue;
                // Hiển thị tất cả các dòng
                row.Visible = true;
            }
        }

        private void tbTenMon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
