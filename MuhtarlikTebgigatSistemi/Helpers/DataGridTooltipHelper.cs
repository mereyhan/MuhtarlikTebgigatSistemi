using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi.Helpers
{
    public class DataGridTooltipHelper
    {
        private readonly Dictionary<string, IForeignKeyPreview> _previewProviders;
        private readonly ToolTip _toolTip = new ToolTip();

        public DataGridTooltipHelper(Dictionary<string, IForeignKeyPreview> previewProviders)
        {
            _previewProviders = previewProviders;
        }

        public void AttachTo(DataGridView dataGridView)
        {
            dataGridView.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var column = dataGridView.Columns[e.ColumnIndex];
                    if (_previewProviders.TryGetValue(column.Name, out var provider))
                    {
                        var value = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                        if (!string.IsNullOrEmpty(value))
                        {
                            // string text = provider.GetTooltipText(value);
                            // var cellRect = dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                            // _toolTip.Show(text, dataGridView, cellRect.X + 10, cellRect.Y + 20, 3000);
                        }
                    }
                }
            };
        }
    }

}
