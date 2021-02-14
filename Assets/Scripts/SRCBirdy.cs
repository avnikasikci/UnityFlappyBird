using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRCBirdy : MonoBehaviour
{
    public bool IsDead;

    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public SRCScoreManager _SRCScoreManager;

    // Start is called before the first frame update
    void Start() // iLK obje calıstıralacak bir kez calıstırılır.
    {

    }

    // Update is called once per frame
    void Update() // çalıştığı sürece bütün frameler oynatılan kod zorda kalmadıkça kullanılmaz.
    {
        //Debug.Log("As23332");
        if (Input.GetMouseButtonDown(0)) // eğer mouse sol tıka bastığında ...
        {
            /*ios yada android de dokunmatik tıklama alır...*/

            //Havaya yükselt...

            rb2D.velocity = Vector2.up * velocity; // havada kuşu sıcrat.

        }
    }


    private void OnTriggerEnter2D(Collider2D collision) // bir triggera girdiğimizde
    {
        if (collision.gameObject.name == "ScoreArea") // bu objenin içine geldiğimde
        {
            _SRCScoreManager.UpdateScore();
        }
    }


}
