public class JYP{
    
    //Properties.
    public string Name {get; set;}
    public int NumberOfMembers {get; set;}
    public string Debut {get; set;} //2015/10/20
    public string MostPopularSong {get; set;}

    //Methods.
    public void Solo(string idolName, string groupName){
        Console.WriteLine($"{idolName} from {groupName} has announced their solo projects!");
    }
    public void Tour(string groupName, string date){
        Console.WriteLine($"{groupName} will now be touring on {date}.");
    }
    public virtual void SingMostPopularSong(){
        Console.WriteLine();
    }
    public virtual void SingFavoriteSong(){
        Console.WriteLine();
    }

    //Instance Constructor
    public JYP(string name, int membersCount, string debut, string popularSong){
        this.Name = name;
        this.NumberOfMembers = membersCount;
        this.Debut = debut;
        this.MostPopularSong = popularSong;
    }
}

//classes: Twice, SKZ, Nmixx, Itzy
// properties: 

public class Program{

    static void Main(string[] args){

    }
}

