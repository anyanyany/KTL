namespace Szemeredi
{
    partial class GameControl
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
            this.computerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bottomPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.computersNumbers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playersNumbers = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.roundLabel = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.computerPanel.SuspendLayout();
            this.playerPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.mainPanel.Controls.Add(this.bottomPanel, 0, 3);
            this.mainPanel.Controls.Add(this.playerPanel, 0, 2);
            this.mainPanel.Controls.Add(this.computerPanel, 0, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 4;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPanel.Size = new System.Drawing.Size(900, 600);
            this.mainPanel.TabIndex = 0;
            // 
            // computerPanel
            // 
            this.computerPanel.ColumnCount = 2;
            this.computerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.computerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.computerPanel.Controls.Add(this.computersNumbers, 0, 0);
            this.computerPanel.Controls.Add(this.label1, 0, 0);
            this.computerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerPanel.Location = new System.Drawing.Point(0, 0);
            this.computerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.computerPanel.Name = "computerPanel";
            this.computerPanel.RowCount = 1;
            this.computerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.computerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.computerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.computerPanel.Size = new System.Drawing.Size(900, 90);
            this.computerPanel.TabIndex = 0;
            // 
            // playerPanel
            // 
            this.playerPanel.ColumnCount = 2;
            this.playerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.playerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.playerPanel.Controls.Add(this.playersNumbers, 0, 0);
            this.playerPanel.Controls.Add(this.label2, 0, 0);
            this.playerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerPanel.Location = new System.Drawing.Point(0, 450);
            this.playerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.RowCount = 1;
            this.playerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerPanel.Size = new System.Drawing.Size(900, 90);
            this.playerPanel.TabIndex = 1;
            // 
            // bottomPanel
            // 
            this.bottomPanel.ColumnCount = 2;
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.bottomPanel.Controls.Add(this.actionLabel, 0, 0);
            this.bottomPanel.Controls.Add(this.roundLabel, 0, 0);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 540);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.RowCount = 1;
            this.bottomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomPanel.Size = new System.Drawing.Size(900, 60);
            this.bottomPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepPink;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "komputer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // computersNumbers
            // 
            this.computersNumbers.AutoSize = true;
            this.computersNumbers.BackColor = System.Drawing.Color.DeepPink;
            this.computersNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computersNumbers.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computersNumbers.ForeColor = System.Drawing.Color.Black;
            this.computersNumbers.Location = new System.Drawing.Point(138, 0);
            this.computersNumbers.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.computersNumbers.Name = "computersNumbers";
            this.computersNumbers.Size = new System.Drawing.Size(762, 90);
            this.computersNumbers.TabIndex = 2;
            this.computersNumbers.Text = "2  5  22  30";
            this.computersNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chartreuse;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 90);
            this.label2.TabIndex = 2;
            this.label2.Text = "gracz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playersNumbers
            // 
            this.playersNumbers.AutoSize = true;
            this.playersNumbers.BackColor = System.Drawing.Color.Chartreuse;
            this.playersNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersNumbers.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playersNumbers.ForeColor = System.Drawing.Color.Black;
            this.playersNumbers.Location = new System.Drawing.Point(138, 0);
            this.playersNumbers.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.playersNumbers.Name = "playersNumbers";
            this.playersNumbers.Size = new System.Drawing.Size(762, 90);
            this.playersNumbers.TabIndex = 3;
            this.playersNumbers.Text = "8  12  15  47";
            this.playersNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.buttonsPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 360);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.ColumnCount = 1;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(3, 3);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 1;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.Size = new System.Drawing.Size(759, 354);
            this.buttonsPanel.TabIndex = 0;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.BackColor = System.Drawing.Color.DarkGray;
            this.roundLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundLabel.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundLabel.ForeColor = System.Drawing.Color.White;
            this.roundLabel.Location = new System.Drawing.Point(3, 3);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(3);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(219, 54);
            this.roundLabel.TabIndex = 3;
            this.roundLabel.Text = "runda: 1";
            this.roundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.BackColor = System.Drawing.Color.DarkGray;
            this.actionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionLabel.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionLabel.ForeColor = System.Drawing.Color.White;
            this.actionLabel.Location = new System.Drawing.Point(228, 3);
            this.actionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(669, 54);
            this.actionLabel.TabIndex = 4;
            this.actionLabel.Text = "ruch: gracz wybiera dwie liczby";
            this.actionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(900, 600);
            this.mainPanel.ResumeLayout(false);
            this.computerPanel.ResumeLayout(false);
            this.computerPanel.PerformLayout();
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel computerPanel;
        private System.Windows.Forms.TableLayoutPanel bottomPanel;
        private System.Windows.Forms.TableLayoutPanel playerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label computersNumbers;
        private System.Windows.Forms.Label playersNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label actionLabel;
    }
}
