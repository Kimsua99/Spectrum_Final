using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputNumber : MonoBehaviour
{
    private bool activated = false;

    [SerializeField]
    private Text text_Preview;
    [SerializeField]
    private Text text_Input;
    [SerializeField]
    private InputField if_text;

    [SerializeField]
    private GameObject go_Base;//�׻� Ȱ��ȭ �Ǵ°� �ƴϹǷ� ���ʿ��� �� ����. 

    [SerializeField]
    public Image image;

    [SerializeField]
    private ActionController thePlayer;

    public Transform a1;//���� ���� �ִ� �ڽ� �ݶ��̴�
    public Transform a2;
    public Transform a3;
    public Transform a4;
    public Transform a5;
    public Transform a6;
    public Transform a7;
    public Transform a8;
    public Transform a9;
    public Transform a10;
    public Transform a11;
    public Transform a2_1;
    public Transform a2_2;
    public Transform a2_3;
    public Transform a2_4;
    public Transform a2_5;
    public Transform a2_6;
    public Transform a2_7;
    public Transform a2_8;
    public Transform a2_9;
    public Transform a2_10;
    public Transform a2_11;
    public Transform a2_12;
    public Transform a2_13;
    public Transform a2_14;
    public Transform a2_15;
    public Transform a3_1;
    public Transform a3_2;
    public Transform a3_3;
    public Transform a3_4;
    public Transform a3_5;


    void Update()
    {
        if (activated)
        {
            if (Input.GetKeyDown(KeyCode.Return))//���� ġ�� ok��ư ���� ȿ��
                OK();
            else if (Input.GetKeyDown(KeyCode.Escape))//esc ������ ��ҹ�ư ���� ȿ��
                Cancel();
        }
    }

    public void Call()//�ٸ� ������ �θ��� �̰� ���.
    {
        image.gameObject.SetActive(true);
        go_Base.SetActive(true);//ȭ�� �߰� ��. 
        activated = true;
        if_text.text = "";
        text_Preview.text = DragSlot.instance.dragSlot.itemCount.ToString();//ȣ�����ڸ��� �������� �ִ� ������ �־���. 
    }

    public void Cancel()
    {
        image.gameObject.SetActive(false);
        activated = false;//����ϸ� â �������
        DragSlot.instance.SetColor(0);//�巡�� �� ����
        go_Base.SetActive(false);//�κ� â �����.
        DragSlot.instance.dragSlot = null;
    }

    public void OK()//ok��ư ������ ��.
    {
        DragSlot.instance.SetColor(0);

        int num;
        if (text_Input.text != "")//������ �ƴϰ�
        {
            if (CheckNumber(text_Input.text))//�������� �ƴ��� üũ��. -> ���ڸ� ������ ���� ����
            {
                num = int.Parse(text_Input.text);
                if (num > DragSlot.instance.dragSlot.itemCount)//���� �������� ���ں��� ū ���� �������� �ϸ� ������ �ִ�� ������. 
                    num = DragSlot.instance.dragSlot.itemCount;
            }
            else
                num = 1;//���� ���� �����̸� 1�� ó��.
        }
        else
            num = int.Parse(text_Preview.text);//�ƹ��͵� ���� �ʾ��� ���� �ؽ�Ʈ �������� �ִ� ������ �Ѱ���.

        StartCoroutine(DropItemCorountine(num));//�ϳ��� ������ ����߸����� �ڷ�ƾ �Լ� ����. 
    }

    IEnumerator DropItemCorountine(int _num)//������ �ڷ�ƾ �Լ� ����.
    {
        float dist1 = Vector3.Distance(GameObject.Find("altar1").transform.position, thePlayer.transform.position);
        float dist2 = Vector3.Distance(GameObject.Find("altar2").transform.position, thePlayer.transform.position);
        float dist4 = Vector3.Distance(GameObject.Find("altar4").transform.position, thePlayer.transform.position);
        float dist3 = Vector3.Distance(GameObject.Find("altar3").transform.position, thePlayer.transform.position);
        float dist6 = Vector3.Distance(GameObject.Find("altar6").transform.position, thePlayer.transform.position);
        float dist5 = Vector3.Distance(GameObject.Find("altar5").transform.position, thePlayer.transform.position);
        float dist7 = Vector3.Distance(GameObject.Find("altar7").transform.position, thePlayer.transform.position);
        float dist8 = Vector3.Distance(GameObject.Find("altar8").transform.position, thePlayer.transform.position);
        float dist2_1 = Vector3.Distance(GameObject.Find("altar2_1").transform.position, thePlayer.transform.position);
        float dist2_2 = Vector3.Distance(GameObject.Find("altar2_2").transform.position, thePlayer.transform.position);
        float dist2_3 = Vector3.Distance(GameObject.Find("altar2_3").transform.position, thePlayer.transform.position);
        float dist2_4 = Vector3.Distance(GameObject.Find("altar2_4").transform.position, thePlayer.transform.position);
        float dist2_5 = Vector3.Distance(GameObject.Find("altar2_5").transform.position, thePlayer.transform.position);
        float dist2_6 = Vector3.Distance(GameObject.Find("altar2_6").transform.position, thePlayer.transform.position);
        float dist2_7 = Vector3.Distance(GameObject.Find("altar2_7").transform.position, thePlayer.transform.position);
        float dist2_8 = Vector3.Distance(GameObject.Find("altar2_8").transform.position, thePlayer.transform.position);
        float dist2_9 = Vector3.Distance(GameObject.Find("altar2_9").transform.position, thePlayer.transform.position);
        float dist3_1 = Vector3.Distance(GameObject.Find("altar3_1").transform.position, thePlayer.transform.position);
        float dist3_2 = Vector3.Distance(GameObject.Find("altar3_2").transform.position, thePlayer.transform.position);
        float dist3_3 = Vector3.Distance(GameObject.Find("altar3_3").transform.position, thePlayer.transform.position);
        float dist3_4 = Vector3.Distance(GameObject.Find("altar3_4").transform.position, thePlayer.transform.position);
        float dist3_5 = Vector3.Distance(GameObject.Find("altar3_5").transform.position, thePlayer.transform.position);

        if (dist1 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a1.transform.position,//a1���� ����. 
                    a1.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist2 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a2.transform.position,//a1���� ����. 
                     a2.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }
        else if (dist4 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a3.transform.position,//a1���� ����. 
                     a3.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }
        else if (dist3 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a4.transform.position,//a1���� ����. 
                     a4.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }
        else if (dist6 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a5.transform.position,//a1���� ����. 
                     a5.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }
        else if (dist5 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a6.transform.position,//a1���� ����. 
                     a6.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }
        else if (dist7 <= 3.5f)
        {
            Debug.Log(DragSlot.instance.dragSlot.item.itemName);
            if (DragSlot.instance.dragSlot.item.itemName == "white_sblood")
            {
                Debug.Log("����");
                Debug.Log(DragSlot.instance.dragSlot.item.itemName);
                for (int i = 0; i < _num; i++)
                {
                    Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                        a7.position,//a1���� ����. 
                         a7.rotation);

                    DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                    yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
                }

                DragSlot.instance.dragSlot = null;//�巡�� ���� ����
                image.gameObject.SetActive(false);
                go_Base.SetActive(false);
                activated = false;
            }

            else if (DragSlot.instance.dragSlot.item.itemName == "yellow_sblood")
            {
                Debug.Log("�����");
                Debug.Log(DragSlot.instance.dragSlot.item.itemName);
                for (int i = 0; i < _num; i++)
                {
                    Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                        a8.transform.position,//a1���� ����. 
                         a8.transform.rotation);

                    DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                    yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
                }

                DragSlot.instance.dragSlot = null;//�巡�� ���� ����
                image.gameObject.SetActive(false);
                go_Base.SetActive(false);
                activated = false;
            }

            else if (DragSlot.instance.dragSlot.item.itemName == "black_sblood")
            {
                Debug.Log("������");
                Debug.Log(DragSlot.instance.dragSlot.item.itemName);
                for (int i = 0; i < _num; i++)
                {
                    Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                        a9.transform.position,//a1���� ����. 
                         a9.transform.rotation);

                    DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                    yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
                }

                DragSlot.instance.dragSlot = null;//�巡�� ���� ����
                image.gameObject.SetActive(false);
                go_Base.SetActive(false);
                activated = false;
            }

            else if (DragSlot.instance.dragSlot.item.itemName == "blue_sblood")
            {
                Debug.Log("�Ķ���");
                Debug.Log(DragSlot.instance.dragSlot.item.itemName);
                for (int i = 0; i < _num; i++)
                {
                    Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                        a10.transform.position,//a1���� ����. 
                         a10.transform.rotation);

                    DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                    yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
                }

                DragSlot.instance.dragSlot = null;//�巡�� ���� ����
                image.gameObject.SetActive(false);
                go_Base.SetActive(false);
                activated = false;
            }
        }
       
        else if (dist8 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a11.transform.position,//a1���� ����. 
                     a11.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist2_1 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a2_1.transform.position,//a1���� ����. 
                     a2_1.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist2_2 <= 9.5f)
        {
            Debug.Log(DragSlot.instance.dragSlot.item.itemName);
            if (DragSlot.instance.dragSlot.item.itemName == "magic_red")
            {
                Debug.Log("����");
                Debug.Log(DragSlot.instance.dragSlot.item.itemName);
                for (int i = 0; i < _num; i++)
                {
                    Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                        a2_2.position,//a1���� ����. 
                         a2_2.rotation);

                    DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                    yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
                }

                DragSlot.instance.dragSlot = null;//�巡�� ���� ����
                image.gameObject.SetActive(false);
                go_Base.SetActive(false);
                activated = false;
            }

            else if (DragSlot.instance.dragSlot.item.itemName == "magic_orange")
            {
                Debug.Log("��Ȳ");
                Debug.Log(DragSlot.instance.dragSlot.item.itemName);
                for (int i = 0; i < _num; i++)
                {
                    Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                        a2_3.transform.position,//a1���� ����. 
                         a2_3.transform.rotation);

                    DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                    yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
                }

                DragSlot.instance.dragSlot = null;//�巡�� ���� ����
                image.gameObject.SetActive(false);
                go_Base.SetActive(false);
                activated = false;
            }

            else if (DragSlot.instance.dragSlot.item.itemName == "magic_yellow")
            {
                Debug.Log("���");
                Debug.Log(DragSlot.instance.dragSlot.item.itemName);
                for (int i = 0; i < _num; i++)
                {
                    Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                        a2_4.transform.position,//a1���� ����. 
                         a2_4.transform.rotation);

                    DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                    yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
                }

                DragSlot.instance.dragSlot = null;//�巡�� ���� ����
                image.gameObject.SetActive(false);
                go_Base.SetActive(false);
                activated = false;
            }

            else if (DragSlot.instance.dragSlot.item.itemName == "magic_green")
            {
                Debug.Log("�ʷ�");
                Debug.Log(DragSlot.instance.dragSlot.item.itemName);
                for (int i = 0; i < _num; i++)
                {
                    Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                        a2_5.transform.position,//a1���� ����. 
                         a2_5.transform.rotation);

                    DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                    yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
                }

                DragSlot.instance.dragSlot = null;//�巡�� ���� ����
                image.gameObject.SetActive(false);
                go_Base.SetActive(false);
                activated = false;
            }

            else if (DragSlot.instance.dragSlot.item.itemName == "magic_blue")
            {
                Debug.Log("�Ķ�");
                Debug.Log(DragSlot.instance.dragSlot.item.itemName);
                for (int i = 0; i < _num; i++)
                {
                    Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                        a2_6.transform.position,//a1���� ����. 
                         a2_6.transform.rotation);

                    DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                    yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
                }

                DragSlot.instance.dragSlot = null;//�巡�� ���� ����
                image.gameObject.SetActive(false);
                go_Base.SetActive(false);
                activated = false;
            }

            else if (DragSlot.instance.dragSlot.item.itemName == "magic_purple")
            {
                Debug.Log("����");
                Debug.Log(DragSlot.instance.dragSlot.item.itemName);
                for (int i = 0; i < _num; i++)
                {
                    Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                        a2_7.transform.position,//a1���� ����. 
                         a2_7.transform.rotation);

                    DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                    yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
                }

                DragSlot.instance.dragSlot = null;//�巡�� ���� ����
                image.gameObject.SetActive(false);
                go_Base.SetActive(false);
                activated = false;
            }

            else if (DragSlot.instance.dragSlot.item.itemName == "rock_hangi")
            {
                Debug.Log("�ѱ��� ��");
                Debug.Log(DragSlot.instance.dragSlot.item.itemName);
                for (int i = 0; i < _num; i++)
                {
                    Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                        a2_8.transform.position,//a1���� ����. 
                         a2_8.transform.rotation);

                    DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                    yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
                }

                DragSlot.instance.dragSlot = null;//�巡�� ���� ����
                image.gameObject.SetActive(false);
                go_Base.SetActive(false);
                activated = false;
            }
        }

        else if (dist2_3 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a2_9.transform.position,//a1���� ����. 
                     a2_9.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist2_4 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a2_10.transform.position,//a1���� ����. 
                     a2_10.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist2_5 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a2_11.transform.position,//a1���� ����. 
                     a2_11.transform.rotation);
                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist2_6 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a2_12.transform.position,//a1���� ����. 
                     a2_12.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist2_7 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a2_13.transform.position,//a1���� ����. 
                     a2_13.transform.rotation);


                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist2_8 <= 7.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a2_14.transform.position,//a1���� ����. 
                     a2_14.transform.rotation);


                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist2_9 <= 7.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a2_15.transform.position,//a1���� ����. 
                     a2_15.transform.rotation);


                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist3_1 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a3_1.transform.position,//a1���� ����. 
                     a3_1.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist3_2 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a3_2.transform.position,//a1���� ����. 
                     a3_2.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist3_3 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a3_3.transform.position,//a1���� ����. 
                     a3_3.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else if (dist3_4 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a3_4.transform.position,//a1���� ����. 
                     a3_4.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }
        else if (dist3_5 <= 3.5f)
        {
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    a3_5.transform.position,//a1���� ����. 
                     a3_5.transform.rotation);

                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }

        else 
        {
            GameObject.Find("Show Text").transform.Find("leverText").gameObject.SetActive(false);
            for (int i = 0; i < _num; i++)
            {
                Instantiate(DragSlot.instance.dragSlot.item.itemPrefab,
                    thePlayer.transform.position + thePlayer.transform.forward,//���� ī�޶� �տ� ����. 
                    Quaternion.identity);
                DragSlot.instance.dragSlot.SetSlotCount(-1);//�ϳ� ���� �� ���� ī��Ʈ �� �ϳ��� �پ��.
                yield return new WaitForSeconds(0.05f);//��� ����ϴ� �ð�. 
            }

            DragSlot.instance.dragSlot = null;//�巡�� ���� ����
            image.gameObject.SetActive(false);
            go_Base.SetActive(false);
            activated = false;
        }
    }

    private bool CheckNumber(string _argString)//�������� �ƴ��� Ȯ��. ���ڿ��� �޾Ƽ� Ȯ����.
    {
        char[] _tempCharArray = _argString.ToCharArray();//���ڿ��� �ڵ����� ���� ���ڷ� �ٲ�. �����ٶ󸶹ٻ��� ��� 0��° �迭�� �� 1��° �迭�� �� �̷������� ���ͼ� �ѱ��ھ� �������� �������� ��.
        bool isNumber = true;//�����̸�

        for (int i = 0; i < _tempCharArray.Length; i++)//����� ���̸�ŭ �ݺ����� ���Ƽ�
        {
            if (_tempCharArray[i] >= 48 && _tempCharArray[i] <= 57)//i��°�� �ƽ�Ű �ڵ忡�� 48-57�� 10�������� ������. �̸� �迭�� �ְ� �ѱ��ھ� ���ϸ鼭 Ȯ����.
                continue;//�����ϸ� ���� �� �����ϰ� �ݺ��� ����
            isNumber = false;//�������� ���ϸ� �ݺ��� �������� ���� �ƴ��� �˸�.
        }
        return isNumber;
    }
}