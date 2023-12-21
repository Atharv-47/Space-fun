using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public Logicscript logic;
    public bool Spaceshipisok = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && Spaceshipisok)
        {
            myrigidbody.velocity = Vector2.up * 10;
        }
        else if (Input.GetKeyDown(KeyCode.S) && Spaceshipisok)
        {
            myrigidbody.velocity= Vector2.down * 10;
        }
        if (transform.position.y>30 || transform);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        Spaceshipisok=false;
    }

}
