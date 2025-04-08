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
            txt_nama_produk = new TextBox();
            txt_deskripsi_produk = new TextBox();
            txt_harga_produk = new TextBox();
            txt_gambar_produk = new TextBox();
            reset_btn = new Button();
            save_btn = new Button();
            update_btn = new Button();
            data_produk = new ListView();
            delete_btn = new Button();
            cabang = new Button();
            booking = new Button();
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
            label1.Click += label1_Click;
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
            // txt_nama_produk
            // 
            txt_nama_produk.Location = new Point(179, 29);
            txt_nama_produk.Name = "txt_nama_produk";
            txt_nama_produk.Size = new Size(448, 23);
            txt_nama_produk.TabIndex = 4;
            // 
            // txt_deskripsi_produk
            // 
            txt_deskripsi_produk.Location = new Point(179, 58);
            txt_deskripsi_produk.Name = "txt_deskripsi_produk";
            txt_deskripsi_produk.Size = new Size(448, 23);
            txt_deskripsi_produk.TabIndex = 5;
            // 
            // txt_harga_produk
            // 
            txt_harga_produk.Location = new Point(179, 87);
            txt_harga_produk.Name = "txt_harga_produk";
            txt_harga_produk.Size = new Size(448, 23);
            txt_harga_produk.TabIndex = 6;
            // 
            // txt_gambar_produk
            // 
            txt_gambar_produk.Location = new Point(179, 116);
            txt_gambar_produk.Name = "txt_gambar_produk";
            txt_gambar_produk.Size = new Size(448, 23);
            txt_gambar_produk.TabIndex = 7;
            // 
            // reset_btn
            // 
            reset_btn.Location = new Point(735, 29);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(53, 110);
            reset_btn.TabIndex = 8;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(640, 23);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(80, 35);
            save_btn.TabIndex = 9;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(640, 68);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(80, 35);
            update_btn.TabIndex = 10;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            // 
            // data_produk
            // 
            data_produk.Location = new Point(12, 187);
            data_produk.Name = "data_produk";
            data_produk.Size = new Size(774, 205);
            data_produk.TabIndex = 11;
            data_produk.UseCompatibleStateImageBehavior = false;
            data_produk.View = View.Details;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(640, 112);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(80, 35);
            delete_btn.TabIndex = 12;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            // 
            // cabang
            // 
            cabang.Location = new Point(689, 403);
            cabang.Name = "cabang";
            cabang.Size = new Size(80, 35);
            cabang.TabIndex = 13;
            cabang.Text = "Cabang";
            cabang.UseVisualStyleBackColor = true;
            // 
            // booking
            // 
            booking.Location = new Point(603, 403);
            booking.Name = "booking";
            booking.Size = new Size(80, 35);
            booking.TabIndex = 14;
            booking.Text = "Booking";
            booking.UseVisualStyleBackColor = true;
            // 
            // Motor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(booking);
            Controls.Add(cabang);
            Controls.Add(delete_btn);
            Controls.Add(data_produk);
            Controls.Add(update_btn);
            Controls.Add(save_btn);
            Controls.Add(reset_btn);
            Controls.Add(txt_gambar_produk);
            Controls.Add(txt_harga_produk);
            Controls.Add(txt_deskripsi_produk);
            Controls.Add(txt_nama_produk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Motor";
            Text = "Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_nama_produk;
        private TextBox txt_deskripsi_produk;
        private TextBox txt_harga_produk;
        private TextBox txt_gambar_produk;
        private Button reset_btn;
        private Button save_btn;
        private Button update_btn;
        private ListView data_produk;
        private Button delete_btn;
        private Button cabang;
        private Button booking;

    }
}