
# Sistema de ventas y gestión aerolinea
---
Este TP para la tecnicatura en programación de la UTN permite controlar a una aerolinea ficticia, permitiendo logearse dependiendo del rol,
vender vuelo a clientes, que luego pasaran a ser pasajeros, gestionar los vuelos que hay, editarlos, crearlos y borrarlos. Lo mismo con las aeronaves y los pasajeros.
A continuación se detallara el funcionamiento del programa.
## Inicio de sesión
---
![Inicio de sesion](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmInicioSesion.png)
<br>
Primero que nada, hay que iniciar sesión en el programa. Utilizando la deserialización Json, se procede a obtener una lista de usarios, que permitirá al empleado en cuestión ingresar al programa.
<br>
# Vendedor
---
![Vendedor](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmVendedor1.png)
<br>
Lo que se ve, es el menu del vendedor, es quien va a poner ver los vuelos, venderlos, crear clientes que luego van a ser pasajeros, editarlos, borrarlos y ver las estadisticas de los vuelos en el sistema.
<br>
![Ver vuelos](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmVendedorVerVuelos.png)
<br>
En este apartado, el vendedor va a poder visualizar los vuelos disponibles.
<br>
Para poder visualizar todos los datos del vuelo, hay que posicionarse en el DataGridView de los vuelos y **hacer doble click en la fila del vuelo deseado sobre la primer columna, aquella que tiene la flecha**.
<br>
![Ver vuelos 2](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmVendedorVerVuelo2.png)
<br>
Hecho esto, aparecerá debajo la lista de los pasajeros en dicho vuelo, al costado derecho los datos del vuelo tal y como se puede apreciar en la foto.
<br>
![Ver vuelos 3](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmVendedorVerVuelo3.png)
<br>
Si desea buscar un pasajero en **todos** los vuelos en el sistema, tiene que introducir su **dni** y automaticamente, sin presionar ningún botón aparecerá el pasajero si es que este existe.
<br>
Luego de haber hecho eso, usted podrá editar o eliminar a el pasajero buscado
<br>
![Ver vuelos 4](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmVendedorVerVuelo4_EditarPasajero.png)
<br>
Al editar el pasajero, se abrirá otra ventanda, con los datos del pasajero en cuestión.
<br>
Podrá editar los datos que desee, excepto el dni, que es único para cada pasajero.

