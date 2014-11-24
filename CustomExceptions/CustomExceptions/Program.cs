using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
          
            try
            {
            throw new UserAlreadyLoggedInException("User is already logged in....Kushal");
            }
            catch (UserAlreadyLoggedInException e)
            {
                Console.WriteLine(e.Message);
            }
                Console.ReadLine();
            
        }
    }
}

/*create a class that derives from the System.Exception class*/
public class UserAlreadyLoggedInException : Exception
{
    public  UserAlreadyLoggedInException() : base(){}
    public  UserAlreadyLoggedInException(string message) : base(message){}
    /*Can use the inner Exception to support the inner exceptions*/
    public UserAlreadyLoggedInException(string msg, Exception innerException) : base(msg, innerException) { }
    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    /*If you want your exception class to run across application domains,  then the object must be serializable.*/
}
    