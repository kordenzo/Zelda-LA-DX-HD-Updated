using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace LADXHD_Patcher
{
    public class ZipPatches
    {
        private static Dictionary<string, object> resources = ResourceHelper.GetAllResources();

        public static void ExtractPatches()
        {
            // Set the patches and zipfile paths.
            string patchesPath = (Config.tempFolder + "\\patches").CreatePath();
            string patchedPath = (Config.tempFolder + "\\patchedFiles").CreatePath();
            string zipFilePath = Path.Combine(Config.tempFolder, "patches.zip");

            // Write the zipfile, extract it, then delete it.
            File.WriteAllBytes(zipFilePath, (byte[])resources["patches.zip"]);
            ZipFile.ExtractToDirectory(zipFilePath, patchesPath);
            zipFilePath.RemovePath();
        }
    }
}
