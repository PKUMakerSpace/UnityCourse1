using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMain : MonoBehaviour //GameMain的Component
{
    public GameObject GameOverPanel, MenuPanel;  //游戏结束的面板，菜单的面板，后者还没做（二者都通过Unity Inspector拖拽得到）

    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale: 游戏时间缩放，可以用于游戏整体的加速和减速，适合街机类游戏速度逐渐上升等场景
        Time.timeScale = 1; //重新开始的时候默认游戏为开始状态
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleGameOver()
    {
        MenuPanel.SetActive(false); //关闭游戏菜单面板
        GameOverPanel.SetActive(true); //显示游戏结束面板
        Time.timeScale = 0; //暂停游戏
    }

    public void HandleSuspend()
    {
        MenuPanel.SetActive(true); //显示游戏菜单面板
        GameOverPanel.SetActive(false); //关闭游戏结束面板
        Time.timeScale = 0; //暂停游戏
    }

    public void HandleRestart()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single); //重新载入游戏场景，即重新开始
    }
}
