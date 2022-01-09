
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu(fileName = "New Player HP", menuName = "Player HP", order = 53)]
public class PlayerHPdata : ScriptableObject
{ 
    private  float currentSpeed;
    private int score;
    private int bullets;

    public UnityAction<int> OnAddOrDecreaseBullet;
   
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
        get { return bullets; }
        set {
             bullets = value;
            OnAddOrDecreaseBullet?.Invoke(Bullets);  
            }
    }

    private void Awake()
    {
        bullets = 0;
        Score = 0;
    }

}
