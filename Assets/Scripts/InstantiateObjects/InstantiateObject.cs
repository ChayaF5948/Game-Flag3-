using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    
    [SerializeField]
    private GameObject[] objectForInstantiate;

    private float STimer;

    private float S1Timer;

    private bool isInstantaite = true;
    private bool isInstantaite1 = true;


    // Start is called before the first frame update
    void Start()
    {
        STimer = Random.Range(20f, 25f);
        S1Timer = Random.Range(40f, 50f);
        StartCoroutine(Timer());
        StartCoroutine(Timer1());
    }

    // Update is called once per frame
    void Update()
    {
        CreatePerfab();
    }



    private void CreatePerfab()
    {
        if (isInstantaite)
        {
            var position = new Vector3(Random.Range(-26f, 13f), 1, Random.Range(-15f, 60f));
            Instantiate(objectForInstantiate[0], position, Quaternion.identity);
            

            StartCoroutine(Timer());
        }

        if (isInstantaite1)
        {
            var position = new Vector3(Random.Range(-26f, 13f), 1, Random.Range(-15f, 60f));
            Instantiate(objectForInstantiate[1], position, Quaternion.identity);

            StartCoroutine(Timer1());

        }

    }

    IEnumerator Timer()
    {
        isInstantaite = false;
        yield return new WaitForSeconds(STimer);
        isInstantaite = true;
    }

    IEnumerator Timer1()
    {
        isInstantaite1 = false;
        yield return new WaitForSeconds(S1Timer);
        isInstantaite1 = true;
    }
}

