using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //File Stream, Stream writer, Stream reader

            string path = @"D:\\myFile.txt";

            //Append - add the new item
            //CreateNew method - if same name file already exists then throw the exception
            //Open - Open the file
            //OpneOrCreate - if file exists then open the new file other than it will create new file
            //truncate - open the existing file and cut all the stored data, so size will be zero
            //read, write, read and write

            //StremWriter
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Write, FileShare.Read))////file created//at every run time it will override the file 
            {
                using (StreamWriter writer = new StreamWriter(file, Encoding.UTF8))
                {
                    writer.WriteLine("my name is chirag mali");//writline method execute text in next line
                    writer.WriteLine("my name is ram");//writline method execute text in next line
                    writer.WriteLine("my name is shyam");//writline method execute text in next line
                }
            }  
            
            //StremReader
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))////file created//at every run time it will override the file 
            {
                using (StreamReader reader = new StreamReader(file, Encoding.UTF8))
                {
                    //string line = reader.ReadLine();//Readline - read only first line in form of string
                    string line = "";
                    while( (line = reader.ReadLine()) != null)
                    {
                         Console.WriteLine(line);
                    }
                }
            } 


            //file.Close();//insteat of this we can use using

            
            //Directory part
            //string path = @"D:\My Directory";
            //string path2 = @"D:\My Directory 2";
            //string path3 = @"D:\My Directory\new1";

            ////DirectoryInfo dir = new DirectoryInfo(path);
            ////DirectoryInfo dir = new DirectoryInfo(path2);
            //DirectoryInfo dir = new DirectoryInfo(path3);

            //Console.WriteLine(dir.Name);
            //Console.WriteLine(dir.FullName);
            //Console.WriteLine(dir.LastAccessTime);
            //Console.WriteLine(dir.CreationTime);
            //Console.WriteLine(dir.Attributes);
            //Console.WriteLine(dir.Parent);
            //Console.WriteLine(dir.Root);
            //Console.WriteLine(dir.LastWriteTime);

            //DirectoryInfo[] dirs = dir.GetDirectories();//get folder name

            //foreach (var item in dirs)
            //{
            //    Console.WriteLine(item);
            //    //Console.WriteLine(item.GetFiles().Length);//get files from folder
            //}

            //dir.Delete(true);//to delete data from path2

            //dir.MoveTo(path2);//path one data move to path 2(MoveTo method first create directory then move the data)

            //dir.Create();//create folder
            //dir.CreateSubdirectory("Another directory");//create sub folder


            //Console.WriteLine("directory deleted..");



            //@=verbatim literal on c#
            //string path = @"D:\dat.txt";
            //string path2 = @"D:\dat1.txt"; 
            ////copy method have 2 version
            ////File.Copy(path, path2);// made the copy of dat.txt
            //File.Copy(path, path2, true); //override the copy file


            //if (File.Exists(path))//check file exist or not
            //{
            //    Console.WriteLine("file found");
            //    string data = File.ReadAllText(path);//to read all text from the file
            //    Console.WriteLine(data);
            //}
            //else
            //{
            //    Console.WriteLine("File not found");
            //}

            Console.ReadLine();
        }
    }
}
