-- MySQL dump 10.16  Distrib 10.1.8-MariaDB, for Win32 (AMD64)
--
-- Host: localhost    Database: motor4hire
-- ------------------------------------------------------
-- Server version	10.1.8-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `activities`
--

DROP TABLE IF EXISTS `activities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `activities` (
  `idactivities` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `actname` varchar(200) NOT NULL,
  `description` varchar(200) NOT NULL,
  `startdate` datetime NOT NULL,
  `enddate` datetime NOT NULL,
  `organized_by` varchar(200) NOT NULL,
  PRIMARY KEY (`idactivities`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `activities`
--

LOCK TABLES `activities` WRITE;
/*!40000 ALTER TABLE `activities` DISABLE KEYS */;
INSERT INTO `activities` VALUES (1,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd'),(2,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd'),(3,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd'),(4,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd'),(5,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd'),(6,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd'),(7,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd'),(8,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd'),(9,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd'),(10,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd'),(11,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd');
/*!40000 ALTER TABLE `activities` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `complaints`
--

DROP TABLE IF EXISTS `complaints`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `complaints` (
  `idcomplaints` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idmember` int(10) unsigned DEFAULT NULL,
  `complinants` varchar(200) DEFAULT NULL,
  `description` text,
  `datecomplaint` datetime DEFAULT NULL,
  `idmotor` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`idcomplaints`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `complaints`
--

LOCK TABLES `complaints` WRITE;
/*!40000 ALTER TABLE `complaints` DISABLE KEYS */;
INSERT INTO `complaints` VALUES (1,1,'','baho siya ug baba, baho ug ilok','2017-09-14 00:00:00',2);
/*!40000 ALTER TABLE `complaints` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `member`
--

DROP TABLE IF EXISTS `member`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `member` (
  `idmember` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `mname` varchar(2) DEFAULT NULL,
  `address` varchar(200) DEFAULT NULL,
  `barangay` varchar(145) DEFAULT NULL,
  `age` int(10) unsigned DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `licenseno` varchar(45) DEFAULT NULL,
  `expirydate` datetime DEFAULT NULL,
  `bday` datetime DEFAULT NULL,
  `requirements1` varchar(45) DEFAULT NULL,
  `requirements2` varchar(45) DEFAULT NULL,
  `datereg` datetime DEFAULT NULL,
  `status` varchar(45) DEFAULT 'inactive',
  PRIMARY KEY (`idmember`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `member`
--

LOCK TABLES `member` WRITE;
/*!40000 ALTER TABLE `member` DISABLE KEYS */;
INSERT INTO `member` VALUES (1,'nino pio emmauel','','g','balilihan','balilihan barangay',27,'Male','li001','2017-09-13 00:00:00','1990-09-13 00:00:00','barangay clearance','police clearance','2017-09-13 00:00:00','Active'),(2,'q','','q','ww','ee',25,'Male','asd','2017-09-13 00:00:00','1992-09-13 00:00:00','barangay clearance','police clearance','2017-09-13 00:00:00','active'),(3,'lerma','','g','balilihan 1','baarangay balilihan',25,'Female','qqwe','2017-09-13 00:00:00','1992-09-13 00:00:00','barangay clearance','police clearance','2017-09-13 00:00:00','Active');
/*!40000 ALTER TABLE `member` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `motor`
--

DROP TABLE IF EXISTS `motor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `motor` (
  `idmotor` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `date_register` datetime NOT NULL,
  `idmember` int(10) unsigned NOT NULL,
  `or_num` varchar(45) NOT NULL,
  `cr_num` varchar(45) NOT NULL,
  `description` varchar(300) NOT NULL,
  `dateofexpiration` datetime NOT NULL,
  `plateNo` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL DEFAULT 'Inactive',
  PRIMARY KEY (`idmotor`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `motor`
--

LOCK TABLES `motor` WRITE;
/*!40000 ALTER TABLE `motor` DISABLE KEYS */;
INSERT INTO `motor` VALUES (1,'my mothe','2017-09-13 00:00:00',3,'sfs','cr','assdf','2017-09-13 00:00:00','pp009','active'),(2,'my mothe ew','2017-09-13 00:00:00',1,'or','cr','assdf','2017-09-13 00:00:00','pp009','active'),(3,'my mothe qw','2017-09-13 00:00:00',2,'or 0001','cr','assdf','2017-09-13 00:00:00','pp009','active');
/*!40000 ALTER TABLE `motor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `officers`
--

DROP TABLE IF EXISTS `officers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `officers` (
  `idofficers` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `president` varchar(130) NOT NULL,
  `vice` varchar(130) NOT NULL,
  `secretary` varchar(130) NOT NULL,
  `tresurer` varchar(130) NOT NULL,
  `auditor` varchar(130) NOT NULL,
  `dateelected` datetime NOT NULL,
  PRIMARY KEY (`idofficers`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `officers`
--

LOCK TABLES `officers` WRITE;
/*!40000 ALTER TABLE `officers` DISABLE KEYS */;
INSERT INTO `officers` VALUES (1,'nino pio emmauel g ','nino pio emmauel g ','nino pio emmauel g ','nino pio emmauel g ','nino pio emmauel g ','2017-09-14 00:00:00');
/*!40000 ALTER TABLE `officers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payments` (
  `idpayments` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idmember` int(10) unsigned NOT NULL,
  `amount` double(10,2) NOT NULL,
  `datepaid` datetime NOT NULL,
  `fname` varchar(45) NOT NULL,
  `lname` varchar(45) NOT NULL,
  `mname` varchar(1) NOT NULL,
  PRIMARY KEY (`idpayments`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
INSERT INTO `payments` VALUES (1,0,1500.00,'2017-09-12 00:00:00','pio emmanuel','','g'),(2,0,1500.00,'2017-09-12 00:00:00','pio emmanuel','','g'),(3,0,1500.00,'2017-09-12 00:00:00','pio','','G'),(4,0,1500.00,'2017-09-13 00:00:00','nino pio emmanuel','','g'),(5,1,1500.00,'2017-09-13 00:00:00','nino pio emmauel','','g'),(6,3,1600.00,'2017-09-13 00:00:00','lerma','','g'),(7,3,1600.00,'2017-09-13 00:00:00','lerma','','g'),(8,4,1500.00,'2017-09-18 00:00:00','q','l','b');
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sticker`
--

DROP TABLE IF EXISTS `sticker`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sticker` (
  `idsticker` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idmember` int(10) unsigned NOT NULL,
  `stickerNo` varchar(45) NOT NULL,
  `datestart` datetime NOT NULL,
  `mystatus` varchar(45) NOT NULL,
  PRIMARY KEY (`idsticker`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sticker`
--

LOCK TABLES `sticker` WRITE;
/*!40000 ALTER TABLE `sticker` DISABLE KEYS */;
/*!40000 ALTER TABLE `sticker` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `useraccount`
--

DROP TABLE IF EXISTS `useraccount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `useraccount` (
  `iduseraccount` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `usertype` varchar(45) NOT NULL,
  PRIMARY KEY (`iduseraccount`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `useraccount`
--

LOCK TABLES `useraccount` WRITE;
/*!40000 ALTER TABLE `useraccount` DISABLE KEYS */;
INSERT INTO `useraccount` VALUES (1,'admin','YCZdx7/N+fE1TjTX/808EA==','Admin'),(2,'president','JEo6IULLMCJE1cauNTbQSw==','President');
/*!40000 ALTER TABLE `useraccount` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-09-20  8:31:23
