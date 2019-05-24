using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPlayer : GuardScript
{

    new void Start()
    {
        base.Start();  
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }

    public void ThrowPower1(){

        if(direction == false){
            GameObject go;
            go=Instantiate(power1,gameObject.transform.position + Vector3.up*0.26f +Vector3.left*0.26f,Quaternion.identity) ;
            go.GetComponent<Rigidbody2D>().velocity = speed*Vector2.left ;
            go.transform.localScale =  new Vector3(1.0f, 1.0f, 1.0f);
            Physics2D.IgnoreCollision(go.GetComponent<BoxCollider2D>(),GetComponent<BoxCollider2D>());
        }
        else {
            GameObject go;
            go=Instantiate(power1,gameObject.transform.position + Vector3.up*0.26f +Vector3.right*0.26f,Quaternion.identity);
            go.GetComponent<Rigidbody2D>().velocity = speed*Vector2.right;
            go.transform.localScale =  new Vector3(-1.0f, 1.0f, 1.0f);
            Physics2D.IgnoreCollision(go.GetComponent<BoxCollider2D>(),GetComponent<BoxCollider2D>());
        }

    }


}
