using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private PlayerHPdata playerHPdata;

    [SerializeField]
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = playerHPdata.Score;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
        if(score == 30)
        {
            Debug.Log(score);
        }
    }
}
