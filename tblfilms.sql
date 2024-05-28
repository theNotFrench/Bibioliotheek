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
-- Table structure for table `tblfilms`
--

CREATE TABLE `tblfilms` (
  `gameID` int(11) NOT NULL,
  `titel` varchar(70) NOT NULL,
  `jaar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblfilms`
--

INSERT INTO `tblfilms` (`gameID`, `titel`, `jaar`) VALUES
(1, 'Dark Souls 3', 2016),
(2, 'Lunacid', 2023),
(5, 'apex', 2020),
(6, 'Guilty gear', 2021),
(7, 'Dark Souls 2', 2013),
(9, 'Dark souls 1', 2011);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblfilms`
--
ALTER TABLE `tblfilms`
  ADD PRIMARY KEY (`gameID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblfilms`
--
ALTER TABLE `tblfilms`
  MODIFY `gameID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
