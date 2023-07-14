using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class AltarParent : MonoBehaviour
{
    public GameObject Spike;
    //private List<Altar> alList;
    private bool isAllTrue = false; // hy : �ڽ� �������� ��� true�ΰ�?
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        for (int i = 0; i < transform.GetChildCount(); i++)
        {
            if (!gameObject.transform.GetChild(i).GetComponent<Altar>().isAltarEnter) // hy : �ڽ� ��ü���� Altar ��ũ��Ʈ���� isEnterAltar ������ ��� true�� �Ǹ� ����
            {
                isAllTrue = false; // hy : �ϳ��� true�ƴϸ� �� ������ false��ä�� false
                return;
            }
            else
            {
                isAllTrue = true; // hy : ��� �ڽ� �������� true�̸� �� ������ true��
            }
        }

        if (isAllTrue)
        {
            Debug.Log("���� ���� ���� ��");
        }
        */

        for (int i = 0; i < transform.GetChildCount(); i++)
        {
            if (gameObject.transform.GetChild(30).GetComponent<Altar>().isAltarEnter == true)
            {
                Debug.Log("3�� ���� �� ����");
                GameObject.Find("S8_Trigger3").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��
            }

            else if (gameObject.transform.GetChild(26).GetComponent<Altar>().isAltarEnter && gameObject.transform.GetChild(27).GetComponent<Altar>().isAltarEnter &&
                gameObject.transform.GetChild(28).GetComponent<Altar>().isAltarEnter  && gameObject.transform.GetChild(29).GetComponent<Altar>().isAltarEnter == true)
            {
                Debug.Log("3�� �̷� ���� �� ����");
                GameObject.Find("Mazedoor").GetComponent<DoorOpen>().isOperate = true;
                GameObject.Find("S2_Trigger3").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��
            }
            
            else if (gameObject.transform.GetChild(24).GetComponent<Altar>().isAltarEnter && gameObject.transform.GetChild(25).GetComponent<Altar>().isAltarEnter == true)
            {
                Debug.Log("2�ο��� 3�η� ���ϴ� �� 2 ����");
                GameObject.Find("SecondFinalDoor").transform.localEulerAngles = new Vector3(-0.265f, -81.83f, 0.043f);
                GameObject.Find("S9_Trigger3").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��

            }
            

            if (gameObject.transform.GetChild(23).GetComponent<Altar>().isAltarEnter == true)
            {
                Debug.Log("2�� ��� ���� ����");
                
            }

            else if (gameObject.transform.GetChild(22).GetComponent<Altar>().isAltarEnter == true)
            {
                Debug.Log("2�� ������ ���� ����");
                
            }

            else if (gameObject.transform.GetChild(21).GetComponent<Altar>().isAltarEnter == true)
            {
                Debug.Log("2�� �Ķ� ���� ����");
                
            }

            else if (gameObject.transform.GetChild(20).GetComponent<Altar>().isAltarEnter == true)
            {
                Debug.Log("2�� ��ȫ ���� ����");
                
            }

            else if (gameObject.transform.GetChild(19).GetComponent<Altar>().isAltarEnter == true)
            {
                Debug.Log("2�� �ʷ� ���� ����");
            }

            else if (gameObject.transform.GetChild(18).GetComponent<Altar>().isAltarEnter == true)
            {
                Debug.Log("2�� ���� 1�� ������ ��, �ѱ��� ��, ���� �� �� ����");
                GameObject.Find("secondportalDoor").GetComponent<DoorOpen>().isOperate = true;
                GameObject.Find("SinjunDoor").GetComponent<DoorOpen>().isOperate = true;
                GameObject.Find("CaveEnterDoor").GetComponent<DoorOpen>().isOperate = true;
                GameObject.Find("S4_Trigger26").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��
            }

            else if (gameObject.transform.GetChild(16).GetComponent<Altar>().isAltarEnter && gameObject.transform.GetChild(17).GetComponent<Altar>().isAltarEnter == true)
            {

                Debug.Log("2�� 2�� �߾ӹ� ����");
                GameObject.Find("CenterSecondDoor").GetComponent<DoorOpen>().isOperate = true;
                GameObject.Find("S4_Trigger12").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��
            }

            else if (gameObject.transform.GetChild(12).GetComponent<Altar>().isAltarEnter && gameObject.transform.GetChild(13).GetComponent<Altar>().isAltarEnter
               && gameObject.transform.GetChild(14).GetComponent<Altar>().isAltarEnter && gameObject.transform.GetChild(15).GetComponent<Altar>().isAltarEnter == true)
            {

                Debug.Log("2�� 1�� �߾ӹ� ����");
                GameObject.Find("CenterFirstDoor").GetComponent<DoorOpen>().isOperate = true;
                GameObject.Find("S4_Trigger9").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��
            }

            else if (gameObject.transform.GetChild(11).GetComponent<Altar>().isAltarEnter == true)
            {
                GameObject.Find("SpikeLeverDoor").GetComponent<DoorOpen>().isOperate = true;
                Spike.gameObject.SetActive(false);
                GameObject.Find("S4_Trigger4").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��
                Debug.Log("2�� ����� 1�� ���� �����.");
            }

            else if (gameObject.transform.GetChild(10).GetComponent<Altar>().isAltarEnter == true)
            {
                GameObject.Find("S10_Conv_Trigger5").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��
                Debug.Log("1�� ������ �̺� ����");
            } 

            else if (gameObject.transform.GetChild(6).GetComponent<Altar>().isAltarEnter && gameObject.transform.GetChild(7).GetComponent<Altar>().isAltarEnter
                && gameObject.transform.GetChild(8).GetComponent<Altar>().isAltarEnter && gameObject.transform.GetChild(9).GetComponent<Altar>().isAltarEnter == true)
            {
                //DialogueLua.SetQuestField("S9_GetBlood", "State", "success"); // hy : ����Ʈ ���¸� �������� �ٲ�
                GameObject.Find("S9_Conv_Trigger14").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��

                Debug.Log("����� ���� ���� �� �̺� ����");
            } 

            else if (gameObject.transform.GetChild(2).GetComponent<Altar>().isAltarEnter && gameObject.transform.GetChild(3).GetComponent<Altar>().isAltarEnter
                && gameObject.transform.GetChild(4).GetComponent<Altar>().isAltarEnter && gameObject.transform.GetChild(5).GetComponent<Altar>().isAltarEnter == true)
            {
                //DialogueLua.SetQuestField("S9_GetBlood", "State", "success"); // hy : ����Ʈ ���¸� �������� �ٲ�
                GameObject.Find("S9_Conv_Trigger9").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��


                Debug.Log("��ĵ�� �� �̺� ����");
            }

            else if (gameObject.transform.GetChild(0).GetComponent<Altar>().isAltarEnter && gameObject.transform.GetChild(1).GetComponent<Altar>().isAltarEnter == true)
            {
                //DialogueLua.SetQuestField("S8_DoorOpen", "State", "success"); // hy : ����Ʈ ���¸� �������� �ٲ�
                GameObject.Find("S8_Conv_Trigger16").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��

                //Debug.Log(DialogueLua.GetQuestField("S8_DoorOpen", "State").asString);
                Debug.Log("���� ����� �� �̺� ����");
            }     

        }
    }
}