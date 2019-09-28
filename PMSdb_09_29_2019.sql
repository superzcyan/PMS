-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: pms
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `appointments`
--

DROP TABLE IF EXISTS `appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointments` (
  `count` int(11) NOT NULL AUTO_INCREMENT,
  `patientid` varchar(45) DEFAULT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `surname` varchar(45) DEFAULT NULL,
  `contactno` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `doctor` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  `start` varchar(45) DEFAULT NULL,
  `end` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`count`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointments`
--

LOCK TABLES `appointments` WRITE;
/*!40000 ALTER TABLE `appointments` DISABLE KEYS */;
/*!40000 ALTER TABLE `appointments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `currentmedication`
--

DROP TABLE IF EXISTS `currentmedication`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `currentmedication` (
  `count` int(11) NOT NULL AUTO_INCREMENT,
  `patientid` varchar(45) DEFAULT NULL,
  `brandname` varchar(45) DEFAULT NULL,
  `dosage` varchar(45) DEFAULT NULL,
  `frequency` varchar(45) DEFAULT NULL,
  `lasttaken` varchar(45) DEFAULT NULL,
  `regularly` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`count`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `currentmedication`
--

LOCK TABLES `currentmedication` WRITE;
/*!40000 ALTER TABLE `currentmedication` DISABLE KEYS */;
/*!40000 ALTER TABLE `currentmedication` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `familymedhistory`
--

DROP TABLE IF EXISTS `familymedhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `familymedhistory` (
  `count` int(11) NOT NULL AUTO_INCREMENT,
  `patientid` varchar(45) DEFAULT NULL,
  `type` varchar(45) DEFAULT NULL,
  `paternal` tinyint(4) DEFAULT NULL,
  `maternal` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`count`),
  UNIQUE KEY `count_UNIQUE` (`count`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `familymedhistory`
--

LOCK TABLES `familymedhistory` WRITE;
/*!40000 ALTER TABLE `familymedhistory` DISABLE KEYS */;
INSERT INTO `familymedhistory` VALUES (1,'P1','High Blood',NULL,NULL),(2,'P1','Stroke',NULL,NULL),(3,'P1','Bleed Disorder',NULL,NULL),(4,'P1','Diabetes',NULL,NULL),(5,'P1','Thyroid Disease',NULL,NULL),(6,'P1','Heart Disease',NULL,NULL),(7,'P1','Lung Disease',NULL,NULL),(8,'P1','Lung Cancer',NULL,NULL),(9,'P1','Gastrointestinal Disease',NULL,NULL),(10,'P1','Colon Cancer',NULL,NULL),(11,'P1','Pancreatic Cancer',NULL,NULL),(12,'P1','Kidney Disease',NULL,NULL),(13,'P1','Kidney Cancer',NULL,NULL),(14,'P1','Bladder Disease',NULL,NULL),(15,'P1','Bladder Cancer',NULL,NULL),(16,'P1','Reproductive Disease',NULL,NULL),(17,'P1','Ovarian Cancer',NULL,NULL),(18,'P1','Endometrial Cancer',NULL,NULL),(19,'P1','Cervical Cancer',NULL,NULL),(20,'P1','Osteoporosis',NULL,NULL),(21,'P1','Other Diseases/Cancer',NULL,NULL);
/*!40000 ALTER TABLE `familymedhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `healthandwellnessgoals`
--

DROP TABLE IF EXISTS `healthandwellnessgoals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `healthandwellnessgoals` (
  `patientid` varchar(45) NOT NULL,
  `goals` longtext,
  `challenges` longtext,
  PRIMARY KEY (`patientid`),
  UNIQUE KEY `patientid_UNIQUE` (`patientid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `healthandwellnessgoals`
--

LOCK TABLES `healthandwellnessgoals` WRITE;
/*!40000 ALTER TABLE `healthandwellnessgoals` DISABLE KEYS */;
INSERT INTO `healthandwellnessgoals` VALUES ('P1','','');
/*!40000 ALTER TABLE `healthandwellnessgoals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicationhistory`
--

DROP TABLE IF EXISTS `medicationhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medicationhistory` (
  `patientid` varchar(45) NOT NULL,
  `historyofillness` longtext,
  `medicalhistory` longtext,
  `surgicalhistory` longtext,
  `medicationsuppallergyhistory` longtext,
  `familymedicalhistory` longtext,
  `reviewpast6months` longtext,
  PRIMARY KEY (`patientid`),
  UNIQUE KEY `patiendid_UNIQUE` (`patientid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicationhistory`
--

LOCK TABLES `medicationhistory` WRITE;
/*!40000 ALTER TABLE `medicationhistory` DISABLE KEYS */;
INSERT INTO `medicationhistory` VALUES ('P1','Strechable','Diabetes, Kidney Disease, Kidney Stones, Other(  )','Hysterectomy, Mastectomy, Other(  )','',NULL,'');
/*!40000 ALTER TABLE `medicationhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menstrual`
--

DROP TABLE IF EXISTS `menstrual`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menstrual` (
  `patientid` varchar(45) NOT NULL,
  `ageofmens` varchar(45) DEFAULT NULL,
  `padperday` varchar(45) DEFAULT NULL,
  `daysofmens` varchar(45) DEFAULT NULL,
  `regularity` varchar(45) DEFAULT NULL,
  `menscycle` varchar(45) DEFAULT NULL,
  `agemenopause` varchar(45) DEFAULT NULL,
  `nopregnancies` varchar(45) DEFAULT NULL,
  `nochildren` varchar(45) DEFAULT NULL,
  `nomiscarriage` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`patientid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menstrual`
--

LOCK TABLES `menstrual` WRITE;
/*!40000 ALTER TABLE `menstrual` DISABLE KEYS */;
INSERT INTO `menstrual` VALUES ('P1','','','','','','','','','');
/*!40000 ALTER TABLE `menstrual` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patients`
--

DROP TABLE IF EXISTS `patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patients` (
  `patientid` varchar(45) NOT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `gender` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `birthday` varchar(45) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `mobileno` varchar(45) DEFAULT NULL,
  `homeno` varchar(45) DEFAULT NULL,
  `religion` varchar(45) DEFAULT NULL,
  `emergencyname` varchar(45) DEFAULT NULL,
  `emergencycontact` varchar(45) DEFAULT NULL,
  `emergencyrelationship` varchar(45) DEFAULT NULL,
  `avesleep` varchar(45) DEFAULT NULL,
  `work` varchar(45) DEFAULT NULL,
  `occupation` varchar(45) DEFAULT NULL,
  `prevoccupation` varchar(45) DEFAULT NULL,
  `numberofchildren` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`patientid`),
  UNIQUE KEY `patientid_UNIQUE` (`patientid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients`
--

LOCK TABLES `patients` WRITE;
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` VALUES ('P1','Luffy','D','Monkey','Male','Foosha Village','May 05, 1989',30,'gomugomu@gmail.com','09785132588','43454165','Pirate','Garp D Monkey','09875315698','Grand Father','','','','','');
/*!40000 ALTER TABLE `patients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personalandsocialhistory`
--

DROP TABLE IF EXISTS `personalandsocialhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personalandsocialhistory` (
  `count` int(11) NOT NULL AUTO_INCREMENT,
  `patientid` varchar(45) DEFAULT NULL,
  `activity` varchar(45) DEFAULT NULL,
  `day` varchar(45) DEFAULT NULL,
  `week` varchar(45) DEFAULT NULL,
  `kind` varchar(45) DEFAULT NULL,
  `month` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`count`),
  UNIQUE KEY `count_UNIQUE` (`count`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personalandsocialhistory`
--

LOCK TABLES `personalandsocialhistory` WRITE;
/*!40000 ALTER TABLE `personalandsocialhistory` DISABLE KEYS */;
INSERT INTO `personalandsocialhistory` VALUES (1,'P1','Alcohol',NULL,NULL,NULL,NULL),(2,'P1','Tobacco/Cigar',NULL,NULL,NULL,NULL),(3,'P1','Caffeine',NULL,NULL,NULL,NULL),(4,'P1','Drugs',NULL,NULL,NULL,NULL),(5,'P1','Excercise',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `personalandsocialhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prescriptions`
--

DROP TABLE IF EXISTS `prescriptions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prescriptions` (
  `count` int(11) NOT NULL AUTO_INCREMENT,
  `patientid` varchar(45) DEFAULT NULL,
  `medicine` varchar(45) DEFAULT NULL,
  `dosage` varchar(45) DEFAULT NULL,
  `quantity` varchar(45) DEFAULT NULL,
  `morning` varchar(45) DEFAULT NULL,
  `noon` varchar(45) DEFAULT NULL,
  `afternoon` varchar(45) DEFAULT NULL,
  `other` longtext,
  `doctor` varchar(45) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`count`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prescriptions`
--

LOCK TABLES `prescriptions` WRITE;
/*!40000 ALTER TABLE `prescriptions` DISABLE KEYS */;
/*!40000 ALTER TABLE `prescriptions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schedules`
--

DROP TABLE IF EXISTS `schedules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `schedules` (
  `count` int(11) NOT NULL AUTO_INCREMENT,
  `empid` varchar(45) DEFAULT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `position` varchar(45) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  `starttime` varchar(45) DEFAULT NULL,
  `endtime` varchar(45) DEFAULT NULL,
  `off` varchar(45) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`count`),
  UNIQUE KEY `count_UNIQUE` (`count`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedules`
--

LOCK TABLES `schedules` WRITE;
/*!40000 ALTER TABLE `schedules` DISABLE KEYS */;
/*!40000 ALTER TABLE `schedules` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staffs`
--

DROP TABLE IF EXISTS `staffs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staffs` (
  `count` int(11) NOT NULL AUTO_INCREMENT,
  `empid` varchar(45) DEFAULT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `surname` varchar(45) DEFAULT NULL,
  `gender` varchar(45) DEFAULT NULL,
  `emailaddress` varchar(45) DEFAULT NULL,
  `mobileno` varchar(45) DEFAULT NULL,
  `homeno` varchar(45) DEFAULT NULL,
  `birthday` date DEFAULT NULL,
  `age` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `position` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`count`),
  UNIQUE KEY `count_UNIQUE` (`count`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staffs`
--

LOCK TABLES `staffs` WRITE;
/*!40000 ALTER TABLE `staffs` DISABLE KEYS */;
INSERT INTO `staffs` VALUES (1,'E1','Zcyrel','Patron','Cortejo','Male','zcycortejo@gmail.com','09151742319','4347540','1990-07-03','28','Quezon City','admin','qweasd'),(2,'E2','Tony','Tony','Chopper','Male','tonytonychopper@gmail.com','09875431254','434-1546','1990-12-04','Chopper','Drum Island','Doctor','qweasd'),(3,'E3','Namy','Cat','Burglar','Female','catburglar@gmail.com','0978321545','434-5165','1990-07-03','Burglar','Cocoyasi Village','Receptionist','qweasd'),(4,'E4','Nico','R','Robin','Female','devilchild@gmail.com','09875321548','635-4313','1985-02-06','Robin','Ohara','Nurse','qweasd');
/*!40000 ALTER TABLE `staffs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplements`
--

DROP TABLE IF EXISTS `supplements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplements` (
  `count` int(11) NOT NULL AUTO_INCREMENT,
  `patientid` varchar(45) DEFAULT NULL,
  `brandname` varchar(45) DEFAULT NULL,
  `dosage` varchar(45) DEFAULT NULL,
  `frequency` varchar(45) DEFAULT NULL,
  `lasttaken` varchar(45) DEFAULT NULL,
  `regularly` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`count`),
  UNIQUE KEY `count_UNIQUE` (`count`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplements`
--

LOCK TABLES `supplements` WRITE;
/*!40000 ALTER TABLE `supplements` DISABLE KEYS */;
/*!40000 ALTER TABLE `supplements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `treatments`
--

DROP TABLE IF EXISTS `treatments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `treatments` (
  `count` int(11) NOT NULL AUTO_INCREMENT,
  `patientid` varchar(45) DEFAULT NULL,
  `proceed` varchar(45) DEFAULT NULL,
  `targetillness` varchar(45) DEFAULT NULL,
  `sessions` varchar(45) DEFAULT NULL,
  `result` varchar(45) DEFAULT NULL,
  `doctor` varchar(45) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`count`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `treatments`
--

LOCK TABLES `treatments` WRITE;
/*!40000 ALTER TABLE `treatments` DISABLE KEYS */;
/*!40000 ALTER TABLE `treatments` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-09-29  7:55:15
