namespace WindowsFormsApp1
{
    partial class FMDI
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
            this.components = new System.ComponentModel.Container();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помещениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.арендаторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.арендаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.окноToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зданиеToolStripMenuItem,
            this.помещениеToolStripMenuItem,
            this.арендаторToolStripMenuItem,
            this.арендаToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // зданиеToolStripMenuItem
            // 
            this.зданиеToolStripMenuItem.Name = "зданиеToolStripMenuItem";
            this.зданиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зданиеToolStripMenuItem.Text = "Здание";
            this.зданиеToolStripMenuItem.Click += new System.EventHandler(this.зданиеToolStripMenuItem_Click);
            // 
            // помещениеToolStripMenuItem
            // 
            this.помещениеToolStripMenuItem.Name = "помещениеToolStripMenuItem";
            this.помещениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.помещениеToolStripMenuItem.Text = "Помещение";
            this.помещениеToolStripMenuItem.Click += new System.EventHandler(this.помещениеToolStripMenuItem_Click);
            // 
            // арендаторToolStripMenuItem
            // 
            this.арендаторToolStripMenuItem.Name = "арендаторToolStripMenuItem";
            this.арендаторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.арендаторToolStripMenuItem.Text = "Арендатор";
            this.арендаторToolStripMenuItem.Click += new System.EventHandler(this.арендаторToolStripMenuItem_Click);
            // 
            // арендаToolStripMenuItem
            // 
            this.арендаToolStripMenuItem.Name = "арендаToolStripMenuItem";
            this.арендаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.арендаToolStripMenuItem.Text = "Аренда";
            this.арендаToolStripMenuItem.Click += new System.EventHandler(this.арендаToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.окноToolStripMenuItem.Text = "Окно";
            // 
            // FMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 528);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FMDI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FMDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помещениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem арендаторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem арендаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
    }
}

