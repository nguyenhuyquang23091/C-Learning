-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: c-sharp
-- ------------------------------------------------------
-- Server version	9.0.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Administration`
--

DROP TABLE IF EXISTS `Administration`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Administration` (
  `UserId` int NOT NULL,
  `Salary` decimal(10,2) DEFAULT NULL,
  `EmploymentType` enum('FullTime','PartTime') DEFAULT NULL,
  `WorkingHours` int DEFAULT NULL,
  PRIMARY KEY (`UserId`),
  CONSTRAINT `Administration_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Administration`
--

LOCK TABLES `Administration` WRITE;
/*!40000 ALTER TABLE `Administration` DISABLE KEYS */;
INSERT INTO `Administration` VALUES (21,4000000.00,'PartTime',5),(25,4000000.00,'FullTime',5),(29,4000000.00,'FullTime',4);
/*!40000 ALTER TABLE `Administration` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Students`
--

DROP TABLE IF EXISTS `Students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Students` (
  `UserId` int NOT NULL,
  `CurrentSubject1` varchar(100) DEFAULT NULL,
  `CurrentSubject2` varchar(100) DEFAULT NULL,
  `PreviousSubject1` varchar(100) DEFAULT NULL,
  `PreviousSubject2` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`UserId`),
  CONSTRAINT `Students_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Students`
--

LOCK TABLES `Students` WRITE;
/*!40000 ALTER TABLE `Students` DISABLE KEYS */;
/*!40000 ALTER TABLE `Students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `SystemAdmin`
--

DROP TABLE IF EXISTS `SystemAdmin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `SystemAdmin` (
  `UserId` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(100) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  PRIMARY KEY (`UserId`),
  UNIQUE KEY `Username` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=171 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `SystemAdmin`
--

LOCK TABLES `SystemAdmin` WRITE;
/*!40000 ALTER TABLE `SystemAdmin` DISABLE KEYS */;
INSERT INTO `SystemAdmin` VALUES (146,'a','a'),(148,'af','q'),(149,'q','q'),(150,'h','h'),(151,'bv','a'),(152,'f','f'),(153,'v','b'),(154,'g','g'),(155,'x','x'),(156,'ga','f'),(157,'l','l'),(159,'a2','a'),(160,'j','j'),(162,'xx','x'),(164,'la','l'),(165,'faa','f'),(166,'faag','f'),(167,'m','m'),(169,'ja','j'),(170,'zxzx','z');
/*!40000 ALTER TABLE `SystemAdmin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `TeachingStaff`
--

DROP TABLE IF EXISTS `TeachingStaff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `TeachingStaff` (
  `UserId` int NOT NULL,
  `Salary` decimal(10,2) DEFAULT NULL,
  `Subject1` varchar(100) DEFAULT NULL,
  `Subject2` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`UserId`),
  CONSTRAINT `TeachingStaff_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `TeachingStaff`
--

LOCK TABLES `TeachingStaff` WRITE;
/*!40000 ALTER TABLE `TeachingStaff` DISABLE KEYS */;
INSERT INTO `TeachingStaff` VALUES (23,30000000.00,'Math','English'),(24,3000000.00,'Math','English'),(28,2000000.00,'Math','English'),(30,3333333.00,'OOP','C#'),(31,5000000.00,'Math','English');
/*!40000 ALTER TABLE `TeachingStaff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Users`
--

DROP TABLE IF EXISTS `Users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  `Telephone` varchar(20) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `RoleType` enum('TeachingStaff','Administration','Students') NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Users`
--

LOCK TABLES `Users` WRITE;
/*!40000 ALTER TABLE `Users` DISABLE KEYS */;
INSERT INTO `Users` VALUES (21,'minh','3434123123','lebao0824@gmail.com','Administration'),(23,'quang1','0342408183','lebao0824@gmail.com','TeachingStaff'),(24,'g','03424081835','lebao082647@gmail.com','TeachingStaff'),(25,'quang','0342408183','lebao0824@gmail.com','Administration'),(28,'qaaaa','0342408185','lebao08245@gmail.com','TeachingStaff'),(29,'quang','0342408184','lebao0982@gmaill.com','Administration'),(30,'Huy Quang','0342408183','lebao08243@gmail.com','TeachingStaff'),(31,'thinh an','0342408183','helloimwkang2@gmai..com','TeachingStaff');
/*!40000 ALTER TABLE `Users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'c-sharp'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-08-29  2:31:36
