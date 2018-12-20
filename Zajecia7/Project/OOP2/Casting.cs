using System;


namespace OOP2.Casting
{
    // Rzutowanie
    public static class Casting
    {
        // Proste rzutowanie typów warościowych
        public static void CastingValueTypes()
        {
            float floatingPoint = 3.14f;
            int integerValue = (int)floatingPoint; // jawne rzutowanie typu zmienno przecikowego na typ całowito liczbowy
            Console.WriteLine(integerValue.ToString()); // Wynik rzuotwania '3'
        }

        public static void CastingObjects()
        {
            Student student = new Student();
            Human humanImplicit = student; // niejawna konwersja w góre klasy dziedziczącej Student na klasę bazową Human
            Human humanExplicit = (Human)student; // jawna konwersja w góre klasy dziedziczącej Student na klasę bazową Human
        }

        public static void CastingValidation()
        {
            Student student = new Student();

            // Sprawdzenie przy pomocy operatora 'is'
            // is <--- zwraca wartość logiczną (true/false)
            if(student is Human)
                Console.WriteLine("Obiekt jest obkiekem klasy Human lub po nim dziedziczy!");

            // Sprawdzenie przy pomocy operatoa 'as'
            // operator 'as' dokonuje rzutowania na dany typ jeżeli jest to możliwe, w przeciwnym wypadku przypisuje wartość 'null'
            Object studentBoxed = student as Object; // Każda klasa dziedziczy po klasie 'System.Object', jest to przykład boxing'u
            if(studentBoxed != null)
                Console.WriteLine("Rzutowanie na System.Object powiodło się!");

            //Unboxing
            Student studentUnboxed = (Student)studentBoxed;
            if(studentUnboxed != null)
                Console.WriteLine("Unboxing udany!");
        }

        public static void CustomCastingTest()
        {
            Student student = new Student()
            {
                Name = "Paweł",
                IndexNumber = 123456
            };
            string studentCastetToString = student;
            Console.WriteLine(student);
        }
    }


    public class Human
    {
        public string Name { get; set; }
    }
    public class Student : Human
    {
        public int IndexNumber { get; set; }


        // Mamy mozliwość definiowania własnej konwersji
        // wzór deklaracji:
        // public static <implicit/explicit> operator <returning type>(<object> varName) {...}
        // eg.
        public static implicit operator string(Student student) // deklaracja nie jawnej konwersji, dla jawnej 'implicit' zamieniamy na 'expilict'
        {
            return $"Imie: {student.Name} \nIndex: {student.IndexNumber.ToString()}";
        }
        // przykład wywołania wyżej
    }
}
