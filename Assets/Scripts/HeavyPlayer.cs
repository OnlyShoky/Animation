using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyPlayer : GuardScript
{

    
    // Start is called before the first frame update
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
            //go.transform.localScale.x = go.transform.localScale.x *(1) ; //* Vector3(1.0f, 1.0f, 1.0f);
            go.transform.localScale  = new Vector3(-go.transform.localScale.x, go.transform.localScale.y, go.transform.localScale.z);

            Physics2D.IgnoreCollision(go.GetComponent<BoxCollider2D>(),GetComponent<BoxCollider2D>());
        }
        else {
            GameObject go;
            go=Instantiate(power1,gameObject.transform.position + Vector3.up*0.26f +Vector3.right*0.26f,Quaternion.identity);
            go.GetComponent<Rigidbody2D>().velocity = speed*Vector2.right;
            //go.transform.localScale  = new Vector3(-1.0f, 1.0f, 1.0f);
            go.transform.localScale  = new Vector3(go.transform.localScale.x, go.transform.localScale.y, go.transform.localScale.z);
            Physics2D.IgnoreCollision(go.GetComponent<BoxCollider2D>(),GetComponent<BoxCollider2D>());
        }

    }

    public void ThrowPower2(){

        if(direction == false){
            GameObject go;
            go=Instantiate(power2,gameObject.transform.position + Vector3.up*0.26f +Vector3.left*0.26f,Quaternion.identity) ;
            go.transform.parent = gameObject.transform;
            //go.GetComponent<Rigidbody2D>().velocity = speed*Vector2.left ;
            //go.transform.localScale.x = go.transform.localScale.x *(1) ; //* Vector3(1.0f, 1.0f, 1.0f);
            go.transform.localScale  = new Vector3(go.transform.localScale.x, go.transform.localScale.y, go.transform.localScale.z);

            Physics2D.IgnoreCollision(go.GetComponent<BoxCollider2D>(),GetComponent<BoxCollider2D>());
        }
        else {
            GameObject go;
            go=Instantiate(power2,gameObject.transform.position + Vector3.up*0.26f +Vector3.right*0.26f,Quaternion.identity);
            go.transform.parent = gameObject.transform;
            //go.GetComponent<Rigidbody2D>().velocity = speed*Vector2.right;
            //go.transform.localScale  = new Vector3(-1.0f, 1.0f, 1.0f);
            go.transform.localScale  = new Vector3(-go.transform.localScale.x, go.transform.localScale.y, go.transform.localScale.z);
            Physics2D.IgnoreCollision(go.GetComponent<BoxCollider2D>(),GetComponent<BoxCollider2D>());
        }

    }

    

}
