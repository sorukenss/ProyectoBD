USE PRegCol;

GO
CREATE PROCEDURE GuardarEmpleado
@Primer_Nombre varchar(20),@Segundo_Nombre varchar(20),@Primer_Apellido varchar(20),@Segundo_Apellido varchar(20),@Sexo varchar(9),@Identificacion varchar(11),@Contrase�a varchar(20)
AS
INSERT INTO Empleado(Identificacion,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Segundo_Apellido,Sexo,Contrase�a)
VALUES(@Identificacion,@Primer_Apellido,@Segundo_Nombre,@Primer_Apellido,@Segundo_Apellido,@Sexo,@Contrase�a)
GO

SELECT * FROM Empleado;