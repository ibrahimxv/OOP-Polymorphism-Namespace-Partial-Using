using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Polymorphism;

internal class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ProductCount { get; set; }
    public decimal Price { get; set; }
    public Order(int id,string name, decimal price, int productcount)
    {
         Id = id;
         Name = name;
        Price = price;
        ProductCount = productcount;
    }
    public Order(int productcount)
    {
         ProductCount = productcount;
    }
    public Order ()
    {
        ProductCount = 1;
    }

    public decimal CalculateTotalPrice()
    {
        return Price * ProductCount;
    }
    public void IncreaseCount (int n = 1)    
    {
        ProductCount += n;
    }
    public override string ToString()
    {
        return $"Order Id: {Id}, Product: {Name}, Count: {ProductCount}, Price: {Price}, Total: {CalculateTotalPrice()} ";
    }
    public int Diff;
    public int NewPrice;

    public Order(int newprice, int diff)
    {
        NewPrice = newprice;
        Diff = diff;
    }
    public void ChangePrice(int newprice)
    {
        NewPrice = newprice;
        Diff = NewPrice - (int)Price;
        Price = NewPrice;
    }
}
