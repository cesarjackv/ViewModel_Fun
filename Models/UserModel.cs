#pragma warning disable CS8618
namespace ViewModel_Fun.Models;
public class User
{
    public string firstName { get; set; } = null!;
    public string lastName { get; set; } = null!;
    
    public User(string first, string last){
        firstName = first;
        lastName = last;
    }

    public User(string first){
        firstName = first;
    }
}