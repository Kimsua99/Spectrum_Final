using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFollow : MonoBehaviour
{
    public GameObject ThePlayer;
    public float TargetDistace;
    public float AllowedDistance = 7;
    public GameObject TheNPC;
    public float followSpeed;
    public RaycastHit Shot;

    [SerializeField]
    public float jumpForce;

    private Rigidbody NPCRigid;

    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        NPCRigid = GetComponent<Rigidbody>();
    }
    void Update()
    {

        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            Vector3 playerPos = ThePlayer.transform.position;
            playerPos.y = transform.position.y; // hy : npc�� �ü��� ���� �ʰԲ� ������

            transform.LookAt(playerPos, Vector3.up);
            TargetDistace = Vector3.Distance(ThePlayer.transform.position, transform.position); // hy : �� ��ġ �Ÿ� ���ϴ� �Լ�
            //TargetDistace = Shot.distance;

            Vector3 direction = (ThePlayer.transform.position - transform.position).normalized; // hy : ���̰� 1�� ��ֺ���
            //Debug.Log(NPCRigid.velocity.magnitude);
            if (TargetDistace >= AllowedDistance * 10)
            {
                transform.position = playerPos - new Vector3(0, 0, 1);
                //animator.SetBool("walk", true);
            }
            else if(TargetDistace >= AllowedDistance * 2.6)
            {
                NPCRigid.AddForce((direction) * followSpeed * 1.2f);
                animator.SetBool("walk", true);
            }
            else if (TargetDistace >= AllowedDistance)
            {
                //followSpeed = 2f;
                NPCRigid.AddForce((direction) * followSpeed); // hy : �������� �ٲٴ� �ͺ��� rigidbody ������ �� �ڿ��������
                animator.SetBool("walk", true);
                //transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, followSpeed);
                //Debug.Log("������� ��"); //���࿡ �÷��̾�� npc���� �Ÿ��� 5���� ũ�� npc�� �÷��̾��� ��ġ�� ����ؼ� �������� �̵���. 5���� ������ ������ �ִٰ� �Ǵ��ؼ� ����.
                //���⿡ �ȴ� �ִϸ��̼� �߰��ؾ� ��. TheNPC.GetComponent<Animation>().Play("running");
            }
            
            else
            {
                animator.SetBool("walk", false);
                //followSpeed = 0;
                //Debug.Log("������ �ִ� ��");
                //���⿡ ������ �ִ� �ִϸ��̼� �߰��ؾ� ��. TheNPC.GetComponent<Animation>().Play("idle");
            }

            if (ThePlayer.GetComponent<PlayerController>().isJump == true)
            {
                //Debug.Log("�ڴ�");
                animator.SetBool("jump", true);
            }
            else 
            {
                //Debug.Log("�ȶڴ�");
                animator.SetBool("jump", false);
            }
        }
        // ���⿡ �÷��̾ �����ϸ� NPC�� ���� �����ϴ� �ڵ带 ������ ���� �������,, ����ٸ� �÷��̾���Ʈ�ѷ��� �ִ� �����ڵ� �����ͼ� �÷��̾� �ٸ� NPC�� �׸�ŭ ���� �ٰ� ����. 
    }

}
