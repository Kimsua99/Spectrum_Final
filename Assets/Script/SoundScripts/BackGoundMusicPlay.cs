using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem; // Put at top of script to access Dialogue System stuff. ... 


public class BackGoundMusicPlay : MonoBehaviour
{
    public AudioSource s;
    private bool isPlay = false; // hy : ������ �� ��, �긦 true��Ŵ
    private SaveNLoad theSaveNLoad;
    // Start is called before the first frame update
    void Start()
    {
        //s1 = GameObject.Find("bgs1").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlay)
        {
            s.Play();
            enabled = false;
        }
    }
    private void OnTriggerStay(Collider other) // �÷��̾ �� �ִ� ���� ��� ����ž���(������ true�� �Ǵ� ������ ĳġ�ؾ� �ϹǷ�)
    {
        if (other.tag == "Player")
        {
            /*FindObjectOfType<Inventory>().ClearAllSlots();
            theSaveNLoad = FindObjectOfType<SaveNLoad>();
            theSaveNLoad.LoadInvenData();

            Debug.Log("�κ����� ��� �ε� �Ϸ�");*/
            if (DialogueLua.GetVariable("isBgmOn").asBool) // ���� �޽����� �������� �� ������ true�� �����
            {
                //DialogueManager.StopConversation();
                //s1.Play();

                //Debug.Log("���������");
                isPlay = true;


            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<Inventory>().ClearAllSlots();
            theSaveNLoad = FindObjectOfType<SaveNLoad>();
            theSaveNLoad.LoadInvenData();
            Debug.Log("�κ����� ��� �ε� �Ϸ�");
            GameObject.Find("PauseMenu").GetComponent<EscapeMenu>().ClickSave();
        }
    }
}
    