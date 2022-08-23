using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyNewProject.FileHandling
{
    class Demo
    {
        
        static void Createfolder()

        {
             string Path = @"E:\C#\TestFolder";
            if (Directory.Exists(Path))
            {
                Console.WriteLine("Folder is already Created");
            }
            else
            {
               Directory.CreateDirectory(Path);
                Console.WriteLine("folder is created");
            }
        }
        static void createfile()
        {
            string path = @"E:\C#\TestFolder\testfile.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File already exists");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("file created");
            }

        }
        //using DirectoryInfo&file info class
        static void CreateFolderinfo()
        {
            string path = @"E:\C#\TestFolder\testfolder1";
            DirectoryInfo d = new DirectoryInfo(path);
            if(d.Exists)
            {
                Console.WriteLine("Folder already exists");
            }
            else
            {
                d.Create();
                Console.WriteLine("Folder created");
            }
        }
        static void createfileinfo()
        {
            string path = @"E:\C#\TestFolder\testfile2.html";
            FileInfo f = new FileInfo(path);
            if(f.Exists)
            {
                Console.WriteLine("File already Exists");
            }
            else
            {
                f.Create();
                Console.WriteLine("File created");

            }
        }
        
        /*static void Main(string[] args)
        {
            Demo.Createfolder();
            Demo.createfile();
            Demo.CreateFolderinfo();
            Demo.createfileinfo();
            Console.ReadLine();
        }*/

         static void WriteToFile(Dept dept)
    {
        try
        {
            FileStream fs = new FileStream(@"E:\C#\TestFolder\wTestFile", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(dept.Id);
            bw.Write(dept.Name);
            bw.Write(dept.Location);
            bw.Close();
            fs.Close();
            Console.WriteLine("Data added to file");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    static void ReadFromFile()
    {
        try
        {
            FileStream fs = new FileStream(@"E:\C#\TestFolder\wtestfile", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Console.WriteLine(br.ReadInt32()); //Id
            Console.WriteLine(br.ReadString());// Name
            Console.WriteLine(br.ReadString());// Location
            br.Close();
            fs.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
        static void WriteToFileUsingStream()
        {//using filestream streamwriter
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\wtestfile", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("This is sample text in the file by shital");
                sw.Close();
                fs.Close();
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ReadFromFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\testfolder\wtestfile", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        static void Main(string[] args)
    {
            //Dept dept = new Dept { Id = 1, Name = "HR", Location = "Pune" };
            //WriteToFile(dept);
            //ReadFromFile();
            WriteToFileUsingStream();
            ReadFromFileUsingStream();



            Console.ReadLine();
    }
    }
    public class Dept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
    //assignment
    /*Create a class Course with Id, Name & Fees properties, Create a file to Write course details using BianaryWriter & read the same using BinaryReader.
*/

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int fees { get; set; }
    }
    class assignment1
    {
        static void WriteToFile(Course crs)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\Course.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(crs.Id);
                bw.Write(crs.Name);
                bw.Write(crs.fees); ;
                bw.Close();
                fs.Close();
                Console.WriteLine("Data added to file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static  void Readfromfile()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\Course.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Console.WriteLine(br.ReadInt32()); //Id
                Console.WriteLine(br.ReadString());// Name
                Console.WriteLine(br.ReadInt32());// Fees
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
        static void Main(string[] args)
        {
            //Course c = new Course { Id = 1, Name = "C#", fees = 50000 };
            //WriteToFile(c);
            Readfromfile();

            Console.ReadLine();

        }
    }
    class Assign2
    {
        //Write a code to accept string from user & write to file using StreamWriter & read & display on console 
        static void Writeusingstream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\testfile", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(Console.ReadLine());
                sw.Close();
                fs.Close();
                Console.WriteLine("done");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void ReadUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\testfile", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }
            catch(Exception E)

            {
                Console.WriteLine(E.Message);
            }
        }

        static void Main(string[] args)
        {
            //Writeusingstream();
            ReadUsingStream();
            Console.ReadLine();
        }
    }


}
