using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PicUpItem
{
  shoots,
  speed
}

public class AddAbility : MonoBehaviour
{
    [SerializeField] PicUpItem PicUpItem; 
  
  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerHPdata playerHPdata = other.gameObject.GetComponentInChildren<PlayerHPdata>();

        if(PicUpItem == PicUpItem.shoots)
            {
                playerHPdata.Bullets =+ 15;
                
            }

        }


        Destroy(this);
    }
}
