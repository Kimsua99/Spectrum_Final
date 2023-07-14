using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem; // Put at top of script to access Dialogue System stuff. ... 

public class BackGroundMusicStop : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource s;
    private bool isStop = false; // hy : ������ �� ��, �긦 true��Ŵ

    // Start is called before the first frame update
    void Start()
    {
        //s1 = GameObject.Find("bgs1").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("���� ����");
        if (isStop)
        {
            s.Stop();
            enabled = false;
        }
    }
    private void OnTriggerStay(Collider other) // �÷��̾ �� �ִ� ���� ��� ����ž���(������ true�� �Ǵ� ������ ĳġ�ؾ� �ϹǷ�)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("����1");
            if (!DialogueLua.GetVariable("isBgmOn").asBool) // ���� �޽����� �������� �� ������ true�� �����
            {
                //DialogueManager.StopConversation();
                //s1.Play();
                isStop = true;
            }
        }
    }
}
