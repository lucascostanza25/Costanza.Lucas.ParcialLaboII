using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.PPLabII.Interfaces;
using Google.Cloud.Firestore;

namespace Entidades.PPLabII.Firebase
{
    public class Firebase<T> : IFirebase<T>
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

        public async Task<bool> Actualizar(T objeto, string coleccion, string? documento)
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
    }

}

    

