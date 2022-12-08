using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public GameManager manager;
    public float velocity = 1;
    private Rigidbody2D _rigidBody;
    public bool gameOverFlag;
    // Start is called before the first frame update
    void Start()
    {
        gameOverFlag = false;
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown("space") && !gameOverFlag)
        {
            Time.timeScale = 1;
            _rigidBody.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOverFlag = true;
        manager.GameOver();
    }
}
