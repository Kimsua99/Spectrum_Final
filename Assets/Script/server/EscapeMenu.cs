using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EscapeMenu : MonoBehaviour
{
    [SerializeField] private GameObject go_BaseUI; // �Ͻ� ���� UI �г�
    [SerializeField] private SaveNLoad theSaveNLoad;
    private PlayerController player;
    bool isSound;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PlayerController>();
        isSound = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!GameManager.isPause)
                CallMenu();
            else
                CloseMenu();
        }
    }

    private void CallMenu()
    {
        GameManager.isPause = true;
        go_BaseUI.SetActive(true);
        Time.timeScale = 0f; // �ð��� �帧 ����. 0���. �� �ð��� ����.
        //player.enabled = false;
    }

    private void CloseMenu()
    {
        GameManager.isPause = false;
        go_BaseUI.SetActive(false);
        Time.timeScale = 1f; // 1��� (���� �ӵ�)
        //player.enabled = true;
    }

    public void ClickSave()
    {
        Debug.Log("���̺�");
        theSaveNLoad.SaveData();
    }

    public void ClickLoad()
    {
        Debug.Log("�ε�");
        theSaveNLoad.LoadData();
    }

    public void ClickSound()
    {
        if (isSound)
        {
            isSound = !isSound;
            Debug.Log("�Ҹ� ��");
            AudioListener.volume = 0;
        }
        else
        {
            isSound = !isSound;
            Debug.Log("�Ҹ� ��");
            AudioListener.volume = 1;
        }
    }

    public void ClickTitle()
    {
        Debug.Log("Ÿ��Ʋ");
        SceneManager.LoadScene("TitleNoTimeLine");
    }

}
