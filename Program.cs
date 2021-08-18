using System;
using Akavache;
using DryIoc;
using Splat.DryIoc;

namespace SplatAkavacheInitExceptionRepro
{
    class Program
    {
        private static void Main(string[] args)
        {
            Registrations.Start("SplatAkavacheInitExceptionRepro");

            var container = new Container();
            try
            {
                container.UseDryIocDependencyResolver(); //THROWS HERE
            }
            catch (ContainerException)
            {
                Console.WriteLine("Duplicate key exception thrown !!!");
                throw;
            }
        }
    }
}
