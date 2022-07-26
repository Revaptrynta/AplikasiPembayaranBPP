-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 27 Jan 2022 pada 02.02
-- Versi server: 10.4.22-MariaDB
-- Versi PHP: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `project`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbbiaya`
--

CREATE TABLE `tbbiaya` (
  `id_biaya` varchar(10) NOT NULL,
  `jenjang` varchar(10) NOT NULL,
  `biaya_atribut` int(20) NOT NULL,
  `biaya_esq` int(25) NOT NULL,
  `BPP_Pokok` int(25) NOT NULL,
  `biaya_outbond` int(25) NOT NULL,
  `total_biaya` int(25) NOT NULL,
  `Jumlah_Cicilan` int(11) NOT NULL,
  `Biaya_Cicilan` int(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbbiaya`
--

INSERT INTO `tbbiaya` (`id_biaya`, `jenjang`, `biaya_atribut`, `biaya_esq`, `BPP_Pokok`, `biaya_outbond`, `total_biaya`, `Jumlah_Cicilan`, `Biaya_Cicilan`) VALUES
('IB001', 'D3', 1200000, 150000, 3750000, 150000, 5600000, 2, 2800000),
('IB002', 'D3', 1200000, 150000, 3750000, 150000, 5600000, 4, 1400000),
('IB003', 'D3', 1200000, 150000, 3750000, 150000, 5600000, 1, 5600000),
('IB004', 'S1', 1200000, 150000, 4750000, 150000, 6600000, 2, 3300000),
('IB005', 'S1', 1200000, 150000, 4750000, 150000, 6600000, 4, 1650000),
('IB006', 'S1', 1200000, 150000, 4750000, 150000, 6600000, 6, 1100000),
('IB007', 'S1', 1200000, 150000, 4750000, 150000, 6600000, 1, 6600000),
('IB008', 'S2', 1200000, 150000, 6000000, 150000, 7850000, 2, 3925000),
('IB009', 'S2', 1200000, 150000, 6000000, 150000, 7850000, 4, 1962500),
('IB010', 'S2', 1200000, 150000, 6000000, 150000, 7850000, 1, 7850000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbjenjang`
--

CREATE TABLE `tbjenjang` (
  `id_jenjang` char(10) NOT NULL,
  `jenjang` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbjenjang`
--

INSERT INTO `tbjenjang` (`id_jenjang`, `jenjang`) VALUES
('2019D3', 'D3'),
('2019S1', 'S1'),
('2019S2', 'S2');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbmahasiswa`
--

CREATE TABLE `tbmahasiswa` (
  `nim` char(10) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `Alamat` varchar(100) NOT NULL,
  `Tanggal_lahir` varchar(20) NOT NULL,
  `Jenis_Kelamin` varchar(20) NOT NULL,
  `Agama` varchar(20) NOT NULL,
  `progdi` varchar(20) NOT NULL,
  `kelas` varchar(10) NOT NULL,
  `jenjang` varchar(5) NOT NULL,
  `No_Telp` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbmahasiswa`
--

INSERT INTO `tbmahasiswa` (`nim`, `nama`, `Alamat`, `Tanggal_lahir`, `Jenis_Kelamin`, `Agama`, `progdi`, `kelas`, `jenjang`, `No_Telp`) VALUES
('20192301', 'Aditya', 'Sukapura', '2001-04-28', 'Laki-laki', 'Islam', 'Teknik Mesin', 'Reguler', 'S1', '087654321897'),
('20192302', 'Bella', 'Pondok Kopi Jakarta Timur', '2000-06-14', 'Perempuan', 'Kristen Protestan', 'Sistem Informasi', 'Karyawan', 'D3', '089765432123'),
('20192303', 'Deon ', 'Kemayoran Jakarta Pusat', '1997-11-27', 'Laki-laki', 'Kristen Katholik', 'Teknik Elektro', 'Karyawan', 'S2', '082134567890'),
('20192304', 'Reva', 'Tipar cakung Jakarta Utara', '2000-12-12', 'Perempuan', 'Islam', 'Teknologi Informasi', 'Reguler', 'S1', '089622686423'),
('20192305', 'Putri yanita', 'Cilincing Jarta Utara', '2001-01-16', 'Perempuan', 'Islam', 'Teknik Industri', 'Karyawan', 'S2', '0875465432');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbspp`
--

CREATE TABLE `tbspp` (
  `no_transaksi_KRS` char(10) NOT NULL,
  `Tanggal_Bayar` varchar(20) NOT NULL,
  `nim` varchar(10) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `Total_SKS` varchar(25) NOT NULL,
  `biaya_SKS` int(20) NOT NULL,
  `Total_Biaya_KRS` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbspp`
--

INSERT INTO `tbspp` (`no_transaksi_KRS`, `Tanggal_Bayar`, `nim`, `nama`, `Total_SKS`, `biaya_SKS`, `Total_Biaya_KRS`) VALUES
('S01', '25-January-2022', '20192301', 'Aditya', '24', 150000, '3.600.000'),
('S02', '25-January-2022', '20192302', 'Bella', '22', 175000, '3.850.000'),
('S03', '25-January-2022', '20192303', 'Deon ', '20', 175000, '3.500.000'),
('S04', '27-January-2022', '20192304', 'Reva', '24', 150000, '3.600.000'),
('S05', '27-January-2022', '20192305', 'Putri yanita', '20', 175000, '3.500.000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbuangkampus`
--

CREATE TABLE `tbuangkampus` (
  `nomor_transaksi` char(10) NOT NULL,
  `Tanggal_Bayar` varchar(20) NOT NULL,
  `jenjang` varchar(6) NOT NULL,
  `nim` varchar(10) NOT NULL,
  `id_biaya` varchar(10) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `jumlah_biaya` int(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbuangkampus`
--

INSERT INTO `tbuangkampus` (`nomor_transaksi`, `Tanggal_Bayar`, `jenjang`, `nim`, `id_biaya`, `nama`, `jumlah_biaya`) VALUES
('00001', '25-January-2022', 'S1', '20192301', 'IB005', 'Aditya', 1650000),
('00002', '25-January-2022', 'D3', '20192302', 'IB003', 'Bella', 5600000),
('00003', '25-January-2022', 'S2', '20192303', 'IB008', 'Deon ', 3925000),
('00004', '27-January-2022', 'S1', '20192304', 'IB004', 'Reva', 3300000),
('00005', '27-January-2022', 'S2', '20192305', 'IB010', 'Putri yanita', 7850000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbbiaya`
--
ALTER TABLE `tbbiaya`
  ADD PRIMARY KEY (`id_biaya`);

--
-- Indeks untuk tabel `tbjenjang`
--
ALTER TABLE `tbjenjang`
  ADD PRIMARY KEY (`id_jenjang`);

--
-- Indeks untuk tabel `tbmahasiswa`
--
ALTER TABLE `tbmahasiswa`
  ADD PRIMARY KEY (`nim`);

--
-- Indeks untuk tabel `tbspp`
--
ALTER TABLE `tbspp`
  ADD PRIMARY KEY (`no_transaksi_KRS`);

--
-- Indeks untuk tabel `tbuangkampus`
--
ALTER TABLE `tbuangkampus`
  ADD PRIMARY KEY (`nomor_transaksi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
