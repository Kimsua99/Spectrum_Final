using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffFloor : MonoBehaviour
{

    public GameObject FirstPlate;
    public GameObject SecondPlate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FirstFloorOn", 3f, 5f);
        InvokeRepeating("FirstFloorOff", 6f, 5f);

        InvokeRepeating("SecondFloorOff", 3f, 5f);
        InvokeRepeating("SecondFloorOn", 6f, 5f);
    }

    public void FirstFloorOff() 
    {
        Debug.Log("1��° ����");

        FirstPlate.gameObject.SetActive(false);

    }

    public void FirstFloorOn()
    {
        Debug.Log("1��° ����");

        FirstPlate.gameObject.SetActive(true);

    }

    public void SecondFloorOff()
    {
        Debug.Log("2��° ����");

        SecondPlate.gameObject.SetActive(false);

    }

    public void SecondFloorOn()
    {
        Debug.Log("2��° ����");

        SecondPlate.gameObject.SetActive(true);

    }

}
