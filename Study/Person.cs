public class Person
{
    private string name{get;set;}
     private string address{get;set;}
     
    public Person(string name, string address)
    {
        this.name = name;
        this.address = address;
    }


    public string getName()
    {
        return name;
    }

    public string getAddress()
    {
        return address;
    }

    public void setAddress(string address)
    {
        this.address = address;
    }
    public  virtual string toString()
    {
        return name + "(" + address + ")";
    }
}