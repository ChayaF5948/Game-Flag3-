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
    //[SerializeField] PlayerHPdata playerData;
  
  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            
            PlayerMovement datas = other.gameObject.GetComponentInChildren<PlayerMovement>();
            //PlayerHPdata playerHP = datas.playerHPdata;

            if (type == PicUpType.shoots)
            {
                datas.playerData.Bullets = datas.playerData.Bullets +15;
                //playerData.
                //Debug.Log("Add bullets");
                if(datas.playerData.Bullets >= 15)
                {
                    datas.playerData.Bullets = 15;
                }

            }

            else if (type == PicUpType.speed)
            {
                datas.playerData.Score = datas.playerData.Score +1;
                if(datas.playerData.Score >= 2)
                {
                    Debug.Log("Add speed");
                }
                //isAddScore = true;
                Debug.Log("Score:" + datas.playerData.Score);
               

            }

            else if(type == PicUpType.dubleSpeed)
            {
                datas.playerData.DoubleSpeed = datas.playerData.DoubleSpeed +=0.5f;

            }
            Destroy(gameObject);

        }
       
    }
}
