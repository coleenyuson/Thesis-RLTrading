-- MySQL dump 10.13  Distrib 8.0.11, for Win64 (x86_64)
--
-- Host: localhost    Database: rillan_trading
-- ------------------------------------------------------
-- Server version	8.0.11

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `customer` (
  `cust_id` int(11) NOT NULL,
  `cust_firstName` varchar(100) DEFAULT NULL,
  `cust_lastName` varchar(100) DEFAULT NULL,
  `cust_address` varchar(255) DEFAULT NULL,
  `cust_contactNum` int(11) DEFAULT NULL,
  `cust_faxNum` int(11) DEFAULT NULL,
  PRIMARY KEY (`cust_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `damage_item`
--

DROP TABLE IF EXISTS `damage_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `damage_item` (
  `dmg_item_id` int(11) NOT NULL,
  `item_id_fk` int(11) DEFAULT NULL,
  `dmg_quantity` int(11) DEFAULT NULL,
  `dmg_unit` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`dmg_item_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `damage_item`
--

LOCK TABLES `damage_item` WRITE;
/*!40000 ALTER TABLE `damage_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `damage_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `employee` (
  `emp_id` int(11) NOT NULL AUTO_INCREMENT,
  `emp_firstName` varchar(100) DEFAULT NULL,
  `emp_lastName` varchar(70) DEFAULT NULL,
  `emp_middleName` varchar(100) NOT NULL,
  `emp_contactNum` varchar(45) DEFAULT NULL,
  `emp_address` varchar(255) DEFAULT NULL,
  `emp_birthdate` datetime DEFAULT NULL,
  `emp_sex` int(11) DEFAULT NULL,
  `emp_role` int(11) DEFAULT NULL,
  `emp_branch` varchar(45) DEFAULT NULL,
  `emp_status` int(11) DEFAULT NULL,
  `emp_username` varchar(45) DEFAULT NULL,
  `emp_password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`emp_id`,`emp_middleName`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (3,'Coleen','Yuson','Dagoc','09123456789','Davao City','1998-08-05 00:00:00',0,0,'RL',1,'coleenyuson','system123');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item`
--

DROP TABLE IF EXISTS `item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `item` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_code` varchar(45) DEFAULT NULL,
  `item_desc` varchar(250) DEFAULT NULL,
  `item_brand` varchar(45) DEFAULT NULL,
  `item_category` varchar(45) DEFAULT NULL,
  `item_sellingPrice` float DEFAULT NULL,
  PRIMARY KEY (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item`
--

LOCK TABLES `item` WRITE;
/*!40000 ALTER TABLE `item` DISABLE KEYS */;
INSERT INTO `item` VALUES (1,'NB-001','Green Apple Large Notebook','Green Apple','School Supplies',25),(2,'NB-002','Cattleya Large Spring Notebook','Cattleya','School Supplies',25),(3,'NB-003','Cattleya Regular Spring Notebook','Cattleya','School Supplier',25),(4,'BP-001','Pilot Black','Pilot','School Supplies',20),(5,'BP-002','Pilot Blue','Pilot','School Supplies',20);
/*!40000 ALTER TABLE `item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_store`
--

DROP TABLE IF EXISTS `item_store`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `item_store` (
  `str_item_id` int(11) DEFAULT NULL,
  `str_quantity` int(11) DEFAULT NULL,
  `str_unit` varchar(45) DEFAULT NULL,
  `str_reorderPoint` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_store`
--

LOCK TABLES `item_store` WRITE;
/*!40000 ALTER TABLE `item_store` DISABLE KEYS */;
/*!40000 ALTER TABLE `item_store` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_supplier`
--

DROP TABLE IF EXISTS `item_supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `item_supplier` (
  `itemSupp_id` int(11) NOT NULL AUTO_INCREMENT,
  `supp_id` varchar(45) DEFAULT NULL,
  `item_id` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`itemSupp_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_supplier`
--

LOCK TABLES `item_supplier` WRITE;
/*!40000 ALTER TABLE `item_supplier` DISABLE KEYS */;
/*!40000 ALTER TABLE `item_supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_warehouse`
--

DROP TABLE IF EXISTS `item_warehouse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `item_warehouse` (
  `wrhs_item_id` int(11) DEFAULT NULL,
  `wrhs_quantity` int(11) DEFAULT NULL,
  `wrhs_unit` varchar(45) DEFAULT NULL,
  `wrhs_reorderPoint` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_warehouse`
--

LOCK TABLES `item_warehouse` WRITE;
/*!40000 ALTER TABLE `item_warehouse` DISABLE KEYS */;
/*!40000 ALTER TABLE `item_warehouse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `payment` (
  `payment_id` int(11) NOT NULL,
  `payment_cust_id` int(11) DEFAULT NULL,
  `paymen_so_id` int(11) DEFAULT NULL,
  `payment_type` int(11) DEFAULT NULL,
  `payment_amount` float DEFAULT NULL,
  `payment_date` datetime DEFAULT NULL,
  `payment_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`payment_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase_order`
--

DROP TABLE IF EXISTS `purchase_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `purchase_order` (
  `po_id` int(11) NOT NULL AUTO_INCREMENT,
  `po_supp_id` int(11) DEFAULT NULL,
  `po_emp_id` int(11) DEFAULT NULL,
  `po_date` datetime DEFAULT NULL,
  `po_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`po_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase_order`
--

LOCK TABLES `purchase_order` WRITE;
/*!40000 ALTER TABLE `purchase_order` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchase_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase_order_line`
--

DROP TABLE IF EXISTS `purchase_order_line`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `purchase_order_line` (
  `po_line_id` int(11) NOT NULL AUTO_INCREMENT,
  `po_id` int(11) DEFAULT NULL,
  `po_line_item_id` int(11) DEFAULT NULL,
  `po_line_item_desc` varchar(255) DEFAULT NULL,
  `po_line_quanity` int(11) DEFAULT NULL,
  `po_line_unit` varchar(45) DEFAULT NULL,
  `po_line_price` float DEFAULT NULL,
  PRIMARY KEY (`po_line_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase_order_line`
--

LOCK TABLES `purchase_order_line` WRITE;
/*!40000 ALTER TABLE `purchase_order_line` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchase_order_line` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sales_order`
--

DROP TABLE IF EXISTS `sales_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `sales_order` (
  `so_id` int(11) NOT NULL,
  `so_cust_id` int(11) DEFAULT NULL,
  `so_emp_id` int(11) DEFAULT NULL,
  `so_date` datetime DEFAULT NULL,
  `so_totalAmount` float DEFAULT NULL,
  `so_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`so_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales_order`
--

LOCK TABLES `sales_order` WRITE;
/*!40000 ALTER TABLE `sales_order` DISABLE KEYS */;
/*!40000 ALTER TABLE `sales_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sales_order_line`
--

DROP TABLE IF EXISTS `sales_order_line`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `sales_order_line` (
  `so_line_id` int(11) NOT NULL,
  `so_id` int(11) DEFAULT NULL,
  `so_line_item_id` int(11) DEFAULT NULL,
  `so_line_item_desc` varchar(255) DEFAULT NULL,
  `so_line_selling_price` float DEFAULT NULL,
  `so_line_quantity` int(11) DEFAULT NULL,
  `so_line_discount` float DEFAULT NULL,
  PRIMARY KEY (`so_line_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales_order_line`
--

LOCK TABLES `sales_order_line` WRITE;
/*!40000 ALTER TABLE `sales_order_line` DISABLE KEYS */;
/*!40000 ALTER TABLE `sales_order_line` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `store_record`
--

DROP TABLE IF EXISTS `store_record`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `store_record` (
  `strRecord_id` int(11) NOT NULL AUTO_INCREMENT,
  `strRecord_item_id` int(11) DEFAULT NULL,
  `strRecord_type` int(11) DEFAULT NULL,
  `strRecord_quantity` int(11) DEFAULT NULL,
  `store_record_unit` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`strRecord_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `store_record`
--

LOCK TABLES `store_record` WRITE;
/*!40000 ALTER TABLE `store_record` DISABLE KEYS */;
/*!40000 ALTER TABLE `store_record` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `store_restock_order`
--

DROP TABLE IF EXISTS `store_restock_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `store_restock_order` (
  `ro_id` int(11) NOT NULL AUTO_INCREMENT,
  `ro_employee_id` int(11) DEFAULT NULL,
  `ro_date` datetime DEFAULT NULL,
  `ro_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`ro_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `store_restock_order`
--

LOCK TABLES `store_restock_order` WRITE;
/*!40000 ALTER TABLE `store_restock_order` DISABLE KEYS */;
/*!40000 ALTER TABLE `store_restock_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `store_restock_order_line`
--

DROP TABLE IF EXISTS `store_restock_order_line`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `store_restock_order_line` (
  `ro_line_id` int(11) NOT NULL,
  `ro_id` int(11) DEFAULT NULL,
  `ro_item_id` int(11) DEFAULT NULL,
  `ro_quantity` int(11) DEFAULT NULL,
  `ro_unit` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ro_line_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `store_restock_order_line`
--

LOCK TABLES `store_restock_order_line` WRITE;
/*!40000 ALTER TABLE `store_restock_order_line` DISABLE KEYS */;
/*!40000 ALTER TABLE `store_restock_order_line` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `supplier` (
  `supp_id` int(11) NOT NULL AUTO_INCREMENT,
  `supp_name` varchar(100) DEFAULT NULL,
  `supp_address` varchar(255) DEFAULT NULL,
  `supp_contactPerson` varchar(100) DEFAULT NULL,
  `supp_emailAddress` varchar(45) DEFAULT NULL,
  `supp_contactNum` int(11) DEFAULT NULL,
  `supp_faxNum` int(11) DEFAULT NULL,
  PRIMARY KEY (`supp_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `warehouse_record`
--

DROP TABLE IF EXISTS `warehouse_record`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `warehouse_record` (
  `wrhsRecord_id` int(11) NOT NULL,
  `wrhsRecord_item_id` int(11) DEFAULT NULL,
  `wrhsRecord_type` int(11) DEFAULT NULL,
  `wrhsRecord_quantity` int(11) DEFAULT NULL,
  `wrhsRecord_unit` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`wrhsRecord_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `warehouse_record`
--

LOCK TABLES `warehouse_record` WRITE;
/*!40000 ALTER TABLE `warehouse_record` DISABLE KEYS */;
/*!40000 ALTER TABLE `warehouse_record` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-07-09 20:10:29
