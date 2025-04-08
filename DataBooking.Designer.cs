namespace RentalBike
{
    partial class DataBooking
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
            motor = new Button();
            txt_no_telepon = new TextBox();
            txt_email = new TextBox();
            data_rental = new ListView();
            btn_update = new Button();
            txt_nama = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txt_lama_jam = new TextBox();
            txt_date = new TextBox();
            label2 = new Label();
            label5 = new Label();
            nama_ = new Label();
            status = new ComboBox();
            btn_save = new Button();
            btn_delete = new Button();
            listMotor = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // motor
            // 
            motor.Location = new Point(706, 403);
            motor.Name = "motor";
            motor.Size = new Size(80, 35);
            motor.TabIndex = 45;
            motor.Text = "Motor";
            motor.UseVisualStyleBackColor = true;
            motor.Click += motor_Click;
            // 
            // txt_no_telepon
            // 
            txt_no_telepon.Location = new Point(170, 109);
            txt_no_telepon.Name = "txt_no_telepon";
            txt_no_telepon.Size = new Size(254, 23);
            txt_no_telepon.TabIndex = 44;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(170, 70);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(254, 23);
            txt_email.TabIndex = 43;
            // 
            // data_rental
            // 
            data_rental.Location = new Point(12, 187);
            data_rental.Name = "data_rental";
            data_rental.Size = new Size(774, 205);
            data_rental.TabIndex = 40;
            data_rental.UseCompatibleStateImageBehavior = false;
            data_rental.View = View.Details;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(599, 138);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(80, 35);
            btn_update.TabIndex = 38;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(170, 33);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(254, 23);
            txt_nama.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 72);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 35;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 112);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 34;
            label3.Text = "No Telepon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 33);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 33;
            label1.Text = "Nama Pemesan";
            // 
            // txt_lama_jam
            // 
            txt_lama_jam.Location = new Point(549, 65);
            txt_lama_jam.Name = "txt_lama_jam";
            txt_lama_jam.Size = new Size(231, 23);
            txt_lama_jam.TabIndex = 50;
            // 
            // txt_date
            // 
            txt_date.Location = new Point(549, 32);
            txt_date.Name = "txt_date";
            txt_date.Size = new Size(231, 23);
            txt_date.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 73);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 48;
            label2.Text = "Lama Jam";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 112);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 47;
            label5.Text = "Rental Status";
            // 
            // nama_
            // 
            nama_.AutoSize = true;
            nama_.Location = new Point(450, 36);
            nama_.Name = "nama_";
            nama_.Size = new Size(67, 15);
            nama_.TabIndex = 46;
            nama_.Text = "Rental Date";
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Location = new Point(549, 109);
            status.Name = "status";
            status.Size = new Size(121, 23);
            status.TabIndex = 55;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.DarkGreen;
            btn_save.Location = new Point(488, 138);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(80, 35);
            btn_save.TabIndex = 56;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.IndianRed;
            btn_delete.Location = new Point(700, 138);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(80, 35);
            btn_delete.TabIndex = 57;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // listMotor
            // 
            listMotor.FormattingEnabled = true;
            listMotor.Location = new Point(170, 145);
            listMotor.Name = "listMotor";
            listMotor.Size = new Size(254, 23);
            listMotor.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 148);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 58;
            label6.Text = "Motor";
            // 
            // DataBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listMotor);
            Controls.Add(label6);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Controls.Add(status);
            Controls.Add(txt_lama_jam);
            Controls.Add(txt_date);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(nama_);
            Controls.Add(motor);
            Controls.Add(txt_no_telepon);
            Controls.Add(txt_email);
            Controls.Add(data_rental);
            Controls.Add(btn_update);
            Controls.Add(txt_nama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "DataBooking";
            Text = "Data Booking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button motor;
        private TextBox txt_no_telepon;
        private TextBox txt_email;
        private ListView data_rental;
        private Button btn_update;
        private TextBox txt_nama;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txt_lama_jam;
        private TextBox txt_date;
        private Label label2;
        private Label label5;
        private Label nama_;
        private ComboBox status;
        private Button btn_save;
        private Button btn_delete;
        private ComboBox listMotor;
        private Label label6;
    }
}
