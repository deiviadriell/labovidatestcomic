# Prueba técnica Labovida
 
 La siguiente prueba consta de una aplicacion web realizada en Aspnet MVC para la selección de comics, se deberá realizar el fork del 
 repositorio en sus cuentas de github y clonarlas en sus respectivos ambientes, además se debe de crear un documento Word con capturas que reflejen el resultado de todos los   puntos al correo sistemas@grupolabovida.com
 
 El tiempo estimado de esta prueba es de 2 horas, y contara a partir de la generacion del repositorio en sus debidas cuentas. 
 
 Si su prueba asignada es de caracter remoto favor generar una base de datos en MS Sql Server, y generar la base siguiendo el script que se encuentra en ComicBookGallery/BackupBD.bak

![screenshot1](https://github.com/sarn1/example-aspnet-mvc/blob/master/screenshot1.png)

### 1. Modificar el orden, el primer comic deberá ser Bone #50 (1 punto) ###
### 2. Modificar el color del texto en el detalle de los comics (1 puntos) ###
### 3. Agregar un nuevo comic a tu elección, junto con su detalle (2 puntos) ###
### 4. Crear un nuevo controlador llamada "Distribucion", deberá tener una vista que muestre una tabla con valores random de ejemplares vendidos (4 puntos) ###
### 5. Crear un nuevo método dentro del controlador ComicsBook que descargue el siguiente PDF https://www.is4k.es/sites/default/files/contenidos/los_vengadores_acoso_nunca_mas_marvel_panini_is4k.pdf luego de aplastar un boton descargar en la vista de detalle (4 puntos) ###
### 6. Descargar el paquete de nugget y usar entity framework para conectarse a la siguiente base de datos: MS SQL SERVER ###
Server: SERVERAS2\GRUPOVIDA 
Usuario: prueba
Password: prueba (3 puntos) 
### 7. Crear un nuevo boton en el navbar llamado ¨Dashboard¨, se debe generar una pagina en blanco que solo muestre un boton (3 puntos) ###
### 8. Usando AJAX (JQuery o Vanilla Javascript), al hacer click en el boton generado en el punto 6 debera solicitar al backend un JSON (4 puntos) ###
Este JSON debe ser el resultado de una extracción de datos haciendo uso de LINQ
### 9. Subir el repositorio a su cuenta de github (1 puntos) ###
