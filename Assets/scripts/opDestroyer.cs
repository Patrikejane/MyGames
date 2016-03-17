using UnityEngine;
using System.Collections;

public class opDestroyer : MonoBehaviour {

    // Use this for initialization
    
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "leftop" || col.gameObject.tag == "rightop" || col.gameObject.tag == "midop")
        {
            Debug.Log("hit");
            Destroy(col.gameObject);

        }
    }
}
