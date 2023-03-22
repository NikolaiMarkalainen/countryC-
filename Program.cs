using System;
using System.Collections;

namespace country{
class Program{

    static void Main(string[] args){
        ArrayList countries = new ArrayList();
    countries.Add(new Country("US", "United States", 9834000, 331449281, "Washington D.C."));
    countries.Add(new Country("CA", "Canada", 9985000, 38246108, "Ottawa"));
    countries.Add(new Country("MX", "Mexico", 1964375, 130262216, "Mexico City"));
    countries.Add(new Country("JP", "Japan", 377972, 126010000, "Tokyo"));
    countries.Add(new Country("BR", "Brazil", 8515767, 212821986, "Brasília"));

        Console.WriteLine(countries.Count);
        foreach (Country country in countries){
            Console.WriteLine(country.ToString());
            Console.WriteLine($"Population Density: {country.PopulationDensity} per square kilometer\n");
        }
    }
}

public class Country{
    private string _code;
    private string _name;
    private double _area;
    private int _population;
    private string _capital;

public Country(string code, string name, double area, int population, string capital){
    Code = code;
    Name = name;
    Area = area;
    Population = population;
    Capital = capital;
}
public string Code{
    get{ 
        return _code.ToUpper();
    }
    set{
        if(string.IsNullOrEmpty(value) || value.Length < 2){
        throw new ArgumentException("Country code must be 2 characters long");
    }
        _code = value.ToUpper();
    }    
}

public string Name {
    get { 
        return _name;
    }
    set{
        if(string.IsNullOrEmpty(value)) throw new ArgumentException("Name cannot be null");
        _name = value;
    }
}
public double Area {
    get {
        return _area;
    }
    set{
        if(value <= 0) {
            throw new ArgumentException("Area cannot be less than 0");
        }
        _area = value;
    }
}
public int Population {
    get {
        return _population;
    }
    set{
        if(value <= 0) throw new ArgumentException("Population cannot be less than 0");
        _population = value;
    }
}
public string Capital {
    get { 
        return _capital; 
    }
    set {
        if(string.IsNullOrEmpty(value)) throw new ArgumentException("Capital cannot be null or empty");
        _capital = value;
    }
}
public double PopulationDensity{
    get{
        return Population / Area;
    }
}
public override string ToString(){
    return  $"{Code} {Name} {Capital}";
}

}

}