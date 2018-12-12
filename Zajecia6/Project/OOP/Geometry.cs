namespace Geometry
{
    // Kolejno�� dziedziczenia (Liskov substitution principle) cz�� zasad SOLID'u
    // przyk�adem jest znana nam z geometri zale�no�� jako �e kwadrat jest prostok�tem, kt�ra nie ma odzwierciedlenia w zasadach dziedziczenia
    public class Square
    {
        int Length { get; set; }
    }
    public class Rectangle : Square
    {
        
        int Width { get; set; }
    }
}