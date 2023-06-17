using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MissileSpeed = 25f;
    public GameObject miss;
    public float t = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up*MissileSpeed;
    }

    // Update is called once per frame
    void Update()
    {
         Destroy(miss, t);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "enemy_ships" || collision.gameObject.tag=="aster"){
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
