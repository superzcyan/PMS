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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `currentmedication`
--

LOCK TABLES `currentmedication` WRITE;
/*!40000 ALTER TABLE `currentmedication` DISABLE KEYS */;
INSERT INTO `currentmedication` VALUES (3,'P2','Biogesic','500','1','Today','Yes');
/*!40000 ALTER TABLE `currentmedication` ENABLE KEYS */;
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
INSERT INTO `healthandwellnessgoals` VALUES ('P1','',''),('P2','',''),('P3','None','None'),('P4','Be fat','Food'),('P5','','');
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
INSERT INTO `medicationhistory` VALUES ('P001','Unirary Tract Infection','Agina(Chest Pain), Asthma, Kidney Stones, Stomach/Peptic Ulcer, Other( Sleepless )','Thyroidectomy, Heart Valve, Gallbladder, Hemorrhoidectomy, Bariatric Surgery, Mastectomy, Other( Peralized )','','',''),('P002','Toothache','Other(    )','Other(    )','','',''),('P003','Toothache','Other(    )','Other(    )','','',''),('P004','Toothache','Other(              )','Thyroidectomy, Heart Valve, Gallbladder, Hemorrhoidectomy, Bariatric Surgery, Mastectomy, Other(              )','','',''),('P1','Unirary Tract Infection','Other(          )','Cataracts, CABG, Heart Valve, Bowel/Stomach Resection, Colonoscopy, Tubal Ligation, Cesarean Section, Other(          )','Tree Nuts, Nuts, Soy','Pancreatic Cancer(M), Colon Cancer(M), Gastrointestinal Disease(M), Lung Cancer(M), Lung Disease(M), Heart Disease(M), Thyroid Disease(P), Diabetes(P), Bleeding Disorder(M), Stroke(P), High Blood Pressure(M)',''),('P2','Toothache','Other(              )','Cataracts, CABG, Heart Valve, Bowel/Stomach Resection, Colonoscopy, Tubal Ligation, Cesarean Section, Other(              )','Tree Nuts, Nuts, Soy','Pancreatic Cancer(M), Colon Cancer(M), Gastrointestinal Disease(M), Lung Cancer(M), Lung Disease(M), Heart Disease(M), Thyroid Disease(P), Diabetes(P), Bleeding Disorder(M), Stroke(P), High Blood Pressure(M)',''),('P3','Noseless','Kidney Disease, Crohn\'s Disease, Anemia, Stomach/Peptic Ulcer, Rheumatic fever, Other(    )','Cataracts, CABG, Heart Valve, Bowel/Stomach Resection, Colonoscopy, Tubal Ligation, Cesarean Section, Other(    )','','',''),('P4','Nothing','Agina(Chest Pain), Asthma, Other(  )','Pacemaker, Heart Valve, Bariatric Surgery, Spinal Surgery, Other(  )','Tree Nuts, Nuts, Soy, Milk','Bleeding Disorder(P), Stroke(P), High Blood Pressure(M)','Reproductive problems, Double Vision, Loss of Vision, Neck pain, Muscle / Joint pains'),('P5','Eargaasm','Kidney Disease, Crohn\'s Disease, Anemia, Stomach/Peptic Ulcer, Rheumatic fever, Other(    )Hypothyroidism, Cancer, Kidney Disease, Stomach/Peptic Ulcer, Other(  )','Cataracts, CABG, Heart Valve, Bowel/Stomach Resection, Colonoscopy, Tubal Ligation, Cesarean Section, Other(    )Cardiac Stents, Bariatric Surgery, Tubal Ligation, Prostate Surgery/Resection, Other(  )','Fish, Tree Nuts, Wheat, Soy, Eggs','','');
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
INSERT INTO `menstrual` VALUES ('P001','','','','','','','','',''),('P002','','','','Irregular','','','','',''),('P003','','','','Irregular','','','','',''),('P004','','','','Irregular','','','','',''),('P1','','','','Irregular','','','','',''),('P2','','','','Regular','1','','','',''),('P3','','','','Irregular','','','','',''),('P4','14','','','Irregular','3','','','',''),('P5','','','','Irregular','','','','','');
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
INSERT INTO `patients` VALUES ('P1','Zcyrel','','Cortejo','Male','Quezon City','July 03, 1990',29,'zcycortejo@gmail.com','09151745313','43434313','Catholic','Elizabeth Patron','097543134','Mother','','','','',''),('P2','Heidi','Patron','Cortejo','Female','Quezon City','January 05, 2000',19,'h@gmail.com','09754313131','64634343','Catholic','Roque Cortejo','09154531545','Father','','','','',''),('P3','Clarisse','Patron','Cortejo','Female','Quezon City','October 03, 2001',17,'cla@gmail.com','09874131354','32132333','Catholic','Roque Cortejo','09875136546','Father','1','','','',''),('P4','Happy','B','Barozo','Female','Antipolo','December 26, 1988',30,'hbb@gmail.com','09753132154','46434578','Iglesia','Tatie Manera','0987843213','Team Lead','5','BPO','BPO','BPO',''),('P5','Clara','C','Benin','Female','Makati','May 19, 1989',30,'cb@gmail.com','098213454','47643313','Catholic','Gabba Santiago','09143154769','Boyfriend','','','','','');
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
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personalandsocialhistory`
--

LOCK TABLES `personalandsocialhistory` WRITE;
/*!40000 ALTER TABLE `personalandsocialhistory` DISABLE KEYS */;
INSERT INTO `personalandsocialhistory` VALUES (31,'P1','Alcohol',NULL,NULL,NULL,NULL),(32,'P1','Tobacco/Cigar',NULL,NULL,NULL,NULL),(33,'P1','Caffeine',NULL,NULL,NULL,NULL),(34,'P1','Drugs',NULL,NULL,NULL,NULL),(35,'P1','Excercise',NULL,NULL,NULL,NULL),(36,'P3','Alcohol','5','5','Beer','5'),(37,'P3','Tobacco/Cigar','3','2','Cigar','3'),(38,'P3','Caffeine','20','5','Coffee','12'),(39,'P3','Drugs','1','1','Paracetamol','1'),(40,'P3','Excercise','0','0','0','0'),(41,'P4','Alcohol','1','2','Beer','3'),(42,'P4','Tobacco/Cigar','1','1','Cigar','5'),(43,'P4','Caffeine','2','1','Coffee',NULL),(44,'P4','Drugs',NULL,NULL,NULL,NULL),(45,'P4','Excercise',NULL,NULL,NULL,NULL),(46,'P5','Alcohol',NULL,NULL,NULL,NULL),(47,'P5','Tobacco/Cigar',NULL,NULL,NULL,NULL),(48,'P5','Caffeine',NULL,NULL,NULL,NULL),(49,'P5','Drugs',NULL,NULL,NULL,NULL),(50,'P5','Excercise',NULL,NULL,NULL,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staffs`
--

LOCK TABLES `staffs` WRITE;
/*!40000 ALTER TABLE `staffs` DISABLE KEYS */;
INSERT INTO `staffs` VALUES (1,'E1','Zcyrel','Patron','Cortejo','Male','zcycortejo@gmail.com','091517422319','000','1990-07-14','Cortejo','Quezon City','admin','qweasd'),(5,'E2','Nami','Cat','Burglar','Female','namiburglar@gmail.com','0999784531','605-6644','2019-09-06','Burglar','Quezon City','Receptionist','qweasd'),(6,'E3','Tony','Tony','Chopper','Male','tonytonychopper@gmail.com','09405478132','701-4310','1990-04-02','Chopper','Drum Island','Doctor','qweasd'),(7,'E4','Tony','Tony','Chopper','Male','tonytonychopper@gmail.com','09655457871','706-4512','1990-04-02','Chopper','tonytonychopper','Nurse','qweasd');
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplements`
--

LOCK TABLES `supplements` WRITE;
/*!40000 ALTER TABLE `supplements` DISABLE KEYS */;
INSERT INTO `supplements` VALUES (3,'P2','Protein Whey','200','3','Yesterday','No');
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `treatments`
--

LOCK TABLES `treatments` WRITE;
/*!40000 ALTER TABLE `treatments` DISABLE KEYS */;
INSERT INTO `treatments` VALUES (2,'P1','Disection','Sleepless','3','Secret mission','Jasper Agustin','09/20/2019'),(3,'P1','Disection','Sleepless','3','Secret mission','Jasper Agustin','09/20/2019');
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

-- Dump completed on 2019-09-21 17:33:27
