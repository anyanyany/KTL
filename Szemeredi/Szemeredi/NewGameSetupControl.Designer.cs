namespace Szemeredi
{
    partial class NewGameSetupControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.defineKPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.KNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.defineNPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.NNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.firstMovePanel = new System.Windows.Forms.TableLayoutPanel();
            this.computerRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.playerRadioButton = new System.Windows.Forms.RadioButton();
            this.startGameButton = new System.Windows.Forms.Button();
            this.chooseColorsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.computerColor5Button = new System.Windows.Forms.Button();
            this.playerColor5Button = new System.Windows.Forms.Button();
            this.computerColor4Button = new System.Windows.Forms.Button();
            this.playerColor4Button = new System.Windows.Forms.Button();
            this.computerColor3Button = new System.Windows.Forms.Button();
            this.playerColor3Button = new System.Windows.Forms.Button();
            this.computerColor2Button = new System.Windows.Forms.Button();
            this.playerColor2Button = new System.Windows.Forms.Button();
            this.computerColor1Button = new System.Windows.Forms.Button();
            this.playerColor1Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.defineKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KNumericUpDown)).BeginInit();
            this.defineNPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NNumericUpDown)).BeginInit();
            this.firstMovePanel.SuspendLayout();
            this.chooseColorsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.defineKPanel, 0, 2);
            this.mainPanel.Controls.Add(this.label1, 0, 0);
            this.mainPanel.Controls.Add(this.defineNPanel, 0, 1);
            this.mainPanel.Controls.Add(this.firstMovePanel, 0, 3);
            this.mainPanel.Controls.Add(this.startGameButton, 0, 5);
            this.mainPanel.Controls.Add(this.chooseColorsPanel, 0, 4);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 6;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.Size = new System.Drawing.Size(500, 400);
            this.mainPanel.TabIndex = 0;
            // 
            // defineKPanel
            // 
            this.defineKPanel.ColumnCount = 2;
            this.defineKPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineKPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineKPanel.Controls.Add(this.label3, 0, 0);
            this.defineKPanel.Controls.Add(this.KNumericUpDown, 1, 0);
            this.defineKPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defineKPanel.Location = new System.Drawing.Point(3, 123);
            this.defineKPanel.Name = "defineKPanel";
            this.defineKPanel.RowCount = 1;
            this.defineKPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineKPanel.Size = new System.Drawing.Size(494, 54);
            this.defineKPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Caviar Dreams", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 54);
            this.label3.TabIndex = 1;
            this.label3.Text = "k = ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // KNumericUpDown
            // 
            this.KNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.KNumericUpDown.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KNumericUpDown.Location = new System.Drawing.Point(250, 11);
            this.KNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KNumericUpDown.Name = "KNumericUpDown";
            this.KNumericUpDown.Size = new System.Drawing.Size(120, 32);
            this.KNumericUpDown.TabIndex = 2;
            this.KNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "N O W A   G R A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defineNPanel
            // 
            this.defineNPanel.ColumnCount = 2;
            this.defineNPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineNPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineNPanel.Controls.Add(this.label2, 0, 0);
            this.defineNPanel.Controls.Add(this.NNumericUpDown, 1, 0);
            this.defineNPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defineNPanel.Location = new System.Drawing.Point(3, 63);
            this.defineNPanel.Name = "defineNPanel";
            this.defineNPanel.RowCount = 1;
            this.defineNPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineNPanel.Size = new System.Drawing.Size(494, 54);
            this.defineNPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Caviar Dreams", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "n = ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NNumericUpDown
            // 
            this.NNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NNumericUpDown.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NNumericUpDown.Location = new System.Drawing.Point(250, 11);
            this.NNumericUpDown.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.NNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NNumericUpDown.Name = "NNumericUpDown";
            this.NNumericUpDown.Size = new System.Drawing.Size(120, 32);
            this.NNumericUpDown.TabIndex = 2;
            this.NNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // firstMovePanel
            // 
            this.firstMovePanel.ColumnCount = 3;
            this.firstMovePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.firstMovePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.firstMovePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.firstMovePanel.Controls.Add(this.computerRadioButton, 2, 0);
            this.firstMovePanel.Controls.Add(this.label4, 0, 0);
            this.firstMovePanel.Controls.Add(this.playerRadioButton, 1, 0);
            this.firstMovePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstMovePanel.Location = new System.Drawing.Point(3, 183);
            this.firstMovePanel.Name = "firstMovePanel";
            this.firstMovePanel.RowCount = 1;
            this.firstMovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.firstMovePanel.Size = new System.Drawing.Size(494, 54);
            this.firstMovePanel.TabIndex = 3;
            // 
            // computerRadioButton
            // 
            this.computerRadioButton.AutoSize = true;
            this.computerRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerRadioButton.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computerRadioButton.ForeColor = System.Drawing.Color.DimGray;
            this.computerRadioButton.Location = new System.Drawing.Point(348, 3);
            this.computerRadioButton.Name = "computerRadioButton";
            this.computerRadioButton.Size = new System.Drawing.Size(143, 48);
            this.computerRadioButton.TabIndex = 4;
            this.computerRadioButton.Text = "komputer";
            this.computerRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 54);
            this.label4.TabIndex = 2;
            this.label4.Text = "pierwszy ruch";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerRadioButton
            // 
            this.playerRadioButton.AutoSize = true;
            this.playerRadioButton.Checked = true;
            this.playerRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerRadioButton.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerRadioButton.ForeColor = System.Drawing.Color.DimGray;
            this.playerRadioButton.Location = new System.Drawing.Point(250, 3);
            this.playerRadioButton.Name = "playerRadioButton";
            this.playerRadioButton.Size = new System.Drawing.Size(92, 48);
            this.playerRadioButton.TabIndex = 3;
            this.playerRadioButton.TabStop = true;
            this.playerRadioButton.Text = "gracz";
            this.playerRadioButton.UseVisualStyleBackColor = true;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Crimson;
            this.startGameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startGameButton.FlatAppearance.BorderSize = 0;
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameButton.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startGameButton.ForeColor = System.Drawing.Color.White;
            this.startGameButton.Location = new System.Drawing.Point(3, 343);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(494, 54);
            this.startGameButton.TabIndex = 4;
            this.startGameButton.Text = "S T A R T";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // chooseColorsPanel
            // 
            this.chooseColorsPanel.ColumnCount = 8;
            this.chooseColorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.chooseColorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.chooseColorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.chooseColorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.chooseColorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.chooseColorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.chooseColorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.chooseColorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.chooseColorsPanel.Controls.Add(this.computerColor5Button, 6, 2);
            this.chooseColorsPanel.Controls.Add(this.playerColor5Button, 6, 1);
            this.chooseColorsPanel.Controls.Add(this.computerColor4Button, 5, 2);
            this.chooseColorsPanel.Controls.Add(this.playerColor4Button, 5, 1);
            this.chooseColorsPanel.Controls.Add(this.computerColor3Button, 4, 2);
            this.chooseColorsPanel.Controls.Add(this.playerColor3Button, 4, 1);
            this.chooseColorsPanel.Controls.Add(this.computerColor2Button, 3, 2);
            this.chooseColorsPanel.Controls.Add(this.playerColor2Button, 3, 1);
            this.chooseColorsPanel.Controls.Add(this.computerColor1Button, 2, 2);
            this.chooseColorsPanel.Controls.Add(this.playerColor1Button, 2, 1);
            this.chooseColorsPanel.Controls.Add(this.label6, 1, 2);
            this.chooseColorsPanel.Controls.Add(this.label5, 1, 1);
            this.chooseColorsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseColorsPanel.Location = new System.Drawing.Point(3, 243);
            this.chooseColorsPanel.Name = "chooseColorsPanel";
            this.chooseColorsPanel.RowCount = 4;
            this.chooseColorsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.chooseColorsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.chooseColorsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.chooseColorsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.chooseColorsPanel.Size = new System.Drawing.Size(494, 94);
            this.chooseColorsPanel.TabIndex = 5;
            // 
            // computerColor5Button
            // 
            this.computerColor5Button.BackColor = System.Drawing.Color.DeepPink;
            this.computerColor5Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerColor5Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.computerColor5Button.FlatAppearance.BorderSize = 0;
            this.computerColor5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computerColor5Button.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computerColor5Button.ForeColor = System.Drawing.Color.White;
            this.computerColor5Button.Location = new System.Drawing.Point(371, 49);
            this.computerColor5Button.Name = "computerColor5Button";
            this.computerColor5Button.Size = new System.Drawing.Size(43, 31);
            this.computerColor5Button.TabIndex = 14;
            this.computerColor5Button.UseVisualStyleBackColor = false;
            this.computerColor5Button.Click += new System.EventHandler(this.computerColorButton_Click);
            // 
            // playerColor5Button
            // 
            this.playerColor5Button.BackColor = System.Drawing.Color.DeepPink;
            this.playerColor5Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerColor5Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.playerColor5Button.FlatAppearance.BorderSize = 0;
            this.playerColor5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerColor5Button.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerColor5Button.ForeColor = System.Drawing.Color.White;
            this.playerColor5Button.Location = new System.Drawing.Point(371, 12);
            this.playerColor5Button.Name = "playerColor5Button";
            this.playerColor5Button.Size = new System.Drawing.Size(43, 31);
            this.playerColor5Button.TabIndex = 13;
            this.playerColor5Button.UseVisualStyleBackColor = false;
            this.playerColor5Button.Click += new System.EventHandler(this.playerColorButton_Click);
            // 
            // computerColor4Button
            // 
            this.computerColor4Button.BackColor = System.Drawing.Color.Violet;
            this.computerColor4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerColor4Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.computerColor4Button.FlatAppearance.BorderSize = 0;
            this.computerColor4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computerColor4Button.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computerColor4Button.ForeColor = System.Drawing.Color.White;
            this.computerColor4Button.Location = new System.Drawing.Point(322, 49);
            this.computerColor4Button.Name = "computerColor4Button";
            this.computerColor4Button.Size = new System.Drawing.Size(43, 31);
            this.computerColor4Button.TabIndex = 12;
            this.computerColor4Button.UseVisualStyleBackColor = false;
            this.computerColor4Button.Click += new System.EventHandler(this.computerColorButton_Click);
            // 
            // playerColor4Button
            // 
            this.playerColor4Button.BackColor = System.Drawing.Color.Violet;
            this.playerColor4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerColor4Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.playerColor4Button.FlatAppearance.BorderSize = 0;
            this.playerColor4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerColor4Button.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerColor4Button.ForeColor = System.Drawing.Color.White;
            this.playerColor4Button.Location = new System.Drawing.Point(322, 12);
            this.playerColor4Button.Name = "playerColor4Button";
            this.playerColor4Button.Size = new System.Drawing.Size(43, 31);
            this.playerColor4Button.TabIndex = 11;
            this.playerColor4Button.UseVisualStyleBackColor = false;
            this.playerColor4Button.Click += new System.EventHandler(this.playerColorButton_Click);
            // 
            // computerColor3Button
            // 
            this.computerColor3Button.BackColor = System.Drawing.Color.Cyan;
            this.computerColor3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerColor3Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.computerColor3Button.FlatAppearance.BorderSize = 0;
            this.computerColor3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computerColor3Button.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computerColor3Button.ForeColor = System.Drawing.Color.White;
            this.computerColor3Button.Location = new System.Drawing.Point(273, 49);
            this.computerColor3Button.Name = "computerColor3Button";
            this.computerColor3Button.Size = new System.Drawing.Size(43, 31);
            this.computerColor3Button.TabIndex = 10;
            this.computerColor3Button.UseVisualStyleBackColor = false;
            this.computerColor3Button.Click += new System.EventHandler(this.computerColorButton_Click);
            // 
            // playerColor3Button
            // 
            this.playerColor3Button.BackColor = System.Drawing.Color.Cyan;
            this.playerColor3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerColor3Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.playerColor3Button.FlatAppearance.BorderSize = 0;
            this.playerColor3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerColor3Button.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerColor3Button.ForeColor = System.Drawing.Color.White;
            this.playerColor3Button.Location = new System.Drawing.Point(273, 12);
            this.playerColor3Button.Name = "playerColor3Button";
            this.playerColor3Button.Size = new System.Drawing.Size(43, 31);
            this.playerColor3Button.TabIndex = 9;
            this.playerColor3Button.UseVisualStyleBackColor = false;
            this.playerColor3Button.Click += new System.EventHandler(this.playerColorButton_Click);
            // 
            // computerColor2Button
            // 
            this.computerColor2Button.BackColor = System.Drawing.Color.Chartreuse;
            this.computerColor2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerColor2Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.computerColor2Button.FlatAppearance.BorderSize = 0;
            this.computerColor2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computerColor2Button.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computerColor2Button.ForeColor = System.Drawing.Color.White;
            this.computerColor2Button.Location = new System.Drawing.Point(224, 49);
            this.computerColor2Button.Name = "computerColor2Button";
            this.computerColor2Button.Size = new System.Drawing.Size(43, 31);
            this.computerColor2Button.TabIndex = 8;
            this.computerColor2Button.UseVisualStyleBackColor = false;
            this.computerColor2Button.Click += new System.EventHandler(this.computerColorButton_Click);
            // 
            // playerColor2Button
            // 
            this.playerColor2Button.BackColor = System.Drawing.Color.Chartreuse;
            this.playerColor2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerColor2Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.playerColor2Button.FlatAppearance.BorderSize = 0;
            this.playerColor2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerColor2Button.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerColor2Button.ForeColor = System.Drawing.Color.White;
            this.playerColor2Button.Location = new System.Drawing.Point(224, 12);
            this.playerColor2Button.Name = "playerColor2Button";
            this.playerColor2Button.Size = new System.Drawing.Size(43, 31);
            this.playerColor2Button.TabIndex = 7;
            this.playerColor2Button.UseVisualStyleBackColor = false;
            this.playerColor2Button.Click += new System.EventHandler(this.playerColorButton_Click);
            // 
            // computerColor1Button
            // 
            this.computerColor1Button.BackColor = System.Drawing.Color.Yellow;
            this.computerColor1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerColor1Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.computerColor1Button.FlatAppearance.BorderSize = 0;
            this.computerColor1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computerColor1Button.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computerColor1Button.ForeColor = System.Drawing.Color.White;
            this.computerColor1Button.Location = new System.Drawing.Point(175, 49);
            this.computerColor1Button.Name = "computerColor1Button";
            this.computerColor1Button.Size = new System.Drawing.Size(43, 31);
            this.computerColor1Button.TabIndex = 6;
            this.computerColor1Button.UseVisualStyleBackColor = false;
            this.computerColor1Button.Click += new System.EventHandler(this.computerColorButton_Click);
            // 
            // playerColor1Button
            // 
            this.playerColor1Button.BackColor = System.Drawing.Color.Yellow;
            this.playerColor1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerColor1Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.playerColor1Button.FlatAppearance.BorderSize = 0;
            this.playerColor1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerColor1Button.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerColor1Button.ForeColor = System.Drawing.Color.White;
            this.playerColor1Button.Location = new System.Drawing.Point(175, 12);
            this.playerColor1Button.Name = "playerColor1Button";
            this.playerColor1Button.Size = new System.Drawing.Size(43, 31);
            this.playerColor1Button.TabIndex = 5;
            this.playerColor1Button.UseVisualStyleBackColor = false;
            this.playerColor1Button.Click += new System.EventHandler(this.playerColorButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(52, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "komputer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(52, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "gracz";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewGameSetupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "NewGameSetupControl";
            this.Size = new System.Drawing.Size(500, 400);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.defineKPanel.ResumeLayout(false);
            this.defineKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KNumericUpDown)).EndInit();
            this.defineNPanel.ResumeLayout(false);
            this.defineNPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NNumericUpDown)).EndInit();
            this.firstMovePanel.ResumeLayout(false);
            this.firstMovePanel.PerformLayout();
            this.chooseColorsPanel.ResumeLayout(false);
            this.chooseColorsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel defineNPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel defineKPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown KNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel firstMovePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton playerRadioButton;
        private System.Windows.Forms.RadioButton computerRadioButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.TableLayoutPanel chooseColorsPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button playerColor1Button;
        private System.Windows.Forms.Button computerColor5Button;
        private System.Windows.Forms.Button playerColor5Button;
        private System.Windows.Forms.Button computerColor4Button;
        private System.Windows.Forms.Button playerColor4Button;
        private System.Windows.Forms.Button computerColor3Button;
        private System.Windows.Forms.Button playerColor3Button;
        private System.Windows.Forms.Button computerColor2Button;
        private System.Windows.Forms.Button playerColor2Button;
        private System.Windows.Forms.Button computerColor1Button;
    }
}
