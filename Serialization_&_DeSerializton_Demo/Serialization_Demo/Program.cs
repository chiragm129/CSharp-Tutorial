using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serialization

            //string path = @"D:\MyFolder\Sample.txt";
            //Employee emp = new Employee(21,"chirag");
            //FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(stream, emp);
            //stream.Close();
            //Console.WriteLine("File created successfully..." + path);

            //De-Serialization
            string path = @"D:\MyFolder\Sample.txt";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Employee emp = (Employee)bf.Deserialize(stream);
            Console.WriteLine("Empoyeed Id: " + emp.Id);
            Console.WriteLine("Empoyeed Name: " + emp.Name);
            stream.Close();


            Console.ReadLine();
        }
    }
}
