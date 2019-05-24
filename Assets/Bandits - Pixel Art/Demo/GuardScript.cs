using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.IO;
using UnityEditor;

public class GuardScript : MonoBehaviour {

    [SerializeField] protected float      speed = 1.0f;
    [SerializeField] protected float      jumpForce = 4.0f;
        [SerializeField] protected int     playerNumber = 0 ;


    private KeyCode UP,DOWN,LEFT,RIGHT,JUMP,ATTACK,POWER1,POWER2,POWER3,POWER4;
    //private float               inputX;
    protected Animator            animator;
    private Rigidbody2D         body2d;
    private bool                combatIdle = false;
    private bool                isGrounded = true;
    public GameObject power1 ,power2 ;
    private int numberJumps = 2 ;

    public bool direction = false ;

    private List<string> listOfCharacters = new List<string>();
    private List<string> listOfPowers = new List<string>();



    private void updateCharacters(){
        listOfCharacters.Add("HeavyBandit");
        listOfCharacters.Add("LightBandit");
    }

    private void updatePowers(){
        listOfPowers.Add("Power_1");
    }

    private void updateControls(int i ){
        switch(i){
            case 1 :
            UP = Player1Controls.getUP;
            DOWN = Player1Controls.getDOWN;
            LEFT = Player1Controls.getLEFT;
            RIGHT = Player1Controls.getRIGHT;
            JUMP = Player1Controls.getJUMP;
            ATTACK = Player1Controls.getATTACK;
            POWER1= Player1Controls.getPOWER1;
            POWER2 = Player1Controls.getPOWER2;
            POWER3 = Player1Controls.getPOWER3;
            POWER4 = Player1Controls.getPOWER4;
            Debug.Log("Player "+playerNumber + "Controles " + i);
            break;

            case 2 :
            UP = Player2Controls.getUP;
            DOWN = Player2Controls.getDOWN;
            LEFT = Player2Controls.getLEFT;
            RIGHT = Player2Controls.getRIGHT;
            JUMP = Player2Controls.getJUMP;
            ATTACK = Player2Controls.getATTACK;
            POWER1= Player2Controls.getPOWER1;
            POWER2 = Player2Controls.getPOWER2;
            POWER3 = Player2Controls.getPOWER3;
            POWER4 = Player2Controls.getPOWER4;
            Debug.Log("Player "+playerNumber + "Controles " + i);

            break;
        }
        

    }

    // Use this for initialization
    protected void Start () {
        animator = GetComponent<Animator>();
        body2d = GetComponent<Rigidbody2D>();

        Physics2D.IgnoreCollision(GetComponent<BoxCollider2D>(),GetComponent<BoxCollider2D>());
        updateCharacters();
        updatePowers();
        updateControls(playerNumber);
	}
	
	// Update is called once per frame
	protected void Update () {
        // -- Handle input and movement --
        //inputX = Input.GetAxis("Horizontal");
        // Swap direction of sprite depending on walk direction
        if (Input.GetKey(RIGHT)){

            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            direction = true ;
            body2d.velocity = new Vector2(1 * speed, body2d.velocity.y);

        }
        else if (Input.GetKey(LEFT)){

            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            direction = false;
            body2d.velocity = new Vector2(-1 * speed, body2d.velocity.y);


        }

        // Move
        //body2d.velocity = new Vector2(inputX * speed, body2d.velocity.y);


        // -- Handle Animations --
        //isGrounded = IsGrounded();
        animator.SetBool("Grounded", isGrounded);

    
        /*    
        //Death
        if (Input.GetKeyDown("k"))
            animator.SetTrigger("Death");
        //Hurt
        else if (Input.GetKeyDown("h"))
            animator.SetTrigger("Hurt");
        //Recover
        else if (Input.GetKeyDown("r"))
            animator.SetTrigger("Recover");
        //Change between idle and combat idle
        else if (Input.GetKeyDown("i"))
            combatIdle = !combatIdle;

*/

        //Attack
        //else if (Input.GetKeyDown(ATTACK))
        if (Input.GetKeyDown(ATTACK))

        {
            animator.SetTrigger("Attack");
        }

        //Jump
        else if (Input.GetKeyDown(JUMP) && (numberJumps >0) )// && isGrounded)
        {
            numberJumps -- ;
            print(gameObject.name + numberJumps.ToString());
            animator.SetTrigger("Jump");
            body2d.velocity = new Vector2(body2d.velocity.x, jumpForce);
        }

        //Power1
        else if (Input.GetKeyDown(POWER1))
        {
            animator.SetTrigger("Power1");
            
        }

        //Power1
        else if (Input.GetKeyDown(POWER2))
        {
            animator.SetTrigger("Power2");
            
        }

        //Walk
        //else if (Mathf.Abs(inputX) > Mathf.Epsilon && isGrounded)
        else if ((Input.GetKey(RIGHT) ||Input.GetKey(LEFT)) && isGrounded)
            animator.SetInteger("AnimState", 2);
        //Combat idle
        else if (combatIdle)
            animator.SetInteger("AnimState", 1);
        //Idle
        else
            animator.SetInteger("AnimState", 0);

    }


    bool IsGrounded()
    {
        return Physics2D.Raycast(transform.position, -Vector3.up);
    }

//Detect the trigger collision with a power
    private void OnTriggerEnter2D(Collider2D other) {
        if(listOfPowers.Contains(other.gameObject.name.Replace("(Clone)",""))){
            print("Collision with trigger "+other.gameObject.name);
            animator.SetTrigger("Hurt");
        }

    }

//Detect a collision with character
    private void OnCollisionEnter2D(Collision2D other) {
        /* if(listOfCharacters.Contains(other.gameObject.name)){
            print("Collision with Collider2d"+other.gameObject.name);
            animator.SetTrigger("Hurt");
        }
        */

        if(other.gameObject.name =="Espada"){
            animator.SetTrigger("Hurt");
        }

        if(other.gameObject.name=="ground"){
            isGrounded = true ;
            numberJumps = 2 ;
        }



        
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.name=="ground")
            isGrounded = false ;

    }

}
