-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 11, 2024 at 10:31 PM
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
-- Table structure for table `tbladmins`
--

CREATE TABLE `tbladmins` (
  `adminid` int(11) NOT NULL,
  `klantid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbladmins`
--

INSERT INTO `tbladmins` (`adminid`, `klantid`) VALUES
(1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblgames`
--

CREATE TABLE `tblgames` (
  `gameID` int(11) NOT NULL,
  `gamenaam` varchar(50) NOT NULL,
  `producer` varchar(50) NOT NULL,
  `uitgavejaar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblgames`
--

INSERT INTO `tblgames` (`gameID`, `gamenaam`, `producer`, `uitgavejaar`) VALUES
(1, 'Dark Souls III', 'Fromsoftware', 2016);

-- --------------------------------------------------------

--
-- Table structure for table `tblklant`
--

CREATE TABLE `tblklant` (
  `klantid` int(11) NOT NULL,
  `klantnaam` varchar(50) NOT NULL,
  `gebruikernaam` varchar(50) NOT NULL,
  `wachtwoord` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblklant`
--

INSERT INTO `tblklant` (`klantid`, `klantnaam`, `gebruikernaam`, `wachtwoord`) VALUES
(1, 'rayan', 'ray', 'mira'),
(2, 'Tim', 'Tim', 'timothy');

-- --------------------------------------------------------

--
-- Table structure for table `tbllijnuitlenen`
--

CREATE TABLE `tbllijnuitlenen` (
  `lijnuitleenid` int(11) NOT NULL,
  `uitleenid` int(11) NOT NULL,
  `gameID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbluitlenen`
--

CREATE TABLE `tbluitlenen` (
  `uitleenid` int(11) NOT NULL,
  `klantid` int(11) NOT NULL,
  `datumbegin` date NOT NULL,
  `datumterug` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbladmins`
--
ALTER TABLE `tbladmins`
  ADD PRIMARY KEY (`adminid`);

--
-- Indexes for table `tblgames`
--
ALTER TABLE `tblgames`
  ADD PRIMARY KEY (`gameID`);

--
-- Indexes for table `tblklant`
--
ALTER TABLE `tblklant`
  ADD PRIMARY KEY (`klantid`);

--
-- Indexes for table `tbllijnuitlenen`
--
ALTER TABLE `tbllijnuitlenen`
  ADD PRIMARY KEY (`lijnuitleenid`);

--
-- Indexes for table `tbluitlenen`
--
ALTER TABLE `tbluitlenen`
  ADD PRIMARY KEY (`uitleenid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbladmins`
--
ALTER TABLE `tbladmins`
  MODIFY `adminid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tblgames`
--
ALTER TABLE `tblgames`
  MODIFY `gameID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tblklant`
--
ALTER TABLE `tblklant`
  MODIFY `klantid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbllijnuitlenen`
--
ALTER TABLE `tbllijnuitlenen`
  MODIFY `lijnuitleenid` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbluitlenen`
--
ALTER TABLE `tbluitlenen`
  MODIFY `uitleenid` int(11) NOT NULL AUTO_INCREMENT;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
