namespace BirdsBank.Models.Bird;

public interface IBird
{
    int Id { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    string Place { get; set; }
}