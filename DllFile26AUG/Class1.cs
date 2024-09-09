namespace DllFile26AUG;

[AttributeUsage(AttributeTargets.All)]
public class MyCustomeAttribute:Attribute
{
    public float Version { get; set; }
    public string? Name { get; set; }

    public MyCustomeAttribute(string name, float version){
        this.Version = version;
        this.Name = name;
    }
}
