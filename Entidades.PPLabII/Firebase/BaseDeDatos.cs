using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.PPLabII.Interfaces;
using Google.Cloud.Firestore;

namespace Entidades.PPLabII.Firebase
{
    public class BaseDeDatos<T> : IBaseDeDatos<T>
    {
        public async Task<bool> Agregar(T item, string coleccion, string documento)
        {
            var projectKey = "prog-2-ab04c";
            FirestoreDb db = FirestoreDb.Create(projectKey);
            CollectionReference colRef = db.Collection(coleccion);
            DocumentReference docRef = colRef.Document(documento);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if(snapshot.Exists)
            {
                return false;
            }
            await docRef.SetAsync(item);
            return true;
        }

        public async Task<bool> Actualizar(T objeto, string coleccion, string documento)
        {
            var projectKey = "prog-2-ab04c";
            FirestoreDb db = FirestoreDb.Create(projectKey);
            CollectionReference colRef = db.Collection(coleccion);
            DocumentReference docRef = colRef.Document(documento);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                await docRef.SetAsync(objeto);
                return true;
            }
            return false;
        }

        public async Task<List<T>> Traer(string coleccion)
        {
            List<T> lista = new List<T>();
            var projectKey = "prog-2-ab04c";
            FirestoreDb db = FirestoreDb.Create(projectKey);
            CollectionReference colRef = db.Collection(coleccion);
            var snapshot = await colRef.GetSnapshotAsync();
            var listaSnapshot = snapshot.ToList();

            foreach(var item in listaSnapshot)
            {
                T objeto = item.ConvertTo<T>();
                lista.Add(objeto);
            }

            return lista;
        }

        public async Task<bool> Eliminar(string coleccion, string documento)
        {
            var projectKey = "prog-2-ab04c";
            FirestoreDb db = FirestoreDb.Create(projectKey);
            CollectionReference colRef = db.Collection(coleccion);
            DocumentReference docRef = colRef.Document(documento);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if(!snapshot.Exists)
            {
                return false;
            }
            await docRef.DeleteAsync();
            return true;
        }

        //public static async Task<bool> ActualizarVuelo(Vuelos vuelo)
        //{
        //    var projectKey = "prog-2-ab04c";
        //    FirestoreDb db = FirestoreDb.Create(projectKey);
        //    CollectionReference vueloColRef = db.Collection("vuelos");

        //    DocumentReference vueloDocRef = vueloColRef.Document(vuelo.CodigoVuelo);

        //    DocumentSnapshot snapshot = await vueloDocRef.GetSnapshotAsync();

        //    if (!snapshot.Exists)
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

    

