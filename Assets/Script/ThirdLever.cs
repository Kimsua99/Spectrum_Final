using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdLever : MonoBehaviour
{
    public Transform from;
    public Transform to;
    public float speed = 0.1F;
    public Transform Player;
    public AudioSource levers;

    [SerializeField]
    private Text leverText;

    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        float dist = Vector3.Distance(gameObject.transform.position, Player.position);

        if (dist <= 4f)
        {
            leverText.text = "(U) ��ư�� ���� ������ ���ÿ�";

            if (Input.GetKeyDown(KeyCode.U))
            {
                leverText.gameObject.SetActive(false);
                levers.Play();
                from.rotation = to.rotation;
                Debug.Log("�� ����");

                GameObject.Find("S7_Trigger6").GetComponent<BoxCollider>().enabled = true; // hy : �ڽ� �ݶ��̴��� enable�Ͽ� OnTriggerEnter�ǰ� �� 
                GameObject.Find("spaceDoor").GetComponent<DoorOpen>().isOperate = true;
                
            }
        }
    }
}
