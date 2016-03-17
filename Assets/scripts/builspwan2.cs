using UnityEngine;
using System.Collections;

public class builspwan2 : MonoBehaviour {

    public float delayTimer = 0.4f;
    float timer;
    int BNo;
    public GameObject[] buildings;

    Vector3 upPos = new Vector3(7f, 1.5f, 30f);
    Vector3 downPos = new Vector3(7f, 0.5f, 30f);


    // Use this for initialization
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            BNo = Random.Range(0, 2);
            if (BNo == 0)
            {
                Instantiate(buildings[0], upPos, transform.rotation);
                timer = delayTimer;
            }
            if (BNo == 1)
            {
                Instantiate(buildings[0], downPos, transform.rotation);
                timer = delayTimer;
            }
        }

    }
}
