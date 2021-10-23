using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour //玩家控制小球的Component
{
    // Start is called before the first frame update

    public GameMain gameMain;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool xsp = Input.GetKey(KeyCode.A), ysp = Input.GetKey(KeyCode.D);
        //Physics.gravity = new Vector3(0, -50, 0);
        if(xsp && !ysp)
        {
            Physics.gravity = new Vector3(-5, -10, 0);
        }
        else if (!xsp && ysp)
        {
            Physics.gravity = new Vector3(5, -10, 0);
        }
        else
        {
            Physics.gravity = new Vector3(0, -10, 0);
        }

        if(transform.position.y > 20)
        {
            gameMain.HandleGameOver();
        }

    }
}
