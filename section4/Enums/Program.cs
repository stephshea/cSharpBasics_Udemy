using System;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;

            Console.WriteLine((int)method);

            var methodId = 3;
            System.Console.WriteLine((ShippingMethod)methodId);

            System.Console.WriteLine(method.ToString());
            
            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            System.Console.WriteLine(shippingMethod);
        }
    }
}
