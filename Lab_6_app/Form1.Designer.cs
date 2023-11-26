namespace Lab_6_app
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
            this.init_data = new System.Windows.Forms.ComboBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.lr = new System.Windows.Forms.Label();
            this.tb_1_1 = new System.Windows.Forms.TextBox();
            this.tb_2_1 = new System.Windows.Forms.TextBox();
            this.tb_1_2 = new System.Windows.Forms.TextBox();
            this.tb_2_2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.cb_find = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // init_data
            // 
            this.init_data.FormattingEnabled = true;
            this.init_data.Items.AddRange(new object[] {
            "Координатами центру і радіусом",
            "Діаметром",
            "Координатами центру і точки на колі"});
            this.init_data.Location = new System.Drawing.Point(13, 13);
            this.init_data.Name = "init_data";
            this.init_data.Size = new System.Drawing.Size(264, 24);
            this.init_data.TabIndex = 0;
            this.init_data.SelectedIndexChanged += new System.EventHandler(this.init_data_SelectedIndexChanged);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(316, 16);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(71, 26);
            this.l1.TabIndex = 1;
            this.l1.Text = "label1";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(316, 80);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(71, 26);
            this.l2.TabIndex = 2;
            this.l2.Text = "label2";
            // 
            // lr
            // 
            this.lr.AutoSize = true;
            this.lr.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lr.Location = new System.Drawing.Point(316, 153);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(76, 26);
            this.lr.TabIndex = 4;
            this.lr.Text = "Result";
            // 
            // tb_1_1
            // 
            this.tb_1_1.Location = new System.Drawing.Point(321, 45);
            this.tb_1_1.Name = "tb_1_1";
            this.tb_1_1.Size = new System.Drawing.Size(100, 22);
            this.tb_1_1.TabIndex = 5;
            this.tb_1_1.TextChanged += new System.EventHandler(this.tb_1_1_TextChanged);
            // 
            // tb_2_1
            // 
            this.tb_2_1.Location = new System.Drawing.Point(321, 109);
            this.tb_2_1.Name = "tb_2_1";
            this.tb_2_1.Size = new System.Drawing.Size(100, 22);
            this.tb_2_1.TabIndex = 6;
            this.tb_2_1.TextChanged += new System.EventHandler(this.tb_2_1_TextChanged);
            // 
            // tb_1_2
            // 
            this.tb_1_2.Location = new System.Drawing.Point(428, 44);
            this.tb_1_2.Name = "tb_1_2";
            this.tb_1_2.Size = new System.Drawing.Size(100, 22);
            this.tb_1_2.TabIndex = 9;
            this.tb_1_2.TextChanged += new System.EventHandler(this.tb_1_2_TextChanged);
            // 
            // tb_2_2
            // 
            this.tb_2_2.Location = new System.Drawing.Point(428, 109);
            this.tb_2_2.Name = "tb_2_2";
            this.tb_2_2.Size = new System.Drawing.Size(100, 22);
            this.tb_2_2.TabIndex = 10;
            this.tb_2_2.TextChanged += new System.EventHandler(this.tb_2_2_TextChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(316, 179);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(71, 26);
            this.result.TabIndex = 11;
            this.result.Text = "label5";
            // 
            // cb_find
            // 
            this.cb_find.FormattingEnabled = true;
            this.cb_find.Items.AddRange(new object[] {
            "Площа",
            "Довжина",
            "Об\'єм"});
            this.cb_find.Location = new System.Drawing.Point(13, 42);
            this.cb_find.Name = "cb_find";
            this.cb_find.Size = new System.Drawing.Size(264, 24);
            this.cb_find.TabIndex = 12;
            this.cb_find.SelectedIndexChanged += new System.EventHandler(this.cb_find_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 215);
            this.Controls.Add(this.cb_find);
            this.Controls.Add(this.result);
            this.Controls.Add(this.tb_2_2);
            this.Controls.Add(this.tb_1_2);
            this.Controls.Add(this.tb_2_1);
            this.Controls.Add(this.tb_1_1);
            this.Controls.Add(this.lr);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.init_data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox init_data;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label lr;
        private System.Windows.Forms.TextBox tb_1_1;
        private System.Windows.Forms.TextBox tb_2_1;
        private System.Windows.Forms.TextBox tb_1_2;
        private System.Windows.Forms.TextBox tb_2_2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ComboBox cb_find;
    }
}

