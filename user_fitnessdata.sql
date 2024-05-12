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
-- Table structure for table `user_fitnessdata`
--

CREATE TABLE `user_fitnessdata` (
  `id` int(11) NOT NULL,
  `user_id` int(40) NOT NULL,
  `weight` int(40) NOT NULL,
  `height` int(40) NOT NULL,
  `age` int(40) NOT NULL,
  `gender` int(40) NOT NULL,
  `activity_level` text NOT NULL,
  `weight_goal` text NOT NULL,
  `target_weight` int(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_fitnessdata`
--

INSERT INTO `user_fitnessdata` (`id`, `user_id`, `weight`, `height`, `age`, `gender`, `activity_level`, `weight_goal`, `target_weight`) VALUES
(8, 11, 40, 140, 20, 1, 'Sedentary (little to no exercise)', 'Weight Loss', 45),
(9, 12, 60, 165, 30, 1, 'Moderately active (moderate exercise/sports 3-5 days a week)', 'Weight Loss', 55),
(10, 13, 60, 165, 30, 1, 'Moderately active (moderate exercise/sports 3-5 days a week)', 'Weight Loss', 55),
(11, 14, 60, 165, 30, 1, 'Moderately active (moderate exercise/sports 3-5 days a week)', 'Weight Loss', 55),
(12, 15, 60, 165, 30, 1, 'Moderately active (moderate exercise/sports 3-5 days a week)', 'Weight Loss', 55),
(13, 16, 60, 65, 30, 1, 'Moderately active (moderate exercise/sports 3-5 days a week)', 'Weight Loss', 55),
(14, 17, 60, 165, 30, 1, 'Moderately active (moderate exercise/sports 3-5 days a week)', 'Weight Loss', 40),
(15, 18, 60, 165, 30, 1, 'Moderately active (moderate exercise/sports 3-5 days a week)', 'Weight Loss', 40),
(16, 19, 100, 50, 25, 0, 'Lightly active (light exercise/sports 1-3 days a week)', 'Weight Loss', 150),
(17, 20, 42, 150, 19, 1, 'Lightly active (light exercise/sports 1-3 days a week)', 'Weight Gain', 45),
(18, 21, 40, 120, 4, -1, 'Moderately active (moderate exercise/sports 3-5 days a week)', 'Weight Gain', 55),
(19, 22, 60, 65, 19, 0, 'Very active (hard exercise/sports 6-7 days a week)', 'Weight Gain', 55),
(20, 23, 180, 150, 45, 0, 'Sedentary (little to no exercise)', 'Weight Loss', 150),
(21, 24, 75, 180, 20, 0, 'Moderately active (moderate exercise/sports 3-5 days a week)', 'Weight Gain', 80);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `user_fitnessdata`
--
ALTER TABLE `user_fitnessdata`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `user_fitnessdata`
--
ALTER TABLE `user_fitnessdata`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
