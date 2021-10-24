using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public float deltaTime = 1;
    private float timeCount = 0;

    public GameObject ObjectPrefab = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        if(timeCount > deltaTime)
        {
            timeCount = 0;
            GameObject.Instantiate(ObjectPrefab, 
                this.transform.position + new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)), 
                Quaternion.identity);
        }
    }
}
