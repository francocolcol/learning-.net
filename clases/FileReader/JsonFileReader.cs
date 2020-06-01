using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Clases.FileReader
{
    public class JsonFileReader<T>
    {
        //Crea el delegate para que sea el tipo del evento
        public delegate void StudentsRead(List<T> students);
        //Crea el evento con el tipo del delegate
        public event StudentsRead OnFileRead;
        public void ReadJsonFile(string filePath)
        {
            using StreamReader stReader = new StreamReader(filePath);
            var json = stReader.ReadToEnd();
            List<T> elements = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
            //Dispara el evento con los elementos del archivo para que lo utilicen las funciones del evento
            OnFileRead(elements);
        }
    }
}
