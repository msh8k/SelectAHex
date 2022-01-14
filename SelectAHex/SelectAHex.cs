using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectAHex
{
    public partial class SelectAHex : Form
    {
        private const double HEX_WIDTH = 50;

        private List<Hex3> Nest = new List<Hex3> ( );
        private List<PointF> SelectedHexagons = new List<PointF> ( );

        private List<List<Hex3>> FileNests;
        private List<List<PointF>> FileHexagons;

        private double hexHeight;

        private int fileCount = 0;
        public SelectAHex ( )
        {
            
            InitializeComponent ( );

            hexHeight = HexHeight (HEX_WIDTH);
            /*
            for (int y = 5; y >= -5; y--)
            {
                for (int x = -5; x <= 5; x++)
                {
                    Nest.Add (new Hex3 (new PointF((y % 2 == 1) ? x - 0.5f : x, y)));
                }
            }
            */
        }

        private void DrawHexGrid (Graphics gr, Pen pen, float height)
        {
            PointF[ ] points;

            for (int row = 0; row < 11; row++)
            {
                // Draw the row.
                for (int col = 0; col < 11; col++)
                {
                    // Get the points for the row's next hexagon.
                    points = HexToPoints (height, row, col);

                    // Draw it.
                    gr.DrawPolygon (pen, points);
                }// end for col
            }// end for row
        }//end DrawHexGrid (Graphics, Pen, float)

        private PointF[ ] HexToPoints (double width, float row, float col)
        {
            double height = hexHeight;
            float side = (float)height / 2.0F;
            float halfSide = side / 2.0F;
            float halfWidth = (float)width / 2.0F;
            float x = halfWidth;
            float y = 0;

            // move to hex row
            x += (float)(row * width);

            // start at top of hex
            y += col * (side + halfSide);

            // adjust for odd columns
            if (col % 2 == 1)
            {
                x += halfWidth;
            }// end if

            return new PointF[ ]
                {
                    new PointF(x, y),                                     // 1
                    new PointF(x + halfWidth, y + halfSide),              // 2
                    new PointF(x + halfWidth, y + side + halfSide),       // 3
                    new PointF(x, y + (float)height),                     // 4
                    new PointF(x - halfWidth, y + side + halfSide),       // 5
                    new PointF(x - halfWidth, y + halfSide),              // 6
                };
        }// end HexToPoints

        private double HexHeight (double width)
        {
            return (width * 2.0 / 3.0 * Math.Sqrt (3));
        }
                
        private void hexGrid_Paint (object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw the selected hexagons.
            foreach (PointF point in SelectedHexagons)
            {
                e.Graphics.FillPolygon (Brushes.Yellow,
                    HexToPoints (HEX_WIDTH, point.X, point.Y));
            }// end foreach
            
            // Draw the grid.
            DrawHexGrid (e.Graphics, Pens.Black, (float)HEX_WIDTH);

            // Draw axes
            e.Graphics.DrawLine (Pens.Black, new Point (0, (int)(hexHeight * 4.25)), new Point (hexGrid.Width, (int)(hexHeight * 4.25)));
            e.Graphics.DrawLine (Pens.Black, new Point ((int)(HEX_WIDTH * 6.0), 0), new Point ((int)(HEX_WIDTH * 6.0), hexGrid.Height));
            e.Graphics.DrawLine (Pens.Red, new Point (0, 72), new Point (650, 448));
            e.Graphics.DrawLine (Pens.Blue, new Point (0, 419), new Point (650, 43));

        }// end hexGrid_Paint

        #region Sort-of working

        private void hexGrid_MouseClick (object sender, MouseEventArgs e)
        {
            PointF test = new PointF( );
            int x;

            try
            {
                //x = ((int)(Math.Ceiling((e.Y / hexHeight))) % 2 == 1) ? e.X - 25 : e.X;
                test = PointToHex (e.X, e.Y, HEX_WIDTH);
            } catch (IndexOutOfRangeException)
            {
                return;
            }

            Hex3 cell = new Hex3 (test);

            if (SelectedHexagons.Contains (test))
            {
                SelectedHexagons.Remove (test);
                Nest.Remove (Nest.Find (c => c.x == cell.x && c.y == cell.y && c.z == cell.z));
            }
            else
            {
                SelectedHexagons.Add (test);
                Nest.Add (cell);
            }

            hexGrid.Refresh ( );
        }// end hexGrid_MouseClick

        // cast floats as ints to lazy-truncate to hexagon row / col
        private PointF PointToHex (float x, float y, double width)
        {
            double height = hexHeight;
            double side = height / 2.0;
            

            // account for "nesting" of hexagons on graph - lose 25% of height - 1.5F, not 2.0F
            height = side * 1.5F;
            float col = (int)(y / height);

            // adjust for odd-numbered rows being further right on the grid
            float row = (int)(x / width);

            if (row > 10 || col > 10)
                throw new IndexOutOfRangeException("Mouse click out of range");
            else
                return new PointF (row, col);
        }// end PointToHex

        private double calcHCS (List<Hex3> nest)
        {
            double x = 0;
            double y = 0;
            double z = 0;

            double hX = 0;
            double hY = 0;
            double hZ = 0;

            double cOMX = 0;
            double cOMY = 0;
            double cOMZ = 0;

            double total = 0;
            double totalSR = 0;

            foreach (Hex3 cell in nest)
            {
                cOMX += cell.x;
                cOMY += cell.y;
                cOMZ += cell.z;
            }

            cOMX /= nest.Count;
            cOMY /= nest.Count;
            cOMZ /= nest.Count;

            foreach (Hex3 cell in nest)
            {
                x = (cell.x - cOMX) * (cell.x - cOMX);
                y = (cell.y - cOMY) * (cell.y - cOMY);
                z = (cell.z - cOMZ) * (cell.z - cOMZ);

                hX += x;
                hY += y;
                hZ += z;

                total += x + y + z;
                totalSR += Math.Sqrt (x + y + z);
            }

            CoMXTextBox.Text = cOMX.ToString ( );
            CoMYTextBox.Text = cOMY.ToString ( );
            CoMZTextBox.Text = cOMZ.ToString ( );


            HCSXTextBox.Text = hX.ToString ( );
            HCSYTextBox.Text = hY.ToString ( );
            HCSZTextBox.Text = hZ.ToString ( );
            HCSTotalTextBox.Text = total.ToString ( );
            HCSRootTextBox.Text = totalSR.ToString ( );

            return totalSR;
        }

        private double calcRCS (List<Hex3> nest)
        {
            double _x = 0;
            double _y = 0;

            double cX = 0;
            double cY = 0;

            double cOMcX = 0;
            double cOMcY = 0;

            double cTotal = 0;
            double cTotalSR = 0;

            foreach (Hex3 cell in nest)
            {
                cOMcX += cell.row;
                cOMcY += cell.col;
            }

            cOMcX /= nest.Count;
            cOMcY /= nest.Count;

            foreach (Hex3 cell in nest)
            {
                _x = (cell.row - cOMcX) * (cell.row - cOMcX);
                _y = (cell.col - cOMcY) * (cell.col - cOMcY);

                cX += _x;
                cY += _y;

                cTotal += _x + _y;
                cTotalSR += Math.Sqrt (_x + _y);
            }

            CoMXCartTextBox.Text = cOMcX.ToString ( );
            CoMYCartTextBox.Text = cOMcY.ToString ( );

            CartXTextBox.Text = cX.ToString ( );
            CartYTextBox.Text = cY.ToString ( );
            CartTotalTextBox.Text = cTotal.ToString ( );
            CartRootTextBox.Text = cTotalSR.ToString ( );

            return cTotalSR;
        }

        private void calcIHCS (List<Hex3> nest)
        {
            long x = 0;
            long y = 0;
            long z = 0;

            long sumx = 0;
            long sumy = 0;
            long sumz = 0;

            long comx = 0;
            long comy = 0;
            long comz = 0;

            long nestSize = nest.Count;
            double squaredNest = nest.Count * nest.Count;

            long total = 0;

            double validateTotal = 0.0;
            double validateTotalSR = 0.0;

            foreach (Hex3 cell in nest)
            {
                comx += cell.x;
                comy += cell.y;
                comz += cell.z;
            }

            foreach (Hex3 cell in nest)
            {
                x = (cell.x * nestSize - comx) * (cell.x * nestSize - comx);
                y = (cell.y * nestSize - comy) * (cell.y * nestSize - comy);
                z = (cell.z * nestSize - comz) * (cell.z * nestSize - comz);

                sumx += x;
                sumy += y;
                sumz += z;

                total += x + y + z;

                validateTotal += (x / squaredNest) + (y / squaredNest) + (z / squaredNest);
                validateTotalSR += Math.Sqrt ((x / squaredNest) + (y / squaredNest) + (z / squaredNest));
            }

            IHCSCoMXBox.Text = comx.ToString ( );
            IHCSCoMYBox.Text = comy.ToString ( );
            IHCSCoMZBox.Text = comz.ToString ( );

            IHCSXBox.Text = sumx.ToString ( );
            IHCSYBox.Text = sumy.ToString ( );
            IHCSZBox.Text = sumz.ToString ( );

            IHCSIntTotalBox.Text = total.ToString ( );
            validateIHCSTotalBox.Text = validateTotal.ToString ( );
            validateIHCSRootBox.Text = validateTotalSR.ToString ( );
        }
        private void CalcButton_Click (object sender, EventArgs e)
        {
            double hcsRoot = calcHCS (Nest);
            double rcsRoot = calcRCS (Nest);
            calcIHCS (Nest);

            RatioTextBox.Text = (hcsRoot / rcsRoot).ToString ( );
            numberOfCellsBox.Text = Nest.Count.ToString ( );
        }

        private void ResetButton_Click (object sender, EventArgs e)
        {
            Nest = new List<Hex3> ( );
            SelectedHexagons = new List<PointF> ( );

            CoMXTextBox.Text = string.Empty;
            CoMYTextBox.Text = string.Empty;
            CoMZTextBox.Text = string.Empty;

            CoMXCartTextBox.Text = string.Empty;
            CoMYCartTextBox.Text = string.Empty;

            HCSXTextBox.Text = string.Empty;
            HCSYTextBox.Text = string.Empty;
            HCSZTextBox.Text = string.Empty;
            HCSTotalTextBox.Text = string.Empty;
            HCSRootTextBox.Text = string.Empty;

            CartXTextBox.Text = string.Empty;
            CartYTextBox.Text = string.Empty;
            CartTotalTextBox.Text = string.Empty;
            CartRootTextBox.Text = string.Empty;

            RatioTextBox.Text = string.Empty;
            numberOfCellsBox.Text = string.Empty;

            IHCSCoMXBox.Text = string.Empty;
            IHCSCoMYBox.Text = string.Empty;
            IHCSCoMZBox.Text = string.Empty;

            IHCSXBox.Text = string.Empty;
            IHCSYBox.Text = string.Empty;
            IHCSZBox.Text = string.Empty;

            IHCSIntTotalBox.Text = string.Empty;
            validateIHCSTotalBox.Text = string.Empty;
            validateIHCSRootBox.Text = string.Empty;

            NextButton.Enabled = false;
            PrevButton.Enabled = false;

            hexGrid.Refresh ( );
        }

        private void GetCSVPathButton_Click (object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog ( );
            dialog.ShowDialog ( );
            StreamReader reader = new StreamReader (dialog.FileName);

            FileNests = new List<List<Hex3>> ( );
            fileCount = 0;

            string line;
            string[ ] coords = new string[3];
            int [ ] coordinates = new int[3];

            int size = 0;
            
            while ((line = reader.ReadLine ( )) != null)
            {
                if (line.Length == 1)
                {
                    size = int.Parse (line.Substring(0,1));
                    reader.ReadLine ( );
                }

                FileNests.Add (new List<Hex3> ( ));

                for (int i = 0; i < size; i++)
                {
                    line = reader.ReadLine ( );
                    coords = line.Split (',');
                    // coords[2] = coords[2].TrimEnd ( );

                    for (int j = 0; j < coords.Length; j++)
                    {
                        coordinates[j] = int.Parse (coords[j]);
                    }

                    FileNests[fileCount].Add (new Hex3 (coordinates[0], coordinates[1], coordinates[2]));
                }
                fileCount++;
            }

            reader.Close ( );
            NextButton.Enabled = true;
            PrevButton.Enabled = true;

            fileCount = 0;

            double hcsRoot = calcHCS (FileNests[fileCount]);
            double rcsRoot = calcRCS (FileNests[fileCount]);
            calcIHCS (FileNests[fileCount]);

            RatioTextBox.Text = (hcsRoot / rcsRoot).ToString ( );
            numberOfCellsBox.Text = FileNests[fileCount].Count.ToString ( );

            SelectedHexagons = new List<PointF> ( );

            float row;
            float col;

            foreach (Hex3 hex in FileNests[fileCount])
            {
                row = 0.0F;
                col = 0.0F;

                if ((hex.x + hex.y) % 2 != 0)
                    row = 0.5F;
                row += ((hex.x + hex.y) / 2.0F) + 5;
                col = 5 - hex.z;

                SelectedHexagons.Add (new PointF (row, col));
            }

            hexGrid.Refresh ( );
        }

        private void NextButton_Click (object sender, EventArgs e)
        {
            if (++fileCount >= FileNests.Count)
                fileCount = 0;

            double hcsRoot = calcHCS (FileNests[fileCount]);
            double rcsRoot = calcRCS (FileNests[fileCount]);
            calcIHCS (FileNests[fileCount]);

            RatioTextBox.Text = (hcsRoot / rcsRoot).ToString ( );
            numberOfCellsBox.Text = FileNests[fileCount].Count.ToString ( );

            SelectedHexagons = new List<PointF> ( );

            float row = 0.0F;
            float col;

            foreach (Hex3 hex in FileNests[fileCount])
            {
                row = 0.0F;
                col = 0.0F;

                if ((hex.x + hex.y) % 2 != 0)
                    row = 0.5F;
                row += ((hex.x + hex.y) / 2.0F) + 5;
                col = 5 - hex.z;

                SelectedHexagons.Add (new PointF (row, col));
            }

            hexGrid.Refresh ( );
        }

        private void PrevButton_Click (object sender, EventArgs e)
        {
            if (--fileCount < 0)
                fileCount = FileNests.Count - 1;

            double hcsRoot = calcHCS (FileNests[fileCount]);
            double rcsRoot = calcRCS (FileNests[fileCount]);
            calcIHCS (FileNests[fileCount]);

            RatioTextBox.Text = (hcsRoot / rcsRoot).ToString ( );
            numberOfCellsBox.Text = FileNests[fileCount].Count.ToString ( );

            SelectedHexagons = new List<PointF> ( );

            float row = 0.0F;
            float col;

            foreach (Hex3 hex in FileNests[fileCount])
            {
                row = 0.0F;
                col = 0.0F;

                if ((hex.x + hex.y) % 2 != 0)
                    row = 0.5F;
                row += ((hex.x + hex.y) / 2.0F) + 5;
                col = 5 - hex.z;

                SelectedHexagons.Add (new PointF (row, col));
            }

            hexGrid.Refresh ( );
        }

        #endregion

        #region Hex Tutorial

        /*

        // Return the points that define the indicated hexagon.
        private PointF[ ] HexToPoints (float height, float row, float col)
        {
            // Start with the leftmost corner of the upper left hexagon.
            float width = HexWidth (height);
            float y = height / 2;
            float x = 0;

            // Move down the required number of rows.
            y += row * height;

            // If the column is odd, move down half a hex more.
            if (col % 2 == 1) y += height / 2;

            // Move over for the column number.
            x += col * (width * 0.75f);

            // Generate the points.
            return new PointF[ ]
                {
                    new PointF(x, y),
                    new PointF(x + width * 0.25f, y - height / 2),
                    new PointF(x + width * 0.75f, y - height / 2),
                    new PointF(x + width, y),
                    new PointF(x + width * 0.75f, y + height / 2),
                    new PointF(x + width * 0.25f, y + height / 2),
                };
        }

        // Return the width of a hexagon.
        private float HexWidth (float height)
        {
            return (float)(4 * (height / 2 / Math.Sqrt (3)));
        }

        // Draw a hexagonal grid for the indicated area.
        // (You might be able to draw the hexagons without
        // drawing any duplicate edges, but this is a lot easier.)
        private void DrawHexGrid (Graphics gr, Pen pen,
            float xmin, float xmax, float ymin, float ymax,
            float height)
        {
            // Loop until a hexagon won't fit.
            for (int row = 0; ; row++)
            {
                // Get the points for the row's first hexagon.
                PointF[ ] points = HexToPoints (height, row, 0);

                // If it doesn't fit, we're done.
                if (points[4].Y > ymax) break;

                // Draw the row.
                for (int col = 0; ; col++)
                {
                    // Get the points for the row's next hexagon.
                    points = HexToPoints (height, row, col);

                    // If it doesn't fit horizontally,
                    // we're done with this row.
                    if (points[3].X > xmax) break;

                    // If it fits vertically, draw it.
                    if (points[4].Y >= ymax)
                    {
                        gr.DrawPolygon (pen, points);
                    }
                }
            }
        }

        // Redraw the grid.
        private void picGrid_Paint (object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw the selected hexagons.
            foreach (PointF point in Hexagons)
            {
                e.Graphics.FillPolygon (Brushes.LightBlue,
                    HexToPoints (HexHeight, point.X, point.Y));
            }

            // Draw the grid.
            DrawHexGrid (e.Graphics, Pens.Black,
                0, picGrid.ClientSize.Width,
                0, picGrid.ClientSize.Height,
                HexHeight);
        }

        // Return the row and column of the hexagon at this point.
        private void PointToHex (float x, float y, float height,
            out int row, out int col)
        {
            // Find the test rectangle containing the point.
            float width = HexWidth (height);
            col = (int)(x / (width * 0.75f));

            if (col % 2 == 0)
                row = (int)(y / height);
            else
                row = (int)((y - height / 2) / height);

            // Find the test area.
            float testx = col * width * 0.75f;
            float testy = row * height;
            if (col % 2 == 1) testy += height / 2;

            // See if the point is above or
            // below the test hexagon on the left.
            bool is_above = false, is_below = false;
            float dx = x - testx;
            if (dx < width / 4)
            {
                float dy = y - (testy + height / 2);
                if (dx < 0.001)
                {
                    // The point is on the left edge of the test rectangle.
                    if (dy < 0) is_above = true;
                    if (dy > 0) is_below = true;
                }
                else if (dy < 0)
                {
                    // See if the point is above the test hexagon.
                    if (-dy / dx > Math.Sqrt (3)) is_above = true;
                }
                else
                {
                    // See if the point is below the test hexagon.
                    if (dy / dx > Math.Sqrt (3)) is_below = true;
                }
            }

            // Adjust the row and column if necessary.
            if (is_above)
            {
                if (col % 2 == 0) row--;
                col--;
            }
            else if (is_below)
            {
                if (col % 2 == 1) row++;
                col--;
            }
        }

        // Display the row and column under the mouse.
        private void picGrid_MouseMove (object sender, MouseEventArgs e)
        {
            int row, col;
            PointToHex (e.X, e.Y, HexHeight, out row, out col);
            this.Text = "(" + row + ", " + col + ")";
        }

        // Add the clicked hexagon to the Hexagons list.
        private void picGrid_MouseClick (object sender, MouseEventArgs e)
        {
            int row, col;
            PointToHex (e.X, e.Y, HexHeight, out row, out col);
            Hexagons.Add (new PointF (row, col));

            picGrid.Refresh ( );
        }
        */
        #endregion


    }
}
