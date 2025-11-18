USE tortilleria_miry;

-- CREATE TABLE usuarios
-- (
-- num_empleado INT PRIMARY KEY NOT NULL,
-- NOMBRE VARCHAR (25),
-- PRIMER_APELLIDO VARCHAR (25),
-- SEGUNDO_APELLIDO VARCHAR (25),
-- CONTRASENA VARCHAR (25),
-- ROL VARCHAR (25)
-- );

-- INSERT INTO usuarios (num_empleado, NOMBRE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, CONTRASENA, ROL)
-- VALUES 
-- (2, 'Melissa', 'Treviño', 'Perez', '123', 'Supervisor'),
-- (3, 'Arely', 'González', 'Landeros', '123', 'Supervisor'),
-- (4, 'Angela', 'Torres', 'Hernandez', '123', 'Supervisor'),
-- (5, 'Ali', 'Martinez', 'Gutierrez', '123', 'Supervisor');

SELECT rol FROM usuarios WHERE num_empleado = 2 AND contrasena = 123;