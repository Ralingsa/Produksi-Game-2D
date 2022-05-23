using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
using UnityEngine.UI ;
public class player : MonoBehaviour
{
    int idMove = 0 ; 
    bool isJump = true ;
    Animator anim;
    bool isDead = false ;
    bool isRestart = false ; 
    public GameObject sampah ;
	


    // Start is called before the first frame update
    void Start()
    {

    anim = GetComponent < Animator > ();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
	{
		MoveLeft();
		 }
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			MoveRight();
		}

		if (Input.GetKeyUp(KeyCode.RightArrow))
		{

		Idle();
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow))
		{
		Idle();
		}
		Move();
        
    }
    public void MoveRight ()
    {
        idMove = 1 ;
    
    }
    public void MoveLeft ()
    {
        idMove = 2 ;

    }
    private void OnCollisionExit2D(Collision2D collision)
	 {
		 // Kondisi ketika menyentuh tanah
		 
		 anim.ResetTrigger("jalan");
		 
		 }

    private void Move ()
    {
         if (idMove == 1 && !isDead)
			{
			 // Kondisi ketika bergerak ke kekanan
			 if (!isJump) anim.SetTrigger("jalan");
			 transform.Translate(1 * Time.deltaTime * 5f, 0, 0);
			transform.localScale = new Vector3(0.4f, 0.4f, 0.4f) ;
			}
		if (idMove == 2 && !isDead)
			 {
			 // Kondisi ketika bergerak ke kiri

			if (!isJump) anim.SetTrigger("jalan");
			 transform.Translate(-1 * Time.deltaTime * 5f, 0, 0);
			transform.localScale = new Vector3(-0.4f, 0.4f, 0.4f);
			 }
    }
   
    
	void OnTriggerEnter2D(Collider2D other )
	{
		if (other.gameObject.CompareTag ("sampah")) {
			Destroy (other.gameObject);
            
        }
        
    }
    public void Idle()
	 {
		 // kondisi ketika idle/diam
		 if (!isJump)
			 {
			
			 anim.ResetTrigger("jalan");
			 
			 }
		 idMove = 0;
		 }
    
    public void Restart()
    {
        if(!isRestart)
        {
        
        {
            SceneManager.LoadScene ("SampleScene") ;
            }
        
        }
    }
}
