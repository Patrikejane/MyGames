using UnityEngine;
using System.Collections;


[RequireComponent(typeof(playerContraller))]
public class player : MonoBehaviour {


    Vector3 startposition;
    public float moveSpeed = 5;
    playerContraller contraller;
    // Use this for initialization
    void Start () {
        startposition = transform.position;
        contraller = GetComponent<playerContraller>();

    }
	
	// Update is called once per frame
	void Update () {
     

    }

    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "leftop" || other.gameObject.tag == "rightop" || other.gameObject.tag == "midop")
        {

            // move Input
            Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            Vector3 moveVelocity = moveInput.normalized * moveSpeed;
            contraller.Move(moveVelocity);



            if (Input.GetKey("up"))
                print("up arrow key is held down");

            if (Input.GetKey("down"))
                print("down arrow key is held down");
            if (Input.GetKey("left"))
                print("left arrow key is held down");

            if (Input.GetKey("right"))
                print("right arrow key is held down");


        }
     
    }

    void OnTriggerExit(Collider other) {

        transform.position = startposition;


    }
}
