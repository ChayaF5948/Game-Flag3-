using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Player HP", menuName = "Player HP", order = 53)]
public class PlayerHPdata : ScriptableObject
{ 
    private float currentSpeed;
    private int score;
    private int bullets;
   
    public float CurrentSpeed
    {
        get => currentSpeed;
        set => currentSpeed = value;
    }

    public int Score
    {
        get => score;
        set => score = value;
    }

    public int Bullets
    {
        get => bullets;
        set => bullets = value;
    }

}
