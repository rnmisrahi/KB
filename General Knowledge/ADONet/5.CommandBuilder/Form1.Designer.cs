namespace _5.CommandBuilder
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
            this.grvDataView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCommandBuilder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnComandBuilder2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvDataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvDataView
            // 
            this.grvDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDataView.Location = new System.Drawing.Point(0, 0);
            this.grvDataView.Name = "grvDataView";
            this.grvDataView.RowTemplate.Height = 24;
            this.grvDataView.Size = new System.Drawing.Size(493, 382);
            this.grvDataView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnComandBuilder2);
            this.panel1.Controls.Add(this.btnCommandBuilder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 382);
            this.panel1.TabIndex = 2;
            // 
            // btnCommandBuilder
            // 
            this.btnCommandBuilder.Location = new System.Drawing.Point(12, 12);
            this.btnCommandBuilder.Name = "btnCommandBuilder";
            this.btnCommandBuilder.Size = new System.Drawing.Size(88, 55);
            this.btnCommandBuilder.TabIndex = 0;
            this.btnCommandBuilder.Text = "Command Builder";
            this.btnCommandBuilder.UseVisualStyleBackColor = true;
            this.btnCommandBuilder.Click += new System.EventHandler(this.btnCommandBuilder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grvDataView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 382);
            this.panel2.TabIndex = 3;
            // 
            // btnComandBuilder2
            // 
            this.btnComandBuilder2.Location = new System.Drawing.Point(12, 83);
            this.btnComandBuilder2.Name = "btnComandBuilder2";
            this.btnComandBuilder2.Size = new System.Drawing.Size(88, 55);
            this.btnComandBuilder2.TabIndex = 0;
            this.btnComandBuilder2.Text = "Command Builder";
            this.btnComandBuilder2.UseVisualStyleBackColor = true;
            this.btnComandBuilder2.Click += new System.EventHandler(this.btnComandBuilder2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grvDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvDataView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCommandBuilder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnComandBuilder2;
    }
}

