using System;


namespace OOP2.NullableTypes
{
    class NullableTypes
    {
        // int integerValue = null; <--- nieprawidłowe przypisanie, typ nie przyjmuje wartości 'null'

        // Nullable types
        int? integerValieWithNull = null; // nullable type '?', typ wartościowy może teraz przyjmować wartość 'null'
        double? floatPointWithNull = null;
        long? longValue64bits = null;

        // Łańcuch znaków
        // 'string' jest wskaźnikiem na pierwszy element łacuchu znkaów więc może przyjmować wartość 'null'
        string word = null;
    }
}
