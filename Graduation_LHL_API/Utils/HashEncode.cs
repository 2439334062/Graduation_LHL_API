using System.Security.Cryptography;
using System.Text;

namespace Graduation_LHL_API.Utils
{
    public  class HashEncode
    {
        //private static string ApplyHash512(string dataString)
        //{
        //    byte[] data = ASCIIEncoding.Unicode.GetBytes(dataString);
        //    byte[] result;
        //    SHA512 shaM = new SHA512Managed();
        //    result = shaM.ComputeHash(data);
        //    return ASCIIEncoding.Unicode.GetString(result);
        //}
        public static string ApplyHash256(string dataString)
        {
            byte[] data = ASCIIEncoding.Unicode.GetBytes(dataString);
            byte[] result;
            SHA256 shaM = new SHA256Managed();
            result = shaM.ComputeHash(data);
            return ASCIIEncoding.Unicode.GetString(result);
        }
    }
}
