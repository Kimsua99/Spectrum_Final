using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 2021.08.03 created by HY
// NEED : Generated Prefab, Room Size, interval
// ���� ���� �ڵ�(�������� ���� �߽ɿ� �� ������Ʈ ������ �ſ� �־����), �ܺο��� enabled true�ϸ� �����

public class BrickGenerator : MonoBehaviour
{
	public int destroyTime = 5; // hy : �ı� �ð�(0�̸� �ı� ���ϴ°�)
	public float interval = 1; // hy : ������ �������� �ð� ����
	public float weight = 10; // hy : ���� ������
	public float height = 10; // hy : ���� ������
	public float yPos = 5; // hy : �������� ���� ����
	public GameObject prefab; // hy : ���� ������

	private GameObject obj;

	// Start is called before the first frame update
	void Start()
    {
		enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
		StartCoroutine(Wait(interval)); // hy : interval��ŭ ��
		
		float offsx = Random.Range(-weight, weight);
		float offsz = Random.Range(-height, height);

		Vector3 pos = transform.position + new Vector3(offsx, yPos, offsz);
		GameObject.Instantiate(prefab, pos, Random.rotation).transform.parent = gameObject.transform;

		if(transform.childCount > 3000) // hy : 3000�� ������ ����
        {
			enabled = false;
        }
	}

	IEnumerator Wait(float interval)
    {
		yield return new WaitForSeconds(interval);

		if (destroyTime > 0)
		{
			yield return new WaitForSeconds(destroyTime);
			Destroy(transform.GetChild(0).gameObject);
		}
    }
}
