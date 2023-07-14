using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class Darken : MonoBehaviour
{

    // 2021.06.14 created by HY
    // Needs : Trigger, Intensity value

    public float emissionIntensity = 0; // hy : ��ü���� ������ ���� ����

    private GameObject crystals; //  hy : emission down ��ų ũ����Ż parent
    private GameObject cave; // hy : ���� ������Ʈ ����
    private Renderer[] renderers; // hy : renderer�� ���� �迭
    // private Light[] lights; // hy : ����Ʈ ��� ���⿡ ����

    // Start is called before the first frame update
    void Start()
    {
        crystals = GameObject.Find("Cave Crystal");
        cave = GameObject.Find("Cave");
        renderers = crystals.transform.GetComponentsInChildren<Renderer>(); // hy : emission down ��ų ��ü�� ��� ���� ����


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) // �÷��̾ �� �ִ� ���� ��� ����ž���(������ true�� �Ǵ� ������ ĳġ�ؾ� �ϹǷ�)
    {
        if (other.tag == "Player")
        {
            foreach (Renderer renderer in renderers)
            {
                renderer.material.SetColor("_EmissionColor", renderer.material.color * emissionIntensity);
                cave.transform.GetComponent<Renderer>().material.SetColor("_EmissionColor", cave.GetComponent<Renderer>().material.color * emissionIntensity * 3);
                //Debug.Log(renderer.material.color);
            }
        }

    }
}
