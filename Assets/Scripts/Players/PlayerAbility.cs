using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbility : MonoBehaviour
{
    public PlayerHPdata playerHP;
    [SerializeField] private KeyCode keyShoot;
    
    private bool canShoot = false;
    [SerializeField] GameObject bullet;
    private float bulletSpeed = 100;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(keyShoot) && playerHP.Bullets >= 1)
        {
            canShoot = true;
        }
        
    }

    private void FixedUpdate()
    {
        if(canShoot)
        {
            canShoot = false;
            GameObject newBullet = Instantiate(bullet, transform.position + new Vector3(1, 0, 0), transform.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
        }
    }

}
