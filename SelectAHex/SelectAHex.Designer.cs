namespace SelectAHex
{
    partial class SelectAHex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ( );
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.hexGrid = new System.Windows.Forms.PictureBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.HCSLabel = new System.Windows.Forms.Label();
            this.CartesianLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.ZLabel = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.SRLabel = new System.Windows.Forms.Label();
            this.HCSXTextBox = new System.Windows.Forms.TextBox();
            this.HCSYTextBox = new System.Windows.Forms.TextBox();
            this.HCSZTextBox = new System.Windows.Forms.TextBox();
            this.HCSTotalTextBox = new System.Windows.Forms.TextBox();
            this.HCSRootTextBox = new System.Windows.Forms.TextBox();
            this.CartXTextBox = new System.Windows.Forms.TextBox();
            this.CartYTextBox = new System.Windows.Forms.TextBox();
            this.CartTotalTextBox = new System.Windows.Forms.TextBox();
            this.CartRootTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CenterOfMassHCSLabel = new System.Windows.Forms.Label();
            this.CoMXLabel = new System.Windows.Forms.Label();
            this.CoMYLabel = new System.Windows.Forms.Label();
            this.CoMZLabel = new System.Windows.Forms.Label();
            this.CoMXTextBox = new System.Windows.Forms.TextBox();
            this.CoMYTextBox = new System.Windows.Forms.TextBox();
            this.CoMZTextBox = new System.Windows.Forms.TextBox();
            this.CoMCartLabel = new System.Windows.Forms.Label();
            this.CoMXCartTextBox = new System.Windows.Forms.TextBox();
            this.CoMYCartTextBox = new System.Windows.Forms.TextBox();
            this.ratioLabel = new System.Windows.Forms.Label();
            this.RatioTextBox = new System.Windows.Forms.TextBox();
            this.IHCSCoMXBox = new System.Windows.Forms.TextBox();
            this.IHCSCoMLabel = new System.Windows.Forms.Label();
            this.IHCSCoMYBox = new System.Windows.Forms.TextBox();
            this.IHCSCoMZBox = new System.Windows.Forms.TextBox();
            this.IHCSZLabel = new System.Windows.Forms.Label();
            this.IHCSYLabel = new System.Windows.Forms.Label();
            this.IHCSXLabel = new System.Windows.Forms.Label();
            this.IHCSLabel = new System.Windows.Forms.Label();
            this.IHCSXBox = new System.Windows.Forms.TextBox();
            this.IHCSYBox = new System.Windows.Forms.TextBox();
            this.IHCSZBox = new System.Windows.Forms.TextBox();
            this.validateRootLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IHCSZ = new System.Windows.Forms.Label();
            this.IHCSY = new System.Windows.Forms.Label();
            this.IHCSX = new System.Windows.Forms.Label();
            this.ValidationLabel = new System.Windows.Forms.Label();
            this.validateHCSTotalLabel = new System.Windows.Forms.Label();
            this.IHCSIntTotalBox = new System.Windows.Forms.TextBox();
            this.validateIHCSTotalBox = new System.Windows.Forms.TextBox();
            this.validateIHCSRootBox = new System.Windows.Forms.TextBox();
            this.NumberOfCellsLabel = new System.Windows.Forms.Label();
            this.numberOfCellsBox = new System.Windows.Forms.TextBox();
            this.GetCSVPathButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hexGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // hexGrid
            // 
            this.hexGrid.BackColor = System.Drawing.Color.White;
            this.hexGrid.Location = new System.Drawing.Point(12, 12);
            this.hexGrid.Name = "hexGrid";
            this.hexGrid.Size = new System.Drawing.Size(585, 500);
            this.hexGrid.TabIndex = 0;
            this.hexGrid.TabStop = false;
            this.hexGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.hexGrid_Paint);
            this.hexGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hexGrid_MouseClick);
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(687, 419);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(99, 23);
            this.CalcButton.TabIndex = 1;
            this.CalcButton.Text = "Calculate!";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // HCSLabel
            // 
            this.HCSLabel.AutoSize = true;
            this.HCSLabel.Location = new System.Drawing.Point(640, 126);
            this.HCSLabel.Name = "HCSLabel";
            this.HCSLabel.Size = new System.Drawing.Size(29, 13);
            this.HCSLabel.TabIndex = 2;
            this.HCSLabel.Text = "HCS";
            // 
            // CartesianLabel
            // 
            this.CartesianLabel.AutoSize = true;
            this.CartesianLabel.Location = new System.Drawing.Point(792, 126);
            this.CartesianLabel.Name = "CartesianLabel";
            this.CartesianLabel.Size = new System.Drawing.Size(29, 13);
            this.CartesianLabel.TabIndex = 3;
            this.CartesianLabel.Text = "RCS";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(722, 149);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(14, 13);
            this.XLabel.TabIndex = 64;
            this.XLabel.Text = "X";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(722, 188);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(14, 13);
            this.YLabel.TabIndex = 65;
            this.YLabel.Text = "Y";
            // 
            // ZLabel
            // 
            this.ZLabel.AutoSize = true;
            this.ZLabel.Location = new System.Drawing.Point(722, 225);
            this.ZLabel.Name = "ZLabel";
            this.ZLabel.Size = new System.Drawing.Size(14, 13);
            this.ZLabel.TabIndex = 66;
            this.ZLabel.Text = "Z";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(713, 269);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 7;
            this.Total.Text = "Total";
            // 
            // SRLabel
            // 
            this.SRLabel.AutoSize = true;
            this.SRLabel.Location = new System.Drawing.Point(715, 307);
            this.SRLabel.Name = "SRLabel";
            this.SRLabel.Size = new System.Drawing.Size(30, 13);
            this.SRLabel.TabIndex = 8;
            this.SRLabel.Text = "Root";
            // 
            // HCSXTextBox
            // 
            this.HCSXTextBox.Location = new System.Drawing.Point(608, 146);
            this.HCSXTextBox.Name = "HCSXTextBox";
            this.HCSXTextBox.Size = new System.Drawing.Size(99, 20);
            this.HCSXTextBox.TabIndex = 9;
            // 
            // HCSYTextBox
            // 
            this.HCSYTextBox.Location = new System.Drawing.Point(608, 185);
            this.HCSYTextBox.Name = "HCSYTextBox";
            this.HCSYTextBox.Size = new System.Drawing.Size(99, 20);
            this.HCSYTextBox.TabIndex = 10;
            // 
            // HCSZTextBox
            // 
            this.HCSZTextBox.Location = new System.Drawing.Point(608, 222);
            this.HCSZTextBox.Name = "HCSZTextBox";
            this.HCSZTextBox.Size = new System.Drawing.Size(99, 20);
            this.HCSZTextBox.TabIndex = 11;
            // 
            // HCSTotalTextBox
            // 
            this.HCSTotalTextBox.Location = new System.Drawing.Point(608, 266);
            this.HCSTotalTextBox.Name = "HCSTotalTextBox";
            this.HCSTotalTextBox.Size = new System.Drawing.Size(99, 20);
            this.HCSTotalTextBox.TabIndex = 12;
            // 
            // HCSRootTextBox
            // 
            this.HCSRootTextBox.Location = new System.Drawing.Point(608, 304);
            this.HCSRootTextBox.Name = "HCSRootTextBox";
            this.HCSRootTextBox.Size = new System.Drawing.Size(99, 20);
            this.HCSRootTextBox.TabIndex = 13;
            // 
            // CartXTextBox
            // 
            this.CartXTextBox.Location = new System.Drawing.Point(758, 146);
            this.CartXTextBox.Name = "CartXTextBox";
            this.CartXTextBox.Size = new System.Drawing.Size(101, 20);
            this.CartXTextBox.TabIndex = 14;
            // 
            // CartYTextBox
            // 
            this.CartYTextBox.Location = new System.Drawing.Point(758, 185);
            this.CartYTextBox.Name = "CartYTextBox";
            this.CartYTextBox.Size = new System.Drawing.Size(101, 20);
            this.CartYTextBox.TabIndex = 15;
            // 
            // CartTotalTextBox
            // 
            this.CartTotalTextBox.Location = new System.Drawing.Point(758, 266);
            this.CartTotalTextBox.Name = "CartTotalTextBox";
            this.CartTotalTextBox.Size = new System.Drawing.Size(101, 20);
            this.CartTotalTextBox.TabIndex = 16;
            // 
            // CartRootTextBox
            // 
            this.CartRootTextBox.Location = new System.Drawing.Point(758, 304);
            this.CartRootTextBox.Name = "CartRootTextBox";
            this.CartRootTextBox.Size = new System.Drawing.Size(101, 20);
            this.CartRootTextBox.TabIndex = 17;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(868, 419);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(102, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CenterOfMassHCSLabel
            // 
            this.CenterOfMassHCSLabel.AutoSize = true;
            this.CenterOfMassHCSLabel.Location = new System.Drawing.Point(605, 9);
            this.CenterOfMassHCSLabel.Name = "CenterOfMassHCSLabel";
            this.CenterOfMassHCSLabel.Size = new System.Drawing.Size(105, 13);
            this.CenterOfMassHCSLabel.TabIndex = 19;
            this.CenterOfMassHCSLabel.Text = "Center Of Mass HCS";
            // 
            // CoMXLabel
            // 
            this.CoMXLabel.AutoSize = true;
            this.CoMXLabel.Location = new System.Drawing.Point(722, 35);
            this.CoMXLabel.Name = "CoMXLabel";
            this.CoMXLabel.Size = new System.Drawing.Size(14, 13);
            this.CoMXLabel.TabIndex = 20;
            this.CoMXLabel.Text = "X";
            // 
            // CoMYLabel
            // 
            this.CoMYLabel.AutoSize = true;
            this.CoMYLabel.Location = new System.Drawing.Point(722, 61);
            this.CoMYLabel.Name = "CoMYLabel";
            this.CoMYLabel.Size = new System.Drawing.Size(14, 13);
            this.CoMYLabel.TabIndex = 21;
            this.CoMYLabel.Text = "Y";
            // 
            // CoMZLabel
            // 
            this.CoMZLabel.AutoSize = true;
            this.CoMZLabel.Location = new System.Drawing.Point(722, 87);
            this.CoMZLabel.Name = "CoMZLabel";
            this.CoMZLabel.Size = new System.Drawing.Size(14, 13);
            this.CoMZLabel.TabIndex = 22;
            this.CoMZLabel.Text = "Z";
            // 
            // CoMXTextBox
            // 
            this.CoMXTextBox.Location = new System.Drawing.Point(608, 32);
            this.CoMXTextBox.Name = "CoMXTextBox";
            this.CoMXTextBox.Size = new System.Drawing.Size(99, 20);
            this.CoMXTextBox.TabIndex = 23;
            // 
            // CoMYTextBox
            // 
            this.CoMYTextBox.Location = new System.Drawing.Point(608, 58);
            this.CoMYTextBox.Name = "CoMYTextBox";
            this.CoMYTextBox.Size = new System.Drawing.Size(99, 20);
            this.CoMYTextBox.TabIndex = 24;
            // 
            // CoMZTextBox
            // 
            this.CoMZTextBox.Location = new System.Drawing.Point(608, 84);
            this.CoMZTextBox.Name = "CoMZTextBox";
            this.CoMZTextBox.Size = new System.Drawing.Size(99, 20);
            this.CoMZTextBox.TabIndex = 25;
            // 
            // CoMCartLabel
            // 
            this.CoMCartLabel.AutoSize = true;
            this.CoMCartLabel.Location = new System.Drawing.Point(755, 9);
            this.CoMCartLabel.Name = "CoMCartLabel";
            this.CoMCartLabel.Size = new System.Drawing.Size(105, 13);
            this.CoMCartLabel.TabIndex = 26;
            this.CoMCartLabel.Text = "Center Of Mass RCS";
            // 
            // CoMXCartTextBox
            // 
            this.CoMXCartTextBox.Location = new System.Drawing.Point(758, 32);
            this.CoMXCartTextBox.Name = "CoMXCartTextBox";
            this.CoMXCartTextBox.Size = new System.Drawing.Size(101, 20);
            this.CoMXCartTextBox.TabIndex = 29;
            // 
            // CoMYCartTextBox
            // 
            this.CoMYCartTextBox.Location = new System.Drawing.Point(758, 58);
            this.CoMYCartTextBox.Name = "CoMYCartTextBox";
            this.CoMYCartTextBox.Size = new System.Drawing.Size(101, 20);
            this.CoMYCartTextBox.TabIndex = 30;
            // 
            // ratioLabel
            // 
            this.ratioLabel.AutoSize = true;
            this.ratioLabel.Location = new System.Drawing.Point(605, 349);
            this.ratioLabel.Name = "ratioLabel";
            this.ratioLabel.Size = new System.Drawing.Size(60, 13);
            this.ratioLabel.TabIndex = 31;
            this.ratioLabel.Text = "HCS : RCS";
            // 
            // RatioTextBox
            // 
            this.RatioTextBox.Location = new System.Drawing.Point(687, 346);
            this.RatioTextBox.Name = "RatioTextBox";
            this.RatioTextBox.Size = new System.Drawing.Size(101, 20);
            this.RatioTextBox.TabIndex = 32;
            // 
            // IHCSCoMXBox
            // 
            this.IHCSCoMXBox.Location = new System.Drawing.Point(922, 32);
            this.IHCSCoMXBox.Name = "IHCSCoMXBox";
            this.IHCSCoMXBox.Size = new System.Drawing.Size(101, 20);
            this.IHCSCoMXBox.TabIndex = 33;
            // 
            // IHCSCoMLabel
            // 
            this.IHCSCoMLabel.AutoSize = true;
            this.IHCSCoMLabel.Location = new System.Drawing.Point(883, 9);
            this.IHCSCoMLabel.Name = "IHCSCoMLabel";
            this.IHCSCoMLabel.Size = new System.Drawing.Size(139, 13);
            this.IHCSCoMLabel.TabIndex = 34;
            this.IHCSCoMLabel.Text = "Center of Mass Integer HCS";
            // 
            // IHCSCoMYBox
            // 
            this.IHCSCoMYBox.Location = new System.Drawing.Point(922, 58);
            this.IHCSCoMYBox.Name = "IHCSCoMYBox";
            this.IHCSCoMYBox.Size = new System.Drawing.Size(101, 20);
            this.IHCSCoMYBox.TabIndex = 35;
            // 
            // IHCSCoMZBox
            // 
            this.IHCSCoMZBox.Location = new System.Drawing.Point(922, 84);
            this.IHCSCoMZBox.Name = "IHCSCoMZBox";
            this.IHCSCoMZBox.Size = new System.Drawing.Size(101, 20);
            this.IHCSCoMZBox.TabIndex = 36;
            // 
            // IHCSZLabel
            // 
            this.IHCSZLabel.AutoSize = true;
            this.IHCSZLabel.Location = new System.Drawing.Point(883, 87);
            this.IHCSZLabel.Name = "IHCSZLabel";
            this.IHCSZLabel.Size = new System.Drawing.Size(14, 13);
            this.IHCSZLabel.TabIndex = 39;
            this.IHCSZLabel.Text = "Z";
            // 
            // IHCSYLabel
            // 
            this.IHCSYLabel.AutoSize = true;
            this.IHCSYLabel.Location = new System.Drawing.Point(883, 61);
            this.IHCSYLabel.Name = "IHCSYLabel";
            this.IHCSYLabel.Size = new System.Drawing.Size(14, 13);
            this.IHCSYLabel.TabIndex = 38;
            this.IHCSYLabel.Text = "Y";
            // 
            // IHCSXLabel
            // 
            this.IHCSXLabel.AutoSize = true;
            this.IHCSXLabel.Location = new System.Drawing.Point(883, 35);
            this.IHCSXLabel.Name = "IHCSXLabel";
            this.IHCSXLabel.Size = new System.Drawing.Size(14, 13);
            this.IHCSXLabel.TabIndex = 37;
            this.IHCSXLabel.Text = "X";
            // 
            // IHCSLabel
            // 
            this.IHCSLabel.AutoSize = true;
            this.IHCSLabel.Location = new System.Drawing.Point(937, 126);
            this.IHCSLabel.Name = "IHCSLabel";
            this.IHCSLabel.Size = new System.Drawing.Size(65, 13);
            this.IHCSLabel.TabIndex = 40;
            this.IHCSLabel.Text = "Integer HCS";
            // 
            // IHCSXBox
            // 
            this.IHCSXBox.Location = new System.Drawing.Point(922, 146);
            this.IHCSXBox.Name = "IHCSXBox";
            this.IHCSXBox.Size = new System.Drawing.Size(101, 20);
            this.IHCSXBox.TabIndex = 41;
            // 
            // IHCSYBox
            // 
            this.IHCSYBox.Location = new System.Drawing.Point(922, 185);
            this.IHCSYBox.Name = "IHCSYBox";
            this.IHCSYBox.Size = new System.Drawing.Size(101, 20);
            this.IHCSYBox.TabIndex = 42;
            // 
            // IHCSZBox
            // 
            this.IHCSZBox.Location = new System.Drawing.Point(922, 222);
            this.IHCSZBox.Name = "IHCSZBox";
            this.IHCSZBox.Size = new System.Drawing.Size(101, 20);
            this.IHCSZBox.TabIndex = 43;
            // 
            // validateRootLabel
            // 
            this.validateRootLabel.AutoSize = true;
            this.validateRootLabel.Location = new System.Drawing.Point(799, 382);
            this.validateRootLabel.Name = "validateRootLabel";
            this.validateRootLabel.Size = new System.Drawing.Size(112, 13);
            this.validateRootLabel.TabIndex = 48;
            this.validateRootLabel.Text = "Compare to HCS Root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(865, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Int Total";
            // 
            // IHCSZ
            // 
            this.IHCSZ.AutoSize = true;
            this.IHCSZ.Location = new System.Drawing.Point(883, 225);
            this.IHCSZ.Name = "IHCSZ";
            this.IHCSZ.Size = new System.Drawing.Size(14, 13);
            this.IHCSZ.TabIndex = 46;
            this.IHCSZ.Text = "Z";
            // 
            // IHCSY
            // 
            this.IHCSY.AutoSize = true;
            this.IHCSY.Location = new System.Drawing.Point(883, 188);
            this.IHCSY.Name = "IHCSY";
            this.IHCSY.Size = new System.Drawing.Size(14, 13);
            this.IHCSY.TabIndex = 45;
            this.IHCSY.Text = "Y";
            // 
            // IHCSX
            // 
            this.IHCSX.AutoSize = true;
            this.IHCSX.Location = new System.Drawing.Point(883, 149);
            this.IHCSX.Name = "IHCSX";
            this.IHCSX.Size = new System.Drawing.Size(14, 13);
            this.IHCSX.TabIndex = 44;
            this.IHCSX.Text = "X";
            // 
            // ValidationLabel
            // 
            this.ValidationLabel.AutoSize = true;
            this.ValidationLabel.Location = new System.Drawing.Point(949, 330);
            this.ValidationLabel.Name = "ValidationLabel";
            this.ValidationLabel.Size = new System.Drawing.Size(53, 13);
            this.ValidationLabel.TabIndex = 49;
            this.ValidationLabel.Text = "Validation";
            // 
            // validateHCSTotalLabel
            // 
            this.validateHCSTotalLabel.AutoSize = true;
            this.validateHCSTotalLabel.Location = new System.Drawing.Point(798, 349);
            this.validateHCSTotalLabel.Name = "validateHCSTotalLabel";
            this.validateHCSTotalLabel.Size = new System.Drawing.Size(113, 13);
            this.validateHCSTotalLabel.TabIndex = 50;
            this.validateHCSTotalLabel.Text = "Compare to HCS Total";
            // 
            // IHCSIntTotalBox
            // 
            this.IHCSIntTotalBox.Location = new System.Drawing.Point(922, 266);
            this.IHCSIntTotalBox.Name = "IHCSIntTotalBox";
            this.IHCSIntTotalBox.Size = new System.Drawing.Size(101, 20);
            this.IHCSIntTotalBox.TabIndex = 51;
            // 
            // validateIHCSTotalBox
            // 
            this.validateIHCSTotalBox.Location = new System.Drawing.Point(922, 346);
            this.validateIHCSTotalBox.Name = "validateIHCSTotalBox";
            this.validateIHCSTotalBox.Size = new System.Drawing.Size(101, 20);
            this.validateIHCSTotalBox.TabIndex = 52;
            // 
            // validateIHCSRootBox
            // 
            this.validateIHCSRootBox.Location = new System.Drawing.Point(922, 379);
            this.validateIHCSRootBox.Name = "validateIHCSRootBox";
            this.validateIHCSRootBox.Size = new System.Drawing.Size(101, 20);
            this.validateIHCSRootBox.TabIndex = 53;
            // 
            // NumberOfCellsLabel
            // 
            this.NumberOfCellsLabel.AutoSize = true;
            this.NumberOfCellsLabel.Location = new System.Drawing.Point(605, 382);
            this.NumberOfCellsLabel.Name = "NumberOfCellsLabel";
            this.NumberOfCellsLabel.Size = new System.Drawing.Size(81, 13);
            this.NumberOfCellsLabel.TabIndex = 54;
            this.NumberOfCellsLabel.Text = "Number of Cells";
            // 
            // numberOfCellsBox
            // 
            this.numberOfCellsBox.Location = new System.Drawing.Point(687, 379);
            this.numberOfCellsBox.Name = "numberOfCellsBox";
            this.numberOfCellsBox.Size = new System.Drawing.Size(101, 20);
            this.numberOfCellsBox.TabIndex = 55;
            // 
            // GetCSVPathButton
            // 
            this.GetCSVPathButton.Location = new System.Drawing.Point(632, 467);
            this.GetCSVPathButton.Name = "GetCSVPathButton";
            this.GetCSVPathButton.Size = new System.Drawing.Size(75, 23);
            this.GetCSVPathButton.TabIndex = 3;
            this.GetCSVPathButton.Text = "Open .csv";
            this.GetCSVPathButton.UseVisualStyleBackColor = true;
            this.GetCSVPathButton.Click += new System.EventHandler(this.GetCSVPathButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(922, 467);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next Nest";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Enabled = false;
            this.PrevButton.Location = new System.Drawing.Point(822, 467);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 4;
            this.PrevButton.Text = "Prev Nest";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // SelectAHex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 536);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.GetCSVPathButton);
            this.Controls.Add(this.numberOfCellsBox);
            this.Controls.Add(this.NumberOfCellsLabel);
            this.Controls.Add(this.validateIHCSRootBox);
            this.Controls.Add(this.validateIHCSTotalBox);
            this.Controls.Add(this.IHCSIntTotalBox);
            this.Controls.Add(this.validateHCSTotalLabel);
            this.Controls.Add(this.ValidationLabel);
            this.Controls.Add(this.validateRootLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IHCSZ);
            this.Controls.Add(this.IHCSY);
            this.Controls.Add(this.IHCSX);
            this.Controls.Add(this.IHCSZBox);
            this.Controls.Add(this.IHCSYBox);
            this.Controls.Add(this.IHCSXBox);
            this.Controls.Add(this.IHCSLabel);
            this.Controls.Add(this.IHCSZLabel);
            this.Controls.Add(this.IHCSYLabel);
            this.Controls.Add(this.IHCSXLabel);
            this.Controls.Add(this.IHCSCoMZBox);
            this.Controls.Add(this.IHCSCoMYBox);
            this.Controls.Add(this.IHCSCoMLabel);
            this.Controls.Add(this.IHCSCoMXBox);
            this.Controls.Add(this.RatioTextBox);
            this.Controls.Add(this.ratioLabel);
            this.Controls.Add(this.CoMYCartTextBox);
            this.Controls.Add(this.CoMXCartTextBox);
            this.Controls.Add(this.CoMCartLabel);
            this.Controls.Add(this.CoMZTextBox);
            this.Controls.Add(this.CoMYTextBox);
            this.Controls.Add(this.CoMXTextBox);
            this.Controls.Add(this.CoMZLabel);
            this.Controls.Add(this.CoMYLabel);
            this.Controls.Add(this.CoMXLabel);
            this.Controls.Add(this.CenterOfMassHCSLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CartRootTextBox);
            this.Controls.Add(this.CartTotalTextBox);
            this.Controls.Add(this.CartYTextBox);
            this.Controls.Add(this.CartXTextBox);
            this.Controls.Add(this.HCSRootTextBox);
            this.Controls.Add(this.HCSTotalTextBox);
            this.Controls.Add(this.HCSZTextBox);
            this.Controls.Add(this.HCSYTextBox);
            this.Controls.Add(this.HCSXTextBox);
            this.Controls.Add(this.SRLabel);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.ZLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.CartesianLabel);
            this.Controls.Add(this.HCSLabel);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.hexGrid);
            this.Name = "SelectAHex";
            this.Text = "SelectAHex";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hexGrid_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.hexGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hexGrid;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label HCSLabel;
        private System.Windows.Forms.Label CartesianLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label ZLabel;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label SRLabel;
        private System.Windows.Forms.TextBox HCSXTextBox;
        private System.Windows.Forms.TextBox HCSYTextBox;
        private System.Windows.Forms.TextBox HCSZTextBox;
        private System.Windows.Forms.TextBox HCSTotalTextBox;
        private System.Windows.Forms.TextBox HCSRootTextBox;
        private System.Windows.Forms.TextBox CartXTextBox;
        private System.Windows.Forms.TextBox CartYTextBox;
        private System.Windows.Forms.TextBox CartTotalTextBox;
        private System.Windows.Forms.TextBox CartRootTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label CenterOfMassHCSLabel;
        private System.Windows.Forms.Label CoMXLabel;
        private System.Windows.Forms.Label CoMYLabel;
        private System.Windows.Forms.Label CoMZLabel;
        private System.Windows.Forms.TextBox CoMXTextBox;
        private System.Windows.Forms.TextBox CoMYTextBox;
        private System.Windows.Forms.TextBox CoMZTextBox;
        private System.Windows.Forms.Label CoMCartLabel;
        private System.Windows.Forms.TextBox CoMXCartTextBox;
        private System.Windows.Forms.TextBox CoMYCartTextBox;
        private System.Windows.Forms.Label ratioLabel;
        private System.Windows.Forms.TextBox RatioTextBox;
        private System.Windows.Forms.TextBox IHCSCoMXBox;
        private System.Windows.Forms.Label IHCSCoMLabel;
        private System.Windows.Forms.TextBox IHCSCoMYBox;
        private System.Windows.Forms.TextBox IHCSCoMZBox;
        private System.Windows.Forms.Label IHCSZLabel;
        private System.Windows.Forms.Label IHCSYLabel;
        private System.Windows.Forms.Label IHCSXLabel;
        private System.Windows.Forms.Label IHCSLabel;
        private System.Windows.Forms.TextBox IHCSXBox;
        private System.Windows.Forms.TextBox IHCSYBox;
        private System.Windows.Forms.TextBox IHCSZBox;
        private System.Windows.Forms.Label validateRootLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IHCSZ;
        private System.Windows.Forms.Label IHCSY;
        private System.Windows.Forms.Label IHCSX;
        private System.Windows.Forms.Label ValidationLabel;
        private System.Windows.Forms.Label validateHCSTotalLabel;
        private System.Windows.Forms.TextBox IHCSIntTotalBox;
        private System.Windows.Forms.TextBox validateIHCSTotalBox;
        private System.Windows.Forms.TextBox validateIHCSRootBox;
        private System.Windows.Forms.Label NumberOfCellsLabel;
        private System.Windows.Forms.TextBox numberOfCellsBox;
        private System.Windows.Forms.Button GetCSVPathButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
    }
}

