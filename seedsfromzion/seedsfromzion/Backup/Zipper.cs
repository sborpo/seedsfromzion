using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ionic.Zip;

namespace seedsfromzion.Backup
{
    class Zipper
    {
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
        public static void zip(String path,String target)
        {
            String[] paths = new String[1];
            paths[0] = path;
            zipCollection(paths, target);
        }
        public static void zipCollection(System.Collections.Generic.IEnumerable<string> files, String target)
        {
            ZipFile zip = new ZipFile();
            foreach (String file in files)
            {
                zip.AddItem(file);
            }
            if (File.Exists(target))
            {
                File.Delete(target);
            }
            zip.Save(target);

        }
    }
}
