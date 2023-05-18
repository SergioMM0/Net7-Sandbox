class Person{
    int age;
    string name;
    public Person(int age, string name){
        this.age = age;
        this.name = name;
    }
    public void SayHello(){
        Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");
    }
    
}