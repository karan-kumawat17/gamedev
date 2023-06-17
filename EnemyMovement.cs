using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float x,y;
    // Start is called before the first frame update
    void Start()
    {
        en();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(x,y,0)*speed*Time.deltaTime);
    }

    void en(){
       x = Random.Range(-1f,1f);
       y = Random.Range(-1f,0f);
    }
}
