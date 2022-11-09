using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpObject : MonoBehaviour
{

    private Rigidbody rb;
    public GravityManager.GravityDirection gravDirection;
    public float bumpForce = 10.0f;
    private bool isPressed;
    
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.GetComponent<Rigidbody>() == null)
        {
            gameObject.AddComponent<Rigidbody>();
        }
        
        rb = gameObject.GetComponent<Rigidbody>();

        if ((int)gravDirection == 0)// if gravDirection is UP
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        }
        else if ((int)gravDirection == 1)// if gravDirection is DOWN
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;
        }
        else if ((int)gravDirection == 2 || (int)gravDirection == 3)// if gravDirection is LEFT or RIGHT
        {
            rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log((int)gravDirection);
            switch ((int)gravDirection)
            {
                case 0: // UP
                    //Debug.Log("going DOWN");
                    rb.AddForce(GravityManager.GravityVectors[1] * GravityManager.GravityStrengh, ForceMode.Impulse);// put it DOWN
                    break;
                case 1:// DOWN
                    //Debug.Log("going UP");
                    rb.AddForce(GravityManager.GravityVectors[0] * GravityManager.GravityStrengh, ForceMode.Impulse);// put it UP
                    break;
                case 2:// LEFT
                    //Debug.Log("going LEFT");
                    rb.AddForce(GravityManager.GravityVectors[3] * GravityManager.GravityStrengh, ForceMode.Impulse);// put it RIGHT
                    break;
                case 3:// RIGHT
                    //Debug.Log("going RIGHT");
                    rb.AddForce(GravityManager.GravityVectors[2] * GravityManager.GravityStrengh, ForceMode.Impulse);// put it LEFT
                    break;
            }
        }
        /*
        else
        {
            isPressed = false;
        }
        */
    }

    
    void FixedUpdate()
    {
        
        if (gravDirection != GravityManager.GravityDirection.Up)
        {
            rb.useGravity = false;
            //rb.AddForce(GravityManager.GravityVectors)
            //Debug.Log((int)gravDirection);
            rb.AddForce(GravityManager.GravityVectors[(int)gravDirection] * GravityManager.GravityStrengh);
        }
        
        /*
        //if (Input.GetKey(KeyCode.Space))
        if (isPressed)
        {
            Debug.Log((int)gravDirection);
            switch ((int)gravDirection)
            {
                case 0: // UP
                    //Debug.Log("going DOWN");
                    rb.AddForce(GravityManager.GravityVectors[1] * GravityManager.GravityStrengh, ForceMode.Impulse);// put it DOWN
                    break;
                case 1:// DOWN
                    //Debug.Log("going UP");
                    rb.AddForce(GravityManager.GravityVectors[0] * GravityManager.GravityStrengh, ForceMode.Impulse);// put it UP
                    break;
                case 2:// LEFT
                    //Debug.Log("going LEFT");
                    rb.AddForce(GravityManager.GravityVectors[3] * GravityManager.GravityStrengh, ForceMode.Impulse);// put it RIGHT
                    break;
                case 3:// RIGHT
                    //Debug.Log("going RIGHT");
                    rb.AddForce(GravityManager.GravityVectors[2] * GravityManager.GravityStrengh, ForceMode.Impulse);// put it LEFT
                    break;
            }
        }
        */
        
    }// end of FixedUpdate()

}
