using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    [SerializeField] int gamesWon;
    [SerializeField] string botName;
    [SerializeField] bool usesMiniMax;
    void Start()
    {
        Debug.Log(gamesWon);
        Debug.Log(botName);
        Debug.Log(usesMiniMax);
    }

    void Update()
    {
        
    }
}
