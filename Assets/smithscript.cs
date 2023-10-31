using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smithscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapstrength;
    public Logix logic;
    public bool Isalive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logix>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && Isalive == true)
        {
            myrigidbody.velocity = Vector2.up * flapstrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        Isalive = false;
    }
}
