using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ionic.Zip;

namespace seedsfromzion.DataAccess
{
    /// <summary>
    /// This class is a wrapper class for ZIP\UNZIP procedures
    /// of files using the external library Ionic.Zip
    /// </summary>
    public class Zipper
    {
        /// <summary>
        /// The zip file.
        /// </summary>
        private ZipFile ziper;

        public Zipper() { ziper = new ZipFile(); }

        /// <summary>
        /// Adds an empty zip folder to the zip archive with the given name.
        /// </summary>
        /// <param name="path"></param>
        public void addZipFolder(String path)
        {
            ziper.AddDirectoryByName(path);
        }

        /// <summary>
        /// Adds all the files located in the given srcDir , to the 
        /// given path in the zip archive
        /// </summary>
        /// <param name="srcDir"></param>
        /// <param name="path"></param>
        public void addDirFilesToDirectory(String srcDir, String path)
        {
            //get the files from the source folder
            string [] files=Directory.GetFiles(srcDir);
            addFiles(files, path);
            
        }

        /// <summary>
        /// Add the given files to the given path in the zip archive
        /// </summary>
        /// <param name="files"></param>
        /// <param name="path"></param>
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

        /// <summary>
        /// Adds a single file to the given path in the zip archive
        /// </summary>
        /// <param name="file"></param>
        /// <param name="path"></param>
        public void addFile(String file, String path)
        {
            String[] arr = new String[1];
            arr[0] = file;
            addFiles(arr, path);
        }

        /// <summary>
        /// extract the given Zip file to the given destintation folder.
        /// assumes that the destination filder exists
        /// </summary>
        /// <param name="zipFile"></param>
        /// <param name="destPath"></param>
        /// <returns>true on success , false on failure</returns>
        public static bool extract(String zipFile, String destPath)
        {
            //if the file is not a zip file , so reture false
            if (!ZipFile.IsZipFile(zipFile))
            {
                return false;
            }
            ZipFile zip = ZipFile.Read(zipFile);
            zip.ExtractAll(destPath);
            return true;
        }

        /// <summary>
        /// creates a zip file in the given location of the file system
        /// replaces the file if exists
        /// </summary>
        /// <param name="target"></param>
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
