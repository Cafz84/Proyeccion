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
            
            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.ReadOnly = true;
        }

        public void FormatoDgvEmpleado(ref DataGridView Dgv)
        {
            DataGridViewCellStyle estilo = Dgv.ColumnHeadersDefaultCellStyle;
            estilo.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estilo.Font = new Font(Dgv.Font, FontStyle.Bold);
            //Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.ReadOnly = true;
        }
    }
}
