using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    public class BaseClass
    {
        private int privateField;

        public int publicField;

        protected int protectedField;

        internal int internalField;

        protected internal int protectedInternalField;

        // private protected int privateProtectedField;   //  modyfikator dostępny od wersji języka C# 7.2 
    }
    
    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base()
        {

        }

        public void TestAccess()
        {
            //base.privateField = 12; // pole private klasy jest dostępny tylko dla niej
            base.publicField = 12; // pole public jest dostępne wszędzie 
            base.protectedField = 12; // pole protected klasy jest dostępne dla klasy bazowej oraz klas po niej dziedziczących
            base.internalField = 12; // pole internal jest dostępny w cąłym zbiorze, assembly, projekcie
            base.protectedInternalField = 12; // pole protected internal jest dostępne jak internal oraz dla klas dziedziczących
                                              // poza danym zbiorem, assembly, projektem
        }
    }

    public class OtherClassInSameAssembly
    {
        private BaseClass _baseClass;
        public OtherClassInSameAssembly()
        {
            _baseClass = new BaseClass();
        }

        public void TestAccess()
        {
            //_baseClass.privateField = 12; // pole private klasy jest dostępny tylko dla niej
            _baseClass.publicField = 12; // pole public jest dostępne wszędzie
            //_baseClass.protectedField = 12; // pole protected klasy jest dostępne dla klasy bazowej oraz klas po niej dziedziczących
            _baseClass.internalField = 12; // pole internal jest dostępny w cąłym zbiorze, assembly, projekcie
            _baseClass.protectedInternalField = 12; // pole protected internal jest dostępne jak internal oraz dla klas dziedziczących
                                              // poza danym zbiorem, assembly, projektem
        }

    }
}
