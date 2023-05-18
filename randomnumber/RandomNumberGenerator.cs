class RandomNumberGenerator
{
    string name;

    public RandomNumberGenerator(string name){
        this.name = name;
    }

    public int randomNumber(){
        return Random(10);
    }
}