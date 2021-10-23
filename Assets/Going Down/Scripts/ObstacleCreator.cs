using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour //障碍物生成器的Component
{
    // Start is called before the first frame update

    public float deltaTime = 3f; //障碍物刷新间隔（可以在Inspector里设置以覆盖默认值）
    private float timeCount = 0;

    public GameObject ObstaclePrefab = null; //障碍物的Prefab，拖拽设置

    void Start()
    {
        
    }

    void CreateObstacle() //在(Random.Range(-4, 4), -10, 0)的随机位置生成一个障碍物
    {
        GameObject.Instantiate(ObstaclePrefab, new Vector3(Random.Range(-4, 4), -10, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime是距离上一次Update的经过的秒数
        timeCount = Time.deltaTime + timeCount;
        if(timeCount > deltaTime) //每deltaTime秒创建一个障碍物
        {
            timeCount = 0;
            CreateObstacle();
        }
    }
}
