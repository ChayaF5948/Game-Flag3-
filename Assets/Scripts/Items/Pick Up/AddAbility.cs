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

    private bool isAddBullet ;
    private bool isAddScore ;
    private bool isPickUp;

    public bool IsAddBullet
    {
        get => isAddBullet;
        set => isAddBullet = value;
    }
    public bool IsAddScore
    {
        get => isAddScore;
        set => isAddScore = value;
    }
    public bool IsPickUp
    {
        get => isPickUp;
        set => isPickUp = value;
    }



    private void Start()
    {
        StartCoroutine(WaitForSecond());
        isAddBullet = false;
        isAddScore = false;
        isPickUp = false;
    }
  
  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isPickUp = true;
            
            PlayerMovement datas = other.gameObject.GetComponentInChildren<PlayerMovement>();
            PlayerHPdata playerHP = datas.playerHPdata;

            if (type == PicUpType.shoots)
            {
                datas.playerHPdata.Bullets = datas.playerHPdata.Bullets +15;
                isAddBullet = true;
                Debug.Log("Add bullets");
                Destroy(gameObject);

                if(datas.playerHPdata.Bullets >= 20)
                {
                    datas.playerHPdata.Bullets = 20;
                }

            }

            else if (type == PicUpType.speed)
            {
                datas.playerHPdata.Score = datas.playerHPdata.Score +1;
                isAddScore = true;
                Debug.Log("Score:" + datas.playerHPdata.Score);
                Destroy(gameObject);

            }
           
         
        }
       
    }

    IEnumerator WaitForSecond()
    {
        yield return new WaitForSeconds(20);
        Destroy(gameObject);
    }

}
