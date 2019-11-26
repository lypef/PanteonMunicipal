-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-11-2019 a las 08:39:09
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
-- Estructura de tabla para la tabla `espacios_asignacion`
--

CREATE TABLE `espacios_asignacion` (
  `id` int(11) NOT NULL,
  `inhumacion` int(11) NOT NULL,
  `espacios_secciones_lugares` int(11) NOT NULL,
  `TxtModalidad` varchar(254) NOT NULL,
  `TxtObservaciones` longtext NOT NULL,
  `TxtCosto` double NOT NULL,
  `TxtCaducidad` date NOT NULL,
  `registro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `espacios_asignacion`
--

INSERT INTO `espacios_asignacion` (`id`, `inhumacion`, `espacios_secciones_lugares`, `TxtModalidad`, `TxtObservaciones`, `TxtCosto`, `TxtCaducidad`, `registro`) VALUES
(38, 3, 7, 'Ninguno', 'Ninguno', 3, '2026-11-21', '2019-11-26 00:58:49'),
(39, 4, 8, 'Ninguno', 'Ninguno', 33, '2026-11-21', '2019-11-25 00:58:49'),
(40, 2, 41, 'Ninguno', 'Ninguno', 1890, '2026-11-21', '2019-11-26 00:58:49'),
(41, 5, 4, 'Ninguno', 'Ninguno', 1000, '2026-11-26', '2019-11-26 01:36:23');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `espacios_secciones`
--

CREATE TABLE `espacios_secciones` (
  `id` int(11) NOT NULL,
  `nombre` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `espacios_secciones`
--

INSERT INTO `espacios_secciones` (`id`, `nombre`) VALUES
(11, 'ZONA 2'),
(15, 'ZONA 4'),
(16, 'ZONA 15'),
(25, 'ZONA 6'),
(27, 'ZONA 8');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `espacios_secciones_lugares`
--

CREATE TABLE `espacios_secciones_lugares` (
  `id` int(11) NOT NULL,
  `seccion` int(11) NOT NULL,
  `nombre` varchar(254) NOT NULL,
  `ocupado` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `espacios_secciones_lugares`
--

INSERT INTO `espacios_secciones_lugares` (`id`, `seccion`, `nombre`, `ocupado`) VALUES
(4, 11, 'lugar 18', 1),
(5, 11, 'lugar 18', 0),
(6, 11, 'lugar 19', 0),
(7, 11, 'lugar 19', 1),
(8, 11, 'lugar 20', 1),
(23, 27, 'lugar 23', 0),
(24, 11, 'lugar 20', 0),
(25, 15, 'lugar 21', 0),
(26, 25, 'lugar 22', 0),
(27, 27, 'sss', 0),
(38, 15, 'sssss', 0),
(39, 25, 'ss', 0),
(41, 11, 'sss', 1);

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
('cscscscsc', 'scscscsc', 'cscscsc', '2019-11-25', '23:14:37', '1.- INHUMANACION', 'scscsc'),
('dwdwdwd', 'wdwdwd', 'dwdwdwdw', '2019-11-25', '23:16:46', '1.- INHUMANACION', 'wdwdwd'),
('dwdwdwdw', 'dwdwdwdwd', 'dwdwdwdwd', '2019-11-25', '23:14:30', 'SITUACION', 'wdwdwdwd'),
('wdwdw', 'xcefd', 'dwdwdwdwdwdw', '2019-11-25', '23:14:43', '1.- INHUMANACION', 'wwdwdw');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `fosa_comun`
--

CREATE TABLE `fosa_comun` (
  `TxtFolio` varchar(254) NOT NULL,
  `TxtFuneraria` varchar(254) NOT NULL,
  `TxtSexo` varchar(254) NOT NULL,
  `TxtUbicacion` longtext NOT NULL,
  `TxtFiscalia` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `fosa_comun`
--

INSERT INTO `fosa_comun` (`TxtFolio`, `TxtFuneraria`, `TxtSexo`, `TxtUbicacion`, `TxtFiscalia`) VALUES
('AEDF9218-DD-D', 'X', 'MASCULINO', 'UBICACION DEL CUERPO', '07112019161531.pdf'),
('FOLIO', 'FUNERARIA', 'FEMENINO', 'UBICACION DEL CUERPOUBICACION DEL CUERPOUBICACION DEL CUERPOUBICACION DEL CUERPOUBICACION DEL CUERPOUBICACION DEL CUERPOUBICACION DEL CUERPOUBICACION DEL CUERPOUBICACION DEL CUERPOUBICACION DEL CUERPOUBICACION DEL CUERPOUBICACION DEL CUERPOUBICACION DEL ', '07112019161544.pdf'),
('FOLIO UPDATE', 'FUNERARIA UPDATE', 'FEMENINO', 'UBICACION UPDATE', '07112019161512.pdf'),
('kjhjkhkjheee', 'jkhjkhjkee', 'SELECCIONE UN SEXOee', 'vcedfefefeee', '07112019151119.pdfeeee'),
('www', 'www', 'www', 'www', 'wwww');

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
(2, 'FEDERICO AQUISI  PEREZ RAMIREZa', 'HOMBRE', 'ZONA SUR', '333JHN3JKNJK3', 'M3J3H3', '2019-11-21', '2019-11-22', '2019-11-23', 'AA', '3112019171321.pdf', 'JOSE FEDERICO AQUINO PEREZ', 'SSS', 'SSSS'),
(3, 'ESTA ES UNA PRUEBA DE ACTUALIZACION', 'OTRO', 'ZONA SUR', '3JKN3KJ3NJ33J3NJ', 'KNKLNKLN', '2019-11-01', '2019-11-02', '2019-11-03', '', '4112019224117.pdf', 'NOMBRE COMPLETO CON APELLIDOS DEL ENCARGADO', '20 de noviembre, no. 306, col. centro.', '1651515'),
(4, 'frgfbfgdb', 'bfdbdf', 'fdbfdbfdbffdbfdbfbfd', 'fbbfdbfd', 'dfbfdb', '2019-11-21', '2019-11-21', '2019-11-21', 'fdbfbfbfdb', '2111201924423.pdf', 'fdbfdbfb', 'fdbfb', ''),
(5, 'aaaa', 'aa', 'aaa', 'aa', 'aa', '2019-11-26', '2019-11-26', '2019-11-26', '', '2611201904625.pdf', 'aaa', 'aa', 'a');

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
(9, 3, 'desc', 'concepto 9', 1450, 'Fatima Yadira Soto Petic', '2019-11-05 16:05:18'),
(10, 3, 'ss', 'sss', 1500, 'Fatima Yadira Soto Petic', '2019-11-21 01:45:25'),
(11, 2, '', '', 1500, 'Fatima Yadira Soto Petic', '2019-11-26 00:46:34');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(254) NOT NULL,
  `password` varchar(254) NOT NULL,
  `name` varchar(254) NOT NULL,
  `is_admin` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `name`, `is_admin`) VALUES
(1, 'root', '63a9f0ea7bb98050796b649e85481845', 'Admin', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `espacios_asignacion`
--
ALTER TABLE `espacios_asignacion`
  ADD PRIMARY KEY (`id`),
  ADD KEY `inhumanacion_asignacion_espacio` (`espacios_secciones_lugares`),
  ADD KEY `inhumanacion asignacion` (`inhumacion`);

--
-- Indices de la tabla `espacios_secciones`
--
ALTER TABLE `espacios_secciones`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `espacios_secciones_lugares`
--
ALTER TABLE `espacios_secciones_lugares`
  ADD PRIMARY KEY (`id`),
  ADD KEY `seccion_lugar` (`seccion`);

--
-- Indices de la tabla `exhumaciones`
--
ALTER TABLE `exhumaciones`
  ADD PRIMARY KEY (`TxtFolio`);

--
-- Indices de la tabla `fosa_comun`
--
ALTER TABLE `fosa_comun`
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
-- AUTO_INCREMENT de la tabla `espacios_asignacion`
--
ALTER TABLE `espacios_asignacion`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT de la tabla `espacios_secciones`
--
ALTER TABLE `espacios_secciones`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT de la tabla `espacios_secciones_lugares`
--
ALTER TABLE `espacios_secciones_lugares`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT de la tabla `inhumaciones`
--
ALTER TABLE `inhumaciones`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `inhumaciones_pagos`
--
ALTER TABLE `inhumaciones_pagos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `espacios_asignacion`
--
ALTER TABLE `espacios_asignacion`
  ADD CONSTRAINT `espacios_asignacion` FOREIGN KEY (`espacios_secciones_lugares`) REFERENCES `espacios_secciones_lugares` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `inhumanacion asignacion` FOREIGN KEY (`inhumacion`) REFERENCES `inhumaciones` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `espacios_secciones_lugares`
--
ALTER TABLE `espacios_secciones_lugares`
  ADD CONSTRAINT `seccion_lugar` FOREIGN KEY (`seccion`) REFERENCES `espacios_secciones` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `inhumaciones_pagos`
--
ALTER TABLE `inhumaciones_pagos`
  ADD CONSTRAINT `oagis_inhumanaciones` FOREIGN KEY (`inhumanacion`) REFERENCES `inhumaciones` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
