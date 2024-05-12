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
-- Table structure for table `user_lifestyle`
--

CREATE TABLE `user_lifestyle` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `water` int(11) NOT NULL,
  `sleep` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_lifestyle`
--

INSERT INTO `user_lifestyle` (`id`, `user_id`, `water`, `sleep`) VALUES
(1, 6, 8, 8),
(2, 11, 4, 4),
(3, 12, 8, 8),
(4, 13, 8, 8),
(5, 14, 8, 8),
(6, 15, 8, 8),
(7, 16, 6, 1),
(8, 17, 10, 10),
(9, 18, 10, 10),
(10, 19, 20, 8),
(11, 20, 8, 6),
(12, 21, 5, 5),
(13, 22, 50, 2),
(14, 23, 100, 24),
(15, 24, 8, 8);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `user_lifestyle`
--
ALTER TABLE `user_lifestyle`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `user_lifestyle`
--
ALTER TABLE `user_lifestyle`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
