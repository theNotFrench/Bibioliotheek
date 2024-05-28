-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 28, 2024 at 10:35 PM
-- Server version: 5.7.17
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `filmproject`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbllenen`
--

CREATE TABLE `tbllenen` (
  `lenenID` int(11) NOT NULL,
  `gameID` int(11) NOT NULL,
  `uitlenen` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbllenen`
--

INSERT INTO `tbllenen` (`lenenID`, `gameID`, `uitlenen`) VALUES
(1, 1, 0),
(2, 6, 1),
(3, 2, 0),
(5, 5, 0),
(7, 9, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbllenen`
--
ALTER TABLE `tbllenen`
  ADD PRIMARY KEY (`lenenID`),
  ADD KEY `gameID` (`gameID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbllenen`
--
ALTER TABLE `tbllenen`
  MODIFY `lenenID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbllenen`
--
ALTER TABLE `tbllenen`
  ADD CONSTRAINT `tbllenen_ibfk_1` FOREIGN KEY (`gameID`) REFERENCES `tblfilms` (`gameID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
