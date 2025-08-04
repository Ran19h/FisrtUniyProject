//using UnityEngine;
//using System.Collections;

//public class IguanaUserController : MonoBehaviour {
//	IguanaCharacter iguanaCharacter;
//	public float speed=10;

//	void Start () {
//		iguanaCharacter = GetComponent < IguanaCharacter> ();
//	}

//void Update () {	
//	if (Input.GetButtonDown ("Fire1")) {
//		iguanaCharacter.Attack();
//	}

//	if (Input.GetKeyDown (KeyCode.H)) {
//		iguanaCharacter.Hit();
//	}

//	if (Input.GetKeyDown (KeyCode.E)) {
//		iguanaCharacter.Eat();
//	}

//	if (Input.GetKeyDown (KeyCode.K)) {
//		iguanaCharacter.Death();
//	}

//	if (Input.GetKeyDown (KeyCode.R)) {
//		iguanaCharacter.Rebirth();
//	}




//} new 

//    void Update()
//    {
//        if (Input.GetButtonDown("Fire1"))
//        {
//            iguanaCharacter.Attack();
//        }

//        if (Input.GetKeyDown(KeyCode.H))
//        {
//            iguanaCharacter.Hit();
//        }

//        if (Input.GetKeyDown(KeyCode.E))
//        {
//            iguanaCharacter.Eat();
//        }

//        if (Input.GetKeyDown(KeyCode.K))
//        {
//            iguanaCharacter.Death();
//        }

//        if (Input.GetKeyDown(KeyCode.R))
//        {
//            iguanaCharacter.Rebirth();
//        }

//        // NEW: Jump when pressing Space
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            iguanaCharacter.Jump();
//        }
//    }
//    private void FixedUpdate()
//	{
//		float h = Input.GetAxis ("Horizontal");
//		float v = Input.GetAxis ("Vertical");
//		iguanaCharacter.Move (v*speed,speed*h);
//	}
//}

using UnityEngine;
using System.Collections;

public class IguanaUserController : MonoBehaviour
{
    IguanaCharacter iguanaCharacter;
    public float speed = 10;
    public float jumpForce = 5f;   // NEW: Jump force
    Rigidbody rb;                  // NEW

    void Start()
    {
        iguanaCharacter = GetComponent<IguanaCharacter>();
        rb = GetComponent<Rigidbody>();  // NEW
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            iguanaCharacter.Attack();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            iguanaCharacter.Hit();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            iguanaCharacter.Eat();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            iguanaCharacter.Death();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            iguanaCharacter.Rebirth();
        }

        // PHYSICAL JUMP – No animation
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Mathf.Abs(rb.linearVelocity.y) < 0.01f) // simple ground check
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        iguanaCharacter.Move(v * speed, speed * h);
    }
}
