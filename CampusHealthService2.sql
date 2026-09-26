-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: campushealthservice
-- ------------------------------------------------------
-- Server version	8.0.42

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
-- Table structure for table `appointment_history`
--

DROP TABLE IF EXISTS `appointment_history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointment_history` (
  `History_ID` int NOT NULL AUTO_INCREMENT,
  `Appointment_ID` int NOT NULL,
  `Action_Type` varchar(50) NOT NULL,
  `Action_Date` datetime DEFAULT CURRENT_TIMESTAMP,
  `Created_By` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`History_ID`),
  KEY `Appointment_ID` (`Appointment_ID`),
  CONSTRAINT `appointment_history_ibfk_1` FOREIGN KEY (`Appointment_ID`) REFERENCES `appointments` (`Appointment_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointment_history`
--

LOCK TABLES `appointment_history` WRITE;
/*!40000 ALTER TABLE `appointment_history` DISABLE KEYS */;
INSERT INTO `appointment_history` VALUES (1,1,'BOOKED','2026-09-14 10:04:45','Reception'),(2,2,'BOOKED','2026-09-14 10:16:55','Reception'),(3,3,'BOOKED','2026-09-14 11:47:04','Reception'),(4,4,'BOOKED','2026-09-19 05:39:16','Reception'),(5,1,'RESCHEDULED','2026-09-19 06:47:34','Reception'),(6,1,'CANCELLED','2026-09-19 07:39:57','Reception'),(7,5,'CHECKED IN','2026-09-19 09:12:11','Receptionist'),(8,6,'CHECKED IN','2026-09-19 09:15:20','Receptionist'),(9,4,'RESCHEDULED','2026-09-19 09:52:40','Receptionist'),(10,7,'CHECKED IN','2026-09-19 09:52:40','Receptionist'),(11,8,'BOOKED','2026-09-19 12:01:54','Reception'),(12,8,'RESCHEDULED','2026-09-19 12:02:36','Receptionist'),(13,9,'CHECKED IN','2026-09-19 12:02:36','Receptionist'),(14,8,'RESCHEDULED','2026-09-19 13:09:40','Receptionist'),(15,10,'CHECKED IN','2026-09-19 13:09:40','Receptionist'),(16,5,'COMPLETED','2026-09-19 19:12:06','Nurse/Doctor'),(17,3,'COMPLETED','2026-09-20 09:16:06','Nurse/Doctor'),(18,6,'COMPLETED','2026-09-20 09:16:27','Nurse/Doctor'),(19,7,'COMPLETED','2026-09-20 09:16:43','Nurse/Doctor'),(20,9,'COMPLETED','2026-09-20 09:16:54','Nurse/Doctor'),(21,10,'COMPLETED','2026-09-20 09:17:06','Nurse/Doctor'),(22,8,'CHECKED IN','2026-09-20 09:19:55','Nurse/Doctor'),(23,8,'FOLLOW-UP SCHEDULED','2026-09-20 09:45:06','Nurse/Doctor'),(24,11,'BOOKED','2026-09-21 13:30:40','Receptionist'),(25,4,'CANCELLED','2026-09-21 13:48:33','Reception');
/*!40000 ALTER TABLE `appointment_history` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointment_slots`
--

DROP TABLE IF EXISTS `appointment_slots`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointment_slots` (
  `Slot_ID` int NOT NULL AUTO_INCREMENT,
  `Slot_date` date DEFAULT NULL,
  `Services` varchar(50) DEFAULT NULL,
  `Start_Time` time DEFAULT NULL,
  `End_Time` time DEFAULT NULL,
  `Created_by` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Slot_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointment_slots`
--

LOCK TABLES `appointment_slots` WRITE;
/*!40000 ALTER TABLE `appointment_slots` DISABLE KEYS */;
INSERT INTO `appointment_slots` VALUES (1,'2026-09-14','General Consultation (e.g Flu, cold, cough, fever)','08:00:00','09:00:00','Reception'),(2,'2026-09-14','Minor Illness Treatment (e.g. Flu, Headache)','08:00:00','09:00:00','Reception'),(3,'2026-09-15','Medical Check (e.g. TB, HIV)','11:00:00','12:00:00','Reception'),(4,'2026-09-20','General Consultation (e.g Flu, cold, cough, fever)','10:00:00','11:00:00','Reception'),(5,'2026-09-20','General Consultation (e.g Flu, cold, cough, fever)','13:00:00','14:00:00','Reception'),(6,'2026-09-19','Emergency / Urgent Care','09:11:48','11:11:48','Receptionist'),(7,'2026-09-20','Emergency / Urgent Care','09:14:57','11:14:57','Receptionist'),(8,'2026-09-20','Emergency / Urgent Care','09:52:17','11:52:17','Receptionist'),(9,'2026-09-19','Wound Care / Dressing','13:00:00','14:00:00','Reception'),(10,'2026-09-19','Wound Care / Dressing','14:00:00','15:00:00','Receptionist'),(11,'2026-09-19','Emergency / Urgent Care','12:02:08','14:02:08','Receptionist'),(12,'2026-09-19','Wound Care / Dressing','15:00:00','16:00:00','Receptionist'),(13,'2026-09-19','Emergency / Urgent Care','13:08:47','15:08:47','Receptionist'),(14,'2026-09-21','Mental Health Consultation (e.g. Stress, Anxiety)','14:00:00','15:00:00','Receptionist');
/*!40000 ALTER TABLE `appointment_slots` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointments`
--

DROP TABLE IF EXISTS `appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointments` (
  `Appointment_ID` int NOT NULL AUTO_INCREMENT,
  `Patient_ID` int NOT NULL,
  `Slot_ID` int NOT NULL,
  `Appointment_Type` varchar(50) DEFAULT NULL,
  `Appointment_Status` varchar(50) DEFAULT NULL,
  `Date_Created` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Appointment_ID`),
  KEY `Patient_ID` (`Patient_ID`),
  KEY `Slot_ID` (`Slot_ID`),
  CONSTRAINT `appointments_ibfk_1` FOREIGN KEY (`Patient_ID`) REFERENCES `patients` (`Patient_ID`),
  CONSTRAINT `appointments_ibfk_2` FOREIGN KEY (`Slot_ID`) REFERENCES `appointment_slots` (`Slot_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointments`
--

LOCK TABLES `appointments` WRITE;
/*!40000 ALTER TABLE `appointments` DISABLE KEYS */;
INSERT INTO `appointments` VALUES (1,1,5,'General Consultation (e.g Flu, cold, cough, fever)','CANCELLED','2026-09-14 10:04:45'),(2,1,2,'Minor Illness Treatment (e.g. Flu, Headache)','COMPLETED','2026-09-14 10:16:55'),(3,2,3,'Medical Check (e.g. TB, HIV)','COMPLETED','2026-09-14 11:47:04'),(4,3,5,'General Consultation (e.g Flu, cold, cough, fever)','CANCELLED','2026-09-19 05:39:16'),(5,3,6,'Emergency','COMPLETED','2026-09-19 09:12:11'),(6,2,7,'Emergency','COMPLETED','2026-09-19 09:15:20'),(7,2,8,'Emergency','COMPLETED','2026-09-19 09:52:40'),(8,3,12,'Wound Care / Dressing','FOLLOW-UP SCHEDULED','2026-09-19 12:01:54'),(9,3,11,'Emergency','COMPLETED','2026-09-19 12:02:36'),(10,2,13,'Urgent','COMPLETED','2026-09-19 13:09:40'),(11,4,14,'Mental Health Consultation (e.g. Stress, Anxiety)','BOOKED','2026-09-21 13:30:40');
/*!40000 ALTER TABLE `appointments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `emergency`
--

DROP TABLE IF EXISTS `emergency`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `emergency` (
  `Emergency_ID` int NOT NULL AUTO_INCREMENT,
  `Appointment_ID` int NOT NULL,
  `Urgent_Classification` varchar(50) DEFAULT NULL,
  `Recorded_By` varchar(50) DEFAULT NULL,
  `Date_recorded` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Emergency_ID`),
  KEY `Appointment_ID` (`Appointment_ID`),
  CONSTRAINT `emergency_ibfk_1` FOREIGN KEY (`Appointment_ID`) REFERENCES `appointments` (`Appointment_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `emergency`
--

LOCK TABLES `emergency` WRITE;
/*!40000 ALTER TABLE `emergency` DISABLE KEYS */;
INSERT INTO `emergency` VALUES (1,10,'Urgent','Receptionist','2026-09-19 13:09:40');
/*!40000 ALTER TABLE `emergency` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `followup`
--

DROP TABLE IF EXISTS `followup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `followup` (
  `Followup_ID` int NOT NULL AUTO_INCREMENT,
  `Appointment_ID` int NOT NULL,
  `Followup_Date` date DEFAULT NULL,
  `Note_Instructions` text,
  `Recorded_By` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Followup_ID`),
  KEY `Appointment_ID` (`Appointment_ID`),
  CONSTRAINT `followup_ibfk_1` FOREIGN KEY (`Appointment_ID`) REFERENCES `appointments` (`Appointment_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `followup`
--

LOCK TABLES `followup` WRITE;
/*!40000 ALTER TABLE `followup` DISABLE KEYS */;
INSERT INTO `followup` VALUES (1,8,'2026-09-22','for the full check up of the body','Nurse/Doctor');
/*!40000 ALTER TABLE `followup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patients`
--

DROP TABLE IF EXISTS `patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patients` (
  `Patient_ID` int NOT NULL AUTO_INCREMENT,
  `StudentORStaff_Number` varchar(10) DEFAULT NULL,
  `Full_Name` varchar(100) DEFAULT NULL,
  `Contact_Number` varchar(20) DEFAULT NULL,
  `PasswordCode` varchar(20) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Patient_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients`
--

LOCK TABLES `patients` WRITE;
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` VALUES (1,'12345678','John Doe','0712345678','1234','john@gmail.com'),(2,'22527244','Samuel Zondo','0647767795','Samuel@12','22527244.live@mut.ac.za'),(3,'22552331','L.S Jobe','0673403763','Lindo12@','22552331.live@mut.ac.za'),(4,'12356789','Sipha','078534756','Sipha12@','sipha123@gmail.com');
/*!40000 ALTER TABLE `patients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reschedules`
--

DROP TABLE IF EXISTS `reschedules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reschedules` (
  `Change_ID` int NOT NULL AUTO_INCREMENT,
  `Appointment_ID` int NOT NULL,
  `Change_Type` varchar(50) DEFAULT NULL,
  `Original_Slot_ID` int NOT NULL,
  `New_Slot_ID` int DEFAULT NULL,
  `Change_Date` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Change_ID`),
  KEY `Appointment_ID` (`Appointment_ID`),
  KEY `Original_Slot_ID` (`Original_Slot_ID`),
  KEY `New_Slot_ID` (`New_Slot_ID`),
  CONSTRAINT `reschedules_ibfk_1` FOREIGN KEY (`Appointment_ID`) REFERENCES `appointments` (`Appointment_ID`),
  CONSTRAINT `reschedules_ibfk_2` FOREIGN KEY (`Original_Slot_ID`) REFERENCES `appointment_slots` (`Slot_ID`),
  CONSTRAINT `reschedules_ibfk_3` FOREIGN KEY (`New_Slot_ID`) REFERENCES `appointment_slots` (`Slot_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reschedules`
--

LOCK TABLES `reschedules` WRITE;
/*!40000 ALTER TABLE `reschedules` DISABLE KEYS */;
/*!40000 ALTER TABLE `reschedules` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff_users`
--

DROP TABLE IF EXISTS `staff_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff_users` (
  `Staff_ID` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) NOT NULL,
  `PasswordCode` varchar(255) NOT NULL,
  `Full_Name` varchar(100) NOT NULL,
  `Role` varchar(30) NOT NULL,
  PRIMARY KEY (`Staff_ID`),
  UNIQUE KEY `Username` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff_users`
--

LOCK TABLES `staff_users` WRITE;
/*!40000 ALTER TABLE `staff_users` DISABLE KEYS */;
INSERT INTO `staff_users` VALUES (1,'reception','Reception@123','Reception User','Receptionist'),(2,'nurse','NurseDoc@123','Nurse User','Nurse/Doctor'),(3,'manager','Manager@123','Manager User','Manager'),(4,'doctor','NurseDoc@123','Doctor User','Nurse/Doctor');
/*!40000 ALTER TABLE `staff_users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-09-21 13:58:26
