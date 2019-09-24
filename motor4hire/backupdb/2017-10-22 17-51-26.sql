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
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `activities`
--

LOCK TABLES `activities` WRITE;
/*!40000 ALTER TABLE `activities` DISABLE KEYS */;
INSERT INTO `activities` VALUES (3,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd'),(4,'ss','ss','2017-09-13 00:00:00','2017-09-13 00:00:00','sdd'),(5,'test','ss','2017-09-27 00:00:00','2017-09-27 00:00:00','bisu'),(7,'my activity','my desscription activity','2017-09-13 00:00:00','2017-09-27 00:00:00','jhun activity'),(9,'tumba priso','larong pang bansa','2017-09-29 00:00:00','2017-09-29 00:00:00','hammerj'),(10,'hammerj','testing','2017-10-17 00:00:00','2017-11-17 00:00:00','jhunsf'),(11,'bbbbbb','bbbbbb','2017-10-17 00:00:00','2017-10-17 00:00:00','bbbbbb'),(12,'assdfdfd','asfsdfsdfsdfs','2017-10-17 00:00:00','2017-10-17 00:00:00','asdafsdfsfs'),(13,'bvbvbvbvbvv','vbvbvbvbvbvbvb','2017-10-17 00:00:00','2017-10-17 00:00:00','vbvbvbbv'),(15,'ddddddddddddddddddddd','ddddddddddd','2017-10-17 00:00:00','2017-10-17 00:00:00','ddddddddd'),(18,'sdfsdfasfdsf','asffsdfas','2017-10-17 00:00:00','2017-10-17 00:00:00','asdfsdfdsf'),(19,'asdfdsfsfdsfdsfd','sdfdfdfdds\r\nsadfsdfsdf','2017-10-18 00:00:00','2017-10-18 00:00:00','dsfdsfsd'),(20,'asfsfsdfdsfsdfdsfsdfdsfdsfdf','fffffffffffffffffffffffffffffffffffffffffffffffffff','2017-10-18 00:00:00','2017-10-18 00:00:00','sdfdsfdfdsfd'),(21,'xzzzxz','zxzxzxzx','2017-10-18 00:00:00','2017-10-18 00:00:00','zxzxzxzx'),(22,'tyuytu6576575','ytu657567','2017-10-18 00:00:00','2017-10-18 00:00:00','yuyt567657657'),(23,'sadsadasd131313131','sdsdfsdfsd','2017-10-18 00:00:00','2017-10-18 00:00:00','fdsfsdfsdfsd'),(24,'ddddddddddddddddd','dddddddddddddddddd','2017-10-18 00:00:00','2017-10-18 00:00:00','ddddddddd'),(25,'hhhhhhh','hhhhh','2017-10-18 00:00:00','2017-10-18 00:00:00','hhhhgggg');
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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `complaints`
--

LOCK TABLES `complaints` WRITE;
/*!40000 ALTER TABLE `complaints` DISABLE KEYS */;
INSERT INTO `complaints` VALUES (1,1,'hammerjjj','gwapong driver','2017-10-18 00:00:00',2),(2,2,'diegos','dimasalang','2017-10-18 00:00:00',2),(3,2,'mamamam','gorgeous gurl\r\ngwapa super','2017-10-18 00:00:00',2),(4,1,'dddddd','zszszszs','2017-10-18 00:00:00',1),(5,3,'Jhunss','hot mama for today','2017-10-18 00:00:00',3),(6,4,'joy','Baho siya ug ilok,kusog manghikap ug paa','2017-09-30 00:00:00',4),(7,0,'hammerj','baho baba ug elok ','2017-10-18 00:00:00',0),(8,0,'sdfssf','sdfsfs','2017-10-18 00:00:00',0),(9,5,'jhun nis','baho ug ilok','2017-10-18 00:00:00',0),(10,5,'dasdasdas','sdasdadadsa','2017-10-18 00:00:00',0),(11,1,'Jomari','gwapo ni siya','2017-10-18 00:00:00',7),(12,1,'voughn','handsome','2017-10-18 00:00:00',7),(13,1,'mamamama','hamamamama','2017-10-18 00:00:00',8);
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
  `status` varchar(45) DEFAULT 'Inactive',
  `img` varchar(300) NOT NULL,
  PRIMARY KEY (`idmember`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `member`
--

LOCK TABLES `member` WRITE;
/*!40000 ALTER TABLE `member` DISABLE KEYS */;
INSERT INTO `member` VALUES (1,'nino pio emmauel','guday','g','balilihan','balilihan barangay',27,'Male','li001','2017-09-13 00:00:00','1990-09-13 00:00:00','barangay clearance','police clearance','2017-09-13 00:00:00','expired',''),(2,'jhun','merto','q','ww','barangayscxxvxcvxxxxc',25,'Male','asd','2022-08-18 00:00:00','1992-09-13 00:00:00','barangay clearance','police clearance','2017-09-13 00:00:00','expired',''),(3,'lerma','clearing','g','balilihan 1','baarangay balilihan',25,'Female','qqwe','2022-08-18 00:00:00','1992-09-13 00:00:00','barangay clearance','police clearance','2017-09-13 00:00:00','expired',''),(4,'s','sdf','y','hjahf68','89jggfgh',31,'Male','gagjtut68','2020-09-28 00:00:00','1986-09-28 00:00:00','barangay clearance','police clearance','2017-09-28 00:00:00','Active',''),(5,'Sheila','Angoy','','Balilihan','Kampake, Balilihan,Bohol',27,'','PL1111','2020-10-22 00:00:00','1990-09-08 00:00:00','barangay clearance','police clearance','2017-10-22 00:00:00','Active','User.png'),(6,'Mary Grace','Perez','L','Balilihan','Catigbian Bohol',27,'Female','99909','2020-10-22 00:00:00','1990-08-29 00:00:00','barangay clearance','police clearance','2017-10-22 00:00:00','Active','IMG_0203.JPG'),(7,'Gaga','Perez','L','Balilihan','Catigbian Bohol',27,'Female','9898','2020-10-22 00:00:00','1990-08-29 00:00:00','barangay clearance','police clearance','2017-10-22 00:00:00','Active','IMG_0203.JPG'),(8,'Meljoy Gingo','Gingo','B','Balilihan','Cantalid',27,'Female','Lft8900','2017-10-01 00:00:00','1990-08-08 00:00:00','barangay clearance','police clearance','2017-10-22 00:00:00','Active','User.png');
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
  `chasisNo` varchar(160) NOT NULL,
  PRIMARY KEY (`idmotor`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `motor`
--

LOCK TABLES `motor` WRITE;
/*!40000 ALTER TABLE `motor` DISABLE KEYS */;
INSERT INTO `motor` VALUES (1,'my mothe','2016-09-13 00:00:00',1,'sfs','cr','my desciprtion','2018-09-29 00:00:00','pp009','active',''),(2,'my mothe ew','2016-09-13 00:00:00',2,'or','cr','black and white','2017-10-03 00:00:00','pp009','active',''),(3,'xrm 125','2017-09-13 00:00:00',3,'or 0001','cr','assdf','2017-09-23 00:00:00','pp009','active',''),(4,'gjaguu9','2017-09-28 00:00:00',4,'f','f','dgd68','2019-09-29 00:00:00','f','active',''),(7,'xrm 130','2017-10-17 00:00:00',1,'00098','000131','black','2018-10-17 00:00:00','336','Active','00011'),(8,'wave 100','2017-10-17 00:00:00',1,'10','11','blue and red','2018-10-17 00:00:00','1100','Active','10101'),(9,'fury','2017-10-17 00:00:00',5,'ddd','eee','black','2016-10-17 00:00:00','rrrr','Active','ccc'),(10,'eeeerewrw','2017-10-17 00:00:00',5,'ddwerwer','erererwerr','dddmwerwer','2017-10-17 00:00:00','dfsdfsrwrwe','Active','dfdfsd'),(11,'xrm yeyehe','2017-10-22 00:00:00',5,'e33ee33','333333eeeeeeeeeeeeeeee','red and black ','2016-10-22 00:00:00','pl33','Active','tgyiuuiii'),(14,'cvcvcvcv','2017-10-22 00:00:00',1,'dsfdsfsdfsdfsd','rewrwer','sdfsdfsd','2016-10-22 00:00:00','sdfsdfsd','Active','fsdfsdf'),(15,'llkkoii','2017-10-22 00:00:00',1,'ccdfddfd','vcvcv','ffffffddd','2016-10-22 00:00:00','vcvxvdfd','Active','ccvvcvdvd'),(18,'test motor','2017-10-22 00:00:00',5,'orccdffdf','cdddff','test descript','2016-10-22 00:00:00','ddsseee','Active','ccdddsss'),(19,'fury red','2017-10-22 00:00:00',5,'sdwqer','sdcfew','testing','2016-10-22 00:00:00','dfgrrt','Active','tesintggw'),(20,'dkdkddkdk','2017-10-22 00:00:00',5,'hihihihih','fifififi','flflffl','2018-10-22 00:00:00','pepepepepep','Active','hohohoho'),(21,'honda wave','2017-10-22 00:00:00',2,'098hshsk','09868','xrm red','2018-10-25 00:00:00','0ijsvh','Active','098hjdhdj');
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
  `endterm` datetime NOT NULL,
  `pres_image` varchar(450) NOT NULL,
  `vice_image` varchar(450) NOT NULL,
  `sec_image` varchar(450) NOT NULL,
  `tres_image` varchar(450) NOT NULL,
  `aud_image` varchar(450) NOT NULL,
  `status` varchar(10) NOT NULL DEFAULT 'Inactive',
  PRIMARY KEY (`idofficers`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `officers`
--

LOCK TABLES `officers` WRITE;
/*!40000 ALTER TABLE `officers` DISABLE KEYS */;
INSERT INTO `officers` VALUES (1,'nino pio emmauel g ','megi b gingo','lerma g clearing','Hipo A Merto','s y sdf','2014-09-14 00:00:00','2015-10-06 00:00:00','User.png','User.png','User.png','User.png','User.png','Inactive'),(2,'nino pio emmauel g guday','nino pio emmauel g guday','nino pio emmauel g guday','nino pio emmauel g guday','nino pio emmauel g guday','2018-09-28 00:00:00','2017-10-06 00:00:00','','','','','','Inactive'),(3,'s y sdf','jhun q merto','lerma g clearing','megi b gingo','nino pio emmauel g guday','2017-09-30 00:00:00','2017-10-06 00:00:00','1.jpg','sea.jpg','User.png','IMG_2995.JPG','IMG_3151.JPG','Inactive'),(4,'s y sdf','jhun q merto','lerma g clearing','nino pio emmauel g guday','megi b gingo','2017-10-06 00:00:00','2018-10-06 00:00:00','Jellyfish.jpg','Desert.jpg','Penguins.jpg','Chrysanthemum.jpg','Hydrangeas.jpg','Inactive'),(5,'nino pio emmauel g guday','jhun q merto','s y sdf','lerma g clearing','Hipo A Merto','2017-10-17 00:00:00','2017-10-17 00:00:00','1.jpg','IMG_3151.JPG','IMG_3151.JPG','IMG_2808.JPG','IMG_3144.JPG','Active'),(6,'jhun q merto','megi b gingo','Hipo A Merto','lerma g clearing','s y sdf','2019-10-19 00:00:00','2020-10-17 00:00:00','12715473_10204190051110678_5203612858805370564_n.jpg','User.png','IMG_0203.JPG','User.png','Tulips.jpg','Active'),(7,'Meljoy Gingo B Gingo','jhun q merto','jhun q merto','lerma g clearing','nino pio emmauel g guday','2018-10-22 00:00:00','2019-10-22 00:00:00','User.png','User.png','User.png','User.png','User.png','Active');
/*!40000 ALTER TABLE `officers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paymentrate`
--

DROP TABLE IF EXISTS `paymentrate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paymentrate` (
  `idpayment` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `rate` double(10,2) NOT NULL,
  PRIMARY KEY (`idpayment`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paymentrate`
--

LOCK TABLES `paymentrate` WRITE;
/*!40000 ALTER TABLE `paymentrate` DISABLE KEYS */;
INSERT INTO `paymentrate` VALUES (1,1600.00);
/*!40000 ALTER TABLE `paymentrate` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
INSERT INTO `payments` VALUES (1,0,1500.00,'2017-09-12 00:00:00','pio emmanuel','','g'),(2,0,1500.00,'2017-09-12 00:00:00','pio emmanuel','','g'),(3,0,1500.00,'2017-09-12 00:00:00','pio','','G'),(4,0,1500.00,'2017-09-13 00:00:00','nino pio emmanuel','','g'),(5,1,1500.00,'2017-09-13 00:00:00','nino pio emmauel','','g'),(6,3,1600.00,'2017-09-13 00:00:00','lerma','','g'),(7,3,1600.00,'2017-09-13 00:00:00','lerma','','g'),(8,4,1500.00,'2017-09-18 00:00:00','q','l','b'),(9,4,3000.00,'2017-09-28 00:00:00','s','sdf','y'),(10,5,3000.00,'2018-09-29 00:00:00','megi','gingo','b'),(11,6,0.00,'2017-10-09 00:00:00','Hipo','Merto','A'),(12,3,1500.00,'2017-10-17 00:00:00','lerma','clearing','g'),(13,3,1500.00,'2017-10-17 00:00:00','lerma','clearing','g'),(14,1,1500.00,'2017-10-17 00:00:00','nino pio emmauel','guday','g'),(15,6,1500.00,'2017-10-17 00:00:00','Hipo','Merto','A'),(16,6,1500.00,'2017-10-17 00:00:00','Hipo','Merto','A'),(17,5,1500.00,'2017-10-22 00:00:00','Sheila','Angoy',''),(18,1,1500.00,'2017-10-22 00:00:00','nino pio emmauel','guday','g'),(19,1,1500.00,'2017-10-22 00:00:00','nino pio emmauel','guday','g'),(20,1,1500.00,'2017-10-22 00:00:00','nino pio emmauel','guday','g'),(21,1,1500.00,'2017-10-22 00:00:00','nino pio emmauel','guday','g'),(22,1,1500.00,'2017-10-22 00:00:00','nino pio emmauel','guday','g'),(23,1,1500.00,'2017-10-22 00:00:00','nino pio emmauel','guday','g'),(24,5,1500.00,'2017-10-22 00:00:00','Sheila','Angoy',''),(25,5,1500.00,'2017-10-22 00:00:00','Sheila','Angoy',''),(26,5,1500.00,'2017-10-22 00:00:00','Sheila','Angoy',''),(27,2,1500.00,'2017-10-22 00:00:00','jhun','merto','q');
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sticker`
--

LOCK TABLES `sticker` WRITE;
/*!40000 ALTER TABLE `sticker` DISABLE KEYS */;
INSERT INTO `sticker` VALUES (1,5,'n84vWQ17n84vWQ','2016-10-22 00:00:00',''),(2,5,'VV3rlQ17VV3rlQ','2018-10-22 00:00:00',''),(3,2,'Q1gP9S17Q1gP9S','2018-10-25 00:00:00','');
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `useraccount`
--

LOCK TABLES `useraccount` WRITE;
/*!40000 ALTER TABLE `useraccount` DISABLE KEYS */;
INSERT INTO `useraccount` VALUES (1,'admin','YCZdx7/N+fE1TjTX/808EA==','Admin'),(2,'president','JEo6IULLMCJE1cauNTbQSw==','President'),(3,'a','/NNfWRStbZsUyc88S5tjhA==','a');
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

-- Dump completed on 2017-10-22 17:51:28
