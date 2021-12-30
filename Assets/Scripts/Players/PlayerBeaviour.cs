using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeaviour : MonoBehaviour
{
    [SerializeField] private bool isMyGround;

    private  PlayerMovement playerMovement;
    private SwitchPlayers switchPlayers;
    private SwitchPlayers2 switchPlayers2;
    
    public Groups myGroup;

    private void Start()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (myGroup == Groups.Groupe2)
        {


            if (collision.collider.gameObject.layer == LayerMask.NameToLayer("AreaGroupe2"))
            {
                isMyGround = true;

                this.GetComponent<BoxCollider>().isTrigger = false;
            }

            else if (collision.collider.gameObject.layer == LayerMask.NameToLayer("AreaGroupe1"))
            {
                isMyGround = false;

                this.GetComponent<BoxCollider>().isTrigger = true;
            }
        }

        else if (myGroup == Groups.Groupe1)
        {


            if (collision.collider.gameObject.layer == LayerMask.NameToLayer("AreaGroupe2"))
            {
                isMyGround = false;

                this.GetComponent<BoxCollider>().isTrigger = true;
            }

            else if (collision.collider.gameObject.layer == LayerMask.NameToLayer("AreaGroupe1"))
            {
                isMyGround = true;
                this.GetComponent<BoxCollider>().isTrigger = false;

            }
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

        else if (myGroup == Groups.Groupe1 && groupe == Groups.Groupe1 && switchPlayers.Icaught|| myGroup == Groups.Groupe2 && groupe == Groups.Groupe2 && switchPlayers2.Icaught)
        {
            Debug.Log("You are free!!");
            MovmentAble(other);
        }
       

    }
    private void MovmentStop(Collider player)
    {
        Debug.Log("I catched you!");
        playerMovement.enabled = false;
        if(myGroup == Groups.Groupe1)
        {
            switchPlayers = player.gameObject.GetComponent<SwitchPlayers>();
            switchPlayers.Icaught = true;
        }
        else if (myGroup == Groups.Groupe2)
        {
            switchPlayers2 = player.gameObject.GetComponent<SwitchPlayers2>();
            switchPlayers2.Icaught = true;
        }
    }
    private void MovmentAble(Collider player)
    {
        Debug.Log("You are free!!");
        if (myGroup == Groups.Groupe1)
        {
            switchPlayers = player.gameObject.GetComponent<SwitchPlayers>();
            switchPlayers.Icaught = false;
        }
        else if (myGroup == Groups.Groupe2)
        {
            switchPlayers2 = player.gameObject.GetComponent<SwitchPlayers2>();
            switchPlayers2.Icaught = false;
        }
    }



}
