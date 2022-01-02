using UnityEngine;
using System.Collections;
public class Flag : MonoBehaviour
{
    [SerializeField]
    private Groups myFlag;
    [SerializeField]
    private GameObject flag;

    private GameManager gameManager;

    [SerializeField]
    private Material[] area;

    private bool isChangeFlag = true;

    
    public bool IsChangeFlag
    {
        get
        {
            return isChangeFlag;
        }
        set
        {
            isChangeFlag = value;
        }
    }
    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        
    }


    private void OnCollisionEnter(Collision other)

    {
        if(isChangeFlag)
        {
            StartCoroutine(WhaitWhenConquered());
            if (other.gameObject.CompareTag("Player"))
            {
                PlayerMovement whichAGroup = other.gameObject.GetComponentInChildren<PlayerMovement>();
                Groups groupes = whichAGroup.myGroup;
                if (groupes == Groups.Groupe1 && myFlag == Groups.Groupe2)
                {
                    ChangeArea();
                    ChangeFlag();
                }
                else if (groupes == Groups.Groupe2 && myFlag == Groups.Groupe1)
                {
                    ChangeArea();
                    ChangeFlag();
                }
            }
        }
       
    }
    

    private void ChangeFlag()
    {

        gameObject.SetActive(false);
        flag.SetActive(true);
       
       
            if (myFlag == Groups.Groupe2)
            {
                gameManager.FlagGro1Num++;
                gameManager.FlagGro2Num--;
            }
            else if (myFlag == Groups.Groupe1)
            {
                gameManager.FlagGro1Num--;
                gameManager.FlagGro2Num++;
            }
            gameManager.IsConquered = true;
          
       
        
    }

    private void ChangeArea()
    {
        if(myFlag == Groups.Groupe2)
        {
            transform.parent.gameObject.layer = 6;
            transform.parent.GetComponent<Renderer>().material = area[0];
        }
        else if(myFlag == Groups.Groupe1)
        {
            transform.parent.gameObject.layer = 7;
            transform.parent.GetComponent<Renderer>().material = area[1];
        }

    }

  private IEnumerator WhaitWhenConquered()
    {
        isChangeFlag = false;
        yield return new WaitForSeconds(2f);
        isChangeFlag = true;
    }
}
