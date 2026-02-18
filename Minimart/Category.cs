using Microsoft.Data.SqlClient;
using System.Data;

namespace Minimart;

public partial class Category : Form {
    public Category() {
        InitializeComponent();
    }
    SqlConnection? _conn;

    int _categoryId;
    string _categoryName = string.Empty;
    string _description = string.Empty;

    private void frmCategory_Load(object sender, EventArgs e) {
        _conn = Minimart.Connect();
        ShowData("");
    }

    private void ShowData(string str) {
        string sql = "SELECT * FROM Categories "
                     + " WHERE CategoryName LIKE @search"
                     + " or Description LIKE @search";
        SqlCommand cmd = new SqlCommand(sql, _conn);
        cmd.Parameters.AddWithValue("@search", "%" + str + "%");
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        dgvCategory.DataSource = ds.Tables[0];
    }

    private void txtSearch_TextChanged(object sender, EventArgs e) {
        ShowData(txtSearch.Text.Trim());
    }

    private void dgvCategory_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e) {
        _categoryId = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells[0].Value);
        _categoryName = dgvCategory.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
        _description = dgvCategory.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;

        //ทดสอบ (ถ้าทดสอบเสร็จก็ ลบออกได้เลย)
        //string s = categoryID.ToString() + "\n" + categoryName + "\n" + description;
        //MessageBox.Show(s);
    }

    private void btnInsert_Click(object sender, EventArgs e) {
        //ปุ่มเพิ่มข้อมูล
        //เปิดฟอร์ม frmEditCategory ในโหมดเพิ่มข้อมูล
        FrmEditCategory frm = new FrmEditCategory();
        frm.CategoryId = 0; //เพิ่มใหม่
        frm.CategoryName = string.Empty;
        frm.Description = string.Empty;
        frm.Status = "Insert";
        frm.ShowDialog();
        ShowData(""); //รีเฟรชข้อมูล
    }

    private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
        //double click ที่ข้อมูลเพื่อแก้ไขข้อมูล
        //เปิดฟอร์ม frmEditCategory ในโหมดแก้ไขข้อมูล
        FrmEditCategory frm = new FrmEditCategory();
        frm.CategoryId = _categoryId; //แก้ไข
        frm.CategoryName = _categoryName;
        frm.Description = _description;
        frm.Status = "Update";
        
        frm.ShowDialog();
        ShowData(""); //รีเฟรชข้อมูล
    }

    private void btnDelete_Click(object sender, EventArgs e) {
        if (_categoryId == 0) //ไม่ได้เลือกรายการใดๆ
        {
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบ");
            return;
        }

        //ยืนยันการลบข้อมูล
        DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่?", "ยืนยันการลบข้อมูล"
            , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes) {
            try {
                string sql = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@CategoryID", _categoryId);
                int row = cmd.ExecuteNonQuery();
                if (row > 0) {
                    MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว");
                    ShowData(""); //รีเฟรชข้อมูล
                } else {
                    MessageBox.Show("ลบข้อมูลไม่สำเร็จ");
                }
            }
            catch (SqlException ex) {
                MessageBox.Show("ไม่สามารถลบข้อมูลได้ เนื่องจากมีข้อมูลในตารางอื่นอ้างอิงถึง" + "\n" + ex.Message);
            }
        }
    }
}
