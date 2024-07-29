namespace TwoProps;

public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    
    public override string ToString()
    {
        return $"Name: {Name}, Position: {Position}";
    }
}
