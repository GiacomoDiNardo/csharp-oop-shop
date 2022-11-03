// See https://aka.ms/new-console-template for more information


Console.WriteLine("Inserisci nome prodotto:");
string name = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Inserisci descrizione prodotto:");
string description = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Inserisci prezzo prodotto:");
double price = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Inserisci iva prodotto:");
int iva = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Product product1 = new Product(name, description, price, iva);
Console.WriteLine("Il prezzo del prodotto senza iva è: " + product1.Price + " euro");
Console.WriteLine();
Console.WriteLine("Il prezzo del prodotto con iva è: " + product1.PriceIva() + " euro");
Console.WriteLine();
Console.WriteLine("Il nome completo del prodotto è: " + product1.ExtendCode() + " " + product1.Name);
Console.WriteLine();
Console.WriteLine("Descrizione del prodotto: " + product1.Description);



//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:

//    codice(numero intero)
//    nome
//    descrizione
//    prezzo
//    iva 
public class Product
{
    private int code;
    public string name;
    public string description;
    public double price;
    public int iva;
    private double priceIva;


    public Product(string name, string description, double price, int iva)
    {
        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.Iva = iva;
        Code = code;

    }

    public int Code
    {
        get
        {
            return code;
        }

        set
        {
            code = new Random().Next(1, 100000000);
        }
    }
    public double Price { get; }

    public string Name { get; }

    public int Iva { get; set; }

    public double PriceIva()
    {
        priceIva = Price + (Price * Iva / 100);
        return priceIva;
    }

    public string Description { get; }

    public string ExtendCode()
    {
        string strCode = Convert.ToString(Code);
        while (strCode.Length < 8)
        {
            strCode = "0" + strCode;
        }
        return strCode;
    }
}


    //public string GetCode()
    //{
    //    string strCode = Convert.ToString(code);
    //    while(strCode.Length < 8)
    //    {
    //        strCode = "0" + strCode;
    //    }
    //    return strCode;
    //}

//    public double GetPrice()
//    {
//        return price;
//    }

//    public double IvaPrice()
//    {
//        double finalPrice = this.price + (this.price * this.iva / 100);
//        finalPrice = Math.Round(finalPrice, 2);
//        return finalPrice;
//    }

//    public string GetFullName()
//    {
//        return this.GetCode() + " " + this.name;
//    }
//}
