using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    [SerializeField] int gamesWon;
    [SerializeField] float winRate;
    [SerializeField] string botName;
    [SerializeField] bool usesMiniMax;
    void Start()
    {
        gamesWon = 11;
        winRate = 77.4f;
        botName = "Brokenice";
        usesMiniMax = true;
        Debug.Log(gamesWon);
        Debug.Log(winRate);
        Debug.Log(botName);
        Debug.Log(usesMiniMax);
    }

    void Update()
    {
        
    }
}
