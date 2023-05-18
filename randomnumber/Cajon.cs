class Cajon
{
    public List<RandomNumberGenerator> randomList {get; set;}

    public Cajon(){}

    public void addRandomNumberGenerator(RandomNumberGenerator caxibaxe){
        randomList.Add(caxibaxe);
    }

    public int takeOutRandomNumberGenerator(){
        var first = randomList.First;
        var randomNumber = first.randomNumber();
        randomList.Remove(first);
    }
}