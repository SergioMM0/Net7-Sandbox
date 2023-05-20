class RandomNumberGenerator
{
    public string name {get; set; }

    public RandomNumberGenerator(string name){
        this.name = name;
    }

    public int randomNumber(){
        return new Random().Next(1,10);
    }
}