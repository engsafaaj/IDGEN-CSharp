using IDGEN.Gui.StudnetGui;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGEN.Code
{
    public static class PrintHelper
    {
        // Method to print the form
        public static void PrintForm(AddStudentForm formToPrint)
        {
            formToPrint.FormBorderStyle = FormBorderStyle.None;
            formToPrint.buttonSaveAndClose.Visible = false;
            formToPrint.groupBox1.Enabled = true;
            formToPrint.panel1.Visible = false;
            formToPrint.buttonCopy.Visible = false;
            formToPrint.buttonPrint.Visible = false;
            formToPrint.BackColor = Color.White;
            formToPrint.ForeColor = Color.Black;

            // Set up printing
            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.Landscape = true;
            printDocument.PrintPage += (sender, e) =>
            {
                Bitmap bitmap = new Bitmap(formToPrint.Width, formToPrint.Height);
                formToPrint.DrawToBitmap(bitmap, new Rectangle(0, 0, formToPrint.Width, formToPrint.Height));
                e.Graphics.DrawImage(bitmap, 0, 0);
            };
            // Display print dialog and print the document if user agrees
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
            formToPrint.Close();
        }
        public static void PrintPanel(Panel panel)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.Landscape = true;
            printDocument.PrintPage += (sender, e) =>
            {
                // Calculate the size of the panel that fits within the print area
                Size panelSize = panel.Size;
                Rectangle printArea = e.MarginBounds;
                float scaleX = (float)printArea.Width / panelSize.Width;
                float scaleY = (float)printArea.Height / panelSize.Height;
                float scale = Math.Min(scaleX, scaleY);

                // Create a bitmap to hold the contents of the panel
                Bitmap bitmap = new Bitmap(panelSize.Width, panelSize.Height);
                panel.DrawToBitmap(bitmap, new Rectangle(Point.Empty, panelSize));

                // Draw the bitmap onto the print page
                e.Graphics.DrawImage(bitmap, printArea.Left, printArea.Top, panelSize.Width * scale, panelSize.Height * scale);

                // Manually draw ComboBox dropdown items
                foreach (Control control in panel.Controls)
                {
                    if (control is ComboBox comboBox)
                    {
                        if (comboBox.DroppedDown)
                        {
                            Rectangle comboBoxRect = new Rectangle(comboBox.Location.X + printArea.Left, comboBox.Location.Y + printArea.Top, comboBox.Width, comboBox.DropDownHeight);
                            e.Graphics.FillRectangle(SystemBrushes.Window, comboBoxRect);
                            for (int i = 0; i < comboBox.Items.Count; i++)
                            {
                                Rectangle itemRect = new Rectangle(comboBoxRect.Left, comboBoxRect.Top + (comboBox.ItemHeight * i), comboBoxRect.Width, comboBox.ItemHeight);
                                e.Graphics.DrawString(comboBox.Items[i].ToString(), comboBox.Font, SystemBrushes.WindowText, itemRect);
                            }
                        }
                    }
                }
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

    }
}
