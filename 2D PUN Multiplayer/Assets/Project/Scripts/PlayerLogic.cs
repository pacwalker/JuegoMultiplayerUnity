using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float posX;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posX = Input.GetAxis("Horizontal");
        transform.position += (Vector3)new Vector2(posX * speed * Time.deltaTime, 0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    
    public void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Limit")
        {
            //Destroy(gameObject);
            SceneManager.LoadScene("VictoryScreen");
        }    
    }
}
