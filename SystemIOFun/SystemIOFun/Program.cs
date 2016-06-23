using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOFun
{
    class Program
    {
        static void Main(string[] args)
        {
          //  ShowWindowsDirectoryInfo();
          //  ModDirectory();
           // RemDirectory();
           // ListDrives();
           // ListDriveInfo();
           // SimpleFileIO();
            FileStreamMeathod();
            StreamReaderWriter();
        }
        static void ShowWindowsDirectoryInfo()
        {
            Console.WriteLine("***** Directory Info     *******");

            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");

            Console.WriteLine($"Fullname :{dir.FullName}");
            Console.WriteLine($"Name :{dir.Name}");
            Console.WriteLine($"Parent :{dir.Parent}");
            Console.WriteLine($"Creation :{dir.CreationTime}");
            Console.WriteLine($"Attributes :{dir.Attributes}");
            Console.WriteLine($"Root :{dir.Root}");

            Console.ReadLine();
        }

        static void ModDirectory()
        {
            Console.WriteLine("***** Modify Directory Info     *******");

            DirectoryInfo dir = new DirectoryInfo(".");

            DirectoryInfo subdir = dir.CreateSubdirectory("MyFolder");

            
            Console.WriteLine($"Current Directory is :{dir.FullName}");
            Console.WriteLine($"Current Directory is :{subdir.FullName}");
            
            Console.ReadLine();
        }



        //static void RemDirectory()
        //{
        //    Console.WriteLine("***** Delete Directory Info     *******");

        //    try
        //    {
        //        DirectoryInfo dir = new DirectoryInfo(@".\MyFolder");
        //        dir.Delete();

        //    }
        //    catch (DirectoryNotFoundException dnfex)
        //    {

        //        Console.WriteLine($"No Directory to delete "
        //        {
        //            dfnex.Message
        //        }
        //    )
        //        ;
        //    }
        //    catch (IOException ioex)
        //    {
        //        Console.WriteLine("System IO no likey",ioex.);
        //    }
            
        //    Console.ReadLine();
        //}

        static void ListDrives()
        {
            Console.WriteLine("*******  Listing Drives *******");
            string[] myDrives = Directory.GetLogicalDrives();

            foreach (var solid in myDrives)
            {
                Console.WriteLine(solid);
            }


        }

        static void ListDriveInfo()
        {
            Console.WriteLine("***List Drive Info***********");

            DriveInfo[] theDrives = DriveInfo.GetDrives();

            foreach (var things in theDrives)
            {
                Console.WriteLine("Name of Drive"+ things.Name);
                Console.WriteLine("Drive type" +things.DriveType);

                if(things.IsReady)
                {

                    Console.WriteLine("Free space available" + things.AvailableFreeSpace);
                    Console.WriteLine("Drive format" + things.DriveFormat);
                    Console.WriteLine("Volume Label" + things.VolumeLabel);
                }
                Console.WriteLine(things.Name);

                Console.ReadLine();

            }


        }

        static void SimpleFileIO()
        {
            string[] myTasks =

            {
                "Resced Games",
                "Make linup"
                ,
                "Coach Game",
                "Eat Dinner"


            };

            File.WriteAllLines(@".\tasks.txt",myTasks);

            foreach (var task in File.ReadAllLines(@".\tasks.txt"))
            {
                Console.WriteLine($"Todo: {task}");
            }

            Console.ReadLine();

        }

        static void FileStreamMeathod()
        {

            Console.WriteLine("******File stream method********");

            using (FileStream  fs = File.Open(@"myMessages.dat", FileMode.Create))
            {
                string msg = "hello";
                byte[] msgAsBytes = Encoding.Default.GetBytes(msg);

                //writes file
                fs.Write(msgAsBytes, 0, msgAsBytes.Length);

                //moves file cursor back to the start of the file
                //this way we can read

                fs.Position = 0;
                byte[] fromFile = new byte[msgAsBytes.Length];

                for (int i = 0; i <msgAsBytes.Length ; i++)
                {
                    fromFile[i] = (byte) fs.ReadByte();
                    Console.WriteLine(fromFile[i]);
                }
                Console.WriteLine();

                //writing the entire file
                Console.WriteLine(Encoding.Default.GetString(fromFile));
            }
            Console.WriteLine();
        }

        static void StreamReaderWriter()
        {
            Console.WriteLine("******File stream Reader Writer********");

            using (StreamWriter sw = File.CreateText("reminder.txt"))
            {
                sw.WriteLine("Don't forget your Anniversary");
                sw.WriteLine("Don't forget your Birthday");
                sw.WriteLine("Don't forget these numbers");
                for (int i = 0; i < 10; i++)
                {
                    sw.Write(i + "");
                }
                sw.Write(sw.NewLine);
            }

            using (StreamReader sr = File.OpenText("reminder.txt"))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
                Console.WriteLine();

        }



    }
}
