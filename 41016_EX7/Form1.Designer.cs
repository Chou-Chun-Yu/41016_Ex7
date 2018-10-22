namespace _41016_EX7
{

    partial class Menu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        public void InitializeComponent()
        {

            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rb_Bun = new System.Windows.Forms.RadioButton();
            this.rb_Soup = new System.Windows.Forms.RadioButton();
            this.rb_Salad = new System.Windows.Forms.RadioButton();
            this.chk_Starter = new System.Windows.Forms.CheckBox();
            this.chk_Main = new System.Windows.Forms.CheckBox();
            this.chk_Dessert = new System.Windows.Forms.CheckBox();
            this.chk_Beverge = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Check = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rb_Chicken = new System.Windows.Forms.RadioButton();
            this.rb_Noodle = new System.Windows.Forms.RadioButton();
            this.rb_Steak = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rb_Ice = new System.Windows.Forms.RadioButton();
            this.rb_Cheese = new System.Windows.Forms.RadioButton();
            this.rb_Pudding = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.rb_Coffee = new System.Windows.Forms.RadioButton();
            this.rb_Tea = new System.Windows.Forms.RadioButton();
            this.rb_Coke = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Mem_non = new System.Windows.Forms.RadioButton();
            this.Mem_normal = new System.Windows.Forms.RadioButton();
            this.Mem_Gold = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.rb_Bun);
            this.groupBox1.Controls.Add(this.rb_Soup);
            this.groupBox1.Controls.Add(this.rb_Salad);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "數量";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 22);
            this.textBox1.TabIndex = 3;
            // 
            // rb_Bun
            // 
            this.rb_Bun.AutoSize = true;
            this.rb_Bun.Location = new System.Drawing.Point(7, 66);
            this.rb_Bun.Name = "rb_Bun";
            this.rb_Bun.Size = new System.Drawing.Size(73, 16);
            this.rb_Bun.TabIndex = 2;
            this.rb_Bun.Text = "餐包($25)";
            this.rb_Bun.UseVisualStyleBackColor = true;
            this.rb_Bun.CheckedChanged += new System.EventHandler(RadioButton.rb_Bun_CheckedChanged);
            // 
            // rb_Soup
            // 
            this.rb_Soup.AutoSize = true;
            this.rb_Soup.Location = new System.Drawing.Point(7, 44);
            this.rb_Soup.Name = "rb_Soup";
            this.rb_Soup.Size = new System.Drawing.Size(73, 16);
            this.rb_Soup.TabIndex = 1;
            this.rb_Soup.Text = "濃湯($30)";
            this.rb_Soup.UseVisualStyleBackColor = true;
            this.rb_Soup.CheckedChanged += new System.EventHandler(RadioButton.rb_Soup_CheckedChanged);
            // 
            // rb_Salad
            // 
            this.rb_Salad.AutoSize = true;
            this.rb_Salad.Location = new System.Drawing.Point(7, 22);
            this.rb_Salad.Name = "rb_Salad";
            this.rb_Salad.Size = new System.Drawing.Size(73, 16);
            this.rb_Salad.TabIndex = 0;
            this.rb_Salad.Text = "沙拉($35)";
            this.rb_Salad.UseVisualStyleBackColor = true;
            this.rb_Salad.CheckedChanged += new System.EventHandler(RadioButton.rb_Salad_CheckedChanged);
            // 
            // chk_Starter
            // 
            this.chk_Starter.AutoSize = true;
            this.chk_Starter.Location = new System.Drawing.Point(12, 13);
            this.chk_Starter.Name = "chk_Starter";
            this.chk_Starter.Size = new System.Drawing.Size(48, 16);
            this.chk_Starter.TabIndex = 1;
            this.chk_Starter.Text = "前菜";
            this.chk_Starter.UseVisualStyleBackColor = true;
            this.chk_Starter.CheckedChanged += new System.EventHandler(Checkbox.chk_Starter_CheckedChanged);
            // 
            // chk_Main
            // 
            this.chk_Main.AutoSize = true;
            this.chk_Main.Location = new System.Drawing.Point(12, 138);
            this.chk_Main.Name = "chk_Main";
            this.chk_Main.Size = new System.Drawing.Size(48, 16);
            this.chk_Main.TabIndex = 3;
            this.chk_Main.Text = "主餐";
            this.chk_Main.UseVisualStyleBackColor = true;
            this.chk_Main.CheckedChanged += new System.EventHandler(Checkbox.chk_Main_CheckedChanged);
            // 
            // chk_Dessert
            // 
            this.chk_Dessert.AutoSize = true;
            this.chk_Dessert.Location = new System.Drawing.Point(225, 13);
            this.chk_Dessert.Name = "chk_Dessert";
            this.chk_Dessert.Size = new System.Drawing.Size(48, 16);
            this.chk_Dessert.TabIndex = 3;
            this.chk_Dessert.Text = "甜點";
            this.chk_Dessert.UseVisualStyleBackColor = true;
            this.chk_Dessert.CheckedChanged += new System.EventHandler(Checkbox.chk_Dessert_CheckedChanged);
            // 
            // chk_Beverge
            // 
            this.chk_Beverge.AutoSize = true;
            this.chk_Beverge.Location = new System.Drawing.Point(225, 138);
            this.chk_Beverge.Name = "chk_Beverge";
            this.chk_Beverge.Size = new System.Drawing.Size(48, 16);
            this.chk_Beverge.TabIndex = 3;
            this.chk_Beverge.Text = "飲料";
            this.chk_Beverge.UseVisualStyleBackColor = true;
            this.chk_Beverge.CheckedChanged += new System.EventHandler(Checkbox.chk_Beverge_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(457, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bt_Check
            // 
            this.bt_Check.Location = new System.Drawing.Point(464, 248);
            this.bt_Check.Name = "bt_Check";
            this.bt_Check.Size = new System.Drawing.Size(75, 23);
            this.bt_Check.TabIndex = 5;
            this.bt_Check.Text = "結帳";
            this.bt_Check.UseVisualStyleBackColor = true;
            this.bt_Check.Click += new System.EventHandler(this.bt_Check_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.rb_Chicken);
            this.groupBox2.Controls.Add(this.rb_Noodle);
            this.groupBox2.Controls.Add(this.rb_Steak);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 97);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "數量";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 22);
            this.textBox2.TabIndex = 3;
            // 
            // rb_Chicken
            // 
            this.rb_Chicken.AutoSize = true;
            this.rb_Chicken.Location = new System.Drawing.Point(7, 66);
            this.rb_Chicken.Name = "rb_Chicken";
            this.rb_Chicken.Size = new System.Drawing.Size(91, 16);
            this.rb_Chicken.TabIndex = 2;
            this.rb_Chicken.TabStop = true;
            this.rb_Chicken.Text = "雞腿排($125)";
            this.rb_Chicken.UseVisualStyleBackColor = true;
            this.rb_Chicken.CheckedChanged += new System.EventHandler(RadioButton.rb_Chicken_CheckedChanged);
            // 
            // rb_Noodle
            // 
            this.rb_Noodle.AutoSize = true;
            this.rb_Noodle.Location = new System.Drawing.Point(7, 44);
            this.rb_Noodle.Name = "rb_Noodle";
            this.rb_Noodle.Size = new System.Drawing.Size(103, 16);
            this.rb_Noodle.TabIndex = 1;
            this.rb_Noodle.TabStop = true;
            this.rb_Noodle.Text = "義大利麵($175)";
            this.rb_Noodle.UseVisualStyleBackColor = true;
            this.rb_Noodle.CheckedChanged += new System.EventHandler(RadioButton.rb_Noodle_CheckedChanged);
            // 
            // rb_Steak
            // 
            this.rb_Steak.AutoSize = true;
            this.rb_Steak.Location = new System.Drawing.Point(7, 22);
            this.rb_Steak.Name = "rb_Steak";
            this.rb_Steak.Size = new System.Drawing.Size(79, 16);
            this.rb_Steak.TabIndex = 0;
            this.rb_Steak.TabStop = true;
            this.rb_Steak.Text = "牛排($150)";
            this.rb_Steak.UseVisualStyleBackColor = true;
            this.rb_Steak.CheckedChanged += new System.EventHandler(RadioButton.rb_Steak_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.rb_Ice);
            this.groupBox3.Controls.Add(this.rb_Cheese);
            this.groupBox3.Controls.Add(this.rb_Pudding);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(225, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 97);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "數量";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 22);
            this.textBox3.TabIndex = 3;
            // 
            // rb_Ice
            // 
            this.rb_Ice.AutoSize = true;
            this.rb_Ice.Location = new System.Drawing.Point(7, 66);
            this.rb_Ice.Name = "rb_Ice";
            this.rb_Ice.Size = new System.Drawing.Size(85, 16);
            this.rb_Ice.TabIndex = 2;
            this.rb_Ice.TabStop = true;
            this.rb_Ice.Text = "冰淇淋($25)";
            this.rb_Ice.UseVisualStyleBackColor = true;
            this.rb_Ice.CheckedChanged += new System.EventHandler(RadioButton.rb_Ice_CheckedChanged);
            // 
            // rb_Cheese
            // 
            this.rb_Cheese.AutoSize = true;
            this.rb_Cheese.Location = new System.Drawing.Point(7, 44);
            this.rb_Cheese.Name = "rb_Cheese";
            this.rb_Cheese.Size = new System.Drawing.Size(73, 16);
            this.rb_Cheese.TabIndex = 1;
            this.rb_Cheese.TabStop = true;
            this.rb_Cheese.Text = "奶酪($20)";
            this.rb_Cheese.UseVisualStyleBackColor = true;
            this.rb_Cheese.CheckedChanged += new System.EventHandler(RadioButton.rb_Cheese_CheckedChanged);
            // 
            // rb_Pudding
            // 
            this.rb_Pudding.AutoSize = true;
            this.rb_Pudding.Location = new System.Drawing.Point(7, 22);
            this.rb_Pudding.Name = "rb_Pudding";
            this.rb_Pudding.Size = new System.Drawing.Size(73, 16);
            this.rb_Pudding.TabIndex = 0;
            this.rb_Pudding.TabStop = true;
            this.rb_Pudding.Text = "布丁($15)";
            this.rb_Pudding.UseVisualStyleBackColor = true;
            this.rb_Pudding.CheckedChanged += new System.EventHandler(RadioButton.rb_Pudding_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.rb_Coffee);
            this.groupBox4.Controls.Add(this.rb_Tea);
            this.groupBox4.Controls.Add(this.rb_Coke);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(225, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 97);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "數量";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(107, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 22);
            this.textBox4.TabIndex = 3;
            // 
            // rb_Coffee
            // 
            this.rb_Coffee.AutoSize = true;
            this.rb_Coffee.Location = new System.Drawing.Point(7, 66);
            this.rb_Coffee.Name = "rb_Coffee";
            this.rb_Coffee.Size = new System.Drawing.Size(73, 16);
            this.rb_Coffee.TabIndex = 2;
            this.rb_Coffee.TabStop = true;
            this.rb_Coffee.Text = "咖啡($35)";
            this.rb_Coffee.UseVisualStyleBackColor = true;
            this.rb_Coffee.CheckedChanged += new System.EventHandler(RadioButton.rb_Coffee_CheckedChanged);
            // 
            // rb_Tea
            // 
            this.rb_Tea.AutoSize = true;
            this.rb_Tea.Location = new System.Drawing.Point(7, 44);
            this.rb_Tea.Name = "rb_Tea";
            this.rb_Tea.Size = new System.Drawing.Size(73, 16);
            this.rb_Tea.TabIndex = 1;
            this.rb_Tea.TabStop = true;
            this.rb_Tea.Text = "紅茶($25)";
            this.rb_Tea.UseVisualStyleBackColor = true;
            this.rb_Tea.CheckedChanged += new System.EventHandler(RadioButton.rb_Tea_CheckedChanged);
            // 
            // rb_Coke
            // 
            this.rb_Coke.AutoSize = true;
            this.rb_Coke.Location = new System.Drawing.Point(7, 22);
            this.rb_Coke.Name = "rb_Coke";
            this.rb_Coke.Size = new System.Drawing.Size(73, 16);
            this.rb_Coke.TabIndex = 0;
            this.rb_Coke.TabStop = true;
            this.rb_Coke.Text = "可樂($30)";
            this.rb_Coke.UseVisualStyleBackColor = true;
            this.rb_Coke.CheckedChanged += new System.EventHandler(RadioButton.rb_Coke_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Mem_non);
            this.groupBox5.Controls.Add(this.Mem_normal);
            this.groupBox5.Controls.Add(this.Mem_Gold);
            this.groupBox5.Location = new System.Drawing.Point(457, 145);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(103, 97);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            // 
            // Mem_non
            // 
            this.Mem_non.AutoSize = true;
            this.Mem_non.Location = new System.Drawing.Point(7, 66);
            this.Mem_non.Name = "Mem_non";
            this.Mem_non.Size = new System.Drawing.Size(59, 16);
            this.Mem_non.TabIndex = 2;
            this.Mem_non.TabStop = true;
            this.Mem_non.Text = "非會員";
            this.Mem_non.UseVisualStyleBackColor = true;
            // 
            // Mem_normal
            // 
            this.Mem_normal.AutoSize = true;
            this.Mem_normal.Location = new System.Drawing.Point(7, 44);
            this.Mem_normal.Name = "Mem_normal";
            this.Mem_normal.Size = new System.Drawing.Size(47, 16);
            this.Mem_normal.TabIndex = 1;
            this.Mem_normal.TabStop = true;
            this.Mem_normal.Text = "普卡";
            this.Mem_normal.UseVisualStyleBackColor = true;
            // 
            // Mem_Gold
            // 
            this.Mem_Gold.AutoSize = true;
            this.Mem_Gold.Location = new System.Drawing.Point(7, 22);
            this.Mem_Gold.Name = "Mem_Gold";
            this.Mem_Gold.Size = new System.Drawing.Size(47, 16);
            this.Mem_Gold.TabIndex = 0;
            this.Mem_Gold.TabStop = true;
            this.Mem_Gold.Text = "金卡";
            this.Mem_Gold.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 278);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_Check);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chk_Beverge);
            this.Controls.Add(this.chk_Dessert);
            this.Controls.Add(this.chk_Main);
            this.Controls.Add(this.chk_Starter);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu";
            this.Text = "北大西餐廳";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.RadioButton rb_Bun;
        internal System.Windows.Forms.CheckBox chk_Main;
        internal System.Windows.Forms.CheckBox chk_Dessert;
        internal System.Windows.Forms.CheckBox chk_Beverge;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button bt_Check;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.RadioButton rb_Chicken;
        internal System.Windows.Forms.RadioButton rb_Noodle;
        internal System.Windows.Forms.RadioButton rb_Steak;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.RadioButton rb_Ice;
        internal System.Windows.Forms.RadioButton rb_Cheese;
        internal System.Windows.Forms.RadioButton rb_Pudding;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox textBox4;
        internal System.Windows.Forms.RadioButton rb_Coffee;
        internal System.Windows.Forms.RadioButton rb_Tea;
        internal System.Windows.Forms.RadioButton rb_Coke;
        internal System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.RadioButton Mem_non;
        internal System.Windows.Forms.RadioButton Mem_normal;
        internal System.Windows.Forms.RadioButton Mem_Gold;
        internal System.Windows.Forms.CheckBox chk_Starter;
        internal System.Windows.Forms.RadioButton rb_Soup;
        internal System.Windows.Forms.RadioButton rb_Salad;
    }
}

