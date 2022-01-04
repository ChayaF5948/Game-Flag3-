using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeaviour : MonoBehaviour
{
    private bool isMyGround;
    private bool isTrigger;

    private PlayerMovement playerMovement;
    private SwitchPlayers switchPlayers;

    private const string AREA_GROUPE1 = "AreaGroupe1";
    private const string AREA_GROUPE2 = "AreaGroupe2";
    public Groups myGroup;


    public bool IsMyGround
    {
        get => isMyGround;
    }
       




    private void Start()
    {
        isTrigger = this.GetComponent<BoxCollider>().isTrigger;
        isTrigger = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
         if (myGroup == Groups.Groupe1)
        {

            CheckIfMyArea(collision, AREA_GROUPE1, AREA_GROUPE2);
        }
       
        else if (myGroup == Groups.Groupe2)
        {
            CheckIfMyArea(collision, AREA_GROUPE2, AREA_GROUPE1);

        }


    }
    private void OnTriggerEnter(Collider other)
    {
         playerMovement = other.gameObject.GetComponentInChildren<PlayerMovement>();
        Groups groupe = playerMovement.myGroup;

        

        if (myGroup == Groups.Groupe1 && isMyGround && groupe == Groups.Groupe2 || myGroup == Groups.Groupe2 && isMyGround && groupe == Groups.Groupe1)
        {
            
            MovmentStop(other);
        }

        else if (myGroup == Groups.Groupe1 && groupe == Groups.Groupe1 && switchPlayers.Icaught|| myGroup == Groups.Groupe2 && groupe == Groups.Groupe2 && switchPlayers.Icaught)
        {
            Debug.Log("You are free!!");
            MovmentAble(other);
        }

    }

    private void CheckIfMyArea(Collision area, string areaName1, string areaName2)
    {

        if (area.collider.gameObject.layer == LayerMask.NameToLayer(areaName1))
        {
            isMyGround = true;

            isTrigger = false;
        }

        else if (area.collider.gameObject.layer == LayerMask.NameToLayer(areaName2))
        {
            isMyGround = false;

            isTrigger = true;
        }
    }

    private void MovmentStop(Collider player)
    {
        Debug.Log("I catched you!");
        playerMovement.enabled = false;
      
            switchPlayers = player.gameObject.GetComponent<SwitchPlayers>();
            switchPlayers.Icaught = true;
    }

    private void MovmentAble(Collider player)
    {
        Debug.Log("You are free!!");
       
            switchPlayers = player.gameObject.GetComponent<SwitchPlayers>();
            switchPlayers.Icaught = false;
        
       
    }
}
