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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bottomPanel = new System.Windows.Forms.TableLayoutPanel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.KLabel = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.playerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playersNumbersLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.computerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.computersNumbersLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.playerPanel.SuspendLayout();
            this.computerPanel.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.buttonsPanel.Size = new System.Drawing.Size(894, 354);
            this.buttonsPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.ColumnCount = 4;
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.bottomPanel.Controls.Add(this.levelLabel, 2, 0);
            this.bottomPanel.Controls.Add(this.KLabel, 3, 0);
            this.bottomPanel.Controls.Add(this.actionLabel, 1, 0);
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
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.DarkGray;
            this.levelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelLabel.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(723, 3);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(105, 57);
            this.levelLabel.TabIndex = 6;
            this.levelLabel.Text = "poziom";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KLabel
            // 
            this.KLabel.AutoSize = true;
            this.KLabel.BackColor = System.Drawing.Color.DarkGray;
            this.KLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KLabel.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KLabel.ForeColor = System.Drawing.Color.White;
            this.KLabel.Location = new System.Drawing.Point(831, 3);
            this.KLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.KLabel.Name = "KLabel";
            this.KLabel.Size = new System.Drawing.Size(69, 57);
            this.KLabel.TabIndex = 5;
            this.KLabel.Text = "k =";
            this.KLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.BackColor = System.Drawing.Color.DarkGray;
            this.actionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionLabel.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionLabel.ForeColor = System.Drawing.Color.White;
            this.actionLabel.Location = new System.Drawing.Point(120, 3);
            this.actionLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(600, 57);
            this.actionLabel.TabIndex = 4;
            this.actionLabel.Text = "ruch: gracz wybiera dwie liczby";
            this.actionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.BackColor = System.Drawing.Color.DarkGray;
            this.roundLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundLabel.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundLabel.ForeColor = System.Drawing.Color.White;
            this.roundLabel.Location = new System.Drawing.Point(0, 3);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(117, 57);
            this.roundLabel.TabIndex = 3;
            this.roundLabel.Text = "runda: 1";
            this.roundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerPanel
            // 
            this.playerPanel.ColumnCount = 2;
            this.playerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.playerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.playerPanel.Controls.Add(this.playersNumbersLabel, 0, 0);
            this.playerPanel.Controls.Add(this.playerLabel, 0, 0);
            this.playerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerPanel.Location = new System.Drawing.Point(0, 450);
            this.playerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.RowCount = 1;
            this.playerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerPanel.Size = new System.Drawing.Size(900, 90);
            this.playerPanel.TabIndex = 1;
            // 
            // playersNumbersLabel
            // 
            this.playersNumbersLabel.BackColor = System.Drawing.Color.White;
            this.playersNumbersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersNumbersLabel.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playersNumbersLabel.ForeColor = System.Drawing.Color.Black;
            this.playersNumbersLabel.Location = new System.Drawing.Point(138, 0);
            this.playersNumbersLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.playersNumbersLabel.Name = "playersNumbersLabel";
            this.playersNumbersLabel.Size = new System.Drawing.Size(762, 90);
            this.playersNumbersLabel.TabIndex = 3;
            this.playersNumbersLabel.Text = "8  12  15  47";
            this.playersNumbersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.Color.White;
            this.playerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerLabel.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerLabel.ForeColor = System.Drawing.Color.Black;
            this.playerLabel.Location = new System.Drawing.Point(0, 0);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(135, 90);
            this.playerLabel.TabIndex = 2;
            this.playerLabel.Text = "gracz";
            this.playerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // computerPanel
            // 
            this.computerPanel.ColumnCount = 2;
            this.computerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.computerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.computerPanel.Controls.Add(this.computersNumbersLabel, 0, 0);
            this.computerPanel.Controls.Add(this.computerLabel, 0, 0);
            this.computerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerPanel.Location = new System.Drawing.Point(0, 0);
            this.computerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.computerPanel.Name = "computerPanel";
            this.computerPanel.RowCount = 1;
            this.computerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.computerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.computerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.computerPanel.Size = new System.Drawing.Size(900, 90);
            this.computerPanel.TabIndex = 0;
            // 
            // computersNumbersLabel
            // 
            this.computersNumbersLabel.BackColor = System.Drawing.Color.White;
            this.computersNumbersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computersNumbersLabel.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computersNumbersLabel.ForeColor = System.Drawing.Color.Black;
            this.computersNumbersLabel.Location = new System.Drawing.Point(138, 0);
            this.computersNumbersLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.computersNumbersLabel.Name = "computersNumbersLabel";
            this.computersNumbersLabel.Size = new System.Drawing.Size(762, 90);
            this.computersNumbersLabel.TabIndex = 2;
            this.computersNumbersLabel.Text = "2  5  22  30";
            this.computersNumbersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.BackColor = System.Drawing.Color.White;
            this.computerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerLabel.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computerLabel.ForeColor = System.Drawing.Color.Black;
            this.computerLabel.Location = new System.Drawing.Point(0, 0);
            this.computerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(135, 90);
            this.computerLabel.TabIndex = 1;
            this.computerLabel.Text = "komputer";
            this.computerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(900, 600);
            this.mainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            this.computerPanel.ResumeLayout(false);
            this.computerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel computerPanel;
        private System.Windows.Forms.TableLayoutPanel bottomPanel;
        private System.Windows.Forms.TableLayoutPanel playerPanel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label computersNumbersLabel;
        private System.Windows.Forms.Label playersNumbersLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label KLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
    }
}
