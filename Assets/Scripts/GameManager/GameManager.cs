using UnityEngine;
using UnityEngine.Events;
using System.Collections;
[CreateAssetMenu(fileName = "GameManeger", menuName = "Game manager", order = 54)]
public class GameManager : ScriptableObject
{


    public UnityAction<int, int,bool> OnFlagConquered;
   

    public UnityAction<int, int, bool> OnFlagConquered;
    public UnityAction OnPLayerCatch;

    private int flagGro1num = 4;
    private int flagGro2num = 4;

    private bool isConquered = false;

    //private bool isAddBullet;
    //private bool isAddScore;
    //private bool isPicUp;
    private bool thePlayerCaught;

    public bool IsConquered
    {

        get { return isConquered; }
        set
        {
            isConquered = value;
            Debug.Log("The flag Caught Group1");
            if (isConquered)
            {
                OnFlagConquered?.Invoke(flagGro1num, flagGro2num, isConquered);
                isConquered = false;
            }
        }
    }

    public int FlagGro1Num
    {

        get { return flagGro1num; }
        set { flagGro1num = value;
            if (flagGro1num < 0)
            {
                flagGro1num = 0;
            }
        }

    }

    public int FlagGro2Num
    {
        get { return flagGro2num; }
        set { flagGro2num = value;
            if (flagGro2num < 0)
            {
                flagGro2num = 0;
            }
        }
    }

    public bool ThePlayerCaught
    {
        set { thePlayerCaught = value;
            if (thePlayerCaught)
            {
                OnPLayerCatch?.Invoke();
                thePlayerCaught = false;
            }
        }
    }
}
