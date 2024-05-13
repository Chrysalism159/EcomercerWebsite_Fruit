using AutoMapper.Internal.Mappers;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using System.Text;

namespace EcomercerWebsite_Fruit.Services
{
    public class MasterServices
    {
        #region File Services
        public static string UploadImages(IFormFile imagesFile, string folder)
        {
            try
            {
                if(!IsValidFileSize(3, imagesFile.Length))
                    throw new Exception("FileSizeNotValid");
                var uniqueFileName = GetUniqueFileName(imagesFile.FileName).ToLowerInvariant();
                var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","images", folder, uniqueFileName);
                using (var myfile = new FileStream(fullPath, FileMode.CreateNew))
                {
                    imagesFile.CopyTo(myfile);
                }
                return uniqueFileName;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
        private static string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_"
                   + Guid.NewGuid().ToString().Substring(0, 6)
                   + Path.GetExtension(fileName);
        }

        private static bool IsValidFileSize(int _maxSizeInMb, long fileSize)
        {
            return fileSize <= _maxSizeInMb * 1024 * 1024;
        }
        
        #endregion
        public static string GenerateRamdomKey(int length = 5)
        {
            var pattern = @"qazwsxedcrfvtgbyhnujmiklopQAZWSXEDCRFVTGBYHNUJMIKLOP!";
            var sb = new StringBuilder();
            var rd = new Random();
            for (int i = 0; i < length; i++)
            {
                sb.Append(pattern[rd.Next(0, pattern.Length)]);
            }

            return sb.ToString();
        }
    }
}
