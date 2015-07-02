/*
SQLyog Enterprise - MySQL GUI v7.14 
MySQL - 5.6.20 : Database - musica
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE /*!32312 IF NOT EXISTS*/`musica` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `musica`;

/*Table structure for table `artista` */

DROP TABLE IF EXISTS `artista`;

CREATE TABLE `artista` (
  `id_artista` int(11) NOT NULL AUTO_INCREMENT,
  `artista` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_artista`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `artista` */

/*Table structure for table `cancion` */

DROP TABLE IF EXISTS `cancion`;

CREATE TABLE `cancion` (
  `id_cancion` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) NOT NULL,
  `interprete` varchar(30) NOT NULL,
  `album` varchar(30) DEFAULT NULL,
  `duracion` time NOT NULL,
  `tamaño` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_cancion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `cancion` */

/*Table structure for table `genero` */

DROP TABLE IF EXISTS `genero`;

CREATE TABLE `genero` (
  `id_genero` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(30) DEFAULT NULL,
  `tema` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_genero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `genero` */

/*Table structure for table `persona` */

DROP TABLE IF EXISTS `persona`;

CREATE TABLE `persona` (
  `id_perosna` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) DEFAULT NULL,
  `usuario` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_perosna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `persona` */

/*Table structure for table `recientes` */

DROP TABLE IF EXISTS `recientes`;

CREATE TABLE `recientes` (
  `id_recientes` int(11) NOT NULL AUTO_INCREMENT,
  `reciente` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_recientes`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `recientes` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
