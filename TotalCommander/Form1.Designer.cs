
namespace TotalCommander
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.иToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьДиректориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переместитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.upbtn1 = new System.Windows.Forms.Button();
            this.explorer1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drivesCB1 = new System.Windows.Forms.ComboBox();
            this.pathTextBox1 = new System.Windows.Forms.TextBox();
            this.upbtn2 = new System.Windows.Forms.Button();
            this.explorer2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drivesCB2 = new System.Windows.Forms.ComboBox();
            this.pathTextBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.иToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // иToolStripMenuItem
            // 
            this.иToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьФайлToolStripMenuItem,
            this.создатьДиректориюToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.скопироватьToolStripMenuItem,
            this.переименоватьToolStripMenuItem,
            this.переместитьToolStripMenuItem});
            this.иToolStripMenuItem.Name = "иToolStripMenuItem";
            this.иToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.иToolStripMenuItem.Text = "Инструменты";
            // 
            // создатьФайлToolStripMenuItem
            // 
            this.создатьФайлToolStripMenuItem.Name = "создатьФайлToolStripMenuItem";
            this.создатьФайлToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.создатьФайлToolStripMenuItem.Text = "Создать файл";
            // 
            // создатьДиректориюToolStripMenuItem
            // 
            this.создатьДиректориюToolStripMenuItem.Name = "создатьДиректориюToolStripMenuItem";
            this.создатьДиректориюToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.создатьДиректориюToolStripMenuItem.Text = "Создать директорию";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // скопироватьToolStripMenuItem
            // 
            this.скопироватьToolStripMenuItem.Name = "скопироватьToolStripMenuItem";
            this.скопироватьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.скопироватьToolStripMenuItem.Text = "Скопировать";
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            // 
            // переместитьToolStripMenuItem
            // 
            this.переместитьToolStripMenuItem.Name = "переместитьToolStripMenuItem";
            this.переместитьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.переместитьToolStripMenuItem.Text = "Переместить";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.upbtn1);
            this.splitContainer1.Panel1.Controls.Add(this.explorer1);
            this.splitContainer1.Panel1.Controls.Add(this.drivesCB1);
            this.splitContainer1.Panel1.Controls.Add(this.pathTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.upbtn2);
            this.splitContainer1.Panel2.Controls.Add(this.explorer2);
            this.splitContainer1.Panel2.Controls.Add(this.drivesCB2);
            this.splitContainer1.Panel2.Controls.Add(this.pathTextBox2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // upbtn1
            // 
            this.upbtn1.BackgroundImage = global::TotalCommander.Properties.Resources.upArrow;
            this.upbtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upbtn1.Location = new System.Drawing.Point(51, 3);
            this.upbtn1.Name = "upbtn1";
            this.upbtn1.Size = new System.Drawing.Size(26, 21);
            this.upbtn1.TabIndex = 5;
            this.upbtn1.UseVisualStyleBackColor = true;
            this.upbtn1.Click += new System.EventHandler(this.upbtn1_Click);
            // 
            // explorer1
            // 
            this.explorer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.explorer1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.explorer1.HideSelection = false;
            this.explorer1.Location = new System.Drawing.Point(4, 31);
            this.explorer1.Name = "explorer1";
            this.explorer1.Size = new System.Drawing.Size(249, 383);
            this.explorer1.TabIndex = 4;
            this.explorer1.UseCompatibleStateImageBehavior = false;
            this.explorer1.View = System.Windows.Forms.View.SmallIcon;
            this.explorer1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.explorer1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 200;
            // 
            // drivesCB1
            // 
            this.drivesCB1.FormattingEnabled = true;
            this.drivesCB1.Location = new System.Drawing.Point(3, 3);
            this.drivesCB1.Name = "drivesCB1";
            this.drivesCB1.Size = new System.Drawing.Size(46, 21);
            this.drivesCB1.TabIndex = 3;
            // 
            // pathTextBox1
            // 
            this.pathTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox1.Location = new System.Drawing.Point(83, 4);
            this.pathTextBox1.Name = "pathTextBox1";
            this.pathTextBox1.Size = new System.Drawing.Size(170, 20);
            this.pathTextBox1.TabIndex = 0;
            this.pathTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pathTextBox1_KeyPress);
            // 
            // upbtn2
            // 
            this.upbtn2.BackgroundImage = global::TotalCommander.Properties.Resources.upArrow;
            this.upbtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upbtn2.Location = new System.Drawing.Point(67, 3);
            this.upbtn2.Name = "upbtn2";
            this.upbtn2.Size = new System.Drawing.Size(26, 21);
            this.upbtn2.TabIndex = 6;
            this.upbtn2.UseVisualStyleBackColor = true;
            this.upbtn2.Click += new System.EventHandler(this.upbtn2_Click);
            // 
            // explorer2
            // 
            this.explorer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.explorer2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.explorer2.HideSelection = false;
            this.explorer2.Location = new System.Drawing.Point(15, 30);
            this.explorer2.Name = "explorer2";
            this.explorer2.Size = new System.Drawing.Size(503, 383);
            this.explorer2.TabIndex = 5;
            this.explorer2.UseCompatibleStateImageBehavior = false;
            this.explorer2.View = System.Windows.Forms.View.SmallIcon;
            this.explorer2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.explorer2_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 200;
            // 
            // drivesCB2
            // 
            this.drivesCB2.FormattingEnabled = true;
            this.drivesCB2.Location = new System.Drawing.Point(15, 3);
            this.drivesCB2.Name = "drivesCB2";
            this.drivesCB2.Size = new System.Drawing.Size(46, 21);
            this.drivesCB2.TabIndex = 2;
            // 
            // pathTextBox2
            // 
            this.pathTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox2.Location = new System.Drawing.Point(99, 3);
            this.pathTextBox2.Name = "pathTextBox2";
            this.pathTextBox2.Size = new System.Drawing.Size(419, 20);
            this.pathTextBox2.TabIndex = 0;
            this.pathTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pathTextBox2_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Minimal Private";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem иToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьДиректориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скопироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переместитьToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox pathTextBox1;
        private System.Windows.Forms.TextBox pathTextBox2;
        private System.Windows.Forms.ComboBox drivesCB2;
        private System.Windows.Forms.ComboBox drivesCB1;
        private System.Windows.Forms.ListView explorer1;
        private System.Windows.Forms.ListView explorer2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button upbtn1;
        private System.Windows.Forms.Button upbtn2;
    }
}

