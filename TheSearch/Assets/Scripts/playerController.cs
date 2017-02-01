using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class playerController : MonoBehaviour
{
    public float velocidade;
    public float forcaPulo;
    public Text scoreText;
    int score = 0;
  
    private Rigidbody2D rigi2d;
    private bool isRigth;
    private bool iskey;

    void Start()
    {
        rigi2d = GetComponent<Rigidbody2D>();
    }

    //metodo de colisao com triger
    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.tag == "coin")
        { 
            Destroy(other.gameObject);
            score += 1;
            scoreText.text = score + "x8"; 
  
        }
        if (other.tag == "key blue")
        { 
            Destroy(other.gameObject);
            iskey = true;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "lock blue" && iskey)
        {
            SceneManager.LoadScene(2);
        }
            

    }

    void Update()
    {     
        
        float movx = Input.GetAxis("Horizontal");  



        if (isRigth && movx > 0)
        {
            Flip();
        }
        else if (!isRigth && movx < 0)
        {
            Flip();
        }

        rigi2d.velocity = new Vector2(movx * velocidade, rigi2d.velocity.y);

        if (Input.GetButton("Jump"))
        {              
            rigi2d.velocity = new  Vector2(rigi2d.velocity.x, forcaPulo);
        }    
        
    }

    void Flip()
    {
        transform.Rotate(new Vector3(0, 180, 0));
        isRigth = !isRigth;
    }
}