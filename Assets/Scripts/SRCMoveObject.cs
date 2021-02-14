using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRCMoveObject : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 7); // oyun basladıktan 5 sn sonra yok et.
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
