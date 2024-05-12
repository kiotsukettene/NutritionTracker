-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 12, 2024 at 08:20 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `nutrition_tracker`
--

-- --------------------------------------------------------

--
-- Table structure for table `user_macros`
--

CREATE TABLE `user_macros` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `calories` int(11) NOT NULL,
  `carbs` int(11) NOT NULL,
  `fat` int(11) NOT NULL,
  `protein` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_macros`
--

INSERT INTO `user_macros` (`id`, `user_id`, `calories`, `carbs`, `fat`, `protein`) VALUES
(1, 1, 1623, 202, 45, 101),
(2, 2, 1692, 211, 47, 105),
(6, 6, 2199, 274, 61, 137),
(7, 11, 716, 89, 19, 44),
(8, 12, 1546, 193, 42, 96),
(9, 13, 1546, 193, 42, 96),
(10, 14, 1546, 193, 42, 96),
(11, 15, 1546, 193, 42, 96),
(12, 16, 577, 72, 16, 36),
(13, 17, 1546, 193, 42, 96),
(14, 18, 1546, 193, 42, 96),
(15, 19, 1139, 142, 31, 71),
(16, 20, 1763, 220, 48, 110),
(17, 21, 250, 31, 6, 15),
(18, 22, 1830, 228, 50, 114),
(19, 23, 2520, 315, 70, 157),
(20, 24, 3009, 376, 83, 188);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `user_macros`
--
ALTER TABLE `user_macros`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `user_macros`
--
ALTER TABLE `user_macros`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
