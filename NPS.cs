using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{

    int level = 1;
    int health = 3;
    float speed = 1.5f;
    private Vector3 new_pos;

    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("heath" +  health);
    }

    // Update is called once per frame
    void Update()
    {
        new_pos = transform.position;
        new_pos.x += speed * Time.deltaTime;
        gameObject.transform.position = new_pos;
    }
}
