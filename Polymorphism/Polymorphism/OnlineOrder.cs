using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism;

internal class OnlineOrder : Order
{
    public double ShippingDistance { get; set; }
    public OnlineOrder(int id, string name, decimal price, int productcount, double shippingdistance)
        : base(id, name, price, productcount)
    {
        ShippingDistance = shippingdistance;
    }
    public double CalculateShippingCost()
    {
        return ShippingDistance * 0.5;
    }
    public string GetDetail()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Sifaris Id: " + Id);
        sb.AppendLine("Mehsul: " + Name);
        sb.AppendLine("Qiymet: " + Price + " AZN");
        sb.AppendLine("Sayi: " + ProductCount);
        sb.AppendLine("Shipping Cost: " + CalculateShippingCost() + " AZN");
        sb.AppendLine("Mesafe: " + ShippingDistance + " km");
        sb.AppendLine("Umumi Qiymet: " + (CalculateTotalPrice() + (decimal)(CalculateShippingCost())) + " AZN");
        return sb.ToString();
    }
}