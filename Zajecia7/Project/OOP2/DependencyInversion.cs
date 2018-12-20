using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2.DependencyInversion
{
    public static class DependencyInversion
    {
        private static void ReadFromSource(IReader reader) // Do metody/konstruktora przekazujemy obiekty za pośrednictwem interfejsu/abstrakcji
        {
            reader.Read(); // wywołujemy metodę zadeklarowaną w interfejsie, którą wykonuje przekazany obiekt
        }

        public static void DependencyInversionTest()
        {
            FileReader fileReader = new FileReader();
            CDReader cdReader = new CDReader();
            ReadFromSource(fileReader); // nie zależnie od przekazanego obiektu metoda będzie zawsze wykonana
            ReadFromSource(cdReader); // wykonana zostanie logika zawarta w danym obiekcie
        }
    }

    public interface IReader
    {
        void Read();
    }

    public class FileReader : IReader // obiekty przekazywane w argumencie muszą implementować wymagany interfejs
    {
        public void Read()
        {
            Console.WriteLine("Reading from file!");
        }
    }
    public class CDReader : IReader
    {
        public void Read()
        {
            Console.WriteLine("Reading from CD!");
        }
    }
}
