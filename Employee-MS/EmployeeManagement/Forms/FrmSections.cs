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

namespace EmployeeManagement.Forms
{
    public partial class FrmSections : Form
    {
        public FrmSections()
        {
            InitializeComponent();
        }



        //============================Variables============================
        int SectionId, ManagementId, cr;
        DataSet ds = new DataSet();

        //=================================================================


        //============================Functions============================

        void GetData()
        {
            SqlConClass.sqlQuery = @"
                                         SELECT Id,ManagementName FROM TblManagement
                                         ORDER BY ManagementName;
                                         SELECT S.Id,ROW_NUMBER()OVER(ORDER BY(SELECT 1))N,S.SectionName,M.Id AS ManaId 
                                         FROM TblSections S
                                         INNER JOIN TblManagement M ON S.ManagementId =M.Id
                                         ORDER BY S.SectionName
                                       ";
            SqlConClass sql = new SqlConClass();
            ds = sql.selectData(SqlConClass.sqlQuery, 0, null); FillData();
        }

        void FillData()
        {
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.FillCmb(ds.Tables[0], cmbManagement, "ManagementName");
                dgvSections.DataSource = ds.Tables[1];
                dgvSections.ClearSelection();
                txtSection.Text = string.Empty;
                cmbManagement.Select();
                cmbManagement.Focus();
                ManagementId = SectionId = 0; cr = -1;
            }
            else { this.Close(); }
        }

        void GetFillCmb()
        {
            SqlConClass.sqlQuery = @"
                                  SELECT Id,ManagementName FROM TblManagement
                                  ORDER BY ManagementName;
                                    ";
            SqlConClass sql = new SqlConClass(); DataSet dscmb = new DataSet();
            dscmb = sql.selectData(SqlConClass.sqlQuery, 0, null);
            if (FunctionsClass.DsHasTables(dscmb))
            {
                FunctionsClass.UpdateDataset(ref ds, ref dscmb, 0, 0);
                FunctionsClass.FillCmb(ds.Tables[0], cmbManagement, "ManagementName");
            }
            else { this.Close(); }
        }

        void SaveData()
        {
            if (txtSection.Text.Trim() == string.Empty || ManagementId == 0)
            {
                MessageBox.Show("الرجاء التأكد من تعبة الحقل", "إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information); txtSection.Focus(); return;
            }
            SqlParameter[] Para =
            {
                new SqlParameter("@SectionName",txtSection.Text.Trim()),
                new SqlParameter("@ManagementId",ManagementId),
                new SqlParameter("@Id",SectionId)
            };
            SqlConClass sql = new SqlConClass(); ds.Clear();
            ds = sql.cmdExecute("InsertAndUpdateDataForTblSections", Para); FillData();
        }

        void DisPlay()
        {
            SectionId = (int)dgvSections.Rows[cr].Cells[0].Value;
            txtSection.Text = dgvSections.Rows[cr].Cells[2].Value.ToString(); txtSection.Focus();
            //=============================CMB=================================
            var row = dgvSections.Rows[cr];
            ManagementId = (int)row.Cells[3].Value;
            cmbManagement.SelectedValue = ManagementId;
            cmbManagement_SelectionChangeCommitted(default, default);
        }

        void SetPermissions()
        {


            btnAdd.Enabled = VariablesClass.insertPermission;

            btnSave.Enabled = VariablesClass.updatePermission;

            btnDelete.Enabled = VariablesClass.updatePermission;
        }
        //=================================================================

        private void FrmSections_Load(object sender, EventArgs e)
        {
            VariablesClass.functionsClass.MoveForm(this);

            GetData();
            SetPermissions();


        }

        private void dgvSections_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvError((DataGridView)sender) == true) return;
            cr = dgvSections.CurrentRow.Index; DisPlay();
        }

        private void cmbManagement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (FunctionsClass.IsComboBoxValueNull(cmbManagement)) return;
            ManagementId = (int)cmbManagement.SelectedValue;
            ds.Tables[1].DefaultView.RowFilter = $"ManaId = {ManagementId}";
            dgvSections.ClearSelection();
        }

        private void cmbManagement_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

        private void cmbManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbManagement_SelectionChangeCommitted(default, default);
                return;
            }
        }

        //=================================================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SectionId != 0)
            {
                btnRefresh_Click(default, default);
                return;
            }
            SaveData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SectionId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SectionId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSections.ClearSelection();
                return;
            }
            if (MessageBox.Show($"هل انت متأكد من إجراء عميلة الحذف على القسم؟{Environment.NewLine}{txtSection.Text.Trim()}", "حذف البيانات",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConClass sqlcon = new SqlConClass();
                SqlParameter[] para =
                {
           new SqlParameter("@Id",SectionId)
       }; ds.Clear();
                ds = sqlcon.cmdExecute("DeleteForTblSection", para); FillData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //=================================================================

        private void picAddManagement_Click(object sender, EventArgs e)
        {
            FrmManagement Frm = new FrmManagement();
            Frm.ShowDialog();
            GetFillCmb();
        }

        private void txtSection_TextChanged(object sender, EventArgs e)
        {
            if (SectionId == 0)
            {
                ds.Tables[1].DefaultView.RowFilter = $"SectionName Like '%{txtSection.Text.Trim()}%'";
                dgvSections.ClearSelection();
            }
        }

        private void txtSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

    }
}
