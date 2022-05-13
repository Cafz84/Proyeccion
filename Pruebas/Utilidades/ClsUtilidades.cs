using System.Drawing;
using System.Windows.Forms;

namespace Pruebas.Utilidades
{
    public class ClsUtilidades
    {
        public void FormatoDataGridView(ref DataGridView Dgv)
        {
            DataGridViewCellStyle estilo = Dgv.ColumnHeadersDefaultCellStyle;
            estilo.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estilo.Font = new Font(Dgv.Font, FontStyle.Bold);
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dgv.Columns[0].DisplayIndex = Dgv.ColumnCount - 1;
            
            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.ReadOnly = true;
        }

        public void FormatoDgvEmpleado(ref DataGridView Dgv)
        {
            DataGridViewCellStyle estilo = Dgv.ColumnHeadersDefaultCellStyle;
            estilo.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estilo.Font = new Font(Dgv.Font, FontStyle.Bold);
            Dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.ReadOnly = true;
        }

        public void FormatoDgvPEC(ref DataGridView Dgv)
        {
            DataGridViewCellStyle estilo = Dgv.ColumnHeadersDefaultCellStyle;
            estilo.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estilo.Font = new Font(Dgv.Font, FontStyle.Bold);
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.ReadOnly = true;
        }
    }
}
