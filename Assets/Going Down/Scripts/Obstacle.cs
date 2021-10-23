using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour //障碍物的Component
{
    // Start is called before the first frame update

    public float velocity = 1; //障碍物的上升速度

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, velocity * Time.deltaTime, 0)); //以每秒velocity米的速度上升
    }
}
