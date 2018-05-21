namespace _13._17
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.NumericUpDown();
            this.rstbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WIN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level)).BeginInit();
            this.SuspendLayout();
            // 
            // GV
            // 
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AllowUserToResizeColumns = false;
            this.GV.AllowUserToResizeRows = false;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.ColumnHeadersVisible = false;
            this.GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.GV.Location = new System.Drawing.Point(12, 89);
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RowHeadersVisible = false;
            this.GV.RowTemplate.Height = 24;
            this.GV.ShowEditingIcon = false;
            this.GV.ShowRowErrors = false;
            this.GV.Size = new System.Drawing.Size(404, 373);
            this.GV.TabIndex = 0;
            this.GV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_CellClick);
            this.GV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GV_CellPainting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(360, 20);
            this.Level.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Level.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(54, 22);
            this.Level.TabIndex = 1;
            this.Level.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Level.ValueChanged += new System.EventHandler(this.rstbtn_Click);
            // 
            // rstbtn
            // 
            this.rstbtn.Location = new System.Drawing.Point(12, 16);
            this.rstbtn.Name = "rstbtn";
            this.rstbtn.Size = new System.Drawing.Size(78, 29);
            this.rstbtn.TabIndex = 2;
            this.rstbtn.Text = "restart";
            this.rstbtn.UseVisualStyleBackColor = true;
            this.rstbtn.Click += new System.EventHandler(this.rstbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "level:";
            // 
            // WIN
            // 
            this.WIN.AutoSize = true;
            this.WIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WIN.Location = new System.Drawing.Point(147, 9);
            this.WIN.Name = "WIN";
            this.WIN.Size = new System.Drawing.Size(117, 55);
            this.WIN.TabIndex = 4;
            this.WIN.Text = "WIN";
            this.WIN.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 475);
            this.Controls.Add(this.WIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rstbtn);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.GV);
            this.Name = "Form1";
            this.Text = "13.17";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.NumericUpDown Level;
        private System.Windows.Forms.Button rstbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WIN;
    }
}

