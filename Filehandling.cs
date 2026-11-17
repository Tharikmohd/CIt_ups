using System;
using System.IO;

namespace Filehandle
{
    class DemoFilehandle
    {
        public static void Main()
        {
            string path = @"C:\Users\ABCOM\Desktop\citdemo.txt";
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("This is the first line of Cit File handling concept");
            sw.WriteLine("Thank you");

            sw.Close();
            file.Close();

            // FileStream fs2 = new FileStream(path, FileMode.Append, FileAccess.Write);
            // StreamWriter stream = new StreamWriter(fs2);
            // stream.WriteLine("\n How can i help you?");
            // stream.WriteLine("\n Welcome");
            

            // stream.Close();
            // fs2.Close();

            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fileStream);

            string line = sr.ReadLine();

            while(line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
            fileStream.Close();

            // using(StreamWriter sw3 = new StreamWriter(path, true))
            // {
            //     sw3.WriteLine("Thanks for coming");
                
            // }

            // File.AppendAllText(path, "\n Dontnet programming class");

            /*using(StreamWriter stream1 = new StreamWriter(path, true))
            {
                string ans = "Y";
                while(ans == "Y")
                {
                    Console.WriteLine("Enter student ID :");
                    string? id = Console.ReadLine();
                    Console.WriteLine("Enter Student Name : ");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Enter student dept : ");
                    string? dept = Console.ReadLine();

                    string stddetails = $"{id} | {name} | {dept}";
                    stream1.WriteLine(stddetails);
                    Console.WriteLine("Student details successfully updated");

                    Console.WriteLine("Do you want to add more students Y/N?");
                    ans = Console.ReadLine().ToUpper();

                }
            }*/

            Console.WriteLine("Using File class");
            string content = File.ReadAllText(path);
            Console.WriteLine(content);

            string [] lines = File.ReadAllLines(path);
            Console.WriteLine("using Readlines");
            foreach(string i in lines)
            {
                Console.WriteLine(i);
            }

            // string overwrite = Path.Combine(Path.GetDirectoryName(path), "citdemo.txt");
            // File.WriteAllText(overwrite, "Files are oerwritten");

            FileInfo fi = new FileInfo(path);

            Console.WriteLine("File Name : " +fi.Name);
            Console.WriteLine("Extension : " +fi.Extension);
            Console.WriteLine("File size : " +fi.Length);
            Console.WriteLine("Time : "+fi.CreationTime);
            Console.WriteLine("Modified : "+fi.LastWriteTime);
            Console.WriteLine("path " +fi.FullName);
            Console.WriteLine(fi.DirectoryName);
            Console.WriteLine(fi.LastAccessTime);


            string folderpath = @"c:\users\abcom\desktop\citfilehandling";
            if(Directory.Exists(folderpath))
            {
                Console.WriteLine("Directory already exists");
            }
            else
            {
                Directory.CreateDirectory(folderpath);
                Console.WriteLine("Directory successfully created");
            }

            DirectoryInfo di = new DirectoryInfo(folderpath);
            Console.WriteLine(di.CreationTime);
            Console.WriteLine(di.Name);
            Console.WriteLine(di.FullName);

            /*string copypath = Path.Combine(folderpath,"Citdemo_copy.txt");
            File.Copy(path, copypath);
            Console.WriteLine("Files copy to another folder");

            string movefile = Path.Combine(folderpath, "citdemo2.txt");
            
            if(File.Exists(movefile))
            {
                File.Delete(movefile);
            }
            File.Move(path, movefile);
            
            Console.WriteLine("File moved to another folder");

            string delpath = Path.Combine(folderpath, "citdemo2.txt");
            File.Delete(delpath);
            Console.WriteLine("File deleted successfully");

            string [] files = Directory.GetFiles(folderpath);
            foreach(string items in files)
            {
                Console.WriteLine(Path.GetFileName(items));
            }

            string [] root = Directory.GetFileSystemEntries(@"c:\users\abcom\desktop");

            foreach(string item in root)
            {
                Console.WriteLine(item);
            }*/

            FileAttributes attributes = File.GetAttributes(path);

            Console.WriteLine("Current attributes : "+attributes);
            File.SetAttributes(path, FileAttributes.Normal);
            Console.WriteLine("Current attributes : "+attributes);

            string replacepath = Path.Combine(folderpath, "citdemo_copy.txt");
            string backuppath = Path.Combine(folderpath, "Backup.txt");

            File.WriteAllText(backuppath, "citdemo+copy");

            File.Replace(replacepath, backuppath,null);
            Console.WriteLine("Replaced file");

            

        }
    }
}