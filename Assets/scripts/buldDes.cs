using UnityEngine;
using System.Collections;

public class buldDes : MonoBehaviour {

    // Use this for initialization


    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "building")
        {
            Debug.Log("building hit");
            Destroy(col.gameObject);

        }
    }
}