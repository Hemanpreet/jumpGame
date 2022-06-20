using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;//type of variable->> m_Rigidbody is ->> Rigidbody
    /*
    int wholeNumber = 3;
    float decimalNumber = 3.45f;
    string text = "blabla";
    bool condition = false;
    */
    // Start is called before the first frame update
    void Start()
    {
       rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //GetKeyDown is executed the moment we press down the key ,when we hold it it will not be executed again this is what we want for jumping
        if (Input.GetKeyDown("space")) //Input.GetKeyDown turns true if space key is pressed and Input.GetKeyDown turns false if space key is not pressed
        {
            //when space is pressed we want our player to jump in the game
            //on Y axis we will apply Physics i.e we apply phyics that moves the player upwards in Y direction a little bit and physics is contained in this rigid body component
            //we need a reference to this rigid body
                                                                     //new Vector3() mein we add values for 3 different directions X,Y,Z ,  we dont want to move in X direction when player jumps we want to move it in Y direction, Vector3(0,5,) ->> we pass 0 for X becoz we dont want it to move into X direction, we add 5 for Y so we jump up with force of 5,pass 0 for Z becoz we dont want to move it into Z direction
         rb.velocity = new Vector3(0, 5f,0);//we write Rigidbody becoz this is the component we want to get from our game object i.e want to handle rigit body of player(i.e capsule) ,method is called by putting (), this way we can add velocity to our object, we have to tell the script in what direction we want to move this object and by how much so have to give X,Y,Z values becoz given by position , becoz we want to define how far we want to move it and with how much force so for this we use a vector
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }

        if (Input.GetKeyDown("up"))//GetKey is executed even if we hold down the key ,for moving into different directions we want it to hold down into different directions 
        {
            rb.velocity = new Vector3(0, 0, 5f);//we want to move in forward direction so Z value changes
        }
        if (Input.GetKeyDown("right"))//GetKey is executed even if we hold down the key ,for moving into different directions we want it to hold down into different directions 
        {
           rb.velocity = new Vector3(5f, 0, 0);
            
        }
        if (Input.GetKeyDown("down"))//GetKey is executed even if we hold down the key ,for moving into different directions we want it to hold down into different directions 
        {
            rb.velocity = new Vector3(0, 0, -5f);
            
        }
        if (Input.GetKeyDown("left"))//GetKey is executed even if we hold down the key ,for moving into different directions we want it to hold down into different directions 
        {
            rb.velocity = new Vector3(-5f, 0, 0);
           
        }
        */

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
       float movementSpeed = 6f;
       float jumpForce = 5f;

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
    }
   
}
