# CntNetCore
El proyecto fue desarollado en .Net Core 5 con Entity Framework

para llevar a cabo la ejecución del mismo se debe descargar el proyecto, abrir la solución, dirigirse appsettings.json en la raiz principal y editar la linea 
CntNetCoreContext en la cual modificará el parámetro de Server y en el debera especificar el nombre o dirección ip del servidor donde tenga instalado sql server y que a su vez
le permita el ingreso al mismo. Al darle f5 desde visual studio el proyecto creará la base de datos y sus respectivas tablas, sin embargo, si lo que desea es
realizar la prueba del mismo con algunos pacientes ya creados a traves del sistema, ejecute el script .sql llamado CntNetCore.sql desde su gestor de base de datos SQL Server.
