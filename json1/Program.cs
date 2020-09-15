using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace HelloApp
{
    //Сериализуем в json и десериализуем код json в объект c# простейший объект
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            // сохранение данных
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                Person tom = new Person() { Name = "Tom", Age = 35 };
                await JsonSerializer.SerializeAsync<Person>(fs, tom);
                Console.WriteLine("Data has been saved to file");
            }


            /*Здесь вначале сериализуем с помощью метода 
            JsonSerializer.Serialize() объект типа Person в стоку с кодом json. 
              Затем обратно получаем из этой строки объект Person посредством метода JsonSerializer.Deserialize().*/

            // чтение данных
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                Person restoredPerson = await JsonSerializer.DeserializeAsync<Person>(fs);
                Console.WriteLine($"Name: {restoredPerson.Name}  Age: {restoredPerson.Age}");
            }
        }
    }
}
