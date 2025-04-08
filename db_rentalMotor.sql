-- Buat database terlebih dahulu
CREATE DATABASE rentalMotor;
USE rentalMotor;

-- Tabel motor
CREATE TABLE motor (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama_motor VARCHAR(100) NOT NULL,
    plat_motor VARCHAR(20) NOT NULL UNIQUE,
    harga_sewa DECIMAL(10,2) NOT NULL,
    gambar_motor VARCHAR(255) DEFAULT NULL
);

-- Tabel data_booking
CREATE TABLE data_booking (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama_pemesan VARCHAR(100) NOT NULL,
    email_pemesan VARCHAR(100) NOT NULL,
    noHp_pemesan VARCHAR(20) NOT NULL,
    motor_id INT NOT NULL,
    rental_date DATETIME NOT NULL,
    lama_jam INT NOT NULL,
    rental_status ENUM('diterima', 'digunakan', 'dibatalkan') DEFAULT 'diterima',
    FOREIGN KEY (motor_id) REFERENCES motor(id) ON DELETE CASCADE
);
