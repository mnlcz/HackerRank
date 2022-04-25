namespace Days.Day2;
public static class Day2
{
    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        var addedTip = meal_cost * ((double)tip_percent / 100);
        var addedTax = meal_cost * ((double)tax_percent / 100);
        var totalCost = Convert.ToInt32(meal_cost + addedTip + addedTax);
        Console.WriteLine(totalCost);
    }
}