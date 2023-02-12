using System;

// Interface
interface MyFirstInterface
{
    string MyString {get; set;}
}

class MyClass: MyFirstInterface
{
    public string MyString {get; set;}

}

public class Person<T>
{
    // Properties
    private string hobby = "Dance";
    private string name = "George";
    public int num_of_hobby;
    public T[] arr = new T[100];

    public string Favorite_Hobby
    {
        get
        {
            return hobby.ToUpper();
        }
        set
        {
            if (value == "Dance") 
                hobby = value;
        }
    }

    // Indexers
    public T this [string i]
    {
        get { return arr[i];}
        set { arr[i] = value;}
    }

    // Instance Method
    public string getName()
    {
        return this.name;
    }

}

class Program
{
    static void Main()
    {   
        // Instance of class object 
        var myFriendOne = new Person<string>();
        myFriendOne[0] = "soccer";
        Console.WrtieLine(myFriendOne[0]);
    }
}
