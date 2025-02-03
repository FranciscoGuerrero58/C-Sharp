var sale = new SaleWithTax(15, 1.16m);
var message = sale.GetInfo();
var messageTax = sale.GetInfoWithTax();

Console.WriteLine(message);
Console.WriteLine(messageTax);

//Clase heredada
class SaleWithTax : Sale
{
    public decimal Tax {  get; set; }
    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        Tax = tax;
    }
    public string GetInfoWithTax()
    {
        return "El total es " + Total + " Impuesto es: " + Tax;
    }
    public override string GetInfo2()
    {
        return "El total es " + Total + " El impuesto es: " + Tax;
    }
}

//Clase principal
class Sale { 
    public decimal Total {  get; set; }
    public Sale(decimal total) {  Total = total; }

    //Metodo con String
    public string GetInfo()
    {
        return "El total es " + Total;
    }
    //Para reutilizar este metodo y se pueda sobre escribir se deberá poner así 
    public virtual string GetInfo2()
    {
        return "El total es " + Total;
    }
}