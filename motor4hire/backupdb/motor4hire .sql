-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 25, 2017 at 07:19 PM
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
  `enddate` datetime NOT NULL
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
-- Table structure for table `contribution`
--

CREATE TABLE `contribution` (
  `idcontribution` int(10) UNSIGNED NOT NULL,
  `name` varchar(45) NOT NULL,
  `description` varchar(45) NOT NULL,
  `date_contribute` datetime NOT NULL,
  `name_contribute` varchar(200) NOT NULL
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
(1, 'ccc', '', '', '', '', 4, '', '', '2017-08-23 00:00:00', '2017-08-23 00:00:00', '', '', '0001-01-01 00:00:00', 'active'),
(2, 'zXXZ', '', '', '', '', 2323, '', '', '2017-08-23 00:00:00', '2017-08-23 00:00:00', '', '', '0001-01-01 00:00:00', 'inactive'),
(3, 'sdfs', '', '', '', '', 232, '', '', '2017-08-24 00:00:00', '2017-08-24 00:00:00', '', '', '0001-01-01 00:00:00', 'inactive'),
(4, 'sdsd', '', '', '', '', 23, '', '', '2017-08-24 00:00:00', '2017-08-24 00:00:00', '', '', '0001-01-01 00:00:00', 'inactive'),
(5, 'adfs', '', '', '', '', 23, '', '', '2017-08-24 00:00:00', '2017-08-24 00:00:00', '', '', '0001-01-01 00:00:00', 'active'),
(6, 'asdadsadadasdasde1231', '', '', '', '', 23, '', '', '2017-08-24 00:00:00', '2017-08-24 00:00:00', '', '', '0001-01-01 00:00:00', 'inactive'),
(7, 'jhun', '', '', '', '', 34, '', '', '2017-08-24 00:00:00', '2017-08-24 00:00:00', '', '', '0001-01-01 00:00:00', 'inactive'),
(8, 'fd', '', '', '', '', 343, '', '', '2017-08-24 00:00:00', '2017-08-24 00:00:00', '', '', '0001-01-01 00:00:00', 'inactive');

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
  `plateNo` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `motor`
--

INSERT INTO `motor` (`idmotor`, `name`, `date_register`, `idmember`, `or_num`, `cr_num`, `description`, `dateofexpiration`, `plateNo`) VALUES
(1, 'zx', '0001-01-01 00:00:00', 0, 'xzv', 'cvxc', 'cvc', '0001-01-01 00:00:00', 'xvcvvvc'),
(2, 'erwe', '0001-01-01 00:00:00', 0, 'rer', 'fdf', 'dfsf', '0001-01-01 00:00:00', 'werwer'),
(3, '333', '0001-01-01 00:00:00', 0, 'dfdfd', 'sfad', 'we', '0001-01-01 00:00:00', 'saff'),
(4, 'sfsf', '0001-01-01 00:00:00', 0, 'cvcv', 'vx', 'sfvccvc', '0001-01-01 00:00:00', 'xvx'),
(5, 'dddd', '0001-01-01 00:00:00', 0, 'f', 'sf', 'f', '0001-01-01 00:00:00', 'sfs'),
(6, 'aa', '0001-01-01 00:00:00', 6, 'sd', '', 'ss', '0001-01-01 00:00:00', ''),
(7, '', '0001-01-01 00:00:00', 7, '', '', '', '0001-01-01 00:00:00', ''),
(8, '', '0001-01-01 00:00:00', 8, '', '', '', '0001-01-01 00:00:00', '');

-- --------------------------------------------------------

--
-- Table structure for table `officers`
--

CREATE TABLE `officers` (
  `idofficers` int(10) UNSIGNED NOT NULL,
  `idmember` int(10) UNSIGNED NOT NULL,
  `dateofmember` datetime NOT NULL,
  `membertype` varchar(45) NOT NULL
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
(1, 6, 1500.00, '2017-08-25 00:00:00', 'asdadsadadasdasde1231', '', ''),
(2, 4, 1500.00, '2017-08-25 00:00:00', 'sdsd', '', ''),
(3, 1, 1500.00, '2017-08-25 00:00:00', 'ccc', '', ''),
(4, 1, 1500.00, '2017-08-25 00:00:00', 'ccc', '', ''),
(5, 1, 1500.00, '2017-08-25 00:00:00', 'ccc', '', '');

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
-- Indexes for table `contribution`
--
ALTER TABLE `contribution`
  ADD PRIMARY KEY (`idcontribution`);

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
-- AUTO_INCREMENT for table `contribution`
--
ALTER TABLE `contribution`
  MODIFY `idcontribution` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `idmember` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `motor`
--
ALTER TABLE `motor`
  MODIFY `idmotor` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `officers`
--
ALTER TABLE `officers`
  MODIFY `idofficers` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `idpayments` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `useraccount`
--
ALTER TABLE `useraccount`
  MODIFY `iduseraccount` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
