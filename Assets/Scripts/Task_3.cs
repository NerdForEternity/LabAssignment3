using UnityEngine;

public class Task_3 : MonoBehaviour
{
    [SerializeField] private float playerServeScoreChance;
    [SerializeField] private float playerRecentWinScoreChance;
    [SerializeField] private float playerRecentLoseScoreChance;

    private int currentPlayerScore;
    private int currentOpponentScore;
    private bool isMatchPoint;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Task 3: (INCOMPLETE) Estimate chance of player winning a tennis match, based on previous history.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
