using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

// hy : It needs 'IsGround' Script
// �� Ŭ������ IsGround�� ���� ������Ʈ�� �־������ -> ���� ������ ĳ���Ϳ� ��ġ�� ���������
public class ChangePlayerPos : MonoBehaviour
{
    // hy : ���� ������Ʈ ��ġ�� �����ϱ� ���� ����
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.GetComponent<IsGround>().isGround && gameObject.transform.position.y > pos.y + 5) // hy : ������Ʈ�� ���� ��� 5m �̻� �� �� ���ö�� ��
        {
            //Debug.Log(Vector3.Distance(gameObject.transform.position, GameObject.FindGameObjectWithTag("Player").transform.position));



            GameObject.FindGameObjectWithTag("Player").transform.position = gameObject.transform.position; // hy : �÷��̾��� ��ġ�� ���� ������ ��ġ�� �̵�
            GameObject.Destroy(gameObject, 1); // hy : ��ġ�� �ٲ� �� ���� 1�� �� �ı�

            //Debug.Log(gameObject.GetComponent<IsGround>().isGround);
            // hy 06.16 : lua ó���ϱ�, ���� �ٴڿ� ���� ��, ����Ʈ failure, success ó���� �ؾ��� (success ó���� �ٸ� ������ ��, ���⼭�� success�� �ƴ� �� failure ó���� ����)
            string state = DialogueLua.GetQuestField("S3_ThrowBall", "State").asString;
            if (state != "success")
            {
                DialogueLua.SetQuestField("S3_ThrowBall", "State", "failure");
            }
        }
    }
}
