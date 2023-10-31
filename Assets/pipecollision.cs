using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipecollision : MonoBehaviour
{
    // Start is called before the first frame update
    public Logix logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent < Logix >();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.Addscore();
        }
    }
}
