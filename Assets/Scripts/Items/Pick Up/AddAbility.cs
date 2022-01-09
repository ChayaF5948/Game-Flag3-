using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PicUpType
{
  shoots,
  speed,
  dubleSpeed  
}

public class AddAbility : MonoBehaviour
{
    [SerializeField] PicUpType type;
    [SerializeField] GameManager gameManager;
    [SerializeField] PlayerHPdata playerData;
  
  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            PlayerMovement datas = other.gameObject.GetComponentInChildren<PlayerMovement>();
            PlayerHPdata playerHP = datas.playerHPdata;

            if (type == PicUpType.shoots)
            {
                datas.playerHPdata.Bullets = datas.playerHPdata.Bullets +15;
                //playerData.
                //Debug.Log("Add bullets");
                Destroy(gameObject);

                if(datas.playerHPdata.Bullets >= 20)
                {
                    datas.playerHPdata.Bullets = 20;
                }

            }

            else if (type == PicUpType.speed)
            {
                datas.playerHPdata.Score = datas.playerHPdata.Score +1;
                //isAddScore = true;
                Debug.Log("Score:" + datas.playerHPdata.Score);
                Destroy(gameObject);

            }
           
         
        }
       
    }
}
