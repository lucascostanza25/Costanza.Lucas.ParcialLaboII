using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.PPLabII.Interfaces;
using Google.Cloud.Firestore;

namespace Entidades.PPLabII.Firebase
{
    public class Firebase<T> : IBaseDeDatos<T>
    {
        public async Task<bool> Agregar(T item, string coleccion)
        {
            var projectKey = "prog-2-ab04c";
            FirestoreDb db = FirestoreDb.Create(projectKey);
            CollectionReference colRef = db.Collection(coleccion);
            DocumentReference docRef = colRef.Document();
            await docRef.SetAsync(item);
            return true;
        }
        //public static async Task<bool> AgregarVuelo(Vuelos vuelo)
        //{
        //    var projectKey = "prog-2-ab04c";
        //    FirestoreDb db = FirestoreDb.Create(projectKey);
        //    CollectionReference vueloColRef = db.Collection("vuelos");

        //    // Construir la consulta para buscar el vuelo por el código de vuelo
        //    Query query = vueloColRef.WhereEqualTo("CodigoVuelo", vuelo.CodigoVuelo);

        //    QuerySnapshot snapshot = await query.GetSnapshotAsync();
        //    if (snapshot.Count > 0)
        //    {
        //        // El vuelo ya existe en la base de datos.
        //        return false;
        //    }

        //    var rta = await vueloColRef.AddAsync(vuelo);
        //    return true;
        //}

        //public static async Task<List<Vuelos>> TraerVuelos()
        //{
        //    List<Vuelos> listaVuelos = new List<Vuelos>();
        //    var projectKey = "prog-2-ab04c";
        //    FirestoreDb db = FirestoreDb.Create(projectKey);
        //    CollectionReference vueloColRef = db.Collection("vuelos");

        //    var snapshot = await vueloColRef.GetSnapshotAsync();
        //    var lista = snapshot.ToList();

        //    foreach (var item in lista)
        //    {
        //        var vuelo = item.ConvertTo<Vuelos>();
        //        listaVuelos.Add(vuelo);
        //    }
        //    return listaVuelos;
        //}

        //public static async Task<bool> ActualizarVuelo(Vuelos vuelo)
        //{
        //    var projectKey = "prog-2-ab04c";
        //    FirestoreDb db = FirestoreDb.Create(projectKey);
        //    CollectionReference vueloColRef = db.Collection("vuelos");

        //    DocumentReference vueloDocRef = vueloColRef.Document(vuelo.CodigoVuelo);

        //    DocumentSnapshot snapshot = await vueloDocRef.GetSnapshotAsync();

        //    if(!snapshot.Exists)
        //    {
        //        return false;
        //    }

        //    await vueloDocRef.SetAsync(vuelo);

        //    return true;
        //}

        //public static async Task<bool> AgregarAvion(Aviones avion)
        //{
        //    var projectKey = "prog-2-ab04c";
        //    FirestoreDb db = FirestoreDb.Create(projectKey);
        //    CollectionReference avionColRef = db.Collection("aviones");

        //    Query query = avionColRef.WhereEqualTo("Matricula", avion.Matricula);

        //    QuerySnapshot snapshot = await query.GetSnapshotAsync();
        //    if (snapshot.Count > 0)
        //    {
        //        return false;
        //    }

        //    var rta = await avionColRef.AddAsync(avion);
        //    return true;
        //}

        //public static async Task<List<Aviones>> TraerAviones()
        //{
        //    List<Aviones> listaAviones = new List<Aviones>();
        //    var projectKey = "prog-2-ab04c";
        //    FirestoreDb db = FirestoreDb.Create(projectKey);
        //    CollectionReference avionColRef = db.Collection("aviones");

        //    var snapshot = await avionColRef.GetSnapshotAsync();
        //    var lista = snapshot.ToList();

        //    foreach (var item in lista)
        //    {
        //        var avion = item.ConvertTo<Aviones>();
        //        listaAviones.Add(avion);
        //    }
        //    return listaAviones;
        //}

        //public static async Task<bool> ActualizarAvion(Aviones avion)
        //{
        //    var projectKey = "prog-2-ab04c";
        //    FirestoreDb db = FirestoreDb.Create(projectKey);
        //    CollectionReference avionColRef = db.Collection("aviones");

        //    DocumentReference avionDocRef = avionColRef.Document(avion.Matricula);

        //    DocumentSnapshot snapshot = await avionDocRef.GetSnapshotAsync();

        //    if (!snapshot.Exists)
        //    {
        //        return false;
        //    }

        //    await avionDocRef.SetAsync(avion);

        //    return true;
        //}

        //public static async Task<bool> EliminarAvion(string matricula)
        //{
        //    var projectKey = "prog-2-ab04c";
        //    FirestoreDb db = FirestoreDb.Create(projectKey);
        //    CollectionReference avionColRef = db.Collection("aviones");

        //    QuerySnapshot snapshot = await avionColRef.WhereEqualTo("Matricula", matricula).GetSnapshotAsync();

        //    if (snapshot.Count == 0)
        //    {
        //        return false;
        //    }

        //    var avion = snapshot.Documents.First();
        //    await avion.Reference.DeleteAsync();

        //    return true;
        //}
    }

}

    

