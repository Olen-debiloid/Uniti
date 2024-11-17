using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private int health=100;
    private int level =1;
    private float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        health+=level;
        print("Здоровье неписЯ" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;

    }
}
