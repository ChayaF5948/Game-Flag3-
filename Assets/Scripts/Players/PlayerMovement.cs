using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
 public enum Groups 
    { 
        Groupe1,
        Groupe2
    }
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 80f;
    [SerializeField] private float rotateSpeed = 300f;

    private const string VERTICAL1_AXIS = "Vertical1";
    private const string HORIZONTAL1_AXIS = "Horizontal1";

    private const string VERTICAL2_AXIS = "Vertical2";
    private const string HORIZONTAL2_AXIS = "Horizontal2";

    private float v1Input;
    private float h1Input;

    private float v2Input;
    private float h2Input;

    public Groups myGroup;

    private Rigidbody rb;

    [SerializeField] private PlayerHPdata playerHPdata;
    
    private void Start()
    {

        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        if (myGroup == Groups.Groupe1)
        {
            v1Input = Input.GetAxis(VERTICAL1_AXIS) * moveSpeed;
            h1Input = Input.GetAxis(HORIZONTAL1_AXIS) * rotateSpeed;
        }

        else if (myGroup == Groups.Groupe2)
        {
            v2Input = Input.GetAxis(VERTICAL2_AXIS) * moveSpeed;
            h2Input = Input.GetAxis(HORIZONTAL2_AXIS) * rotateSpeed;
        }
    }
    private void FixedUpdate()
    {
        //playerHPdata.Bullets = 5;
        //Debug.Log("Bullet" + playerHPdata.Bullets);

        if(myGroup == Groups.Groupe1)
        {
            Vector3 rotation = Vector3.up * h1Input;
            Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

            rb.MovePosition(transform.position + transform.forward * v1Input);
            rb.MoveRotation(rb.rotation * angleRot);
             
        }
        else if(myGroup == Groups.Groupe2)
        {
             Vector3 rotation = Vector3.up * h2Input;
             Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

             rb.MovePosition(transform.position + transform.forward * v2Input);
             rb.MoveRotation(rb.rotation * angleRot);
        }
    }
}
