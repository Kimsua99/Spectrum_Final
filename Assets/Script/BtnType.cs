using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEditor;

public class BtnType : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    //private MainUI mu;
    public string nextSceneName; 
    public BTNType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup mainGroup;
    public CanvasGroup settingGroup;
    public CanvasGroup levelGroup;
    public CanvasGroup level1;
    public CanvasGroup level2;
    public CanvasGroup level3;
    public CanvasGroup creditGroup;
    int gameLevel=3;
    //bool clear = false;
    bool isSound;

    private static BTNType instance;
    private SaveNLoad theSaveNLoad;
    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
        }
        //else
            //Destroy(this.gameObject);
    }
    public void Start()
    {
        //mu = FindObjectOfType<MainUI>();
        //gameLevel = mu.gameLev;
        defaultScale = buttonScale.localScale;
        isSound = true;
        if (VideoControllers.isCredit == true)
        {
            CanvasGroupOn(creditGroup);
        }
        else
        {
            CanvasGroupOff(creditGroup);
        }
    }

    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.New:
                Debug.Log("������");
                Debug.Log(SaveNLoad.saveData.SceneName);
                if (SaveNLoad.saveData.SceneName == null)
                {
                    SceneManager.LoadScene("SampleScene");
                }
                else {
                    CanvasGroupOn(levelGroup);
                    CanvasGroupOff(mainGroup);
                    if (GameManager.instance.SceneName == "SampleScene")
                    {
                        CanvasGroupOn(level1);
                    }
                    else if (GameManager.instance.SceneName == "Second")
                    {
                        CanvasGroupOn(level2);
                    }
                    else if (GameManager.instance.SceneName == "ThirdBefore" || GameManager.instance.SceneName == "AnesRoom" || GameManager.instance.SceneName == "ThirdAfter")
                    {
                        CanvasGroupOn(level3);
                    }
                    else {
                        Debug.Log("0 ~ 3 �� �Է�");
                    }
                }
                break;

            case BTNType.Continue:
                Debug.Log("�̾��ϱ�");
                theSaveNLoad.LoadData();
                break;

            case BTNType.Setting:
                Debug.Log("����");
                CanvasGroupOn(settingGroup);
                CanvasGroupOff(mainGroup);
                break;

            case BTNType.Ranking:
                Debug.Log("��������");
                break;

            case BTNType.Sound:
                if (isSound)
                {
                    isSound = !isSound;
                    Debug.Log("�Ҹ� ��");
                    AudioListener.volume = 0;
                }
                else {
                    isSound = !isSound;
                    Debug.Log("�Ҹ� ��");
                    AudioListener.volume = 1;
                }
                break;

            case BTNType.Back:
                Debug.Log("�ڷΰ���");
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(settingGroup);
                break;

            case BTNType.Back2:
                Debug.Log("�ڷΰ���");
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(levelGroup);
                CanvasGroupOff(level1);
                CanvasGroupOff(level2);
                CanvasGroupOff(level3);
                break;

            case BTNType.Quit:
                Application.Quit();
                Debug.Log("������");
                break;

            case BTNType.Go1:
                Debug.Log("1��");
                SceneManager.LoadScene("Loading");
                break;

            case BTNType.Go2:
                Debug.Log("2��");
                SceneManager.LoadScene("Loading2");
                break;

            case BTNType.Go3:
                Debug.Log("3��");
                SceneManager.LoadScene("Loading3");
                break;

            case BTNType.Credit:
                Debug.Log("ũ����");
                SceneManager.LoadScene("Credit");
                break;
        }
    }

    IEnumerator LoadCoroutine()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("SampleScene");
        while (operation.isDone)
        {
            yield return null;
        }
        theSaveNLoad = FindObjectOfType<SaveNLoad>();
        theSaveNLoad.LoadData();
        //Destroy(gameObject);
    }

    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.gameObject.SetActive(true);
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.gameObject.SetActive(false);
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.1f;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
