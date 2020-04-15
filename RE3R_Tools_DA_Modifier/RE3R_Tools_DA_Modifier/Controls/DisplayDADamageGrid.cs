using System.Windows.Forms;
using RE3R_Tools_DA_Library;

namespace RE3R_Tools_DA_Modifier.Controls
{
    public partial class DisplayDADamageGrid : UserControl
    {
        private DADamageParser DAParser;

        public DisplayDADamageGrid()
        {
            InitializeComponent();
            DataGrid.CellFormatting += DataGrid_CellFormatting;
            DataGrid.CellEndEdit += DataGrid_CellEndEdit;
        }

        private void DataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 20)
                return;

            DataGridViewCell cell = DataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if(!float.TryParse(cell.Value.ToString(), out float value))
                cell.Value = 100.0f;
        }

        private void DataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value != null && float.TryParse(e.Value.ToString(), out float value))
                e.Value = (value/100).ToString("P2");
        }

        public void ResetToDefault()
        {
            if (DAParser == null) 
                return;

            var defDmgTaken = DAParser.GetDefaultDamageTaken();
            var defDmgDealt = DAParser.GetDefaultDamageDealt();
            FillRows(defDmgTaken, defDmgDealt);
        }

        public void ParseFileData(byte[] data)
        {
            DAParser = new DADamageParser(data);
            FillRows(DAParser.GetDamageTaken(), DAParser.GetDamageDealt());
        }

        public byte[] GetDataToSave()
        {
            var damageTaken = new float[DataGrid.RowCount-1];
            var damageDealt = new float[DataGrid.RowCount-1];

            for(int i = 0; i < damageDealt.Length; ++i)
            {
                damageTaken[i] = CellToValue(i, 0)/100f;
                damageDealt[i] = CellToValue(i, 1)/100f;
            }
            DAParser.SetDamageDealt(damageDealt);
            DAParser.SetDamageTaken(damageTaken);

            return DAParser.GetData();
        }

        private float CellToValue(int row, int column)
        {
            object cell = DataGrid.Rows[row].Cells[column].Value;
            if (cell != null && float.TryParse(cell.ToString(), out float damage))
            {
                return damage;
            }
            
            return 100;
        }

        private void FillRows(float[] damageTaken, float[] damageDealt)
        {
            DataGrid.RowHeadersWidth = 100;
            DataGrid.DefaultCellStyle.Format = "P2";
            DataGrid.Rows.Clear();

            for (int i = 0; i < damageTaken.Length; ++i)
            {
                int row = DataGrid.Rows.Add(damageTaken[i]*100, damageDealt[i]*100);
                DataGrid.Rows[row].HeaderCell.Value = $"DA Rank {i}";
            }
        }
    }
}
