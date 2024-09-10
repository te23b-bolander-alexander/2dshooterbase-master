using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    // Start is called before the first frame update
  [SerializeField]
  float speed = 0.02f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

 
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");

        


        Vector2 movement = new Vector2(xInput, yInput) * speed;
        // Vector2 movementY = new Vector2(0, 1) * 0.010f * yInput;

        transform.Translate(movement);
     



    }

}
