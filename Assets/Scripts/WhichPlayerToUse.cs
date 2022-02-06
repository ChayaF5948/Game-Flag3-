using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichPlayerToUse : MonoBehaviour
{
    //[SerializeField]
    private GameObject player;
    private ChoosePlayerType choosePlayerType;

    // Start is called before the first frame update
    void Start()
    {
         player = choosePlayerType.player;
        Instantiate(player,new Vector3(0,1,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
