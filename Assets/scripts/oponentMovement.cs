using UnityEngine;
using System.Collections;

public class oponentMovement : MonoBehaviour {

    public float speed = 8f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
    }


    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            Debug.Log("game over");
            Destroy(col.gameObject);
        }

    }
   

}
