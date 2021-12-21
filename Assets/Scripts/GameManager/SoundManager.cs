using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    
    [SerializeField] 
    private AudioClip[] audioClips;

    private GameManager gameManager;

    //[SerializeField] private AudioClip playerCaught;
    //[SerializeField] private AudioClip changeFields;
    
    //private bool IsChangeFlag;

    

    private void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        gameManager = GameManager.FindObjectOfType<GameManager>();
        gameManager.OnFlagConquered += PlaySound;
    }

    //private void Update()
    //{
    //    if (IsChangeFlag)
    //    {
    //        Debug.Log("Play Audio");
    //    }
    //}

    private void PlaySound(int flagsP1, int flagsP2)
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
    }

}
