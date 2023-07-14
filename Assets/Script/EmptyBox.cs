using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyBox : MonoBehaviour
{
    public GameObject Boxx;
    public Transform playerr;
    public Camera theCameraa;
    [SerializeField]
    public GameObject go_BoxInvenBasee;
    public GameObject go_InvenBasee;
    public GameObject go_BookUII;

    private RaycastHit hitinfoo;//�浹ü ���� ����.
    public AudioSource openn;
    public AudioSource closee;

    // Update is called once per frame
    void Update()
    {

        Ray ray = theCameraa.ScreenPointToRay(Input.mousePosition);


        if (Physics.Raycast(ray, out hitinfoo))
        {
            Debug.DrawLine(playerr.position, hitinfoo.transform.position, Color.red);
            if (hitinfoo.transform.gameObject.layer == LayerMask.NameToLayer("emptybox"))//���̾ �ٲ������ �Ϲ� ���ڿ� �ٸ��� ���� �κ��� ����.
            {;
                if (GameManager.isOpenBoxInven == false)//�̰� �־�� �ڽ� �κ� ���� ���¿��� ���� ���� �ݴ� �Ҹ� �ȳ�. 
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        Boxx.SetActive(Boxx.active);
                        OpenBoxInven();
                        openn.Play();
                        GameManager.isOpenInventory = true;
                        go_BookUII.gameObject.SetActive(false);


                    }
                }

                else if (Input.GetMouseButtonDown(1))
                {
                    closee.Play();
                    Boxx.SetActive(!Boxx.active);
                    CloseBoxInven();
                    GameManager.isOpenInventory = false;
                    go_BookUII.gameObject.SetActive(true);
                }
            }
        }
    }

    private void OpenBoxInven()
    {
        GameManager.isOpenBoxInven = true;
        GameManager.isOpenInventory = true;
        go_BoxInvenBasee.SetActive(true);//�κ��丮 ���̽��� Ȱ��ȭ �� ����
        go_InvenBasee.SetActive(true);

    }
    public void CloseBoxInven()
    {
        GameManager.isOpenBoxInven = false;
        GameManager.isOpenInventory = false;
        go_BoxInvenBasee.SetActive(false);//�κ��丮 ���̽��� Ȱ��ȭ �� ����
        go_InvenBasee.SetActive(false);

    }
}
