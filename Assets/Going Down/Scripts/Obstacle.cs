using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour //�ϰ����Component
{
    // Start is called before the first frame update

    public float velocity = 1; //�ϰ���������ٶ�

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, velocity * Time.deltaTime, 0)); //��ÿ��velocity�׵��ٶ�����
    }
}
