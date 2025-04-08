namespace RentalBike
{
    partial class Motor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_nama_motor = new TextBox();
            txt_plat_motor = new TextBox();
            txt_harga_sewa = new TextBox();
            txt_gambar_motor = new TextBox();
            reset_btn = new Button();
            save_btn = new Button();
            update_btn = new Button();
            data_motor = new ListView();
            delete_btn = new Button();
            DataBooking = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 31);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Motor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 120);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = " Gambar Motor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 89);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Harga Sewa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 62);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Plat Motor";
            // 
            // txt_nama_motor
            // 
            txt_nama_motor.Location = new Point(179, 29);
            txt_nama_motor.Name = "txt_nama_motor";
            txt_nama_motor.Size = new Size(448, 23);
            txt_nama_motor.TabIndex = 4;
            // 
            // txt_plat_motor
            // 
            txt_plat_motor.Location = new Point(179, 58);
            txt_plat_motor.Name = "txt_plat_motor";
            txt_plat_motor.Size = new Size(448, 23);
            txt_plat_motor.TabIndex = 5;
            // 
            // txt_harga_sewa
            // 
            txt_harga_sewa.Location = new Point(179, 87);
            txt_harga_sewa.Name = "txt_harga_sewa";
            txt_harga_sewa.Size = new Size(448, 23);
            txt_harga_sewa.TabIndex = 6;
            // 
            // txt_gambar_motor
            // 
            txt_gambar_motor.Location = new Point(179, 116);
            txt_gambar_motor.Name = "txt_gambar_motor";
            txt_gambar_motor.Size = new Size(448, 23);
            txt_gambar_motor.TabIndex = 7;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = SystemColors.ButtonShadow;
            reset_btn.Location = new Point(735, 29);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(53, 110);
            reset_btn.TabIndex = 8;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = false;
            reset_btn.Click += reset_btn_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.DarkGreen;
            save_btn.Location = new Point(640, 23);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(80, 35);
            save_btn.TabIndex = 9;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(640, 68);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(80, 35);
            update_btn.TabIndex = 10;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // data_motor
            // 
            data_motor.Location = new Point(12, 187);
            data_motor.Name = "data_motor";
            data_motor.Size = new Size(774, 205);
            data_motor.TabIndex = 11;
            data_motor.UseCompatibleStateImageBehavior = false;
            data_motor.View = View.Details;
            data_motor.SelectedIndexChanged += data_motor_SelectedIndexChanged;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.IndianRed;
            delete_btn.Location = new Point(640, 112);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(80, 35);
            delete_btn.TabIndex = 12;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // DataBooking
            // 
            DataBooking.Location = new Point(696, 403);
            DataBooking.Name = "DataBooking";
            DataBooking.Size = new Size(90, 35);
            DataBooking.TabIndex = 14;
            DataBooking.Text = "DataBooking";
            DataBooking.UseVisualStyleBackColor = true;
            DataBooking.Click += DataBooking_Click;
            // 
            // Motor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataBooking);
            Controls.Add(delete_btn);
            Controls.Add(data_motor);
            Controls.Add(update_btn);
            Controls.Add(save_btn);
            Controls.Add(reset_btn);
            Controls.Add(txt_gambar_motor);
            Controls.Add(txt_harga_sewa);
            Controls.Add(txt_plat_motor);
            Controls.Add(txt_nama_motor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Motor";
            Text = "Motor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_nama_motor;
        private TextBox txt_plat_motor;
        private TextBox txt_harga_sewa;
        private TextBox txt_gambar_motor;
        private Button reset_btn;
        private Button save_btn;
        private Button update_btn;
        private ListView data_motor;
        private Button delete_btn;
        private Button DataBooking;
    }
}