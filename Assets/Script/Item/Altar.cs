using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altar : MonoBehaviour
{
    public AudioSource itemin;
    public bool isAltarEnter = false; 
    public string itemName = "";
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + "����");
        
        if (other.name == itemName)
        {
            itemin.Play();
            isAltarEnter = true; // hy : altar�� �� �������� ������ true�� �ٲ���
            Debug.Log("�ߵ���");
            
        }
    }
}
