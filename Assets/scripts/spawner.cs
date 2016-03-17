using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {


    public float delayTimer = 0.4f;
    float timer;
    int carNo;
    int posNo;
    int initPoint;
    public GameObject[] cars;
    public GameObject[] spwanPos;

    Vector3 midpos = new Vector3(0,0.5f,25.5f);
    Vector3 leftpos = new Vector3(-0.6f, 0.5f, 25.5f);
    Vector3 rightpos = new Vector3(+0.7f, 0.5f, 25.5f);
    // Use this for initialization
    void Start () {
        timer = delayTimer;
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            posNo = Random.Range(0, 3);
            if(posNo == 0) { 
            Instantiate(cars[0], midpos, transform.rotation);
            }
            if(posNo == 1) {
                Instantiate(cars[1], leftpos, transform.rotation);
               
            }
            if(posNo == 2) {
                Instantiate(cars[2], rightpos, transform.rotation);
                
            }
            timer = delayTimer;
        }
    }
}

