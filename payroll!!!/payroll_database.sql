-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 07, 2022 at 07:04 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payroll_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `employee_information`
--

CREATE TABLE `employee_information` (
  `Emp_Id` int(11) NOT NULL,
  `First_Name` varchar(255) NOT NULL,
  `Middle_Name` varchar(255) NOT NULL,
  `Last_Name` varchar(255) NOT NULL,
  `Contact_Num` varchar(11) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Email_Add` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Hourly_rate` int(25) NOT NULL,
  `Employee_Id` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee_information`
--

INSERT INTO `employee_information` (`Emp_Id`, `First_Name`, `Middle_Name`, `Last_Name`, `Contact_Num`, `Address`, `Email_Add`, `Password`, `Hourly_rate`, `Employee_Id`) VALUES
(1001, 'Testing', 'Test', 'Testing', '02481423423', 'Test1', 'testing@gmail.com', 'testing123', 100, '1001'),
(1002, 'Mark', 'Delle', 'Yorky', '09221430291', 'Tracing St. Quezon City', 'markdelle@gmail.com', 'markdelle123', 50, '1002'),
(1003, 'Employee1', 'Emp1', 'Employee', '09123456342', 'employee st. employee city', 'employeeaddress1@gmail.com', 'pass123', 70, '1003'),
(1004, 'Hello', 'World', 'Test', '09123142442', 'hello world st. testing city', 'helloworld@gmail.com', 'helloworld', 80, '1004'),
(1005, 'Ray', 'Illumina', 'Caseo', '0912132312', 'New York City', 'thisismyemail@gmail.com', 'ray123', 80, '1005'),
(1006, 'Bark', 'Kweii', 'Nie', '09143124324', 'Quezon City', 'barkweiinie@gmail.com', 'moviepals', 150, '1006'),
(1007, 'Emma', 'Seiri', 'Cady', '13134142', 'Neverland St.', 'emma@gmail.com', 'emma123', 50, '1007'),
(1008, 'Marnie', 'Jaralba', 'Majait', '0942352352', 'Quezon City', 'marniemajait@gmail.com', 'password', 50, '1008');

-- --------------------------------------------------------

--
-- Table structure for table `payslip`
--

CREATE TABLE `payslip` (
  `Employee_ID` int(11) NOT NULL,
  `First_Name` varchar(255) NOT NULL,
  `Middle_Name` varchar(255) NOT NULL,
  `Last_Name` varchar(255) NOT NULL,
  `Email_ad` varchar(255) NOT NULL,
  `Reference_Number` varchar(255) NOT NULL,
  `Payslip_Date` varchar(255) NOT NULL,
  `Rate_per_hour` varchar(255) NOT NULL,
  `Hours_worked` varchar(255) NOT NULL,
  `Overtime` varchar(255) NOT NULL,
  `Tax` varchar(255) NOT NULL,
  `SSS` varchar(255) NOT NULL,
  `Pag_Ibig` varchar(255) NOT NULL,
  `Philhealth` varchar(255) NOT NULL,
  `Cash_Advance` varchar(255) NOT NULL,
  `Total_Deduction` varchar(255) NOT NULL,
  `Gross_Pay` varchar(255) NOT NULL,
  `Total_Pay` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `payslip`
--

INSERT INTO `payslip` (`Employee_ID`, `First_Name`, `Middle_Name`, `Last_Name`, `Email_ad`, `Reference_Number`, `Payslip_Date`, `Rate_per_hour`, `Hours_worked`, `Overtime`, `Tax`, `SSS`, `Pag_Ibig`, `Philhealth`, `Cash_Advance`, `Total_Deduction`, `Gross_Pay`, `Total_Pay`) VALUES
(1005, 'Ray', 'Illumina', 'Caseo', 'thisismyemail@gmail.com', '107744', 'Sunday, August 7, 2022', '80', '48', '0', '460.8', '219.648', '288', '314.88', '0', '1283.328', '3840', '2556.672'),
(1005, 'Ray', 'Illumina', 'Caseo', 'raycaseo@outlook.com', '186608', 'Sunday, August 7, 2022', '80', '50', '2', '489.6', '233.376', '306', '334.56', '500', '1863.536', '4080', '2216.464'),
(1006, 'Bark', 'Kweii', 'Nie', 'barkweiinie@gmail.com', '221393', 'Sunday, August 7, 2022', '150', '52', '4', '972', '463.32', '607.5', '664.2', '100', '2807.02', '8100', '5292.98'),
(1008, 'Marnie', 'Jaralba', 'Majait', 'marniemajait@gmail.com', '248141', 'Sunday, August 7, 2022', '50', '50', '2', '306', '145.86', '191.25', '209.1', '0', '852.21', '2550', '1697.79'),
(1007, 'Emma', 'Seiri', 'Cady', 'emma@gmail.com', '47934', 'Sunday, August 7, 2022', '50', '60', '12', '396', '188.76', '247.5', '270.6', '500', '1602.86', '3300', '1697.14');

-- --------------------------------------------------------

--
-- Table structure for table `payslip_request`
--

CREATE TABLE `payslip_request` (
  `request_number` int(11) NOT NULL,
  `emp_id` int(11) NOT NULL,
  `firstname` varchar(255) NOT NULL,
  `lastname` varchar(255) NOT NULL,
  `requestdate` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `payslip_request`
--

INSERT INTO `payslip_request` (`request_number`, `emp_id`, `firstname`, `lastname`, `requestdate`, `status`) VALUES
(5, 1001, 'Testing', 'Testing', 'August 07, 2022', 'Approved'),
(6, 1001, 'Testing', 'Testing', 'August 07, 2022', 'Approved');

-- --------------------------------------------------------

--
-- Table structure for table `time_record`
--

CREATE TABLE `time_record` (
  `Employee_Id` varchar(255) NOT NULL,
  `Log_Date` varchar(255) NOT NULL,
  `Time_in` varchar(255) NOT NULL,
  `Before_Status` varchar(255) NOT NULL,
  `Time_Out` varchar(255) NOT NULL,
  `After_Status` varchar(255) NOT NULL,
  `Atten_Id` int(11) NOT NULL,
  `Hrs_worked` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `time_record`
--

INSERT INTO `time_record` (`Employee_Id`, `Log_Date`, `Time_in`, `Before_Status`, `Time_Out`, `After_Status`, `Atten_Id`, `Hrs_worked`) VALUES
('1001', 'August 07, 2022', '1:26:54 AM', 'Time In', '1:26:59 AM', 'Time Out', 59, '0');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee_information`
--
ALTER TABLE `employee_information`
  ADD PRIMARY KEY (`Emp_Id`);

--
-- Indexes for table `payslip`
--
ALTER TABLE `payslip`
  ADD PRIMARY KEY (`Reference_Number`);

--
-- Indexes for table `payslip_request`
--
ALTER TABLE `payslip_request`
  ADD PRIMARY KEY (`request_number`);

--
-- Indexes for table `time_record`
--
ALTER TABLE `time_record`
  ADD PRIMARY KEY (`Atten_Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee_information`
--
ALTER TABLE `employee_information`
  MODIFY `Emp_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1009;

--
-- AUTO_INCREMENT for table `payslip_request`
--
ALTER TABLE `payslip_request`
  MODIFY `request_number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `time_record`
--
ALTER TABLE `time_record`
  MODIFY `Atten_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
