namespace Black_Jack
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
            this.label1 = new System.Windows.Forms.Label();
            this.sum_label = new System.Windows.Forms.Label();
            this.card_box = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.op_cards_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваши средства:";
            // 
            // sum_label
            // 
            this.sum_label.AutoSize = true;
            this.sum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum_label.Location = new System.Drawing.Point(201, 396);
            this.sum_label.Name = "sum_label";
            this.sum_label.Size = new System.Drawing.Size(40, 24);
            this.sum_label.TabIndex = 1;
            this.sum_label.Text = "000";
            // 
            // card_box
            // 
            this.card_box.FormattingEnabled = true;
            this.card_box.Location = new System.Drawing.Point(12, 12);
            this.card_box.Name = "card_box";
            this.card_box.Size = new System.Drawing.Size(203, 290);
            this.card_box.TabIndex = 2;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(221, 12);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Ещё!";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(221, 59);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 23);
            this.stop_btn.TabIndex = 3;
            this.stop_btn.Text = "Всё!";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(582, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество кард оппонента";
            // 
            // op_cards_label
            // 
            this.op_cards_label.AutoSize = true;
            this.op_cards_label.Location = new System.Drawing.Point(746, 50);
            this.op_cards_label.Name = "op_cards_label";
            this.op_cards_label.Size = new System.Drawing.Size(25, 13);
            this.op_cards_label.TabIndex = 5;
            this.op_cards_label.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Black_Jack.Properties.Resources.depositphotos_60642031_stock_photo_poker_table_room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.op_cards_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.card_box);
            this.Controls.Add(this.sum_label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sum_label;
        private System.Windows.Forms.ListBox card_box;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label op_cards_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

