CREATE TABLE IF NOT EXISTS `person` (
  `id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `age` int NOT NULL,
  `gender` varchar(9) NOT NULL,
  PRIMARY KEY (`id`)
) 
