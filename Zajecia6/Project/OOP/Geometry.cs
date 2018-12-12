namespace Geometry
{
    // Kolejnoœæ dziedziczenia (Liskov substitution principle) czêœæ zasad SOLID'u
    // przyk³adem jest znana nam z geometri zale¿noœæ jako ¿e kwadrat jest prostok¹tem, która nie ma odzwierciedlenia w zasadach dziedziczenia
    public class Square
    {
        int Length { get; set; }
    }
    public class Rectangle : Square
    {
        
        int Width { get; set; }
    }
}