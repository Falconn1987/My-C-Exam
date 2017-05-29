namespace MyDrive
{
    partial class frmEstimate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEuroDrivesOrPatios = new System.Windows.Forms.Label();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.lblEurosTop = new System.Windows.Forms.Label();
            this.lblPricePerSquareMetre = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblMetres1 = new System.Windows.Forms.Label();
            this.lblMetres2 = new System.Windows.Forms.Label();
            this.lblGBP = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.txtBrick = new System.Windows.Forms.TextBox();
            this.txtConcrete = new System.Windows.Forms.TextBox();
            this.txtTarmac = new System.Windows.Forms.TextBox();
            this.txtGravel = new System.Windows.Forms.TextBox();
            this.txtLenght = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtGBP = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.grpFoundations = new System.Windows.Forms.GroupBox();
            this.rdbBrick = new System.Windows.Forms.RadioButton();
            this.rdbConcrete = new System.Windows.Forms.RadioButton();
            this.rdbTarmac = new System.Windows.Forms.RadioButton();
            this.rdbGravel = new System.Windows.Forms.RadioButton();
            this.rdbStandard = new System.Windows.Forms.RadioButton();
            this.rdbExtraDeep = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.grpType.SuspendLayout();
            this.grpFoundations.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblEuroDrivesOrPatios
            // 
            this.lblEuroDrivesOrPatios.AutoSize = true;
            this.lblEuroDrivesOrPatios.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroDrivesOrPatios.ForeColor = System.Drawing.Color.Red;
            this.lblEuroDrivesOrPatios.Location = new System.Drawing.Point(181, 24);
            this.lblEuroDrivesOrPatios.Name = "lblEuroDrivesOrPatios";
            this.lblEuroDrivesOrPatios.Size = new System.Drawing.Size(234, 26);
            this.lblEuroDrivesOrPatios.TabIndex = 1;
            this.lblEuroDrivesOrPatios.Text = "Euro Drives or Patios";
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.AutoSize = true;
            this.lblExchangeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExchangeRate.Location = new System.Drawing.Point(137, 73);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(144, 13);
            this.lblExchangeRate.TabIndex = 2;
            this.lblExchangeRate.Text = "EXCHANGE RATE: £1 =";
            // 
            // lblEurosTop
            // 
            this.lblEurosTop.AutoSize = true;
            this.lblEurosTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEurosTop.Location = new System.Drawing.Point(341, 73);
            this.lblEurosTop.Name = "lblEurosTop";
            this.lblEurosTop.Size = new System.Drawing.Size(50, 13);
            this.lblEurosTop.TabIndex = 3;
            this.lblEurosTop.Text = "EUROS";
            // 
            // lblPricePerSquareMetre
            // 
            this.lblPricePerSquareMetre.AutoSize = true;
            this.lblPricePerSquareMetre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerSquareMetre.Location = new System.Drawing.Point(216, 99);
            this.lblPricePerSquareMetre.Name = "lblPricePerSquareMetre";
            this.lblPricePerSquareMetre.Size = new System.Drawing.Size(175, 13);
            this.lblPricePerSquareMetre.TabIndex = 4;
            this.lblPricePerSquareMetre.Text = "PRICE PER SQUARE METRE";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(191, 241);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(57, 13);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "LENGHT";
            this.lblLength.Visible = false;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(197, 267);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(49, 13);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "WIDTH";
            this.lblWidth.Visible = false;
            // 
            // lblMetres1
            // 
            this.lblMetres1.AutoSize = true;
            this.lblMetres1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetres1.Location = new System.Drawing.Point(354, 241);
            this.lblMetres1.Name = "lblMetres1";
            this.lblMetres1.Size = new System.Drawing.Size(58, 13);
            this.lblMetres1.TabIndex = 7;
            this.lblMetres1.Text = "METRES";
            this.lblMetres1.Visible = false;
            // 
            // lblMetres2
            // 
            this.lblMetres2.AutoSize = true;
            this.lblMetres2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetres2.Location = new System.Drawing.Point(353, 267);
            this.lblMetres2.Name = "lblMetres2";
            this.lblMetres2.Size = new System.Drawing.Size(58, 13);
            this.lblMetres2.TabIndex = 8;
            this.lblMetres2.Text = "METRES";
            this.lblMetres2.Visible = false;
            // 
            // lblGBP
            // 
            this.lblGBP.AutoSize = true;
            this.lblGBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGBP.Location = new System.Drawing.Point(153, 313);
            this.lblGBP.Name = "lblGBP";
            this.lblGBP.Size = new System.Drawing.Size(32, 13);
            this.lblGBP.TabIndex = 9;
            this.lblGBP.Text = "GBP";
            this.lblGBP.Visible = false;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(308, 313);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(42, 13);
            this.lblEuro.TabIndex = 10;
            this.lblEuro.Text = "EURO";
            this.lblEuro.Visible = false;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Green;
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(126, 345);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(350, 23);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.Visible = false;
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rdbGravel);
            this.grpType.Controls.Add(this.rdbTarmac);
            this.grpType.Controls.Add(this.rdbConcrete);
            this.grpType.Controls.Add(this.rdbBrick);
            this.grpType.Location = new System.Drawing.Point(103, 103);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(107, 114);
            this.grpType.TabIndex = 12;
            this.grpType.TabStop = false;
            this.grpType.Text = "Materials";
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(280, 70);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(55, 20);
            this.txtExchangeRate.TabIndex = 13;
            this.txtExchangeRate.Text = "1.45";
            this.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBrick
            // 
            this.txtBrick.Location = new System.Drawing.Point(248, 119);
            this.txtBrick.Name = "txtBrick";
            this.txtBrick.Size = new System.Drawing.Size(100, 20);
            this.txtBrick.TabIndex = 14;
            this.txtBrick.Text = "35.75";
            this.txtBrick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConcrete
            // 
            this.txtConcrete.Location = new System.Drawing.Point(248, 145);
            this.txtConcrete.Name = "txtConcrete";
            this.txtConcrete.Size = new System.Drawing.Size(100, 20);
            this.txtConcrete.TabIndex = 15;
            this.txtConcrete.Text = "25.50";
            this.txtConcrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTarmac
            // 
            this.txtTarmac.Location = new System.Drawing.Point(248, 171);
            this.txtTarmac.Name = "txtTarmac";
            this.txtTarmac.Size = new System.Drawing.Size(100, 20);
            this.txtTarmac.TabIndex = 16;
            this.txtTarmac.Text = "20.00";
            this.txtTarmac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGravel
            // 
            this.txtGravel.Location = new System.Drawing.Point(248, 197);
            this.txtGravel.Name = "txtGravel";
            this.txtGravel.Size = new System.Drawing.Size(100, 20);
            this.txtGravel.TabIndex = 17;
            this.txtGravel.Text = "29.75";
            this.txtGravel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLenght
            // 
            this.txtLenght.Location = new System.Drawing.Point(248, 238);
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.Size = new System.Drawing.Size(100, 20);
            this.txtLenght.TabIndex = 18;
            this.txtLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLenght.Visible = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(247, 264);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 19;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWidth.Visible = false;
            // 
            // txtGBP
            // 
            this.txtGBP.Location = new System.Drawing.Point(191, 310);
            this.txtGBP.Name = "txtGBP";
            this.txtGBP.Size = new System.Drawing.Size(100, 20);
            this.txtGBP.TabIndex = 20;
            this.txtGBP.Text = "1";
            this.txtGBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGBP.Visible = false;
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(352, 310);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 21;
            this.txtEuro.Text = "1.45";
            this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEuro.Visible = false;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalculate.Location = new System.Drawing.Point(156, 381);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(88, 23);
            this.cmdCalculate.TabIndex = 22;
            this.cmdCalculate.Text = "CALCULATE";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Visible = false;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStart.Location = new System.Drawing.Point(275, 381);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 23;
            this.cmdStart.Text = "START";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Location = new System.Drawing.Point(377, 381);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 24;
            this.cmdClear.Text = "CLEAR";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Visible = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // grpFoundations
            // 
            this.grpFoundations.Controls.Add(this.rdbExtraDeep);
            this.grpFoundations.Controls.Add(this.rdbStandard);
            this.grpFoundations.Location = new System.Drawing.Point(442, 103);
            this.grpFoundations.Name = "grpFoundations";
            this.grpFoundations.Size = new System.Drawing.Size(135, 88);
            this.grpFoundations.TabIndex = 25;
            this.grpFoundations.TabStop = false;
            this.grpFoundations.Text = "Foundations";
            this.grpFoundations.Visible = false;
            // 
            // rdbBrick
            // 
            this.rdbBrick.AutoSize = true;
            this.rdbBrick.Checked = true;
            this.rdbBrick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBrick.Location = new System.Drawing.Point(4, 26);
            this.rdbBrick.Name = "rdbBrick";
            this.rdbBrick.Size = new System.Drawing.Size(62, 17);
            this.rdbBrick.TabIndex = 0;
            this.rdbBrick.TabStop = true;
            this.rdbBrick.Text = "BRICK";
            this.rdbBrick.UseVisualStyleBackColor = true;
            this.rdbBrick.CheckedChanged += new System.EventHandler(this.rdbBrick_CheckedChanged);
            // 
            // rdbConcrete
            // 
            this.rdbConcrete.AutoSize = true;
            this.rdbConcrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConcrete.Location = new System.Drawing.Point(4, 49);
            this.rdbConcrete.Name = "rdbConcrete";
            this.rdbConcrete.Size = new System.Drawing.Size(92, 17);
            this.rdbConcrete.TabIndex = 1;
            this.rdbConcrete.Text = "CONCRETE";
            this.rdbConcrete.UseVisualStyleBackColor = true;
            this.rdbConcrete.CheckedChanged += new System.EventHandler(this.rdbConcrete_CheckedChanged);
            // 
            // rdbTarmac
            // 
            this.rdbTarmac.AutoSize = true;
            this.rdbTarmac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTarmac.Location = new System.Drawing.Point(4, 69);
            this.rdbTarmac.Name = "rdbTarmac";
            this.rdbTarmac.Size = new System.Drawing.Size(76, 17);
            this.rdbTarmac.TabIndex = 2;
            this.rdbTarmac.Text = "TARMAC";
            this.rdbTarmac.UseVisualStyleBackColor = true;
            this.rdbTarmac.CheckedChanged += new System.EventHandler(this.rdbTarmac_CheckedChanged);
            // 
            // rdbGravel
            // 
            this.rdbGravel.AutoSize = true;
            this.rdbGravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGravel.Location = new System.Drawing.Point(4, 91);
            this.rdbGravel.Name = "rdbGravel";
            this.rdbGravel.Size = new System.Drawing.Size(74, 17);
            this.rdbGravel.TabIndex = 3;
            this.rdbGravel.Text = "GRAVEL";
            this.rdbGravel.UseVisualStyleBackColor = true;
            this.rdbGravel.CheckedChanged += new System.EventHandler(this.rdbGravel_CheckedChanged);
            // 
            // rdbStandard
            // 
            this.rdbStandard.AutoSize = true;
            this.rdbStandard.Checked = true;
            this.rdbStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbStandard.Location = new System.Drawing.Point(7, 34);
            this.rdbStandard.Name = "rdbStandard";
            this.rdbStandard.Size = new System.Drawing.Size(93, 17);
            this.rdbStandard.TabIndex = 0;
            this.rdbStandard.TabStop = true;
            this.rdbStandard.Text = "STANDARD";
            this.rdbStandard.UseVisualStyleBackColor = true;
            this.rdbStandard.CheckedChanged += new System.EventHandler(this.rdbStandard_CheckedChanged);
            // 
            // rdbExtraDeep
            // 
            this.rdbExtraDeep.AutoSize = true;
            this.rdbExtraDeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExtraDeep.Location = new System.Drawing.Point(6, 57);
            this.rdbExtraDeep.Name = "rdbExtraDeep";
            this.rdbExtraDeep.Size = new System.Drawing.Size(103, 17);
            this.rdbExtraDeep.TabIndex = 1;
            this.rdbExtraDeep.Text = "EXTRA DEEP";
            this.rdbExtraDeep.UseVisualStyleBackColor = true;
            this.rdbExtraDeep.CheckedChanged += new System.EventHandler(this.rdbExtraDeep_CheckedChanged);
            // 
            // frmEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 422);
            this.Controls.Add(this.grpFoundations);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtGBP);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLenght);
            this.Controls.Add(this.txtGravel);
            this.Controls.Add(this.txtTarmac);
            this.Controls.Add(this.txtConcrete);
            this.Controls.Add(this.txtBrick);
            this.Controls.Add(this.txtExchangeRate);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblGBP);
            this.Controls.Add(this.lblMetres2);
            this.Controls.Add(this.lblMetres1);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblPricePerSquareMetre);
            this.Controls.Add(this.lblEurosTop);
            this.Controls.Add(this.lblExchangeRate);
            this.Controls.Add(this.lblEuroDrivesOrPatios);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drive Estimates";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpFoundations.ResumeLayout(false);
            this.grpFoundations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblEuroDrivesOrPatios;
        private System.Windows.Forms.Label lblExchangeRate;
        private System.Windows.Forms.Label lblEurosTop;
        private System.Windows.Forms.Label lblPricePerSquareMetre;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblMetres1;
        private System.Windows.Forms.Label lblMetres2;
        private System.Windows.Forms.Label lblGBP;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.TextBox txtBrick;
        private System.Windows.Forms.TextBox txtConcrete;
        private System.Windows.Forms.TextBox txtTarmac;
        private System.Windows.Forms.TextBox txtGravel;
        private System.Windows.Forms.TextBox txtLenght;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtGBP;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.RadioButton rdbGravel;
        private System.Windows.Forms.RadioButton rdbTarmac;
        private System.Windows.Forms.RadioButton rdbConcrete;
        private System.Windows.Forms.RadioButton rdbBrick;
        private System.Windows.Forms.GroupBox grpFoundations;
        private System.Windows.Forms.RadioButton rdbExtraDeep;
        private System.Windows.Forms.RadioButton rdbStandard;
    }
}

