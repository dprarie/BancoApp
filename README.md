# BancoApp
Antes de comenzar es necesario levantar la Base de Datos. Para ello se proporciona el script de creación de la BD para aplicar en SMSS. 

Una vez creada la Base de Datos, es necesario saber si se ha instalado el SQL Server como Localhost o no. 

De haberse instalado como localhost, no será necesario hacer nada más, si no, es necesario que modifique la cadena de conexión de la BD en el archivo SqlConnectionManager dentro del proyecto BancoApp.

La cadena de conexión actual es: Server=localhost;Database=master;Trusted_Connection=True; 

Sólo habría que sustituir localhost por el nombre del pc donde se haya levantado la Base de Datos.
________________________________________________________________________________________________________________________________________________________________________________

Para acceder a la aplicación es necesario usar las siguientes credenciales: 

usuario: admin
contraseña: admin

Una vez iniciada sesión se podrá crear un nuevo usuario con su correspondiente contraseña. 

Como es una aplicación de prueba y los datos de las cuentas bancarias está incluidos en una tabla no accesible mediante la aplicación, solo poseen cuentas bancarias los 11 
primeros clientes (se pueden buscar por id en el apartado correspondiente). 

Esos 11 clientes son 10 clientes de prueba y el admin. Los nuevos clientes que se generen en la aplicación no poseerán cuentas bancarias. 
