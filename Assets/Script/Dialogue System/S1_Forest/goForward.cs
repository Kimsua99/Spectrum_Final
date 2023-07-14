using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem; // Put at top of script to access Dialogue System stuff. ... 

public class goForward : MonoBehaviour
{
    // 2021.06.07 created by HY
    // Needs : Trigger, LuaVariable("isTrue")

    // Start is called before the first frame update

    public int goDistance = 5;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // hy : ���̾�α� �ý��ۿ��� �޽����� ������ ��ũ��Ʈ
    private void OnTriggerStay(Collider other) // �÷��̾ �� �ִ� ���� ��� ����ž���(������ true�� �Ǵ� ������ ĳġ�ؾ� �ϹǷ�)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("����1");
            if (DialogueLua.GetVariable("isTrue").asBool) // ���� �޽����� �������� �� ������ true�� �����
            {
                //DialogueManager.StopConversation();
                other.transform.Translate(new Vector3(0, 0, goDistance)); // ��ġ�̵� ����
                //other.transform.GetChild(0).transform.Translate(new Vector3(0, 0, 10));
                //GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition = new Vector3(0, 1, 0);
                //Debug.Log("��");
            }
        }

    }
    /*
    public void OnConversationEnd(Transform actor)
    {
        DialogueManager.StopConversation();
        actor.transform.Translate(new Vector3(0, 0, 10)); // ��ġ�̵� ����
        GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition = new Vector3(0, 1, 0);
    }
    */
}
