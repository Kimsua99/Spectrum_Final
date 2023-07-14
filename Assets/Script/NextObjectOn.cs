using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class NextObjectOn : MonoBehaviour
{
    // 2021.05.12 created by HY
    // Needs : Trigger, Same name objects with consecutive numbers only (ex. obj1, obj2, obj3...)
 
    private string objName; // hy : �ϳ��� �� ������Ʈ �̸�(���� ���� �κ�)
    private string objNum; // hy : ������Ʈ �ѹ�
    private string next; // hy : ���� ������Ʈ �̸�
    public AudioSource lightPadEffect;
    private bool balEnter = false;

    void Start()
    {
        objName = gameObject.name; // hy : ������Ʈ �̸� ���� + ���� ��

        // hy : Regex�� ���ڿ��� Ư�� ������ ã�Ƴ��ų� �ٸ� ������ ġȯ�ϴ� ���� �ϴ� Ŭ����
        objNum = Regex.Replace(objName, @"\D", ""); // hy : objName �������� ���ڸ� ��������
        objName = objName.Replace(objNum, ""); // hy : ������Ʈ �̸����� ���ڸ� ����
        //Debug.Log(objName);
        next = objName + (int.Parse(objNum) + 1).ToString(); // hy : ���� objNum�� 1�� ���ؼ� ���� ������Ʈ �̸��� ������
        //Debug.Log(next);
    }

    void Update()
    {
        if (balEnter)
        {
            lightPadEffect.Play();
            enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other) // hy : �÷��̾ Ʈ���� ���� ��, ���� ������Ʈ ���̰� setActive����
    {
        if(other.tag == "Player")
        {
            gameObject.transform.parent.Find(next).gameObject.SetActive(true); // hy : Find�Լ��� ����ϸ� ���� �����ε� �̸��� ���� ������Ʈ�� ������ �����ϴ�.
            balEnter = true;
        }
    }
}
