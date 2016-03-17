using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
public class playerContraller : MonoBehaviour {

    Rigidbody myrigid;
    Vector3 velocity;



    // Use this for initialization
    void Start () {
        myrigid = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
       myrigid.MovePosition(myrigid.position + velocity * Time.deltaTime);
    }


    public void Move(Vector3 Velocity)
    {
        velocity = Velocity;

    }
}
