using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityAction<int, int> OnFlagConquered;
   


    private int flagGro1num = 4;
    private int flagGro2num = 4;

    private bool isConquered = false;
    public bool IsConquered
    {

        get { return isConquered; }
        set
        {
            isConquered = value;
            Debug.Log("The flag Caught Group1");
            if (isConquered)
            {
                OnFlagConquered?.Invoke(flagGro1num,flagGro2num);
                isConquered = false;
            }
        }
    }


    public int FlagGro1Num
    {
        get { return flagGro1num; }
        set { flagGro1num = value; }
    }
    public int FlagGro2Num
    {
        get { return flagGro2num; }
        set { flagGro2num = value; }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
