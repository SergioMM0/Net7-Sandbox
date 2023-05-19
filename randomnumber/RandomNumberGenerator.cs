class RandomNumberGenerator
{
    string name;

    public RandomNumberGenerator(string name){
        this.name = name;
    }

    public int randomNumber(){
        return new Random().Next(1, 10);
    }
}