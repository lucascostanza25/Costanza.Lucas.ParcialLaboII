using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Entidades.PPLabII.Firebase
{
    public class VueloFire
    {
        public static string pathKey = "key.json";
        public static async Task Agregar(Vuelos vuelo)
        {
            var projectKey = "prog-2-ab04c";
            FirestoreDb db = FirestoreDb.Create(projectKey);
            CollectionReference vuelosRef = db.Collection("vuelos");

            DocumentReference vueloRef = vuelosRef.Document(vuelo.CodigoVuelo);

            var rta = await vueloRef.SetAsync(vuelo);

            //DocumentReference avionRef = vueloRef.Collection("avion").Document();
            CollectionReference avionRef = vueloRef.Collection("avion");
            await avionRef.AddAsync(vuelo.AvionVuelo);

            CollectionReference pasajerosRef = vueloRef.Collection("pasajeros");
            foreach(Pasajeros pasajero in vuelo.ListaPasajeros)
            {
                //DocumentReference pasajeroRef = pasajerosRef.Document();
                await pasajerosRef.AddAsync(pasajero);
            }
        }
    }

}

    

