using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour //�ϰ�����������Component
{
    // Start is called before the first frame update

    public float deltaTime = 3f; //�ϰ���ˢ�¼����������Inspector�������Ը���Ĭ��ֵ��
    private float timeCount = 0;

    public GameObject ObstaclePrefab = null; //�ϰ����Prefab����ק����

    void Start()
    {
        
    }

    void CreateObstacle() //��(Random.Range(-4, 4), -10, 0)�����λ������һ���ϰ���
    {
        GameObject.Instantiate(ObstaclePrefab, new Vector3(Random.Range(-4, 4), -10, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime�Ǿ�����һ��Update�ľ���������
        timeCount = Time.deltaTime + timeCount;
        if(timeCount > deltaTime) //ÿdeltaTime�봴��һ���ϰ���
        {
            timeCount = 0;
            CreateObstacle();
        }
    }
}
