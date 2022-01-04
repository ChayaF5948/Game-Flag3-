using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    
    [SerializeField]
    private GameObject[] objectForInstantiate;

    private float STimer;

    private bool isInstantaite = true;


    // Start is called before the first frame update
    void Start()
    {
        STimer = Random.Range(2f, 3f);
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
            var position = new Vector3(Random.Range(-26f, 13), 0, Random.Range(-15f, 64f));
            Instantiate(objectForInstantiate[0], position, Quaternion.identity);
            StartCoroutine(Timer());
        }

    }

    IEnumerator Timer()
    {
        isInstantaite = false;
        yield return new WaitForSeconds(STimer);
        isInstantaite = true;
    }
}

