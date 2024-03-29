
# Sistema de ventas y gestión aerolinea
---
Este TP para la tecnicatura en programación de la UTN permite controlar a una aerolinea ficticia, permitiendo logearse dependiendo del rol,
vender vuelo a clientes, que luego pasaran a ser pasajeros, gestionar los vuelos que hay, editarlos, crearlos y borrarlos. Lo mismo con las aeronaves y los pasajeros. Todo conectado a dos bases de datos distintas, Sql y Google Firebase. Utilizando programación multihilo, delegados, eventos y demás complementos que hacen posible el correcto funcionamiento.
A continuación se detallara el funcionamiento del programa.

# Sobre mi
Soy Lucas Costanza y vengo programando en c# hace un tiempo. Considero que el parcial fue un desafio, me resultó entretenido al principio, interesante. 

# Inicio de sesión
---
![Inicio de sesion](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmInicioSesion.png)
<br>
Primero que nada, hay que iniciar sesión en el programa. Utilizando la deserialización Json, se procede a obtener una lista de usarios, que permitirá al empleado en cuestión ingresar al programa.
Datos del administrador: 
Mail: admin@admin.com
Contraseña: 12345678
Datos del supervisor:  
Mail: trobinson@super.com
Contraseña: 12345678
Datos del vendedor:  
Mail: cgorgen@vendedor.com
Contraseña: 123abc45
<br>
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
Si desea filtrar un vuelo, puede introducir el código del mismo en el textbox que se encuentra arriba del DataGridView y de esa forma a utomaticamte aparecerá el vuelo buscado.
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
<br>
Al presionar en el botón *"Editar pasajero"*, este será actualizado con las preferencias deseadas.
<br>
![Vender vuelo 1](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmVendedorVenderVuelo1.png)
<br>
En la sección de vender vuelo. El vendedor podrá convertir un cliente en un pasajero, asignandolo al vuelo deseado, aplicando la serie de filtros que se quiera, y si el vuelo existe, aparecerá debajo.
<br>
![Vender vuelo 2 crear cliente](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmVendedorVenderVuelo2_CrearCliente.png)
Para vender un vuelo, primero hay que crear un cliente, presionando en el botón que dice *"Crear cliente"* se accederá a este formulario, donde se podrá crear un cliente a nuestro gusto, asignandole los valores que querramos, tal como si quiere ocupar un asiento premium o no, lo que le permitiria acceder a despachar 2 equipajes en vez de 1.
<br>
![Vender vuelo 3](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmVendedorVenderVuelo3.png)
<br>
Así es como quedaría el cliente, luego de darle a el botón *"Llamar al siguiente cliente"*, que permité acercar al cliente al sistema de ventas y posterior a eso, proceder con la venta.
Si no se llama al cliente no se va a poder realizar la venta.
<br>
![Vender vuelo 4](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmVendedorVenderVuelo4.png)
<br>
Luego de seleccionado el vuelo de ida y de vuelta, o de ida solo. Utilizando el mismo metodo de antes, doble click sobre la fila que queramos, pero unicamente en la primera columna, en este caso, solo habrá un unico vuelo a elegír.
<br>
![Vender vuelo 5](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmVendedorVenderVuelo5.png)
<br>
Si todo salió bien, aparecerá este mensaje, diciendo que el vuelo fue vendido exitosamente!
<br>
![Vender vuelos 6](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmVendedorVenderVuelo6.png)
<br>
Y posteriormente, volviendo al apartado de ver los vuelo, el cliente (ahora pasajero) se encontrará en su vuelo pertinente.
<br>
Por ultimo, el vendedor podrá visualizar las estadisticas dando click en el menú lateral *"Estadisticas"* y luego en *"Ver"*
<br>
![Ver estadisticas](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmVendedorVerEstadisticas.png)
<br>
<br>
# Supervisor
---
<br>

![Supervisor](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmSupervisor.png)
<br>
El supervisor tendrá carateristicas muy parecidas al vendedor, heredando su form, pero limitando la venta, por lo que el suepervisor, podrá agregar un pasajero de emergencia sin necesidad de pasar por la caja.
<br>
Tambien además, podrá visualizar las mismas estadisticas que el vendedor.
<br>
<br>
# Administrador
---
<br>

El administrador podrá ver, editar, eliminar, y crear los vuelos y los aviones.
<br>
![Administrador 1](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmAdministrador.png)
<br>
En este apartado, el administrador podrá ver los aviones del sistema en el DataGridView.
<br>
Siguiendo la misma metodología del programa, para seleccionar un vuelo y ver todos los datos, deberá seleccionar la fila deseada haciendo doble click unicamente en la primera columna, de esta forma aparecerá al costado la infomación solicitada.
<br>
![Administrador 2](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmAdministradorEditarVuelo.png)
<br>
Para editar un vuelo, deberá seleccionarlo primero tal como se describió anteriormente y luego presionar en el botón de editar, lo que dara inicio al editor del vuelo, dejandole cambiar los parametros excepto el codigo, ya que es unico para cada vuelo.
<br>
Para seleccionar otro avión, deberá hacer doble click sobre el mismo en el DataGridView que aparece en pantalla.
<br>
![Administrador 3](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmAdministradorCrearVuelo.png)
<br>
Para crear un nuevo vuelo, presione sobre el botón *"Crear"* y dará inicio al creado del vuelo que desee.
<br>
![Administrador 4](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmAdministradorAviones.png)
<br>
En esta sección aparecen la flota de aviones disponibles en el sistema.
<br>
Tal como fue explicado antes, para ver toda la información de un avión, deberá hacer doble click en el DataGridView, y sobre el costado aparecerá toda la información.
<br>
![Administrador 5](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmAdministradorEdiatAvion.png)
<br>
Para editar una avión, deberá seleccionar el vuelo que desee editar y luego el botón *"Editar"* dando inicio al proceso de edición del vuelo.
<br>
![Administrador 6](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/FrmAdministradorCrearAvion.png)
<br>
Par crear un nuevo avion, solamente pulse en el botón *"Crear"* y dará inicio al proceso de creado de la eronave.
<br>
<br>
# Datos a tener en cuenta
---
<br>
¡Cuidado! Los datos que se manejan en la aplicación son serializados cuando esta termina su proceso, por lo que hay que se meticuloso cuando se elimina o edita algo.
<br>

# Diagrama de clases
---
<br>
Diagrama de las entidades
<br>

![Diagrama entidades](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/DiagramaDeClasesEntidades.png)

<br>
Diagrama de los forms
<br>

![Diagrama forms](https://github.com/lucascostanza25/Costanza.Lucas.PrimerParcial/blob/master/Fotos_GitHub/DiagramaDeClasesForms.png)
<br>

# Breve explicacion sobre algunos de los temas vistos en la cursada aplicados al tp
---
### Herencia y clase abstracta:
<br>

`public abstract class Persona`
<br>
`public class Cliente : Persona` | `public class Pasajeros : Persona` | `public class Usuarios : Persona`
<br>
### Polimorfismo
<br>

Clase Persona: `abstract protected string Datos();`
<br>

Clases Pasajeros, Usuarios y Cliente: `protected override string Datos()`
<br>

    protected override string Datos()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"NOMBRE: {Nombre}");
        sb.AppendLine($"APELLIDO: {Apellido}");
        sb.AppendLine($"EDAD: {Edad}");
        sb.AppendLine($"DNI: {Dni.ToString()}");
        sb.AppendLine($"GENERO: {Genero}");
        sb.AppendLine($"CANTIDAD DE EQUIPAJE: {CantidadEquipaje}");
        sb.AppendLine($"- Peso primer equipaje: {PesoEquipajeUno}");
        if (AsientoPremium)
        {
            sb.AppendLine($"- Peso segundo equipaje: {PesoEquipajeDos}");
        }


        return sb.ToString();
    }

    public override string ToString()
    {
        return Datos();
    }

### Herencia Form
<br>

El form del supervisor hereda del vendedor: `public partial class Supervisor : FrmVendedor`
<br>

### Enumerados
<br>

Contiene los destinos nacionales e internacionales: `public enum DestinosVuelos`
<br>

### Colecciones
<br>

Se utilizaro listas para los **usuarios**, los **clientes**, los **pasajeros**, los **vuelos** y los **aviones**.
<br>
Ademas se utlizó un diccionario para filtrar los vuelos nacionales e internacionales del enumerado:
<br>
`public static Dictionary<int, DestinosVuelos[]> destinoPorVuelo = new Dictionary<int, DestinosVuelos[]>`
<br>

### Sobrecargas de operadores
<br>

    public static bool operator ==(Vuelos v1, Vuelos v2)
    {
        if (v1.CodigoVuelo == v2.codigoVuelo)
            return true; 
        return false;
    }

    public static bool operator !=(Vuelos v1, Vuelos v2)
    {
        return !(v1 == v2);
    }
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
<br>

### Serialización y deserialización
<br>

Serialización Xml
<br>

    public static void SerializarVuelosXml(List<Vuelos> listaVuelos)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Vuelos>));

        using(StreamWriter streamWriter = new StreamWriter("vuelos.xml"))
        {
            serializer.Serialize(streamWriter, listaVuelos);
        }
    }

<br>

Deserialización Xml
<br>

    public static void DeserializarVuelosXml()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Vuelos>));

        using(FileStream fileStream = new FileStream("vuelos.xml", FileMode.Open))
        {
            listaVuelos = (List<Vuelos>)serializer.Deserialize(fileStream);
        }
    }

<br>

Serialización Json
<br>

    public static void SerializarAvionesJson(List<Aviones> listaAvionesSerializar)
    {
        string jsonSting = JsonSerializer.Serialize(listaAvionesSerializar);
        File.WriteAllText("aviones.json", jsonSting);
    }
 
<br>

Deserialización Json
<br>

    public static void DeserializarAvionesJson(string archivo)
    {
        List<Aviones>? listaAviones = new List<Aviones>();

        string jsonString = File.ReadAllText(archivo);
        listaAviones = JsonSerializer.Deserialize<List<Aviones>>(jsonString);
        MiAerolinea.listaAviones = listaAviones;
    }


















