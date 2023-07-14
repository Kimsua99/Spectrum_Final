using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PixelCrushers.DialogueSystem; // Put at top of script to access Dialogue System stuff. ... 

public class Lever : MonoBehaviour
{
    public Transform from;
    public Transform to;
    public float speed = 0.1F;
    public Transform Player;
    public GameObject lava;
    public AudioSource lever;

    [SerializeField]
    private Text leverText;

    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        float dist = Vector3.Distance(gameObject.transform.position, Player.position);

        if (dist <= 2f)
        {
            leverText.text = "(U) ��ư�� ���� ������ ���ÿ�";

            if (Input.GetKeyDown(KeyCode.U)) 
            {
                lever.Play();
                leverText.gameObject.SetActive(false);
                from.rotation = to.rotation;
                lava.SetActive(false);
                //DialogueLua.SetQuestField("S9_LeverOn", "State", "success"); // hy : ���̾�α׽ý��� ����Ʈ ������ �������� �ٲ���
                
                GameObject.Find("S8_Conv_Trigger6").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��
                GameObject.Find("S9_Conv_Trigger4").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̵带 enable ���Ѽ� OnTriggerEnter���۵ǰ� ��
            }
        }
    }
}
