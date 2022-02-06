using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    
    [SerializeField] 
    private AudioClip[] audioClips;

    [SerializeField]
    private GameManager gameManager;
    private AddAbility AddAbility;
    private SwitchPlayers switchPlayers;
    private PlayerAbility playerAbility;

    //[SerializeField] private AudioClip playerCaught;
    //[SerializeField] private AudioClip changeFields;
    
    //private bool IsChangeFlag;

    

    private void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        gameManager.OnFlagConquered += PlaySound;
    }

    //private void Update()
    //{
    //    if (IsChangeFlag)
    //    {
    //        Debug.Log("Play Audio");
    //    }
    //}

    private void PlaySound(int flagsP1, int flagsP2,bool conquered)
    {
        if (flagsP1 >= 1||flagsP2 >= 1)
        {
            audioSource.clip = audioClips[0];
            audioSource.Play();
            Debug.Log("The ChangeField sound is play");
        }
        else if(flagsP1 <= 0|| flagsP2 <= 0)
        {
            audioSource.clip = audioClips[1];
            audioSource.Play();
        }
        //else if (AddAbility.IsAddScore)
        //{
        //    audioSource.clip = audioClips[3];
        //    audioSource.Play();
        //}
        //else if(AddAbility.IsAddBullet )
        //{
        //    audioSource.clip = audioClips[4];
        //    audioSource.Play();
        //}
        //else if(switchPlayers.Icaught)
        //{
        //    audioSource.clip = audioClips[5];
        //    audioSource.Play();
        //}
        //else if (playerAbility.CanShoot)
        //{
        //    audioSource.clip = audioClips[6];
        //    audioSource.Play();
        //}
        //else if (AddAbility.IsPickUp)
        //{
        //    audioSource.clip = audioClips[7];
        //    audioSource.Play();
        //}

    }

}
