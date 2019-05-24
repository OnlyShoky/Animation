using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_2_Controller : MonoBehaviour
{
    public float speed = 40f ;

    protected Animator animator;

    [SerializeField] private Sprite SpritePhase1 ,SpritePhase2,SpritePhase3,SpritePhase4,SpritePhase5,SpritePhase6,SpritePhase7;

    private Sprite[] spritePhases ;


    private int Phase = 0 ;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = speed*this.GetComponent<Rigidbody2D>().velocity;
        animator = GetComponent<Animator>();
        transform.localScale  = new Vector3(transform.localScale.x*0.5f, transform.localScale.y*0.5f, transform.localScale.z*0.5f);
        animator.SetBool("PowerCharge", true);
        spritePhases = new Sprite[] {SpritePhase1 ,SpritePhase2,SpritePhase3,SpritePhase4,SpritePhase5,SpritePhase6,SpritePhase7};
        
    }

    // Update is called once per frame
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.T))
             animator.SetBool("PowerCharge", true);
        if (Input.GetKeyUp(KeyCode.T))
            animator.SetBool("PowerCharge", false);

        
    }

    private void incrementPhase(){
        GetComponent<SpriteRenderer>().sprite = spritePhases[Phase];
        Phase = (Phase+1) % 7 ;
        animator.SetInteger("PowerState", Phase);
        transform.localScale  = new Vector3(transform.localScale.x*1.15f, transform.localScale.y*1.15f, transform.localScale.z*1.15f);
        Debug.Log("Incrementando de 1");
        Debug.Log(gameObject.transform.localScale);

    }

    private void resetPhase(){
        Phase = 0 ;
        animator.SetInteger("PowerState", 0);
    }

    private void Destroy() {
        Destroy(gameObject);
        //GetComponentInParent<GuardScript>().listOfPowers.Remove(gameObject);
    }
}
