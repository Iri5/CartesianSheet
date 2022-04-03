namespace Cartesian_Sheet
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterDataFromTheFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTheResultToAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTheInputToAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_build = new System.Windows.Forms.Button();
            this.textBox_param = new System.Windows.Forms.TextBox();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.textBox_to = new System.Windows.Forms.TextBox();
            this.label_step = new System.Windows.Forms.Label();
            this.label_param = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.enterDataFromTheFileToolStripMenuItem,
            this.saveTheResultToAFileToolStripMenuItem,
            this.saveTheInputToAFileToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.buildToolStripMenuItem.Text = "Build";
            this.buildToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // enterDataFromTheFileToolStripMenuItem
            // 
            this.enterDataFromTheFileToolStripMenuItem.Name = "enterDataFromTheFileToolStripMenuItem";
            this.enterDataFromTheFileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.enterDataFromTheFileToolStripMenuItem.Text = "Enter data from the file";
            this.enterDataFromTheFileToolStripMenuItem.Click += new System.EventHandler(this.enterDataFromTheFileToolStripMenuItem_Click);
            // 
            // saveTheResultToAFileToolStripMenuItem
            // 
            this.saveTheResultToAFileToolStripMenuItem.Name = "saveTheResultToAFileToolStripMenuItem";
            this.saveTheResultToAFileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveTheResultToAFileToolStripMenuItem.Text = "Save the result to a file";
            this.saveTheResultToAFileToolStripMenuItem.Click += new System.EventHandler(this.saveTheResultToAFileToolStripMenuItem_Click);
            // 
            // saveTheInputToAFileToolStripMenuItem
            // 
            this.saveTheInputToAFileToolStripMenuItem.Name = "saveTheInputToAFileToolStripMenuItem";
            this.saveTheInputToAFileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveTheInputToAFileToolStripMenuItem.Text = "Save the input to a file";
            this.saveTheInputToAFileToolStripMenuItem.Click += new System.EventHandler(this.saveTheInputToAFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Cartesian_Sheet";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(6, 19);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Cartesian_Sheet";
            series1.Name = "CartesianSheet";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(507, 377);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 402);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_clear);
            this.groupBox2.Controls.Add(this.button_build);
            this.groupBox2.Controls.Add(this.textBox_param);
            this.groupBox2.Controls.Add(this.textBox_step);
            this.groupBox2.Controls.Add(this.textBox_from);
            this.groupBox2.Controls.Add(this.textBox_to);
            this.groupBox2.Controls.Add(this.label_step);
            this.groupBox2.Controls.Add(this.label_param);
            this.groupBox2.Controls.Add(this.label_from);
            this.groupBox2.Controls.Add(this.label_to);
            this.groupBox2.Location = new System.Drawing.Point(540, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 402);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(6, 255);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(135, 33);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_build
            // 
            this.button_build.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_build.Location = new System.Drawing.Point(6, 204);
            this.button_build.Name = "button_build";
            this.button_build.Size = new System.Drawing.Size(135, 33);
            this.button_build.TabIndex = 2;
            this.button_build.Text = "Build";
            this.button_build.UseVisualStyleBackColor = true;
            this.button_build.Click += new System.EventHandler(this.button_build_Click);
            // 
            // textBox_param
            // 
            this.textBox_param.Location = new System.Drawing.Point(100, 133);
            this.textBox_param.Name = "textBox_param";
            this.textBox_param.Size = new System.Drawing.Size(47, 20);
            this.textBox_param.TabIndex = 1;
            this.textBox_param.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_param_KeyPress);
            // 
            // textBox_step
            // 
            this.textBox_step.Location = new System.Drawing.Point(100, 97);
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(47, 20);
            this.textBox_step.TabIndex = 1;
            this.textBox_step.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_step_KeyPress);
            // 
            // textBox_from
            // 
            this.textBox_from.Location = new System.Drawing.Point(100, 21);
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.Size = new System.Drawing.Size(47, 20);
            this.textBox_from.TabIndex = 1;
            this.textBox_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_from_KeyPress);
            // 
            // textBox_to
            // 
            this.textBox_to.Location = new System.Drawing.Point(100, 58);
            this.textBox_to.Name = "textBox_to";
            this.textBox_to.Size = new System.Drawing.Size(47, 20);
            this.textBox_to.TabIndex = 1;
            this.textBox_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_to_KeyPress);
            // 
            // label_step
            // 
            this.label_step.AutoSize = true;
            this.label_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_step.Location = new System.Drawing.Point(6, 95);
            this.label_step.Name = "label_step";
            this.label_step.Size = new System.Drawing.Size(91, 20);
            this.label_step.TabIndex = 0;
            this.label_step.Text = "H  (step)   =";
            // 
            // label_param
            // 
            this.label_param.AutoSize = true;
            this.label_param.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_param.Location = new System.Drawing.Point(6, 133);
            this.label_param.Name = "label_param";
            this.label_param.Size = new System.Drawing.Size(90, 20);
            this.label_param.TabIndex = 0;
            this.label_param.Text = "a (param) =";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_from.Location = new System.Drawing.Point(6, 16);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(87, 20);
            this.label_from.TabIndex = 0;
            this.label_from.Text = "A  (from)  =";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_to.Location = new System.Drawing.Point(6, 58);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(89, 20);
            this.label_to.TabIndex = 0;
            this.label_to.Text = "B    (to)     =";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(6, 19);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(241, 367);
            this.table.TabIndex = 4;
            this.table.VirtualMode = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.table);
            this.groupBox3.Location = new System.Drawing.Point(693, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 402);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 439);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 79);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(958, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cartesian Sheet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_param;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.TextBox textBox_to;
        private System.Windows.Forms.Label label_step;
        private System.Windows.Forms.Label label_param;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_build;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem enterDataFromTheFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTheResultToAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTheInputToAFileToolStripMenuItem;
    }
}

