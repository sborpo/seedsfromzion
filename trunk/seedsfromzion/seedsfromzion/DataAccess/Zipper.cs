using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ionic.Zip;

namespace seedsfromzion.DataAccess
{
    public class Zipper
    {
        private ZipFile ziper;

        public Zipper() { ziper = new ZipFile(); }
        public void addZipFolder(String path)
        {
            ziper.AddDirectoryByName(path);
        }
        public void addDirFilesToDirectory(String srcDir, String path)
        {
            string [] files=Directory.GetFiles(srcDir);
            addFiles(files, path);
            
        }


        public void addFiles(System.Collections.Generic.IEnumerable<string> files, String path)
        {
            
            foreach (String file in files)
            {
                if (path == null)
                {
                    ziper.AddFile(file);
                }
                else
                {
                    ziper.AddFile(file, path);
                }
            }
        }
        public void addFile(String file, String path)
        {
            String[] arr = new String[1];
            arr[0] = file;
            addFiles(arr, path);
        }

        public static bool extract(String zipFile, String destPath)
        {
            if (!ZipFile.IsZipFile(zipFile))
            {
                return false;
            }
            ZipFile zip = ZipFile.Read(zipFile);
            zip.ExtractAll(destPath);
            return true;
        }
        public  void zip(String target)
        {
            if (File.Exists(target))
            {
                File.Delete(target);
            }
            ziper.Save(target);
        }

    }
}
