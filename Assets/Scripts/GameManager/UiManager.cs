using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    private GameManager gameManager;
    
    [SerializeField]
    private Text flagTextP1;
    [SerializeField]
    private Text flagTextP2;

    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        gameManager.OnFlagConquered += ChangeTheNumberFlagsText;
    }

    private void ChangeTheNumberFlagsText(int flagsP1,int flagsP2,bool conquered)
    {
        if (conquered)
        {
            flagTextP1.text = $"flags:{flagsP1.ToString()}";
            flagTextP2.text = $"flags:{flagsP2.ToString()}";
        }
       
    }
}
