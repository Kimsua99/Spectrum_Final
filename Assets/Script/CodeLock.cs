using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeLock : MonoBehaviour
{
    int codeLength;
    int placeInCode;
    int failCount = 0;
    public Text HintText;
    public AudioSource wrongN;
    public AudioSource bbi;

    public string code = "";
    public string attemptedCode;

    public void Update()
    {
        if (failCount == 2)
        {
            Debug.Log("�ι� �Ǽ�");
            HintText.text = "Hint 1 : �ܾ �ƴϴ�.";
        }
        else if (failCount == 3)
        {
            Debug.Log("���� �Ǽ�");
            HintText.text = "Hint 2 : �����̸� 6�ڸ��̴�.";
        }

        else if (failCount >= 4)
        {
            Debug.Log("�׹� �̻� �Ǽ�");
            HintText.text = "Hint 3 : ������ ���ĺ� ������ �����϶�.";
        }
    }

    private void Start()
    {
        codeLength = code.Length;
    }
    void CheckCode()
    {
        if (attemptedCode == code)
        {
            Debug.Log("��ȣ ����");
            HintText.gameObject.SetActive(false);
            if (gameObject.name == "KEYBASE")
            {
                GameObject.Find("AnesDoor").GetComponent<DoorOpen>().isOperate = true;
                GameObject.Find("S6_Trigger5").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̴��� enable�Ͽ� OnTriggerEnter�ǰ� �� 
            }
            else if (gameObject.name == "SECONDKEYBASE")
            {
                GameObject.Find("keyDoor").GetComponent<DoorOpen>().isOperate = true;
                GameObject.Find("TimmerTrigger").GetComponent<Timer>().TimerStop();
                GameObject.Find("S4_Trigger24").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̴��� enable�Ͽ� OnTriggerEnter�ǰ� �� 
            }
    
        }

        else
        {
            Debug.Log("��ȣ Ʋ��");
            wrongN.Play();
            failCount++;
        }
    }

    public void SetValue(string value)
    {
        placeInCode++;

        if (placeInCode <= codeLength)
        {
            bbi.Play();
            attemptedCode += value;
        }

        if (placeInCode == codeLength)
        {
            CheckCode();

            attemptedCode = "";
            placeInCode = 0;
        }
    }
}
