-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-05-2020 a las 02:49:11
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
  `TxtFinado` varchar(254) NOT NULL DEFAULT 'FINADO  DESCONOCIDO',
  `TxtNoOrden` varchar(254) NOT NULL DEFAULT 'NO. ORDEN',
  `TxtFecha` date DEFAULT NULL,
  `TxtHora` time DEFAULT NULL,
  `TxtSituacion` varchar(254) NOT NULL DEFAULT 'SITUACION',
  `TxtSolicitando` varchar(254) NOT NULL DEFAULT 'SOLICITANDO',
  `doc_cofepris` varchar(254) NOT NULL,
  `solicitado` varchar(254) NOT NULL DEFAULT 'SOLICITADO',
  `motivo` varchar(254) NOT NULL DEFAULT 'MOTIVO',
  `pago` decimal(65,2) NOT NULL DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
('AEDF9218-DD-D', 'X', 'MASCULINO', 'UBICACION DEL CUERPO', '07112019161531.pdf');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `fosa_comun_docs`
--

CREATE TABLE `fosa_comun_docs` (
  `id` int(11) NOT NULL,
  `fosa_comun_folio` varchar(254) NOT NULL,
  `ruta` varchar(254) NOT NULL,
  `nombre` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `fosa_comun_docs`
--

INSERT INTO `fosa_comun_docs` (`id`, `fosa_comun_folio`, `ruta`, `nombre`) VALUES
(1, 'AEDF9218-DD-D', '1', '1'),
(2, 'AEDF9218-DD-D', '2', '2'),
(3, 'AEDF9218-DD-D', '3', '3'),
(4, 'AEDF9218-DD-D', '4', '4'),
(5, 'AEDF9218-DD-D', '13052020074403p.m..pdf', 'FICHA'),
(6, 'AEDF9218-DD-D', '13052020074418p.m..pdf', 'TICKET');

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
  `TxtTelefonoResponsable` varchar(254) NOT NULL DEFAULT 'Ninguno',
  `_delete` tinyint(1) NOT NULL DEFAULT '0',
  `f_vencimiento` date NOT NULL,
  `ine` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `inhumaciones`
--

INSERT INTO `inhumaciones` (`id`, `TxtNombre`, `TxtSexo`, `TxtZona`, `TxtPerpetuidad`, `TxtNoTumba`, `TxtFechaNacimiento`, `TxtFechaDefunsion`, `TxtFechaRegistro`, `TxtTipoTumba`, `TxtAdjuntar`, `TxtNombreResponsable`, `TxtDireccionResponsable`, `TxtTelefonoResponsable`, `_delete`, `f_vencimiento`, `ine`) VALUES
(3, '', 'SELECCIONE SEXO', 'SELECCIONE ZONA', '', '', '2020-05-11', '2020-05-11', '2020-05-11', 'SELECCIONE TIPO DE TUMBA', '11052020075102p.m..pdf', '', '', '', 0, '2020-05-11', '11052020075105p.m..pdf'),
(4, 'wdwdwd', 'SELECCIONE SEXO', 'SELECCIONE ZONA', '', '', '2020-05-11', '2020-05-11', '2020-05-11', 'SELECCIONE TIPO DE TUMBA', '11052020075330p.m..pdf', '', '', '', 0, '2020-05-11', '11052020075334p.m..pdf'),
(5, 'rgrgrgr', 'SELECCIONE SEXO', 'SELECCIONE ZONA', '', '', '2020-05-11', '2020-05-11', '2020-05-11', 'SELECCIONE TIPO DE TUMBA', '11052020075610p.m..pdf', '', '', '', 0, '0000-00-00', ''),
(6, 'dwdwdw', 'SELECCIONE SEXO', 'SELECCIONE ZONA', '', '', '2020-05-11', '2020-05-11', '2020-05-11', 'SELECCIONE TIPO DE TUMBA', '11052020075637p.m..pdf', '', '', '', 0, '2027-05-11', '11052020075640p.m..pdf'),
(7, 'DIFUNTO NO. UNO', 'SELECCIONE SEXO', 'SELECCIONE ZONA', '', '', '2020-05-11', '2020-05-11', '2020-05-11', 'SELECCIONE TIPO DE TUMBA', '11052020080505p.m..pdf', '', '', '', 0, '2027-05-11', '11052020080510p.m..pdf'),
(8, 'w4fgewfewfe', 'SELECCIONE SEXO', 'SELECCIONE ZONA', '', '', '2020-05-11', '2020-05-11', '2020-05-11', 'SELECCIONE TIPO DE TUMBA', '11052020080830p.m..pdf', '', '', '', 0, '2027-05-11', '11052020080833p.m..pdf');

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
(8, 3, 'aa', 'aaa', 1, 'a', '2019-11-05 16:00:22'),
(9, 3, 'desc', 'concepto 9', 1450, 'Fatima Yadira Soto Petic', '2019-11-05 16:05:18'),
(10, 3, 'ss', 'sss', 1500, 'Fatima Yadira Soto Petic', '2019-11-21 01:45:25'),
(12, 9, 'wdwdwdwdwdwd', 'wdwdwdwd', 1500, 'Fatima Yadira Soto Petic', '2020-01-16 22:42:06'),
(13, 7, 'PAGO', 'PAGHO ', 1500, 'Fatima Yadira Soto Petic', '2020-05-11 20:05:23'),
(14, 8, 'ewfwefe', 'ewfew', 333, 'Fatima Yadira Soto Petic', '2020-05-11 20:08:39');

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
-- Indices de la tabla `fosa_comun_docs`
--
ALTER TABLE `fosa_comun_docs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fosa_comun` (`fosa_comun_folio`);

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
-- AUTO_INCREMENT de la tabla `fosa_comun_docs`
--
ALTER TABLE `fosa_comun_docs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `inhumaciones`
--
ALTER TABLE `inhumaciones`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `inhumaciones_pagos`
--
ALTER TABLE `inhumaciones_pagos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

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
-- Filtros para la tabla `fosa_comun_docs`
--
ALTER TABLE `fosa_comun_docs`
  ADD CONSTRAINT `fosa_comun` FOREIGN KEY (`fosa_comun_folio`) REFERENCES `fosa_comun` (`TxtFolio`);

--
-- Filtros para la tabla `inhumaciones_pagos`
--
ALTER TABLE `inhumaciones_pagos`
  ADD CONSTRAINT `oagis_inhumanaciones` FOREIGN KEY (`inhumanacion`) REFERENCES `inhumaciones` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
