using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRCPipeSpawner : MonoBehaviour
{

    public SRCBirdy _SRCBirdy;
    public GameObject Pipeles;
    public float height;
    public float TimeValue;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject(TimeValue));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!_SRCBirdy.IsDead) // Karekter ölmeyinceye kadar
        {
            Instantiate(Pipeles, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);

        }



    }
}
