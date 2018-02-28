using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode rightKey;
    public KeyCode leftKey;
    public GameObject lightwall;
    int lr = -1;
    Collider2D wall;
    Vector2 lastWallEnd;
    public float speed = 16;
    Animator anim;
    SpriteRenderer sr;

    void spawnWall()
    {
        lastWallEnd = transform.position;
        GameObject l = (GameObject)Instantiate(lightwall, transform.position, Quaternion.identity);
        wall = l.GetComponent<Collider2D>();
    }

    void fitColliderBetween(Collider2D co, Vector2 a, Vector2 b)
    {
        co.transform.position = a + (b - a) * 0.5f;
        float lon = Vector2.Distance(a, b);
        if (a.x != b.x)
            co.transform.localScale = new Vector2(lon+1, 1);
        else
            co.transform.localScale = new Vector2(1, lon+1);
    }

    private void OnTriggerEnter2D(Collider2D co)
    {
        if (co != wall)
        {
            Destroy(gameObject);
        }
    }

    void Start () {
        spawnWall();
        anim = GetComponent<Animator>();
    }


public void Rmas()
{
    lr++;
    if (lr > 3)
    {
        lr = 0;
    }

        if (Input.GetKeyDown(upKey) || (lr == 0))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
            spawnWall();
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKeyDown(downKey) || (lr == 2))
        {
            GetComponent<Rigidbody2D>().velocity = -Vector2.up * speed;
            spawnWall();
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (Input.GetKeyDown(rightKey) || (lr == 1))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            spawnWall();
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        else if (Input.GetKeyDown(leftKey) || (lr == 3))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
            spawnWall();
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
    }

public void Rmenos()
{
    lr--;
    if (lr < 0)
    {
        lr = 3;
    }

        if (Input.GetKeyDown(upKey) || (lr == 0))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
            spawnWall();
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKeyDown(downKey) || (lr == 2))
        {
            GetComponent<Rigidbody2D>().velocity = -Vector2.up * speed;
            spawnWall();
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (Input.GetKeyDown(rightKey) || (lr == 1))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            spawnWall();
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        else if (Input.GetKeyDown(leftKey) || (lr == 3))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
            spawnWall();
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
    }
// Update is called once per frame
void Update () {

        if (Input.GetKeyDown(upKey))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
            spawnWall();
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKeyDown(downKey))
        {
            GetComponent<Rigidbody2D>().velocity = -Vector2.up * speed;
            spawnWall();
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (Input.GetKeyDown(rightKey))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            spawnWall();
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        else if (Input.GetKeyDown(leftKey))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
            spawnWall();
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (transform.position.x > 64.1)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -64.1)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > 64.1)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -64.1)
        {
            Destroy(gameObject);
        }
        fitColliderBetween(wall, lastWallEnd, transform.position);
        anim.Play("Run");
        anim.Play("SonicRunning");
    }
}
