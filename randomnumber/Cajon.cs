class Cajon
{
    public List<RandomNumberGenerator> randomList {get; set;}

    public Cajon(){
        this.randomList = new List<RandomNumberGenerator>();
    }

    public void addRandomNumberGenerator(RandomNumberGenerator caxibaxe){
        randomList.Add(caxibaxe);
    }

    public int takeOutRandomNumberGenerator(){
        var first = randomList.First();
        var randomNumber = first.randomNumber();
        randomList.Remove(first);
        return randomNumber;
    }
}