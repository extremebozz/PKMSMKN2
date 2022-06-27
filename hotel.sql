-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.5.9-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for hotel_smkn2
CREATE DATABASE IF NOT EXISTS `hotel_smkn2` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `hotel_smkn2`;

-- Dumping structure for table hotel_smkn2.kamar_data
CREATE TABLE IF NOT EXISTS `kamar_data` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nomor_kamar` int(10) unsigned NOT NULL,
  `jenis_kamar` int(10) unsigned NOT NULL,
  `id_transaksi` int(10) unsigned DEFAULT NULL,
  `ketersediaan` enum('y','n') NOT NULL DEFAULT 'y',
  PRIMARY KEY (`id`),
  UNIQUE KEY `Index 2` (`nomor_kamar`),
  KEY `FK_kamar_data_kamar_jenis` (`jenis_kamar`),
  KEY `FK_kamar_data_kamar_transaksi` (`id_transaksi`),
  CONSTRAINT `FK_kamar_data_kamar_jenis` FOREIGN KEY (`jenis_kamar`) REFERENCES `kamar_jenis` (`id`),
  CONSTRAINT `FK_kamar_data_kamar_transaksi` FOREIGN KEY (`id_transaksi`) REFERENCES `kamar_transaksi` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.

-- Dumping structure for table hotel_smkn2.kamar_jenis
CREATE TABLE IF NOT EXISTS `kamar_jenis` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `jenis` varchar(50) NOT NULL DEFAULT '',
  `harga` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.

-- Dumping structure for table hotel_smkn2.kamar_transaksi
CREATE TABLE IF NOT EXISTS `kamar_transaksi` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `kamar` int(10) unsigned NOT NULL,
  `extra_bed` int(11) NOT NULL,
  `tanggal_in` date NOT NULL,
  `tanggal_out` date NOT NULL,
  `hari` int(11) unsigned NOT NULL DEFAULT 0,
  `check_in` datetime DEFAULT NULL,
  `check_out` datetime DEFAULT NULL,
  `nominal` int(10) unsigned NOT NULL DEFAULT 0,
  `nama` varchar(50) NOT NULL,
  `identitas` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_kamar_transaksi_datakamar` (`kamar`),
  CONSTRAINT `FK_kamar_transaksi_datakamar` FOREIGN KEY (`kamar`) REFERENCES `kamar_data` (`nomor_kamar`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.

-- Dumping structure for table hotel_smkn2.menu_data
CREATE TABLE IF NOT EXISTS `menu_data` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_kategori` int(11) DEFAULT NULL,
  `nama` varchar(255) NOT NULL DEFAULT '',
  `harga` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_kategori` (`id_kategori`),
  CONSTRAINT `FK_kategori` FOREIGN KEY (`id_kategori`) REFERENCES `menu_kategori` (`id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.

-- Dumping structure for table hotel_smkn2.menu_kategori
CREATE TABLE IF NOT EXISTS `menu_kategori` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.

-- Dumping structure for procedure hotel_smkn2.pTampilKamar
DELIMITER //
CREATE PROCEDURE `pTampilKamar`()
BEGIN

SELECT KD.id, nomor_kamar, jenis_kamar AS id_jenis_kamar, KJ.jenis AS jenis_kamar, KJ.harga AS harga_kamar, ketersediaan, tanggal_in, tanggal_out, check_in, check_out, id_transaksi, (SELECT id FROM restoran_transaksi AS RT WHERE id_transaksi_kamar = KT.id) AS pesanan
FROM kamar_data AS KD LEFT JOIN kamar_jenis AS KJ ON KJ.id = KD.jenis_kamar LEFT JOIN kamar_transaksi AS KT ON KD.id_transaksi = KT.id
ORDER BY jenis_kamar DESC, nomor_kamar ASC;

END//
DELIMITER ;

-- Dumping structure for procedure hotel_smkn2.pTampilKamarByID
DELIMITER //
CREATE PROCEDURE `pTampilKamarByID`(
	IN `IDKamar` INT
)
BEGIN

SELECT KD.id, nomor_kamar, jenis_kamar AS id_jenis_kamar, KJ.jenis AS jenis_kamar, KJ.harga AS harga_kamar, ketersediaan, tanggal_in, tanggal_out, check_in, check_out 
FROM kamar_data AS KD LEFT JOIN kamar_jenis AS KJ ON KJ.id = KD.jenis_kamar LEFT JOIN kamar_transaksi AS KT ON KD.nomor_kamar = KT.kamar
WHERE KD.id = IDKamar
ORDER BY jenis_kamar;

END//
DELIMITER ;

-- Dumping structure for procedure hotel_smkn2.pTampilService
DELIMITER //
CREATE PROCEDURE `pTampilService`()
BEGIN

SELECT KD.id, nomor_kamar, jenis_kamar AS id_jenis_kamar, KJ.jenis AS jenis_kamar, KJ.harga AS harga_kamar, ketersediaan, tanggal_in, tanggal_out, check_in, check_out, id_transaksi, service.sId, service.note, service.aktif
FROM kamar_data AS KD LEFT JOIN kamar_jenis AS KJ ON KJ.id = KD.jenis_kamar LEFT JOIN kamar_transaksi AS KT ON KD.id_transaksi = KT.id LEFT JOIN (SELECT ID sID, kamar, note, aktif FROM service_data WHERE aktif = 1 GROUP BY kamar) service ON KD.nomor_kamar = service.kamar
ORDER BY jenis_kamar DESC, nomor_kamar ASC;

END//
DELIMITER ;

-- Dumping structure for table hotel_smkn2.restoran_detail
CREATE TABLE IF NOT EXISTS `restoran_detail` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_transaksi` int(10) unsigned NOT NULL,
  `id_makanan` int(10) unsigned DEFAULT NULL,
  `nama` varchar(255) NOT NULL,
  `qty` int(11) NOT NULL,
  `harga` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_transaksi` (`id_transaksi`),
  KEY `FK_makanan` (`id_makanan`),
  CONSTRAINT `FK_makanan` FOREIGN KEY (`id_makanan`) REFERENCES `menu_data` (`id`) ON DELETE SET NULL,
  CONSTRAINT `FK_transaksi` FOREIGN KEY (`id_transaksi`) REFERENCES `restoran_transaksi` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.

-- Dumping structure for table hotel_smkn2.restoran_transaksi
CREATE TABLE IF NOT EXISTS `restoran_transaksi` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_transaksi_kamar` int(10) unsigned NOT NULL,
  `tanggal` date NOT NULL,
  `total` int(11) NOT NULL DEFAULT 0,
  `waiter` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_transaksi_kamar` (`id_transaksi_kamar`),
  CONSTRAINT `FK_transaksi_kamar` FOREIGN KEY (`id_transaksi_kamar`) REFERENCES `kamar_transaksi` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.

-- Dumping structure for table hotel_smkn2.service_data
CREATE TABLE IF NOT EXISTS `service_data` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `waktu_tambah` datetime NOT NULL,
  `waktu_selesai` datetime DEFAULT NULL,
  `kamar` int(10) unsigned NOT NULL DEFAULT 0,
  `aktif` enum('1','0') NOT NULL DEFAULT '1',
  `note` text NOT NULL,
  PRIMARY KEY (`id`),
  KEY `kamar` (`kamar`),
  CONSTRAINT `kamar` FOREIGN KEY (`kamar`) REFERENCES `kamar_data` (`nomor_kamar`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.

-- Dumping structure for table hotel_smkn2.user_data
CREATE TABLE IF NOT EXISTS `user_data` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `jabatan` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Unique` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
