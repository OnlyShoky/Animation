using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_1_Controller : MonoBehaviour
{
    public float speed = 40f ;

    private bool direction = false ;


    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = speed*this.GetComponent<Rigidbody2D>().velocity;
        /* direction = GetComponentInParent<GuardScript>().direction ;
        if(direction == false ){
            //transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            this.GetComponent<Rigidbody2D>().velocity = speed*Vector2.left ;
        }
        else{
            //transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            this.GetComponent<Rigidbody2D>().velocity = speed*Vector2.right ;
            
        }*/
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }

    private void OnBecameInvisible() {
        Destroy(gameObject);
        //GetComponentInParent<GuardScript>().listOfPowers.Remove(gameObject);
    }
}
