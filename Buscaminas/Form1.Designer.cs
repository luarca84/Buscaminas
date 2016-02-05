namespace Buscaminas
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMinas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtDificultad = new System.Windows.Forms.TextBox();
            this.lblDificultad = new System.Windows.Forms.Label();
            this.txtMinas = new System.Windows.Forms.TextBox();
            this.lblMinas = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvMinas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 383);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvMinas
            // 
            this.dgvMinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMinas.Location = new System.Drawing.Point(3, 83);
            this.dgvMinas.Name = "dgvMinas";
            this.dgvMinas.Size = new System.Drawing.Size(462, 297);
            this.dgvMinas.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.txtDificultad);
            this.panel1.Controls.Add(this.lblDificultad);
            this.panel1.Controls.Add(this.txtMinas);
            this.panel1.Controls.Add(this.lblMinas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 74);
            this.panel1.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(118, 7);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(313, 49);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtDificultad
            // 
            this.txtDificultad.Location = new System.Drawing.Point(66, 36);
            this.txtDificultad.Name = "txtDificultad";
            this.txtDificultad.Size = new System.Drawing.Size(46, 20);
            this.txtDificultad.TabIndex = 3;
            this.txtDificultad.Text = "10";
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.Location = new System.Drawing.Point(9, 39);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(51, 13);
            this.lblDificultad.TabIndex = 2;
            this.lblDificultad.Text = "Dificultad";
            // 
            // txtMinas
            // 
            this.txtMinas.Location = new System.Drawing.Point(66, 7);
            this.txtMinas.Name = "txtMinas";
            this.txtMinas.Size = new System.Drawing.Size(46, 20);
            this.txtMinas.TabIndex = 1;
            this.txtMinas.Text = "10";
            // 
            // lblMinas
            // 
            this.lblMinas.AutoSize = true;
            this.lblMinas.Location = new System.Drawing.Point(9, 10);
            this.lblMinas.Name = "lblMinas";
            this.lblMinas.Size = new System.Drawing.Size(35, 13);
            this.lblMinas.TabIndex = 0;
            this.lblMinas.Text = "Minas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 383);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscaminas";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvMinas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtDificultad;
        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.TextBox txtMinas;
        private System.Windows.Forms.Label lblMinas;
    }
}

