using System.Runtime.CompilerServices;
using UnityEngine;

public class Task_1 : MonoBehaviour
{
    [SerializeField] private int expectedPayment;
    private int remainingPayment;
    private int hundredsCount;
    private int fiftiesCount;
    private int twentiesCount;
    private int tensCount;
    private int fivesCount;
    private int onesCount;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Task 1: Calculate the number of bills needed for a given amount of money.");
        Debug.Log("Expected Payment: " + expectedPayment);
        remainingPayment = expectedPayment;
        CalculateHundreds(remainingPayment);
        CalculateFifties(remainingPayment);
        CalculateTwenties(remainingPayment);
        CalculateTens(remainingPayment);
        CalculateFives(remainingPayment);   
        CalculateOnes(remainingPayment);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CalculateHundreds(int change)
    {
        while (change >= 100)
        {
            remainingPayment -= 100;
            change -= 100;
            hundredsCount++;
            
        }
        Debug.Log("Hundreds: " + hundredsCount);
    }

    void CalculateFifties(int change)
    {
        while (change >= 50)
        {
            remainingPayment -= 50;
            change -= 50;
            fiftiesCount++;
            
        }
        Debug.Log("Fifties: " + fiftiesCount);
    }

    void CalculateTwenties(int change)
    {
        while (change >= 20)
        {
            remainingPayment -= 20;
            change -= 20;
            twentiesCount++;
            
        }
        Debug.Log("Twenties: " + twentiesCount);
    }

    void CalculateTens(int change)
    {
        while (change >= 10)
        {
            remainingPayment -= 10;
            change -= 10;
            tensCount++;
            
        }
        Debug.Log("Tens: " + tensCount);
    }

    void CalculateFives(int change)
    {
        while (change >= 5)
        {
            remainingPayment -= 5;
            change -= 5;
            fivesCount++;
            
        }
        Debug.Log("Fives: " + fivesCount);
    }

    void CalculateOnes(int change)
    {
        while (change >= 1)
        {
            remainingPayment -= 1;
            change -= 1;
            onesCount++;
            
        }
        Debug.Log("Ones: " + onesCount);
    }
}
