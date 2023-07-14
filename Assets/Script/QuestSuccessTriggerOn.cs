using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class QuestSuccessTriggerOn : MonoBehaviour
{

    // 2021.07.07 created by HY
    // Needs : Trigger, QuestName, TargetBoxTrigger
    public string luaQuestName;
    public GameObject targetTrigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) // hy : �÷��̾ Ʈ���ſ� �����ִµ���
    {
        if(other.tag == "Player")
        {
            if(DialogueLua.GetQuestField(luaQuestName, "State").asString == "success") // hy : ����Ʈ�� �����ϸ�
            {
                targetTrigger.GetComponent<BoxCollider>().enabled = true; // hy : ��ȭ�ý����� ����ִ� �� Ʈ���� on������
            }
        }
    }
}
