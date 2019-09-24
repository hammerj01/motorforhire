-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Sep 14, 2017 at 05:17 PM
-- Server version: 10.1.8-MariaDB
-- PHP Version: 5.5.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `motor4hire`
--

-- --------------------------------------------------------

--
-- Table structure for table `activities`
--

CREATE TABLE `activities` (
  `idactivities` int(10) UNSIGNED NOT NULL,
  `actname` varchar(200) NOT NULL,
  `description` varchar(200) NOT NULL,
  `startdate` datetime NOT NULL,
  `enddate` datetime NOT NULL,
  `organized_by` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `complaints`
--

CREATE TABLE `complaints` (
  `idcompalaints` int(10) UNSIGNED NOT NULL,
  `idmember` int(10) UNSIGNED DEFAULT NULL,
  `complinants` varchar(200) DEFAULT NULL,
  `description` text,
  `datecomplaint` datetime DEFAULT NULL,
  `idmotor` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `idmember` int(10) UNSIGNED NOT NULL,
  `fname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `mname` varchar(2) DEFAULT NULL,
  `address` varchar(200) DEFAULT NULL,
  `barangay` varchar(145) DEFAULT NULL,
  `age` int(10) UNSIGNED DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `licenseno` varchar(45) DEFAULT NULL,
  `expirydate` datetime DEFAULT NULL,
  `bday` datetime DEFAULT NULL,
  `requirements1` varchar(45) DEFAULT NULL,
  `requirements2` varchar(45) DEFAULT NULL,
  `datereg` datetime DEFAULT NULL,
  `status` varchar(45) DEFAULT 'inactive'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`idmember`, `fname`, `lname`, `mname`, `address`, `barangay`, `age`, `gender`, `licenseno`, `expirydate`, `bday`, `requirements1`, `requirements2`, `datereg`, `status`) VALUES
(1, 'nino pio emmauel', '', 'g', 'balilihan', 'balilihan barangay', 27, 'Male', 'li001', '2017-09-13 00:00:00', '1990-09-13 00:00:00', 'barangay clearance', 'police clearance', '2017-09-13 00:00:00', 'Active'),
(2, 'q', '', 'q', 'ww', 'ee', 25, 'Male', 'asd', '2017-09-13 00:00:00', '1992-09-13 00:00:00', 'barangay clearance', 'police clearance', '2017-09-13 00:00:00', 'active'),
(3, 'lerma', '', 'g', 'balilihan 1', 'baarangay balilihan', 25, 'Female', 'qqwe', '2017-09-13 00:00:00', '1992-09-13 00:00:00', 'barangay clearance', 'police clearance', '2017-09-13 00:00:00', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `motor`
--

CREATE TABLE `motor` (
  `idmotor` int(10) UNSIGNED NOT NULL,
  `name` varchar(45) NOT NULL,
  `date_register` datetime NOT NULL,
  `idmember` int(10) UNSIGNED NOT NULL,
  `or_num` varchar(45) NOT NULL,
  `cr_num` varchar(45) NOT NULL,
  `description` varchar(300) NOT NULL,
  `dateofexpiration` datetime NOT NULL,
  `plateNo` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL DEFAULT 'Inactive'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `motor`
--

INSERT INTO `motor` (`idmotor`, `name`, `date_register`, `idmember`, `or_num`, `cr_num`, `description`, `dateofexpiration`, `plateNo`, `status`) VALUES
(1, 'my mothe', '0001-01-01 00:00:00', 3, 'sfs', 'cr', 'assdf', '0001-01-01 00:00:00', 'pp009', 'active');

-- --------------------------------------------------------

--
-- Table structure for table `officers`
--

CREATE TABLE `officers` (
  `idofficers` int(10) UNSIGNED NOT NULL,
  `president` varchar(130) NOT NULL,
  `vice` varchar(130) NOT NULL,
  `secretary` varchar(130) NOT NULL,
  `tresurer` varchar(130) NOT NULL,
  `auditor` varchar(130) NOT NULL,
  `dateelected` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `idpayments` int(10) UNSIGNED NOT NULL,
  `idmember` int(10) UNSIGNED NOT NULL,
  `amount` double(10,2) NOT NULL,
  `datepaid` datetime NOT NULL,
  `fname` varchar(45) NOT NULL,
  `lname` varchar(45) NOT NULL,
  `mname` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`idpayments`, `idmember`, `amount`, `datepaid`, `fname`, `lname`, `mname`) VALUES
(1, 0, 1500.00, '2017-09-12 00:00:00', 'pio emmanuel', '', 'g'),
(2, 0, 1500.00, '2017-09-12 00:00:00', 'pio emmanuel', '', 'g'),
(3, 0, 1500.00, '2017-09-12 00:00:00', 'pio', '', 'G'),
(4, 0, 1500.00, '2017-09-13 00:00:00', 'nino pio emmanuel', '', 'g'),
(5, 1, 1500.00, '2017-09-13 00:00:00', 'nino pio emmauel', '', 'g'),
(6, 3, 1600.00, '2017-09-13 00:00:00', 'lerma', '', 'g'),
(7, 3, 1600.00, '2017-09-13 00:00:00', 'lerma', '', 'g');

-- --------------------------------------------------------

--
-- Table structure for table `sticker`
--

CREATE TABLE `sticker` (
  `idsticker` int(10) UNSIGNED NOT NULL,
  `idmember` int(10) UNSIGNED NOT NULL,
  `stickerNo` varchar(45) NOT NULL,
  `datestart` datetime NOT NULL,
  `mystatus` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `useraccount`
--

CREATE TABLE `useraccount` (
  `iduseraccount` int(10) UNSIGNED NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `usertype` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `useraccount`
--

INSERT INTO `useraccount` (`iduseraccount`, `username`, `password`, `usertype`) VALUES
(1, 'admin', 'YCZdx7/N+fE1TjTX/808EA==', 'Admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `activities`
--
ALTER TABLE `activities`
  ADD PRIMARY KEY (`idactivities`);

--
-- Indexes for table `complaints`
--
ALTER TABLE `complaints`
  ADD PRIMARY KEY (`idcompalaints`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`idmember`);

--
-- Indexes for table `motor`
--
ALTER TABLE `motor`
  ADD PRIMARY KEY (`idmotor`);

--
-- Indexes for table `officers`
--
ALTER TABLE `officers`
  ADD PRIMARY KEY (`idofficers`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`idpayments`);

--
-- Indexes for table `sticker`
--
ALTER TABLE `sticker`
  ADD PRIMARY KEY (`idsticker`);

--
-- Indexes for table `useraccount`
--
ALTER TABLE `useraccount`
  ADD PRIMARY KEY (`iduseraccount`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `activities`
--
ALTER TABLE `activities`
  MODIFY `idactivities` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `complaints`
--
ALTER TABLE `complaints`
  MODIFY `idcompalaints` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `idmember` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `motor`
--
ALTER TABLE `motor`
  MODIFY `idmotor` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `officers`
--
ALTER TABLE `officers`
  MODIFY `idofficers` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `idpayments` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `sticker`
--
ALTER TABLE `sticker`
  MODIFY `idsticker` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `useraccount`
--
ALTER TABLE `useraccount`
  MODIFY `iduseraccount` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
