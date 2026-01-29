using UnityEngine;

public class Task_2 : MonoBehaviour
{
    // Input variables
    [SerializeField] public float coverPrice;
    [SerializeField] public int copiesSold;

    // Variables to hold calculated costs and profits
    private float booksCost;
    private float shippingCost;
    private float totalWholesaleCost;
    private float totalRevenue;
    private float totalProfit;

    // Constants
    private float discountRate = 0.40f;
    private float firstCopyShipping = 3.00f;
    private float additionalCopyShipping = 0.75f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Task 2: Bookstore wholesale cost and profit calculator.");
        Debug.Log("Cover Price: " + coverPrice);
        Debug.Log("Copies Sold: " + copiesSold);

        // Perform calculations
        CalculateBooksCost();
        CalculateShipping();
        CalculateWholesaleCost();
        CalculateRevenue();
        CalculateProfit();

        // Print results
        PrintResults();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CalculateBooksCost()
    {
        // Apply discount to cover price
        float discountedPrice = coverPrice - (coverPrice * discountRate);
        
        // Calculate total cost for books
        booksCost = discountedPrice * copiesSold;
        Debug.Log("Total books cost: " + booksCost);
    }

    // Calculate shipping cost
    void CalculateShipping()
    {
        // First copy costs $3.00, each additional copy costs $0.75
        if (copiesSold <= 0)
        {
            shippingCost = 0;
        }
        else if (copiesSold == 1)
        {
            shippingCost = firstCopyShipping;
        }
        else
        {
            shippingCost = firstCopyShipping + ((copiesSold - 1) * additionalCopyShipping);
        }

        Debug.Log("Shipping cost: " + shippingCost);
    }

    // Calculate total wholesale cost
    void CalculateWholesaleCost()
    {
        totalWholesaleCost = booksCost + shippingCost;
        Debug.Log("Total wholesale cost: " + totalWholesaleCost);
    }

    // Calculate total revenue from sales
    void CalculateRevenue()
    {
        totalRevenue = coverPrice * copiesSold;
        Debug.Log("Total revenue: " + totalRevenue);
    }

    // Calculate profit before operational costs
    void CalculateProfit()
    {
        totalProfit = totalRevenue - totalWholesaleCost;
    }

    void PrintResults()
    {
        Debug.Log("===== TASK 2 RESULTS =====");
        Debug.Log($"Wholesale Cost: {totalWholesaleCost:F2}");
        Debug.Log($"Profit (before operational costs): {totalProfit:F2}");
        Debug.Log("==========================");
    }
}
