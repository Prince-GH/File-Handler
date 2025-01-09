using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class listCustom
{
    private ListBox _clipHistory;
    private Panel _borderPanel;
    private int _hoveredIndex = -1;

    public listCustom(ListBox clipHistory, Form parentForm)
    {
        _clipHistory = clipHistory;

        // Set ListBox to OwnerDraw mode
        _clipHistory.DrawMode = DrawMode.OwnerDrawFixed;

        // Attach the events
        _clipHistory.DrawItem += ClipHistory_DrawItem;
        _clipHistory.MouseMove += ClipHistory_MouseMove;
        _clipHistory.MouseLeave += ClipHistory_MouseLeave;

        // Add a bottom border using a Panel
        _borderPanel = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 2,
            BackColor = Color.Gray
        };

        parentForm.Controls.Add(_borderPanel);
        _borderPanel.BringToFront();
    }

    // Handle the DrawItem event for custom rendering
    private void ClipHistory_DrawItem(object sender, DrawItemEventArgs e)
    {
        e.DrawBackground();

        bool isHovered = e.Index == _hoveredIndex;

        Color textColor = isHovered ? Color.White : Color.White;
        Color backgroundColor = isHovered ? Color.DimGray : _clipHistory.BackColor;

        using (Brush backgroundBrush = new SolidBrush(backgroundColor))
        using (Brush textBrush = new SolidBrush(textColor))
        {
            e.Graphics.FillRectangle(backgroundBrush, e.Bounds);

            if (e.Index >= 0)
            {
                e.Graphics.DrawString(
                    _clipHistory.Items[e.Index].ToString(),
                    e.Font,
                    textBrush,
                    e.Bounds);
            }
        }

        e.DrawFocusRectangle();
    }

    // Handle the MouseMove event for hover effect
    private void ClipHistory_MouseMove(object sender, MouseEventArgs e)
    {
        int index = _clipHistory.IndexFromPoint(e.Location);
        if (index != _hoveredIndex)
        {
            _hoveredIndex = index;
            _clipHistory.Invalidate();
        }
    }

    // Handle the MouseLeave event to reset hover effect
    private void ClipHistory_MouseLeave(object sender, EventArgs e)
    {
        _hoveredIndex = -1;
        _clipHistory.Invalidate();
    }
}
