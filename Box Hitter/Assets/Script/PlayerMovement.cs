using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float force = 2000f;
    [SerializeField] private float sidewaysForce = 3.2f;
    [SerializeField] private float jumpPow = 5f;


    private new Rigidbody rigidbody;
    private bool jumpKeyPressed;
    private bool canJump = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            jumpKeyPressed = true;
        }

        

    }
    public void JumpEnable()
    {
        canJump = true;
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(-force, 0, 0);
        //rigidbody.velocity = new Vector3(0,0,horizontalInput * sidewaysForce);
        if(rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if(canJump) 
        {
               if(jumpKeyPressed)
            {

                rigidbody.AddForce(Vector3.up*jumpPow  , ForceMode.VelocityChange);
                jumpKeyPressed = false;
            } 
        }
       
        if(Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(0, 0, 15);
        }
        if(Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(0, 0, -12);
        }
    }

    
}
