using UnityEngine;
using System.Collections;

public class buildMovement : MonoBehaviour {

    public float speed = 8f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
    }


   
}
