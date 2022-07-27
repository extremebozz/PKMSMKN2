-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.8.3-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
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

-- Dumping structure for table hotel_smkn2.informasi
CREATE TABLE IF NOT EXISTS `informasi` (
  `nama` text NOT NULL,
  `alamat` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table hotel_smkn2.informasi: ~1 rows (approximately)
/*!40000 ALTER TABLE `informasi` DISABLE KEYS */;
INSERT INTO `informasi` (`nama`, `alamat`) VALUES
	('SMK NEGERI 2 BATAM', 'Jl. Pemuda No. 5 Batam Center, Kota Batam');
/*!40000 ALTER TABLE `informasi` ENABLE KEYS */;

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

-- Dumping data for table hotel_smkn2.kamar_data: ~11 rows (approximately)
/*!40000 ALTER TABLE `kamar_data` DISABLE KEYS */;
INSERT INTO `kamar_data` (`id`, `nomor_kamar`, `jenis_kamar`, `id_transaksi`, `ketersediaan`) VALUES
	(1, 1, 2, 16, 'n'),
	(2, 3, 2, NULL, 'y'),
	(4, 5, 3, NULL, 'y'),
	(5, 6, 5, NULL, 'y'),
	(6, 9, 2, 17, 'n'),
	(7, 10, 3, NULL, 'y'),
	(8, 11, 5, NULL, 'y'),
	(9, 12, 2, 11, 'n'),
	(10, 13, 5, 15, 'n'),
	(11, 14, 3, NULL, 'y');
/*!40000 ALTER TABLE `kamar_data` ENABLE KEYS */;

-- Dumping structure for table hotel_smkn2.kamar_jenis
CREATE TABLE IF NOT EXISTS `kamar_jenis` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `jenis` varchar(50) NOT NULL DEFAULT '',
  `harga` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- Dumping data for table hotel_smkn2.kamar_jenis: ~5 rows (approximately)
/*!40000 ALTER TABLE `kamar_jenis` DISABLE KEYS */;
INSERT INTO `kamar_jenis` (`id`, `jenis`, `harga`) VALUES
	(1, 'extra_bed', 550000),
	(2, 'Standard', 750000),
	(3, 'King', 1250000),
	(5, 'Deluxe', 950000),
	(7, 'Hapus', 2500000);
/*!40000 ALTER TABLE `kamar_jenis` ENABLE KEYS */;

-- Dumping structure for table hotel_smkn2.kamar_transaksi
CREATE TABLE IF NOT EXISTS `kamar_transaksi` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `kamar` int(10) unsigned NOT NULL,
  `extra_bed` int(11) NOT NULL,
  `tanggal_in` date NOT NULL,
  `tanggal_out` date NOT NULL,
  `rate` int(10) unsigned NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

-- Dumping data for table hotel_smkn2.kamar_transaksi: ~12 rows (approximately)
/*!40000 ALTER TABLE `kamar_transaksi` DISABLE KEYS */;
INSERT INTO `kamar_transaksi` (`id`, `kamar`, `extra_bed`, `tanggal_in`, `tanggal_out`, `rate`, `hari`, `check_in`, `check_out`, `nominal`, `nama`, `identitas`, `jenis_kelamin`) VALUES
	(1, 1, 0, '2022-06-12', '2022-06-13', 0, 1, '2022-06-12 00:00:00', '2022-06-13 13:46:09', 0, 'test', '', ''),
	(2, 9, 0, '2022-06-12', '2022-06-13', 0, 1, NULL, '2022-06-13 22:26:56', 0, 'test', '', ''),
	(6, 3, 0, '2022-06-14', '2022-06-15', 0, 1, '2022-06-14 18:04:45', '2022-06-15 15:47:25', 0, 'test', '', ''),
	(7, 3, 0, '2022-06-13', '2022-06-14', 0, 1, NULL, '2022-06-13 22:27:10', 0, 'test', '', ''),
	(8, 3, 0, '2022-06-13', '2022-06-14', 0, 1, '2022-06-13 22:28:45', '2022-06-20 22:30:48', 0, 'test', '', ''),
	(9, 6, 0, '2022-06-15', '2022-06-20', 0, 5, '2022-06-15 20:24:48', '2022-06-28 21:38:10', 90000, 'test', '', ''),
	(10, 14, 0, '2022-06-22', '2022-06-23', 0, 1, '2022-06-22 20:45:46', '2022-06-28 21:15:55', 0, 'test', '', ''),
	(11, 12, 1, '2022-06-23', '2022-06-24', 0, 1, '2022-06-28 22:00:00', NULL, 0, 'test', '6232022', 'LK'),
	(12, 11, 0, '2022-06-28', '2022-06-29', 950000, 1, '2022-06-28 21:25:03', '2022-06-28 21:32:33', 1022000, 'TestRate', '2862022', 'LK'),
	(13, 13, 0, '2022-06-28', '2022-07-03', 950000, 5, '2022-06-28 21:39:07', '2022-06-28 21:56:52', 4762000, 'TestRate10', '2862022', 'LK'),
	(14, 9, 0, '2022-06-29', '2022-07-01', 750000, 2, '2022-06-29 20:05:05', '2022-06-30 10:34:34', 1545000, 'Test', '20', 'LK'),
	(15, 13, 0, '2022-07-14', '2022-07-15', 950000, 1, '2022-07-14 22:13:12', NULL, 950000, 'TestFaktur', 'Faktur', 'LK'),
	(16, 1, 0, '2022-07-27', '2022-07-28', 750000, 1, '2022-07-27 23:45:01', NULL, 750000, 'test', 'test', 'LK'),
	(17, 9, 0, '2022-07-28', '2022-07-29', 750000, 1, '2022-07-28 00:07:22', NULL, 750000, 'asd', 'z', 'LK');
/*!40000 ALTER TABLE `kamar_transaksi` ENABLE KEYS */;

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

-- Dumping data for table hotel_smkn2.menu_data: ~4 rows (approximately)
/*!40000 ALTER TABLE `menu_data` DISABLE KEYS */;
INSERT INTO `menu_data` (`id`, `id_kategori`, `nama`, `harga`) VALUES
	(1, 4, 'Teh Obeng', 6000),
	(2, 1, 'Kentang Goreng', 10000),
	(4, 4, 'Teh O', 5000),
	(5, 5, 'Nasi Goreng', 15000);
/*!40000 ALTER TABLE `menu_data` ENABLE KEYS */;

-- Dumping structure for table hotel_smkn2.menu_kategori
CREATE TABLE IF NOT EXISTS `menu_kategori` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

-- Dumping data for table hotel_smkn2.menu_kategori: ~14 rows (approximately)
/*!40000 ALTER TABLE `menu_kategori` DISABLE KEYS */;
INSERT INTO `menu_kategori` (`id`, `nama`) VALUES
	(1, 'Snack'),
	(4, 'Minuman'),
	(5, 'Daerah Jawa'),
	(6, 'a'),
	(7, 'b'),
	(8, 'c'),
	(9, 'd'),
	(10, 'e'),
	(11, 'f'),
	(12, 'g'),
	(13, 'h'),
	(14, 'i'),
	(15, 'j'),
	(16, 'k');
/*!40000 ALTER TABLE `menu_kategori` ENABLE KEYS */;

-- Dumping structure for procedure hotel_smkn2.pTampilKamar
DELIMITER //
CREATE PROCEDURE `pTampilKamar`()
BEGIN

SELECT KD.id, nomor_kamar, jenis_kamar AS id_jenis_kamar, KJ.jenis AS jenis_kamar, KJ.harga AS harga_kamar, ketersediaan, tanggal_in, tanggal_out, check_in, check_out, id_transaksi, (SELECT id FROM restoran_transaksi AS RT WHERE id_transaksi_kamar = KT.id LIMIT 1) AS pesanan, KT.nama AS nama
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

-- Dumping structure for procedure hotel_smkn2.pTampilReportHotel
DELIMITER //
CREATE PROCEDURE `pTampilReportHotel`(
	IN `Tanggal_Awal` DATE,
	IN `Tanggal_Akhir` DATE
)
BEGIN

SELECT *, (SELECT id FROM restoran_transaksi AS RT WHERE id_transaksi_kamar = KT.id) AS pesanan 
FROM kamar_transaksi AS KT LEFT JOIN kamar_data AS KD ON KT.kamar = kd.nomor_kamar LEFT JOIN kamar_jenis AS KJ ON KD.jenis_kamar = KJ.id 
WHERE check_in BETWEEN Tanggal_Awal AND Tanggal_Akhir AND check_in IS NOT NULL AND check_out IS NOT NULL;

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

-- Dumping structure for procedure hotel_smkn2.pTampilTransaksiHotel
DELIMITER //
CREATE PROCEDURE `pTampilTransaksiHotel`()
BEGIN

SELECT *, (SELECT id FROM restoran_transaksi AS RT WHERE id_transaksi_kamar = KT.id) AS pesanan 
FROM kamar_transaksi AS KT LEFT JOIN kamar_data AS KD ON KT.kamar = kd.nomor_kamar LEFT JOIN kamar_jenis AS KJ ON KD.jenis_kamar = KJ.id 
WHERE check_in IS NOT NULL AND check_out IS NOT NULL;

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
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

-- Dumping data for table hotel_smkn2.restoran_detail: ~22 rows (approximately)
/*!40000 ALTER TABLE `restoran_detail` DISABLE KEYS */;
INSERT INTO `restoran_detail` (`id`, `id_transaksi`, `id_makanan`, `nama`, `qty`, `harga`) VALUES
	(1, 3, 1, 'Teh Obeng', 1, 6000),
	(2, 3, 2, 'Kentang Goreng', 1, 10000),
	(4, 3, 5, 'Nasi Goreng', 1, 15000),
	(5, 4, 5, 'Nasi Goreng', 1, 15000),
	(6, 3, 4, 'Teh O', 1, 5000),
	(7, 5, 5, 'Nasi Goreng', 4, 15000),
	(8, 5, 1, 'Teh Obeng', 2, 6000),
	(9, 4, 1, 'Teh Obeng', 5, 6000),
	(10, 6, 1, 'Teh Obeng', 2, 6000),
	(11, 7, 5, 'Nasi Goreng', 1, 15000),
	(12, 7, 4, 'Teh O', 2, 5000),
	(13, 7, 2, 'Kentang Goreng', 2, 10000),
	(14, 8, 2, 'Kentang Goreng', 1, 10000),
	(15, 8, 5, 'Nasi Goreng', 1, 15000),
	(16, 6, 5, 'Nasi Goreng', 2, 15000),
	(17, 9, 5, 'Nasi Goreng', 1, 15000),
	(18, 9, 4, 'Teh O', 2, 5000),
	(19, 11, 2, 'Kentang Goreng', 1, 10000),
	(20, 12, 5, 'Nasi Goreng', 1, 15000),
	(21, 13, 2, 'Kentang Goreng', 1, 10000),
	(22, 14, 2, 'Kentang Goreng', 1, 10000),
	(23, 15, 1, 'Teh Obeng', 1, 6000);
/*!40000 ALTER TABLE `restoran_detail` ENABLE KEYS */;

-- Dumping structure for table hotel_smkn2.restoran_transaksi
CREATE TABLE IF NOT EXISTS `restoran_transaksi` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_transaksi_kamar` int(10) unsigned DEFAULT NULL,
  `tanggal` date NOT NULL,
  `meja` varchar(255) NOT NULL,
  `total` int(11) NOT NULL DEFAULT 0,
  `aktif` enum('Y','N') NOT NULL DEFAULT 'Y',
  `waiter` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_transaksi_kamar` (`id_transaksi_kamar`),
  CONSTRAINT `FK_transaksi_kamar` FOREIGN KEY (`id_transaksi_kamar`) REFERENCES `kamar_transaksi` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

-- Dumping data for table hotel_smkn2.restoran_transaksi: ~12 rows (approximately)
/*!40000 ALTER TABLE `restoran_transaksi` DISABLE KEYS */;
INSERT INTO `restoran_transaksi` (`id`, `id_transaksi_kamar`, `tanggal`, `meja`, `total`, `aktif`, `waiter`) VALUES
	(3, 10, '2022-06-27', '', 36000, 'N', 'admin'),
	(4, 9, '2022-06-27', '', 45000, 'N', 'admin'),
	(5, 12, '2022-06-28', '', 72000, 'N', 'admin'),
	(6, 13, '2022-06-28', '', 12000, 'N', 'admin'),
	(7, 14, '2022-06-29', '', 45000, 'N', 'admin'),
	(8, 11, '2022-06-30', '', 25000, 'N', 'admin'),
	(9, 15, '2022-07-14', '80', 25000, 'N', 'admin'),
	(11, NULL, '2022-07-18', '10', 10000, 'Y', 'admin'),
	(12, 11, '2022-07-27', '20', 15000, 'Y', 'admin'),
	(13, 17, '2022-07-27', '30', 10000, 'Y', 'admin'),
	(14, 11, '2022-07-27', '40', 10000, 'Y', 'admin'),
	(15, 16, '2022-07-27', '123', 6000, 'Y', 'admin');
/*!40000 ALTER TABLE `restoran_transaksi` ENABLE KEYS */;

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
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;

-- Dumping data for table hotel_smkn2.service_data: ~31 rows (approximately)
/*!40000 ALTER TABLE `service_data` DISABLE KEYS */;
INSERT INTO `service_data` (`id`, `waktu_tambah`, `waktu_selesai`, `kamar`, `aktif`, `note`) VALUES
	(1, '2022-06-20 21:19:04', '2022-06-22 19:57:26', 5, '0', 'Test'),
	(2, '2022-06-20 21:19:32', '2022-06-22 19:57:27', 5, '0', 'Test1'),
	(3, '2022-06-22 19:53:28', '2022-06-22 19:59:43', 5, '0', 'Ditambahkan Oleh Room Service!'),
	(4, '2022-06-22 20:00:17', '2022-06-22 20:04:58', 6, '0', 'Ditambahkan Oleh Room Service!'),
	(5, '2022-06-22 20:05:00', '2022-06-22 20:06:05', 6, '0', 'Ditambahkan Oleh Room Service!'),
	(6, '2022-06-22 20:05:02', '2022-06-22 20:06:14', 11, '0', 'Ditambahkan Oleh Room Service!'),
	(8, '2022-06-22 20:05:35', '2022-06-22 20:05:52', 13, '0', 'Ditambahkan Oleh Room Service!'),
	(9, '2022-06-22 20:05:38', '2022-06-22 20:05:45', 1, '0', 'Ditambahkan Oleh Room Service!'),
	(10, '2022-06-22 20:05:39', '2022-06-22 20:06:09', 3, '0', 'Ditambahkan Oleh Room Service!'),
	(11, '2022-06-22 20:05:40', '2022-06-22 20:06:10', 9, '0', 'Ditambahkan Oleh Room Service!'),
	(12, '2022-06-22 20:05:41', '2022-06-22 20:06:11', 12, '0', 'Ditambahkan Oleh Room Service!'),
	(13, '2022-06-22 20:05:42', '2022-06-22 20:06:12', 5, '0', 'Ditambahkan Oleh Room Service!'),
	(14, '2022-06-22 20:05:43', '2022-06-22 20:06:12', 10, '0', 'Ditambahkan Oleh Room Service!'),
	(15, '2022-06-22 20:05:46', '2022-06-22 20:06:13', 14, '0', 'Ditambahkan Oleh Room Service!'),
	(16, '2022-06-22 20:05:48', '2022-06-22 20:05:49', 1, '0', 'Ditambahkan Oleh Room Service!'),
	(17, '2022-06-22 20:06:07', '2022-06-22 20:06:08', 1, '0', 'Ditambahkan Oleh Room Service!'),
	(18, '2022-06-22 20:07:01', '2022-06-22 20:26:45', 6, '0', 'Ditambahkan Oleh Room Service!'),
	(19, '2022-06-22 20:18:09', '2022-06-22 20:46:14', 14, '0', 'Ditambahkan Oleh Room Service!'),
	(24, '2022-06-22 20:30:39', '2022-06-22 20:31:08', 6, '0', 'Test'),
	(25, '2022-06-22 20:31:03', '2022-06-22 20:32:39', 6, '0', 'Test1'),
	(26, '2022-06-22 20:31:19', '2022-06-22 20:32:57', 6, '0', 'test2'),
	(27, '2022-06-22 20:31:22', NULL, 6, '0', 'test3'),
	(28, '2022-06-22 20:45:51', NULL, 14, '0', 'Food'),
	(29, '2022-06-28 21:37:08', NULL, 6, '0', 'Test'),
	(30, '2022-06-28 21:37:11', NULL, 6, '0', 'Terst1'),
	(31, '2022-06-28 21:37:13', NULL, 6, '0', 'Test2'),
	(32, '2022-06-28 21:56:21', NULL, 13, '0', 'test'),
	(33, '2022-06-28 21:56:24', NULL, 13, '0', 'test1'),
	(34, '2022-06-28 21:56:26', NULL, 13, '0', 'test'),
	(35, '2022-06-29 20:05:24', '2022-06-29 20:05:38', 9, '0', 'Bersih'),
	(36, '2022-06-30 10:31:41', '2022-06-30 10:31:51', 9, '0', 'Ditambahkan Oleh Room Service!');
/*!40000 ALTER TABLE `service_data` ENABLE KEYS */;

-- Dumping structure for table hotel_smkn2.user_data
CREATE TABLE IF NOT EXISTS `user_data` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `jabatan` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Unique` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- Dumping data for table hotel_smkn2.user_data: ~4 rows (approximately)
/*!40000 ALTER TABLE `user_data` DISABLE KEYS */;
INSERT INTO `user_data` (`id`, `username`, `password`, `jabatan`) VALUES
	(1, 'admin', '21232f297a57a5a743894a0e4a801fc3', 'Admin'),
	(2, 'hotel', 'e919c49d5f0cd737285367810a3394d0', 'Hotel'),
	(3, 'restoran', 'CC14E85384657DD30EA6346B942C8A3E', 'Restoran'),
	(8, 'service', 'AAABF0D39951F3E6C3E8A7911DF524C2', 'CS');
/*!40000 ALTER TABLE `user_data` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
