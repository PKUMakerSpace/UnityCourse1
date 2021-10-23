using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMain : MonoBehaviour //GameMain��Component
{
    public GameObject GameOverPanel, MenuPanel;  //��Ϸ��������壬�˵�����壬���߻�û�������߶�ͨ��Unity Inspector��ק�õ���

    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale: ��Ϸʱ�����ţ�����������Ϸ����ļ��ٺͼ��٣��ʺϽֻ�����Ϸ�ٶ��������ȳ���
        Time.timeScale = 1; //���¿�ʼ��ʱ��Ĭ����ϷΪ��ʼ״̬
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleGameOver()
    {
        MenuPanel.SetActive(false); //�ر���Ϸ�˵����
        GameOverPanel.SetActive(true); //��ʾ��Ϸ�������
        Time.timeScale = 0; //��ͣ��Ϸ
    }

    public void HandleSuspend()
    {
        MenuPanel.SetActive(true); //��ʾ��Ϸ�˵����
        GameOverPanel.SetActive(false); //�ر���Ϸ�������
        Time.timeScale = 0; //��ͣ��Ϸ
    }

    public void HandleRestart()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single); //����������Ϸ�����������¿�ʼ
    }
}
