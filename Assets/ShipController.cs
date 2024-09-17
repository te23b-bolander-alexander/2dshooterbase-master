using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    // Start is called before the first frame update
  [SerializeField]
  float speed = 6f;
  [SerializeField]
  GameObject SkibidiSigma;

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

        if(Input.GetKeyDown(KeyCode.Space))
        {
          Instantiate(SkibidiSigma, transform.position, Quaternion.identity);
        }
     



    }

}



