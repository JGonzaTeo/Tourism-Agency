CREATE DATABASE  IF NOT EXISTS `agencia_turismo` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `agencia_turismo`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: agencia_turismo
-- ------------------------------------------------------
-- Server version	5.7.19-log

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
-- Table structure for table `tbl_asignacionempleadoaguia`
--

DROP TABLE IF EXISTS `tbl_asignacionempleadoaguia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_asignacionempleadoaguia` (
  `Pk_idEmpleado` int(11) NOT NULL,
  `Pk_idGuia` int(11) NOT NULL,
  `Horario_Inicio` datetime DEFAULT NULL,
  `Horario_Fin` datetime DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`Pk_idEmpleado`,`Pk_idGuia`),
  KEY `fk_Tbl_AsignacionEmpleadoAGuia_Tbl_GuiaTuristico1_idx` (`Pk_idGuia`),
  CONSTRAINT `fk_Tbl_AsignacionEmpleadoAGuia_Tbl_GuiaTuristico1` FOREIGN KEY (`Pk_idGuia`) REFERENCES `tbl_guiaturistico` (`Pk_idGuia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tbl_AsignacionEmpleadoAGuia_Tbl_empleado1` FOREIGN KEY (`Pk_idEmpleado`) REFERENCES `tbl_empleado` (`Pk_idEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_asignacionempleadoaguia`
--

LOCK TABLES `tbl_asignacionempleadoaguia` WRITE;
/*!40000 ALTER TABLE `tbl_asignacionempleadoaguia` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_asignacionempleadoaguia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_asignaciontransporte`
--

DROP TABLE IF EXISTS `tbl_asignaciontransporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_asignaciontransporte` (
  `Pk_idAsignacion` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_idTransporte` int(11) DEFAULT NULL,
  `Fk_idReservacion` int(11) DEFAULT NULL,
  `Fk_idEmpleado` int(11) DEFAULT NULL,
  `FechaSalida` date DEFAULT NULL,
  `FechaEntrada` date DEFAULT NULL,
  PRIMARY KEY (`Pk_idAsignacion`),
  KEY `fk_tbl_AsignacionTransporte_tbl_Transporte1_idx` (`Fk_idTransporte`),
  KEY `fk_tbl_AsignacionTransporte_tbl_Reservacion1_idx` (`Fk_idReservacion`),
  KEY `fk_tbl_asignaciontransporte_tbl_empleado1_idx` (`Fk_idEmpleado`),
  CONSTRAINT `fk_tbl_AsignacionTransporte_tbl_Reservacion1` FOREIGN KEY (`Fk_idReservacion`) REFERENCES `tbl_reservacion` (`Pk_idReservacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbl_AsignacionTransporte_tbl_Transporte1` FOREIGN KEY (`Fk_idTransporte`) REFERENCES `tbl_transporte` (`Pk_idTransporte`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbl_asignaciontransporte_tbl_empleado1` FOREIGN KEY (`Fk_idEmpleado`) REFERENCES `tbl_empleado` (`Pk_idEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_asignaciontransporte`
--

LOCK TABLES `tbl_asignaciontransporte` WRITE;
/*!40000 ALTER TABLE `tbl_asignaciontransporte` DISABLE KEYS */;
INSERT INTO `tbl_asignaciontransporte` VALUES (1,1,1,1,'2019-08-12','2019-08-16');
/*!40000 ALTER TABLE `tbl_asignaciontransporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bitacora`
--

DROP TABLE IF EXISTS `tbl_bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_bitacora` (
  `Pk_idBitacora` int(11) NOT NULL AUTO_INCREMENT,
  `operacion` varchar(45) NOT NULL,
  `usuario` varchar(45) NOT NULL,
  `fecha_ingreso` datetime NOT NULL,
  `proceso_afectado` varchar(45) NOT NULL,
  `direccion_ip` varchar(45) NOT NULL,
  PRIMARY KEY (`Pk_idBitacora`)
) ENGINE=InnoDB AUTO_INCREMENT=214 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bitacora`
--

LOCK TABLES `tbl_bitacora` WRITE;
/*!40000 ALTER TABLE `tbl_bitacora` DISABLE KEYS */;
INSERT INTO `tbl_bitacora` VALUES (90,'INICION DE SESIÓN','jose','2019-08-02 00:00:00','-------------','192.168.1.9'),(91,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(92,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(93,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(94,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(95,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(96,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(97,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(98,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(99,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(100,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(101,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(102,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(103,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(104,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(105,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(106,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(107,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(108,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.1.9'),(109,'INICION DE SESIÓN','admin','2019-08-02 00:00:00','-------------','192.168.1.9'),(110,'NUEVO REGISTRO','','2019-08-02 00:00:00','Empleado','192.168.1.9'),(111,'INICION DE SESIÓN','jose','2019-08-02 00:00:00','-------------','192.168.1.9'),(112,'INICION DE SESIÓN','jose','2019-08-02 00:00:00','-------------','192.168.1.9'),(113,'INICION DE SESIÓN','jose','2019-08-02 00:00:00','-------------','192.168.1.9'),(114,'MODIFICAR','','2019-08-02 00:00:00','Empleado','192.168.1.9'),(115,'INICION DE SESIÓN','edson','2019-08-02 00:00:00','-------------','192.168.43.103'),(116,'CIERRE DE SESIÓN','edson','2019-08-02 00:00:00','-----','192.168.43.103'),(117,'INICION DE SESIÓN','edson','2019-08-02 00:00:00','-------------','192.168.43.103'),(118,'CIERRE DE SESIÓN','edson','2019-08-02 00:00:00','-----','192.168.43.103'),(119,'INICION DE SESIÓN','edson','2019-08-02 00:00:00','-------------','192.168.43.103'),(120,'INICION DE SESIÓN','edson','2019-08-02 00:00:00','-------------','192.168.43.187'),(121,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.43.187'),(122,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.43.187'),(123,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.43.187'),(124,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.43.187'),(125,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.43.187'),(126,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.43.187'),(127,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.43.187'),(128,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.43.187'),(129,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.43.187'),(130,'INICION DE SESIÓN',' ','2019-08-02 00:00:00','-------------','192.168.43.187'),(131,'CIERRE DE SESIÓN','edson','2019-08-02 00:00:00','-----','192.168.43.103'),(132,'INICION DE SESIÓN','jose','2019-08-02 00:00:00','-------------','192.168.43.104'),(133,'INGRESO DE REGISTRO',' ','2019-08-02 00:00:00','DEPARTAMENTOS','192.168.43.104'),(134,'CIERRE DE SESIÓN','jose','2019-08-02 00:00:00','-----','192.168.43.104'),(135,'INICION DE SESIÓN','jose','2019-08-02 00:00:00','-------------','192.168.43.104'),(136,'INGRESO DE REGISTRO','jose','2019-08-02 00:00:00','DEPARTAMENTOS','192.168.43.104'),(137,'CIERRE DE SESIÓN','jose','2019-08-02 00:00:00','-----','192.168.43.104'),(138,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(139,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(140,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(141,'INICION DE SESIÓN','edson','2019-08-03 00:00:00','-------------','192.168.0.5'),(142,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(143,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(144,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(145,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(146,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(147,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(148,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(149,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(150,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(151,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(152,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(153,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(154,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(155,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(156,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(157,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(158,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(159,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(160,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(161,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(162,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(163,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(164,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(165,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(166,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(167,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(168,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(169,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(170,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(171,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(172,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(173,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(174,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(175,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(176,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(177,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(178,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(179,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(180,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(181,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(182,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(183,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(184,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(185,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(186,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(187,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(188,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(189,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(190,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(191,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(192,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(193,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(194,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(195,'PROCESO DE FACTURACIÓN','admin','2019-08-03 00:00:00','VENTAS','192.168.0.5'),(196,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(197,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(198,'PROCESO DE FACTURACIÓN','admin','2019-08-03 00:00:00','VENTAS','192.168.0.5'),(199,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(200,'CREACION DE RESERVACION/ASIGNACION TRANSPORTE','admin','2019-08-03 00:00:00','Empleado','?'),(201,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(202,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(203,'INICION DE SESIÓN','admin','2019-08-03 00:00:00','-------------','192.168.0.5'),(204,'INICION DE SESIÓN','admin','2019-08-04 00:00:00','-------------','192.168.0.5'),(205,'CIERRE DE SESIÓN','admin','2019-08-04 00:00:00','-----','192.168.0.5'),(206,'INICION DE SESIÓN','jose','2019-08-04 00:00:00','-------------','192.168.0.5'),(207,'CIERRE DE SESIÓN','jose','2019-08-04 00:00:00','-----','192.168.0.5'),(208,'INICION DE SESIÓN','edson','2019-08-04 00:00:00','-------------','192.168.0.5'),(209,'CIERRE DE SESIÓN','edson','2019-08-04 00:00:00','-----','192.168.0.5'),(210,'INICION DE SESIÓN','ivan','2019-08-04 00:00:00','-------------','192.168.0.5'),(211,'CIERRE DE SESIÓN','ivan','2019-08-04 00:00:00','-----','192.168.0.5'),(212,'INICION DE SESIÓN','angel','2019-08-04 00:00:00','-------------','192.168.0.5'),(213,'CIERRE DE SESIÓN','angel','2019-08-04 00:00:00','-----','192.168.0.5');
/*!40000 ALTER TABLE `tbl_bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bonos_descuentos`
--

DROP TABLE IF EXISTS `tbl_bonos_descuentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_bonos_descuentos` (
  `Pk_idBonos_Desc` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) DEFAULT NULL,
  `Valor` double DEFAULT NULL,
  `Bono_Desc` tinyint(1) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`Pk_idBonos_Desc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bonos_descuentos`
--

LOCK TABLES `tbl_bonos_descuentos` WRITE;
/*!40000 ALTER TABLE `tbl_bonos_descuentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_bonos_descuentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cliente`
--

DROP TABLE IF EXISTS `tbl_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_cliente` (
  `Pk_idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombreCliente` varchar(45) DEFAULT NULL,
  `apellidoCliente` varchar(45) DEFAULT NULL,
  `telefonoCelCliente` int(11) DEFAULT NULL,
  `telefonoCasaCliente` int(11) DEFAULT NULL,
  `correoCliente` varchar(45) DEFAULT NULL,
  `correoAltCliente` varchar(45) DEFAULT NULL,
  `identificacionCliente` varchar(45) DEFAULT NULL,
  `nitCliente` varchar(45) DEFAULT NULL,
  `estadoCliente` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Pk_idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cliente`
--

LOCK TABLES `tbl_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_cliente` DISABLE KEYS */;
INSERT INTO `tbl_cliente` VALUES (1,'Edson','Juarez',34456735,54677343,'correo1@x.com','correo2@y.com','e34','345563635',1);
/*!40000 ALTER TABLE `tbl_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_departamentos`
--

DROP TABLE IF EXISTS `tbl_departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_departamentos` (
  `Pk_idDepartamento` int(11) NOT NULL AUTO_INCREMENT,
  `NombreDepartamento` varchar(45) DEFAULT NULL,
  `DescripcionDepartamento` varchar(45) DEFAULT NULL,
  `estadoDepartamento` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Pk_idDepartamento`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_departamentos`
--

LOCK TABLES `tbl_departamentos` WRITE;
/*!40000 ALTER TABLE `tbl_departamentos` DISABLE KEYS */;
INSERT INTO `tbl_departamentos` VALUES (1,'Guatemala','Peligroso',1),(2,'Zapaca','Infierno',1);
/*!40000 ALTER TABLE `tbl_departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_empleado`
--

DROP TABLE IF EXISTS `tbl_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_empleado` (
  `Pk_idEmpleado` int(11) NOT NULL AUTO_INCREMENT,
  `nombreEmpleado` varchar(45) DEFAULT NULL,
  `apellidoEmpleado` varchar(45) DEFAULT NULL,
  `fechaNacEmpleado` date DEFAULT NULL,
  `correo` varchar(45) DEFAULT NULL,
  `correoAlternativo` varchar(45) DEFAULT NULL,
  `telefono` varchar(25) DEFAULT NULL,
  `telefonoResidencial` varchar(25) DEFAULT NULL,
  `DPI` varchar(25) DEFAULT NULL,
  `Fk_idUsuario` int(11) DEFAULT NULL,
  `Cuenta_Bancaria` int(11) DEFAULT NULL,
  `NIT` varchar(45) DEFAULT NULL,
  `Sueldo_Base` double DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`Pk_idEmpleado`),
  KEY `fk_Tbl_empleado_Tbl_usuario_idx` (`Fk_idUsuario`),
  CONSTRAINT `fk_Tbl_empleado_Tbl_usuario` FOREIGN KEY (`Fk_idUsuario`) REFERENCES `tbl_usuario` (`Pk_idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_empleado`
--

LOCK TABLES `tbl_empleado` WRITE;
/*!40000 ALTER TABLE `tbl_empleado` DISABLE KEYS */;
INSERT INTO `tbl_empleado` VALUES (1,'José','Gonzalez','2019-08-02','Jose@gmail.com','dfsaasdfg','1234','1234','1223123',1,2147483647,'12342134',12000,'qewrgffddsad',0);
/*!40000 ALTER TABLE `tbl_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_facturadetalle`
--

DROP TABLE IF EXISTS `tbl_facturadetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_facturadetalle` (
  `Pk_idFactura` int(11) NOT NULL,
  `Pk_codigoLinea` int(11) NOT NULL,
  `Fk_idTipoHabitacion` int(11) DEFAULT NULL,
  `FK_idMenus` int(11) DEFAULT NULL,
  `Fk_idLugarTuristico` int(11) DEFAULT NULL,
  `cantidadHabitaciones` int(11) DEFAULT NULL,
  PRIMARY KEY (`Pk_idFactura`,`Pk_codigoLinea`),
  KEY `fk_Tbl_CotizacionDetalle_tbl_TipoHabitacion1_idx` (`Fk_idTipoHabitacion`),
  KEY `fk_Tbl_CotizacionDetalle_tbl_Menus1_idx` (`FK_idMenus`),
  KEY `fk_Tbl_CotizacionDetalle_Tbl_LugarTuristico1_idx` (`Fk_idLugarTuristico`),
  CONSTRAINT `fk_Tbl_CotizacionDetalle_Tbl_LugarTuristico1` FOREIGN KEY (`Fk_idLugarTuristico`) REFERENCES `tbl_lugarturistico` (`Pk_idLugarTuristico`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tbl_CotizacionDetalle_tbl_Menus1` FOREIGN KEY (`FK_idMenus`) REFERENCES `tbl_menus` (`Pk_idMenus`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tbl_CotizacionDetalle_tbl_TipoHabitacion1` FOREIGN KEY (`Fk_idTipoHabitacion`) REFERENCES `tbl_tipohabitacion` (`Pk_idTipoHabitacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tbl_FacturaDetalle_tbl_FacturaEncabezado1` FOREIGN KEY (`Pk_idFactura`) REFERENCES `tbl_facturaencabezado` (`Pk_idFactura`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_facturadetalle`
--

LOCK TABLES `tbl_facturadetalle` WRITE;
/*!40000 ALTER TABLE `tbl_facturadetalle` DISABLE KEYS */;
INSERT INTO `tbl_facturadetalle` VALUES (11,1995461673,1,1,1,3),(12,861703383,1,1,1,1),(13,702952675,1,1,1,0),(14,674925169,1,1,1,0),(15,348671078,1,1,1,6),(16,1600748774,1,1,1,2),(17,62925841,1,1,1,2),(17,796700439,2,2,2,6),(18,524370221,2,2,2,9),(18,2079518173,2,1,1,1),(19,393385965,2,2,2,9),(19,737577323,1,1,1,1),(20,95953033,2,1,2,3),(20,2070127402,2,1,2,1),(21,97511713,1,1,1,2),(21,601161250,2,2,2,6),(22,1576199354,1,1,1,6);
/*!40000 ALTER TABLE `tbl_facturadetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_facturaencabezado`
--

DROP TABLE IF EXISTS `tbl_facturaencabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_facturaencabezado` (
  `Pk_idFactura` int(11) NOT NULL AUTO_INCREMENT,
  `Pk_idCliente` int(11) NOT NULL,
  `Pk_idEmpleado` int(11) NOT NULL,
  `fechaCotizacion` date DEFAULT NULL,
  `cantidadPasajeros` int(11) DEFAULT NULL,
  `Fk_idTipoPago` int(11) DEFAULT NULL,
  `Total` double DEFAULT NULL,
  `Factura_Cotizacion` tinyint(1) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Pk_idFactura`,`Pk_idCliente`,`Pk_idEmpleado`),
  KEY `fk_Tbl_CotizacionEncabezado_Tbl_Empleado1_idx` (`Pk_idEmpleado`),
  KEY `fk_Tbl_CotizacionEncabezado_Tbl_Cliente1_idx` (`Pk_idCliente`),
  KEY `fk_Tbl_FacturaEncabezado_Tbl_TipoPago1_idx` (`Fk_idTipoPago`),
  CONSTRAINT `fk_Tbl_CotizacionEncabezado_Tbl_Cliente1` FOREIGN KEY (`Pk_idCliente`) REFERENCES `tbl_cliente` (`Pk_idCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tbl_CotizacionEncabezado_Tbl_Empleado1` FOREIGN KEY (`Pk_idEmpleado`) REFERENCES `tbl_empleado` (`Pk_idEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tbl_FacturaEncabezado_Tbl_TipoPago1` FOREIGN KEY (`Fk_idTipoPago`) REFERENCES `tbl_tipopagos` (`Pk_idTipoPago`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_facturaencabezado`
--

LOCK TABLES `tbl_facturaencabezado` WRITE;
/*!40000 ALTER TABLE `tbl_facturaencabezado` DISABLE KEYS */;
INSERT INTO `tbl_facturaencabezado` VALUES (3,1,1,'2019-08-03',4,2,1300,1,0),(4,1,1,'2019-08-03',4,3,3700,0,0),(5,1,1,'2019-08-03',3,2,1500,0,0),(6,1,1,'2019-08-03',1,2,2200,1,0),(7,1,1,'2019-08-03',10,1,2200,1,0),(9,1,1,'2019-08-03',2,1,5550,1,0),(10,1,1,'2019-08-03',2,1,2200,1,0),(11,1,1,'2019-08-03',2,3,3850,1,0),(12,1,1,'2019-08-03',3,2,2200,1,0),(13,1,1,'2019-08-03',3,2,2450,1,0),(14,1,1,'2019-08-03',3,2,2450,1,0),(15,1,1,'2019-08-03',7,1,4700,1,0),(16,1,1,'2019-08-03',3,1,3950,1,0),(17,1,1,'2019-08-03',3,1,3950,1,0),(18,1,1,'2019-08-03',10,1,2850,1,0),(19,1,1,'2019-08-03',10,1,3250,1,0),(20,1,1,'2019-08-03',5,2,3400,1,0),(21,1,1,'2019-08-03',3,3,3950,0,0),(22,1,1,'2019-08-03',7,1,4700,1,0);
/*!40000 ALTER TABLE `tbl_facturaencabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_guiaturistico`
--

DROP TABLE IF EXISTS `tbl_guiaturistico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_guiaturistico` (
  `Pk_idGuia` int(11) NOT NULL AUTO_INCREMENT,
  `Ruta` varchar(45) DEFAULT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`Pk_idGuia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_guiaturistico`
--

LOCK TABLES `tbl_guiaturistico` WRITE;
/*!40000 ALTER TABLE `tbl_guiaturistico` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_guiaturistico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_hoteles`
--

DROP TABLE IF EXISTS `tbl_hoteles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_hoteles` (
  `Pk_idHotel` int(11) NOT NULL AUTO_INCREMENT,
  `NombreHotel` varchar(30) DEFAULT NULL,
  `direccionHotel` varchar(45) DEFAULT NULL,
  `telefonoHotel` int(11) DEFAULT NULL,
  `correoHotel` varchar(30) DEFAULT NULL,
  `estadoHotel` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Pk_idHotel`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_hoteles`
--

LOCK TABLES `tbl_hoteles` WRITE;
/*!40000 ALTER TABLE `tbl_hoteles` DISABLE KEYS */;
INSERT INTO `tbl_hoteles` VALUES (1,'Hotel5E','Zona 10',3456353,'correo1',1);
/*!40000 ALTER TABLE `tbl_hoteles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_lugarturistico`
--

DROP TABLE IF EXISTS `tbl_lugarturistico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_lugarturistico` (
  `Pk_idLugarTuristico` int(11) NOT NULL AUTO_INCREMENT,
  `NombreLugarTuristico` varchar(45) DEFAULT NULL,
  `DescripcionLugarTuristico` varchar(45) DEFAULT NULL,
  `Fk_idDepartamento` int(11) NOT NULL,
  `precioLugarTuristico` double NOT NULL,
  `estadoLugarTuristico` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Pk_idLugarTuristico`,`Fk_idDepartamento`),
  KEY `fk_Tbl_LugarTuristico_Tbl_Departamentos1_idx` (`Fk_idDepartamento`),
  CONSTRAINT `fk_Tbl_LugarTuristico_Tbl_Departamentos1` FOREIGN KEY (`Fk_idDepartamento`) REFERENCES `tbl_departamentos` (`Pk_idDepartamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_lugarturistico`
--

LOCK TABLES `tbl_lugarturistico` WRITE;
/*!40000 ALTER TABLE `tbl_lugarturistico` DISABLE KEYS */;
INSERT INTO `tbl_lugarturistico` VALUES (1,'Lugar1','Bonito',1,200,1),(2,'Lugar2','Regular',2,400,1);
/*!40000 ALTER TABLE `tbl_lugarturistico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_menus`
--

DROP TABLE IF EXISTS `tbl_menus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_menus` (
  `Pk_idMenus` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_idRestaurantes` int(11) DEFAULT NULL,
  `nombreMenu` varchar(20) DEFAULT NULL,
  `descripcionMenu` varchar(30) DEFAULT NULL,
  `PrecioMenu` double DEFAULT NULL,
  `estadoMenu` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`Pk_idMenus`),
  KEY `fk_tbl_Menus_tbl_Restaurantes1_idx` (`Fk_idRestaurantes`),
  CONSTRAINT `fk_tbl_Menus_tbl_Restaurantes1` FOREIGN KEY (`Fk_idRestaurantes`) REFERENCES `tbl_restaurantes` (`Pk_idRestaurante`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_menus`
--

LOCK TABLES `tbl_menus` WRITE;
/*!40000 ALTER TABLE `tbl_menus` DISABLE KEYS */;
INSERT INTO `tbl_menus` VALUES (1,1,'Carnita asada','10 de 10',1000,1),(2,1,'Ensalada','xd',150,1);
/*!40000 ALTER TABLE `tbl_menus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_nomina_detalle`
--

DROP TABLE IF EXISTS `tbl_nomina_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_nomina_detalle` (
  `Pk_idEncabezadoN` int(11) NOT NULL,
  `Pk_idLinea` int(11) NOT NULL,
  `Fk_idBonos_Desc` int(11) DEFAULT NULL,
  PRIMARY KEY (`Pk_idEncabezadoN`,`Pk_idLinea`),
  KEY `fk_Tbl_Nomina_Detalle_Tbl_Bonos_Descuentos1_idx` (`Fk_idBonos_Desc`),
  CONSTRAINT `fk_Tbl_Nomina_Detalle_Tbl_Bonos_Descuentos1` FOREIGN KEY (`Fk_idBonos_Desc`) REFERENCES `tbl_bonos_descuentos` (`Pk_idBonos_Desc`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tbl_Nomina_Detalle_Tbl_Nomina_Encabezado1` FOREIGN KEY (`Pk_idEncabezadoN`) REFERENCES `tbl_nomina_encabezado` (`Pk_idEncabezadoN`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_nomina_detalle`
--

LOCK TABLES `tbl_nomina_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_nomina_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_nomina_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_nomina_encabezado`
--

DROP TABLE IF EXISTS `tbl_nomina_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_nomina_encabezado` (
  `Pk_idEncabezadoN` int(11) NOT NULL AUTO_INCREMENT,
  `Pk_idEmpleado` int(11) DEFAULT NULL,
  `Dias` int(11) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Sueldo_Liquido` double DEFAULT NULL,
  PRIMARY KEY (`Pk_idEncabezadoN`),
  KEY `fk_Tbl_Nomina_Encabezado_Tbl_empleado1_idx` (`Pk_idEmpleado`),
  CONSTRAINT `fk_Tbl_Nomina_Encabezado_Tbl_empleado1` FOREIGN KEY (`Pk_idEmpleado`) REFERENCES `tbl_empleado` (`Pk_idEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_nomina_encabezado`
--

LOCK TABLES `tbl_nomina_encabezado` WRITE;
/*!40000 ALTER TABLE `tbl_nomina_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_nomina_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_perfil`
--

DROP TABLE IF EXISTS `tbl_perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_perfil` (
  `Pk_idPerfil` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_Perfil` varchar(45) NOT NULL,
  `detalle_perfil` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Pk_idPerfil`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_perfil`
--

LOCK TABLES `tbl_perfil` WRITE;
/*!40000 ALTER TABLE `tbl_perfil` DISABLE KEYS */;
INSERT INTO `tbl_perfil` VALUES (1,'Administrador','Todas las aplicaciones',1),(2,'Contador','Área de contabilidad',1),(3,'Ventas','Área de ventas',1),(4,'Reservación','Área de reservación',1),(5,'Usuario','Solo mantenimientos',1);
/*!40000 ALTER TABLE `tbl_perfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_reservacion`
--

DROP TABLE IF EXISTS `tbl_reservacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_reservacion` (
  `Pk_idReservacion` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_idCotizacion` int(11) DEFAULT NULL,
  `Fk_idTipoPago` int(11) DEFAULT NULL,
  PRIMARY KEY (`Pk_idReservacion`),
  KEY `fk_tbl_Reservacion_tbl_TipoPagos1_idx` (`Fk_idTipoPago`),
  KEY `fk_Tbl_Reservacion_Tbl_CotizacionEncabezado1_idx` (`Fk_idCotizacion`),
  CONSTRAINT `fk_Tbl_Reservacion_Tbl_CotizacionEncabezado1` FOREIGN KEY (`Fk_idCotizacion`) REFERENCES `tbl_facturaencabezado` (`Pk_idFactura`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbl_Reservacion_tbl_TipoPagos1` FOREIGN KEY (`Fk_idTipoPago`) REFERENCES `tbl_tipopagos` (`Pk_idTipoPago`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_reservacion`
--

LOCK TABLES `tbl_reservacion` WRITE;
/*!40000 ALTER TABLE `tbl_reservacion` DISABLE KEYS */;
INSERT INTO `tbl_reservacion` VALUES (1,21,3);
/*!40000 ALTER TABLE `tbl_reservacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_restaurantes`
--

DROP TABLE IF EXISTS `tbl_restaurantes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_restaurantes` (
  `Pk_idRestaurante` int(11) NOT NULL AUTO_INCREMENT,
  `NombreRestaurante` varchar(30) DEFAULT NULL,
  `DireccionRestaurante` varchar(20) DEFAULT NULL,
  `TelefonoRestaurante` int(11) DEFAULT NULL,
  `CorreoRestaurante` varchar(30) DEFAULT NULL,
  `estadoRestaurante` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Pk_idRestaurante`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_restaurantes`
--

LOCK TABLES `tbl_restaurantes` WRITE;
/*!40000 ALTER TABLE `tbl_restaurantes` DISABLE KEYS */;
INSERT INTO `tbl_restaurantes` VALUES (1,'Los cebollines','Zona 10',45677343,'correo1',1);
/*!40000 ALTER TABLE `tbl_restaurantes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipohabitacion`
--

DROP TABLE IF EXISTS `tbl_tipohabitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_tipohabitacion` (
  `Pk_idTipoHabitacion` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_idHotel` int(11) DEFAULT NULL,
  `nombreHabitacion` varchar(20) DEFAULT NULL,
  `capacidadHabitacion` int(11) DEFAULT NULL,
  `precioHabitacion` double DEFAULT NULL,
  `estadoHabitacion` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`Pk_idTipoHabitacion`),
  KEY `fk_tbl_TipoHabitacion_tbl_Hoteles1_idx` (`Fk_idHotel`),
  CONSTRAINT `fk_tbl_TipoHabitacion_tbl_Hoteles1` FOREIGN KEY (`Fk_idHotel`) REFERENCES `tbl_hoteles` (`Pk_idHotel`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipohabitacion`
--

LOCK TABLES `tbl_tipohabitacion` WRITE;
/*!40000 ALTER TABLE `tbl_tipohabitacion` DISABLE KEYS */;
INSERT INTO `tbl_tipohabitacion` VALUES (1,1,'Suit Presidencial',10,500,1),(2,1,'Normal',5,100,1);
/*!40000 ALTER TABLE `tbl_tipohabitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipopagos`
--

DROP TABLE IF EXISTS `tbl_tipopagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_tipopagos` (
  `Pk_idTipoPago` int(11) NOT NULL AUTO_INCREMENT,
  `NombreTipoPago` varchar(45) DEFAULT NULL,
  `DescripcionTipoPago` varchar(45) DEFAULT NULL,
  `estadoTipoPago` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Pk_idTipoPago`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipopagos`
--

LOCK TABLES `tbl_tipopagos` WRITE;
/*!40000 ALTER TABLE `tbl_tipopagos` DISABLE KEYS */;
INSERT INTO `tbl_tipopagos` VALUES (1,'Efectivo','Pago en persona',1),(2,'Crédito','Pago con recargo',1),(3,'Débito','Pago con tarjeta',1);
/*!40000 ALTER TABLE `tbl_tipopagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_transporte`
--

DROP TABLE IF EXISTS `tbl_transporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_transporte` (
  `Pk_idTransporte` int(11) NOT NULL AUTO_INCREMENT,
  `Placa` varchar(7) DEFAULT NULL,
  `TipoTransporte` varchar(15) DEFAULT NULL,
  `Capacidad` int(11) DEFAULT NULL,
  `estadoTransporte` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Pk_idTransporte`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_transporte`
--

LOCK TABLES `tbl_transporte` WRITE;
/*!40000 ALTER TABLE `tbl_transporte` DISABLE KEYS */;
INSERT INTO `tbl_transporte` VALUES (1,'DDFDe','Troca',35,1);
/*!40000 ALTER TABLE `tbl_transporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usuario`
--

DROP TABLE IF EXISTS `tbl_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_usuario` (
  `Pk_idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombreUsuario` varchar(45) NOT NULL,
  `contrasenaUsuario` varchar(45) DEFAULT NULL,
  `Fk_idPerfil` int(11) NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  `logeado` tinyint(1) NOT NULL,
  PRIMARY KEY (`Pk_idUsuario`,`Fk_idPerfil`),
  KEY `fk_Tbl_Usuario_Tbl_perfil1_idx` (`Fk_idPerfil`),
  CONSTRAINT `fk_Tbl_Usuario_Tbl_perfil1` FOREIGN KEY (`Fk_idPerfil`) REFERENCES `tbl_perfil` (`Pk_idPerfil`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_usuario`
--

LOCK TABLES `tbl_usuario` WRITE;
/*!40000 ALTER TABLE `tbl_usuario` DISABLE KEYS */;
INSERT INTO `tbl_usuario` VALUES (1,'admin','123',1,1,0),(2,'jose','123',2,1,0),(3,'edson','123',3,1,0),(4,'ivan','456',4,1,0),(5,'angel','789',5,1,0);
/*!40000 ALTER TABLE `tbl_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `view_departamento`
--

DROP TABLE IF EXISTS `view_departamento`;
/*!50001 DROP VIEW IF EXISTS `view_departamento`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `view_departamento` AS SELECT 
 1 AS `Pk_idDepartamento`,
 1 AS `NombreDepartamento`,
 1 AS `DescripcionDepartamento`,
 1 AS `estadoDepartamento`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_transporte`
--

DROP TABLE IF EXISTS `view_transporte`;
/*!50001 DROP VIEW IF EXISTS `view_transporte`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `view_transporte` AS SELECT 
 1 AS `Pk_idTransporte`,
 1 AS `Placa`,
 1 AS `TipoTransporte`,
 1 AS `Capacidad`,
 1 AS `estadoTransporte`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'agencia_turismo'
--

--
-- Dumping routines for database 'agencia_turismo'
--
/*!50003 DROP PROCEDURE IF EXISTS `SP_ActualizarDepartamento` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ActualizarDepartamento`(IN Nombre VARCHAR(45), IN Descripcion varchar(45))
BEGIN 
	UPDATE tbl_departamentos SET NombreDepartamento = Nombre, DescripcionDepartamento = Descripcion WHERE NombreDepartamento = Nombre;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_ActualizarTransporte` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ActualizarTransporte`(IN pla VARCHAR(45), IN TipoT varchar(45), IN Cap int)
BEGIN 
	UPDATE tbl_transporte SET Placa = pla, TipoTransporte = TipoT, Capacidad = Cap WHERE Placa = pla;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_BuscarBonosYDesc` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_BuscarBonosYDesc`(in nom VARCHAR(45))
BEGIN
SELECT Pk_idBonos_Desc,Nombre,Valor,Bono_Desc FROM tbl_bonos_descuentos 
WHERE Nombre = nom;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BuscarDepartamento` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BuscarDepartamento`(IN Nombre VARCHAR(45))
BEGIN 
	Select * from tbl_departamentos where NombreDepartamento like CONCAT('%', Nombre , '%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_Buscarempleado` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Buscarempleado`(in nom VARCHAR(45))
BEGIN
SELECT * FROM tbl_empleado 
WHERE nombreEmpleado = nom;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_Buscarempleadoguia` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Buscarempleadoguia`(in nom VARCHAR(45))
BEGIN
SELECT * FROM tbl_asignacionempleadoaguia 
WHERE Nombre = nom;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_Buscarguia` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Buscarguia`(in nom VARCHAR(45))
BEGIN
SELECT Pk_idBonos_Desc,Nombre,Valor,Bono_Desc FROM tbl_bonos_descuentos 
WHERE Nombre = nom;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_Eliminarasignacionguiaemp` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Eliminarasignacionguiaemp`(in cod INT(11),in codguia INT(11),in estado TINYINT(1))
BEGIN
UPDATE tbl_asignacionempleadoaguia
SET Estado="1"
WHERE Pk_idEmpleado=cod AND Pk_idGuia=codguia;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_EliminarBonos_Desc` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_EliminarBonos_Desc`(in cod INT(11),in estado TINYINT(1))
BEGIN
UPDATE tbl_bonos_descuentos 
SET Estado="1"
WHERE Pk_idBonos_Desc=cod;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_EliminarDepartamento` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EliminarDepartamento`(IN Nombre VARCHAR(45))
BEGIN 
	UPDATE tbl_departamentos SET estadoDepartamento = 0 WHERE NombreDepartamento = Nombre;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_Eliminarempleado` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Eliminarempleado`(in cod INT(11))
BEGIN
UPDATE tbl_empleado 
SET Estado="1"
WHERE Pk_idEmpleado=cod;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_Eliminarguia` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Eliminarguia`(in cod INT(11),in estado TINYINT(1))
BEGIN
UPDATE tbl_guiaturistico 
SET Estado="1"
WHERE Pk_idGuia=cod;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_EliminarTransporte` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EliminarTransporte`(IN pla VARCHAR(45))
BEGIN 
	UPDATE tbl_transporte SET estadoTransporte = 0 WHERE Placa = pla;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_InsertarAsigacionTransporte` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_InsertarAsigacionTransporte`(in idTransporte INT(11), in idReservacion INT(11),in idEmpleado INT(11), in salida DATE,
in entrada DATE)
BEGIN
	insert into tbl_asignaciontransporte values (0,idTransporte, idReservacion, idEmpleado, salida, entrada);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_InsertarBitacora` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_InsertarBitacora`(IN ope VARCHAR(45), IN usr VARCHAR(45), IN fecha DATE, IN proc VARCHAR(45), IN dirIp VARCHAR(45))
BEGIN 
	INSERT INTO tbl_bitacora (operacion,usuario,fecha_ingreso,proceso_afectado,direccion_ip) VALUES(ope,usr,fecha,proc,dirIp);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_InsertarBonos_Desc` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_InsertarBonos_Desc`(in cod INT(11),in nom VARCHAR(45),in valor DOUBLE,in tipo TINYINT(1))
BEGIN
insert into tbl_bonos_descuentos(Pk_idBonos_Desc,Nombre,Valor,Bono_Desc) VALUES (cod,nom,valor,tipo);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_InsertarDepartamento` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_InsertarDepartamento`(IN Nombre VARCHAR(45), IN Descripcion VARCHAR(45))
BEGIN 
	INSERT INTO tbl_departamentos (NombreDepartamento,DescripcionDepartamento, estadoDepartamento) VALUES(Nombre,Descripcion,1);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_Insertarempleado` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Insertarempleado`(in nombre VARCHAR(45),in apellido VARCHAR(45),in fechanac DATE,in corr VARCHAR(45),in corralter VARCHAR(45),in tel VARCHAR(25),in telres VARCHAR(25),in dpi VARCHAR(25),in usu INT(11),in cuentabancaria INT(11),nit VARCHAR(45),sueldobase DOUBLE,dir VARCHAR(45),estado TINYINT(1))
BEGIN
insert into tbl_empleado(nombreEmpleado,apellidoEmpleado,fechaNacEmpleado,correo,correoAlternativo,telefono,telefonoResidencial,DPI,Fk_idUsuario,Cuenta_Bancaria,NIT,Sueldo_Base,Direccion,Estado) 
VALUES (nombre,apellido,fechanac,corr,corralter,tel,telres,dpi,usu,cuentabancaria,nit,sueldobase,dir,estado);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_Insertarguia` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Insertarguia`(in cod INT(11),in rut VARCHAR(45),in descrip VARCHAR(45))
BEGIN
insert into tbl_guiaturistico(Pk_idGuia,Ruta,Descripcion) VALUES (cod,rut,descrip);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_InsertarNominadetalle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_InsertarNominadetalle`(in idenca INT(11),in idliena INT(11),in idbono INT(11))
BEGIN
insert into tbl_nomina_detalle(Pk_idEncabezadoN,Pk_idLinea,Fk_idBonos_Desc) VALUES (idenca,idliena,idbono);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_InsertarNominadetalle2` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_InsertarNominadetalle2`(in idenca INT(11),in idliena INT(11),in idbono INT(11))
BEGIN
insert into tbl_nomina_detalle(Pk_idEncabezadoN,Pk_idLinea,Fk_idBonos_Desc) VALUES (idenca,idliena,idbono);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_InsertarNominaencabezado` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_InsertarNominaencabezado`(in idenca INT(11),in idemp INT(11),in dias INT(11),in fecha DATE,in sueldoliquido Double)
BEGIN
insert into tbl_nomina_encabezado(Pk_idEncabezadoN,Pk_idEmpleado,Dias,Fecha,Sueldo_Liquido) VALUES (idenca,idemp,dias,fecha,sueldoliquido);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_InsertarReservacion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_InsertarReservacion`(in idCotizacion INT(11), in idPago INT(11))
BEGIN
	insert into tbl_reservacion values (0,idCotizacion, idPago);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_InsertarTransporte` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_InsertarTransporte`(IN Placa VARCHAR(45), IN TipoTransporte VARCHAR(45), IN Capacidad int)
BEGIN 
	INSERT INTO tbl_transporte (Placa,TipoTransporte,Capacidad,estadoTransporte) VALUES(Placa,TipoTransporte,Capacidad ,1);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_ModificarBonos_Desc` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_ModificarBonos_Desc`(in cod INT(11),in nom VARCHAR(45),in valor DOUBLE,in tipo TINYINT(1))
BEGIN
UPDATE tbl_bonos_descuentos 
SET Nombre =nom,Valor=valor,Bono_Desc=tipo
WHERE Pk_idBonos_Desc=cod;


END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_Modificarempleado` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Modificarempleado`(in cod INT(11),in nombre VARCHAR(45),in apellido VARCHAR(45),in fechanac DATE,in corr VARCHAR(45),in corralter VARCHAR(45),in tel VARCHAR(25),in telres VARCHAR(25),in dpi VARCHAR(25),in usu INT(11),in cuentabancaria INT(11),nit VARCHAR(45),sueldobase DOUBLE,dir VARCHAR(45))
BEGIN
UPDATE tbl_empleado 
SET nombreEmpleado=nombre,apellidoEmpleado=apellido,fechaNacEmpleado=fechanac,correo=corr,correoAlternativo=corralter,telefono=tel,telefonoResidencial=telres,DPI=dpi,Fk_idUsuario=usu,Cuenta_Bancaria=cuentabancaria,NIT=nit,Sueldo_Base=sueldobase,Direccion=dir
WHERE Pk_idEmpleado=cod;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_Modificarguia` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Modificarguia`(in cod INT(11),in rut VARCHAR(45),in descrip VARCHAR(45))
BEGIN
UPDATE tbl_guiaturistico 
SET Ruta=rut,Descripcion=descrip
WHERE Pk_idGuia=cod;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_ModificarReservacion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_ModificarReservacion`(in idCotizacion int(11), in idPago int(11), 
in cod int(11), in idTransporte int(11), in idEmpleado int(11), in salida date,
in entrada date, in cod2 int(11))
BEGIN
UPDATE tbl_reservacion
SET Fk_idCotizacion = idCotizacion, Fk_idTipoPago = idPago
WHERE Pk_idReservacion = cod;

UPDATE tbl_asignaciontransporte
SET Fk_idTransporte = idTransporte, Fk_idEmpleado = idEmpleado, FechaSalida = salida,
FechaEntrada = entrada
WHERE Pk_idAsignacion=cod2;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Sp_sueldoliquido` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_sueldoliquido`(in cod INT(11),in cantidad DOUBLE)
BEGIN
UPDATE tbl_nomina_encabezado 
SET Sueldo_Liquido=cantidad
WHERE Pk_idEncabezadoN=cod;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `view_departamento`
--

/*!50001 DROP VIEW IF EXISTS `view_departamento`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_departamento` AS select `tbl_departamentos`.`Pk_idDepartamento` AS `Pk_idDepartamento`,`tbl_departamentos`.`NombreDepartamento` AS `NombreDepartamento`,`tbl_departamentos`.`DescripcionDepartamento` AS `DescripcionDepartamento`,`tbl_departamentos`.`estadoDepartamento` AS `estadoDepartamento` from `tbl_departamentos` where (`tbl_departamentos`.`estadoDepartamento` = 1) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_transporte`
--

/*!50001 DROP VIEW IF EXISTS `view_transporte`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_transporte` AS select `tbl_transporte`.`Pk_idTransporte` AS `Pk_idTransporte`,`tbl_transporte`.`Placa` AS `Placa`,`tbl_transporte`.`TipoTransporte` AS `TipoTransporte`,`tbl_transporte`.`Capacidad` AS `Capacidad`,`tbl_transporte`.`estadoTransporte` AS `estadoTransporte` from `tbl_transporte` where (`tbl_transporte`.`estadoTransporte` = 1) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-08-07 11:11:31
