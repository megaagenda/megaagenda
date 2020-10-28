/*
Navicat MySQL Data Transfer

Source Server         : Mysql_Quality
Source Server Version : 80021
Source Host           : www.qualitysys.com.br:3300
Source Database       : agenda

Target Server Type    : MYSQL
Target Server Version : 80021
File Encoding         : 65001

Date: 2020-10-28 15:02:44
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for email
-- ----------------------------
DROP TABLE IF EXISTS `email`;
CREATE TABLE `email` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_pessoa` int NOT NULL,
  `email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `chave_email` (`id_pessoa`),
  CONSTRAINT `chave_email` FOREIGN KEY (`id_pessoa`) REFERENCES `pessoa` (`id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- ----------------------------
-- Records of email
-- ----------------------------

-- ----------------------------
-- Table structure for endereco
-- ----------------------------
DROP TABLE IF EXISTS `endereco`;
CREATE TABLE `endereco` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_pessoa` int NOT NULL,
  `tipo` varchar(255) DEFAULT NULL,
  `logradouro` varchar(255) DEFAULT NULL,
  `endereco` varchar(255) DEFAULT NULL,
  `numero` varchar(255) DEFAULT NULL,
  `complemento` varchar(255) DEFAULT NULL,
  `bairro` varchar(255) DEFAULT NULL,
  `cidade` varchar(255) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL,
  `CEP` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `chave_endereco` (`id_pessoa`),
  CONSTRAINT `chave_endereco` FOREIGN KEY (`id_pessoa`) REFERENCES `pessoa` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- ----------------------------
-- Records of endereco
-- ----------------------------

-- ----------------------------
-- Table structure for pessoa
-- ----------------------------
DROP TABLE IF EXISTS `pessoa`;
CREATE TABLE `pessoa` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) DEFAULT NULL,
  `cpf` int DEFAULT NULL,
  `rg` varchar(255) DEFAULT NULL,
  `sexo` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- ----------------------------
-- Records of pessoa
-- ----------------------------

-- ----------------------------
-- Table structure for telefone
-- ----------------------------
DROP TABLE IF EXISTS `telefone`;
CREATE TABLE `telefone` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_pessoa` int NOT NULL,
  `tipo` varchar(255) DEFAULT NULL,
  `numero` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `chave_telefone` (`id_pessoa`),
  CONSTRAINT `chave_telefone` FOREIGN KEY (`id_pessoa`) REFERENCES `pessoa` (`id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- ----------------------------
-- Records of telefone
-- ----------------------------
