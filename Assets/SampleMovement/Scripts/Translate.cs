using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public Vector3 initialSpeed = new Vector3(0, -1, 0);
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(initialSpeed * Time.deltaTime); //以每秒velocity米的速度上升
    }
}
