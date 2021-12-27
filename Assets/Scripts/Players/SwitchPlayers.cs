using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayers : MonoBehaviour
{


    [SerializeField]
    private PlayerNumber playerNumber;
    private PlayerMovement playerMovement;

    private int[] namberPlayer;


    [SerializeField]
    private bool iCaught = false;
    public bool Icaught
    {

        get { return iCaught; }
        set { iCaught = value; }
    }



    // Start is called before the first frame update
    void Start()
    {

        playerMovement = GetComponent<PlayerMovement>();
        if (playerNumber == PlayerNumber.Player1)
        {
            playerMovement.enabled = true;
        }
        if (playerNumber == PlayerNumber.Player2)
        {
            playerMovement.enabled = false;
        }
        if (playerNumber == PlayerNumber.Player3)
        {
            playerMovement.enabled = false;
        }
       



    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1) && !iCaught)
        {
            if (playerNumber == PlayerNumber.Player1)
            {
                playerMovement.enabled = true;
            }
            if (playerNumber == PlayerNumber.Player2)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player3)
            {
                playerMovement.enabled = false;
            }
           


        }

        else if (Input.GetKeyDown(KeyCode.Alpha2) && !iCaught)
        {
            //witchPlayer[1] = curnetPlayer;
            if (playerNumber == PlayerNumber.Player1)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player2)
            {
                playerMovement.enabled = true;
            }
            if (playerNumber == PlayerNumber.Player3)
            {
                playerMovement.enabled = false;
            }
            

        }

        else if (Input.GetKeyDown(KeyCode.Alpha3) && !iCaught)
        {
            //witchPlayer[2] = curnetPlayer;
            if (playerNumber == PlayerNumber.Player1)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player2)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player3)
            {
                playerMovement.enabled = true;
            }
            
        }

      
    }
   
}
