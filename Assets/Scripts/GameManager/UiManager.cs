
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private PlayerHPdata[] playerData;

    [SerializeField]
    private Text flagTextP1;
    [SerializeField]
    private Text flagTextP2;

    [SerializeField]
    private Text bulletTextP1;
    [SerializeField]
    private Text bulletTextP2;


    private void Start()
    {
        gameManager.OnFlagConquered += ChangeTheNumberFlagsText;
        playerData[0].OnAddOrDecreaseBullet += ChangeTheNumberBulletsP1Text;
        playerData[1].OnAddOrDecreaseBullet += ChangeTheNumberBulletsP2Text;
    }

    private void ChangeTheNumberFlagsText(int flagsP1,int flagsP2,bool conquered)
    {
        if (conquered)
        {
            flagTextP1.text = $"flags:{flagsP1.ToString()}";
            flagTextP2.text = $"flags:{flagsP2.ToString()}";
        }  
    }

    private void ChangeTheNumberBulletsP1Text(int bulletP1)
    {
        bulletTextP1.text = $"Bullet:{bulletP1.ToString()}";
    }

    private void ChangeTheNumberBulletsP2Text(int bulletP2)
    {
        bulletTextP2.text = $"Bullet:{bulletP2.ToString()}";
    }
}
