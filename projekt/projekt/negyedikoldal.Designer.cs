namespace projekt
{
    partial class negyedikoldal
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Termék = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ár = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Darab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Összár = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.excl = new System.Windows.Forms.Button();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(270, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fizetendő összeg:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Termék,
            this.Ár,
            this.Darab,
            this.Összár});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 269);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Termék
            // 
            this.Termék.Text = "Termék";
            this.Termék.Width = 130;
            // 
            // Ár
            // 
            this.Ár.Text = "Ár";
            this.Ár.Width = 128;
            // 
            // Darab
            // 
            this.Darab.Text = "Darab";
            this.Darab.Width = 119;
            // 
            // Összár
            // 
            this.Összár.Text = "Összár";
            this.Összár.Width = 130;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDelete});
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(105, 26);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(104, 22);
            this.menuDelete.Text = "Törlés";
            this.menuDelete.Click += new System.EventHandler(this.MenuDelete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 279);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Törlés";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // excl
            // 
            this.excl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.excl.Location = new System.Drawing.Point(310, 310);
            this.excl.Name = "excl";
            this.excl.Size = new System.Drawing.Size(171, 28);
            this.excl.TabIndex = 4;
            this.excl.Text = "Nyomtatás Excelbe";
            this.excl.UseVisualStyleBackColor = true;
            this.excl.Click += new System.EventHandler(this.Excl_Click);
            // 
            // negyedikoldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.excl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "negyedikoldal";
            this.Size = new System.Drawing.Size(550, 355);
            this.menuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Termék;
        private System.Windows.Forms.ColumnHeader Ár;
        private System.Windows.Forms.ColumnHeader Darab;
        private System.Windows.Forms.ColumnHeader Összár;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button excl;
    }
}
