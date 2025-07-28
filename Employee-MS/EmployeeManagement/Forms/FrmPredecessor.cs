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
    public partial class FrmPredecessor : Form
    {
        public FrmPredecessor()
        {
            InitializeComponent();
        }


        //======================Variables====================

        DataSet ds, dsSwap;
        int EmployeeId, PredecessorId, cr;

        //===================================================

        //=====================Funcsions======================

        void GetData()
        {
            SqlConClass.sqlQuery = @"
                                       SELECT E.Id,E.EmployeeName FROM TblEmployee E ORDER BY E.EmployeeName;
                                        SELECT
                                        P.Id,
                                        ROW_NUMBER()OVER(ORDER BY (SELECT 1))N,
                                        E.EmployeeName,
                                        P.PredecessorDate,
                                        P.Value,
                                        P.Note,
                                        p.InstallmentValue,
                                        U.UserName,
                                        E.Id AS EmployeeIdDgv,
                                        ISNULL((    P.Value -SUM(RE.Value)), P.Value) AS	Residual
                                        FROM TblPredecessor P
                                        INNER JOIN TblEmployee E ON P.EmployeeId   =E.Id
                                        INNER JOIN    TblUseres U   ON     P.UserId        =U.Id 
                                        LEFT JOIN TblRepaymentOfAdvances RE ON  RE.PredecessorId = P.Id
                                        WHERE E.EmployeeStatus = 1
                                        GROUP BY P.Id,E.EmployeeName,  P.PredecessorDate,P.Value, P.Note, p.InstallmentValue,  U.UserName  ,E.Id  
                                        ORDER BY P.PredecessorDate DESC;

                                     ";
            SqlConClass sqlCon = new SqlConClass();
            ds = new DataSet();
            ds = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);
            FillData();
            CheckResidualStatus();
        }       



        void FillData()
        {
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.FillCmb(ds.Tables[0], cmbNamesOfEmployee, "EmployeeName");
                dgvPredecessor.DataSource = ds.Tables[1];
                dgvPredecessor.ClearSelection(); cmbNamesOfEmployee.Select(); cmbNamesOfEmployee.Focus();
                RefreshVariable();
            }
        }

        void GetFillCmb()
        {
            SqlConClass.sqlQuery = @"
                                    SELECT E.Id,E.EmployeeName FROM TblEmployee E ORDER BY E.EmployeeName;
                                    ";
            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 0, 0);
                FunctionsClass.FillCmb(ds.Tables[0], cmbNamesOfEmployee, "EmployeeName");
                RefreshVariable();
            }
        }

        void Filldgv(ref DataSet dsSwap)
        {
            FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 1, 0);
            dgvPredecessor.DataSource = ds.Tables[1];
            RefreshVariable();
        }

        void RefreshVariable()
        {
            EmployeeId = PredecessorId = 0; cr = -1;
            ds.Tables[1].DefaultView.RowFilter = null;
            FunctionsClass.ApplyDateFormatToDataGridViewColumns(dgvPredecessor);
            dgvPredecessor.ClearSelection();
            FunctionsClass.Clear(panel2);
        }
        //====================================
        private void CheckResidualStatus()
        {
            foreach (DataGridViewRow row in dgvPredecessor.Rows)
            {
                if (row.IsNewRow) continue;

                // جلب القيمة من عمود Residual
                object residualValue = row.Cells["Residual"].Value;

                if (decimal.TryParse(residualValue?.ToString(), out decimal residual))
                {
                    DataGridViewCell statusCell = row.Cells["Residual"]; 
                    if (residual == 0)
                    {
                       
                        statusCell.Style.BackColor = Color.LightGreen;
                        statusCell.Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        statusCell.Style.BackColor = Color.Red;
                        statusCell.Style.ForeColor = Color.White;
                    }
                }
                else
                {
                    row.Cells["Status"].Style.BackColor = Color.Gray;
                    row.Cells["Status"].Style.ForeColor = Color.White;
                }
            }
        }

        //=============================
        void SaveDiscount()
        {

            {
                SqlParameter[] param = {
        new SqlParameter("@Value", Convert.ToDecimal(txtValue.Text.Trim())),
        new SqlParameter("@InstallmentValue", Convert.ToDecimal(txtInstallmentValue.Text.Trim())),
        new SqlParameter("@Note", txtNote.Text.Trim()),
        new SqlParameter("@EmployeeId", EmployeeId),
        new SqlParameter("@UserId", VariablesClass.userId),
    };

                SqlConClass sqlCon = new SqlConClass();
                dsSwap = sqlCon.cmdExecute("InsertForTblPredecessor", param);
                if (VariablesClass.Save == 3)
                {
                    MessageBox.Show("لا يمكن إضافة سلفة جديدة لأن الموظف لم يُسدد السلفة السابقة بالكامل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Filldgv(ref dsSwap);
            }
        }

        void SetPermissions()
        {


            btnAdd.Enabled = VariablesClass.insertPermission;


            btnDelete.Enabled = VariablesClass.updatePermission;
        }
        //===================================================

        private void FrmViewOrAddRewards_Load(object sender, EventArgs e)
        {
            VariablesClass.functionsClass.MoveForm(this);

            GetData();
            FunctionsClass.ApplyDateTimePickerFormat(this);
            SetPermissions();

        }

        private void dgvRewards_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvError((DataGridView)sender) == true)
            { return; }
            cr = dgvPredecessor.CurrentRow.Index;
            PredecessorId = (int)dgvPredecessor.Rows[cr].Cells[0].Value;
        }

        private void cmbNamesOfEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbNamesOfEmployee.SelectedValue == null)
            {
                return;
            }
            EmployeeId = (int)cmbNamesOfEmployee.SelectedValue;
            ds.Tables[1].DefaultView.RowFilter = $"EmployeeIdDgv = {EmployeeId}";
            dgvPredecessor.ClearSelection();
            CheckResidualStatus();

        }

        private void cmbNamesOfEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbNamesOfEmployee_SelectionChangeCommitted(default, default);
                return;
            }
        }

        private void cmbNamesOfEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsPositiveRealNum((TextBox)sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckEmptyInput(panel2))
            {
                MessageBox.Show("الرجاء التحقق من البيانات المدخلة", "إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((Convert.ToDouble(txtValue.Text) <= 0) || (Convert.ToDouble(txtInstallmentValue.Text) <= 0))
            {
                MessageBox.Show("الرجاء التحقق من القيمة", "إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((Convert.ToDouble(txtValue.Text.Trim()) <= Convert.ToDouble(txtInstallmentValue.Text.Trim())))
            {
                MessageBox.Show("قيمة السداد اكبر من قيمة السلف الرجاء التحقق من قيمة السداد", "إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInstallmentValue.Focus();
                txtInstallmentValue.SelectAll();
                return;
            }


            SaveDiscount();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (PredecessorId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($" هل انت متأكد من حذف السلفة ؟", "حذف البيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                SqlConClass sqlcon = new SqlConClass();
                SqlParameter[] para =
                {
                    new SqlParameter("@PredecessorId", PredecessorId)
                };
                dsSwap = sqlcon.cmdExecute("DeleteFromTblPredecessor", para);
                Filldgv(ref dsSwap);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();

        }

        private void dgvPredecessor_DoubleClick(object sender, EventArgs e)
        {
            if (cr == -1 || PredecessorId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            VariablesClass.PredecessorId = PredecessorId;
            VariablesClass.EmpName = dgvPredecessor.Rows[cr].Cells["EmployeeName"].Value.ToString();

            FrmRepaymentOfAdvances frm = new FrmRepaymentOfAdvances();
            frm.ShowDialog();
            GetData();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            FunctionsClass.ExportToExcel(dgvPredecessor, "بيانات السلف");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picEmployee_Click(object sender, EventArgs e)
        {
            //هنا يتم إستدعاء واجهة الموظفين
            GetFillCmb();
        }

    }
}
