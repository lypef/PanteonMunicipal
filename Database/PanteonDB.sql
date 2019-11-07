-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-11-2019 a las 06:05:12
-- Versión del servidor: 10.1.36-MariaDB
-- Versión de PHP: 5.6.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `panteondb`
--
CREATE DATABASE IF NOT EXISTS `panteondb` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `panteondb`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `exhumaciones`
--

CREATE TABLE `exhumaciones` (
  `TxtFolio` varchar(254) NOT NULL,
  `TxtFinado` varchar(254) NOT NULL,
  `TxtNoOrden` varchar(254) NOT NULL,
  `TxtFecha` date NOT NULL,
  `TxtHora` time NOT NULL,
  `TxtSituacion` varchar(254) NOT NULL,
  `TxtSolicitando` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `exhumaciones`
--

INSERT INTO `exhumaciones` (`TxtFolio`, `TxtFinado`, `TxtNoOrden`, `TxtFecha`, `TxtHora`, `TxtSituacion`, `TxtSolicitando`) VALUES
('FUPDATE', 'FINADO ACTUALIZADO', 'NUMERO ACTUALIZADO', '2019-11-06', '22:09:24', '1.- INHUMANACION', ' SOLICITANTE ACTUALIZADO'),
('HTRHTRHTRH', 'FHTGTRGFHTRHTRHTRH', 'TRHTRHTRTRHTRH', '2019-11-06', '18:16:53', '2.- FOSA COMUN', 'RHTRTRH'),
('JYTJYTJ', 'YJNJYTJYT', 'YTJYTJYTJJ', '2019-11-06', '18:16:43', '2.- FOSA COMUN', 'TJYTJYJJYJ'),
('TRHTRHTRH', 'FRTHTRHTRH', 'TRHTRTRHRTHTRH', '2019-11-06', '18:17:00', '1.- INHUMANACION', 'TRHRTHH');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inhumaciones`
--

CREATE TABLE `inhumaciones` (
  `id` int(11) NOT NULL,
  `TxtNombre` varchar(254) NOT NULL DEFAULT 'Ninguno',
  `TxtSexo` varchar(254) NOT NULL DEFAULT 'Ninguno',
  `TxtZona` varchar(254) NOT NULL DEFAULT 'Ninguno',
  `TxtPerpetuidad` varchar(254) NOT NULL DEFAULT 'Ninguno',
  `TxtNoTumba` varchar(254) NOT NULL DEFAULT 'Ninguno',
  `TxtFechaNacimiento` date NOT NULL,
  `TxtFechaDefunsion` date NOT NULL,
  `TxtFechaRegistro` date NOT NULL,
  `TxtTipoTumba` varchar(254) NOT NULL DEFAULT 'Ninguno',
  `TxtAdjuntar` varchar(254) NOT NULL DEFAULT 'Ninguno',
  `TxtNombreResponsable` varchar(254) NOT NULL DEFAULT 'Ninguno',
  `TxtDireccionResponsable` varchar(254) NOT NULL DEFAULT 'Ninguno',
  `TxtTelefonoResponsable` varchar(254) NOT NULL DEFAULT 'Ninguno'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `inhumaciones`
--

INSERT INTO `inhumaciones` (`id`, `TxtNombre`, `TxtSexo`, `TxtZona`, `TxtPerpetuidad`, `TxtNoTumba`, `TxtFechaNacimiento`, `TxtFechaDefunsion`, `TxtFechaRegistro`, `TxtTipoTumba`, `TxtAdjuntar`, `TxtNombreResponsable`, `TxtDireccionResponsable`, `TxtTelefonoResponsable`) VALUES
(2, 'FEDERICO AQUISI  PEREZ RAMIREZa', 'HOMBRE', 'ZONA SUR', '333JHN3JKNJK3', 'M3J3H3', '2010-11-03', '2019-11-03', '2019-11-03', 'AA', '3112019171321.pdf', 'JOSE FEDERICO AQUINO PEREZ', 'SSS', 'SSSS'),
(3, 'ESTA ES UNA PRUEBA DE ACTUALIZACION', 'OTRO', 'ZONA SUR', '3JKN3KJ3NJ33J3NJ', 'KNKLNKLN', '2019-11-01', '2019-11-02', '2019-11-03', '', '4112019224117.pdf', 'NOMBRE COMPLETO CON APELLIDOS DEL ENCARGADO', '20 de noviembre, no. 306, col. centro.', '1651515');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inhumaciones_pagos`
--

CREATE TABLE `inhumaciones_pagos` (
  `id` int(11) NOT NULL,
  `inhumanacion` int(11) NOT NULL,
  `descripcion` varchar(254) NOT NULL,
  `concepto` varchar(254) NOT NULL,
  `monto` float NOT NULL,
  `preseidente` varchar(254) NOT NULL,
  `fecha` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `inhumaciones_pagos`
--

INSERT INTO `inhumaciones_pagos` (`id`, `inhumanacion`, `descripcion`, `concepto`, `monto`, `preseidente`, `fecha`) VALUES
(6, 3, 'PAGO ACTUALIZADO', 'PAGO POR 4 AÑOS', 1500.5, 'A', '2019-11-05 15:41:24'),
(7, 2, 'AQUI SE ESCRIBEN LAS DESCRIPCIONES', 'AQUI SE ESCRIBE EL CONCEPTO', 150.5, 'LA SEÑORA PRESIDENTA', '2019-11-05 16:00:12'),
(8, 3, 'aa', 'aaa', 1, 'a', '2019-11-05 16:00:22'),
(9, 3, 'desc', 'concepto 9', 1450, 'Fatima Yadira Soto Petic', '2019-11-05 16:05:18');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(254) NOT NULL,
  `password` varchar(254) NOT NULL,
  `name` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `name`) VALUES
(1, 'root', '63a9f0ea7bb98050796b649e85481845', 'Admin');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `exhumaciones`
--
ALTER TABLE `exhumaciones`
  ADD PRIMARY KEY (`TxtFolio`);

--
-- Indices de la tabla `inhumaciones`
--
ALTER TABLE `inhumaciones`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `inhumaciones_pagos`
--
ALTER TABLE `inhumaciones_pagos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `oagis_inhumanaciones` (`inhumanacion`);

--
-- Indices de la tabla `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `inhumaciones`
--
ALTER TABLE `inhumaciones`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `inhumaciones_pagos`
--
ALTER TABLE `inhumaciones_pagos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `inhumaciones_pagos`
--
ALTER TABLE `inhumaciones_pagos`
  ADD CONSTRAINT `oagis_inhumanaciones` FOREIGN KEY (`inhumanacion`) REFERENCES `inhumaciones` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
