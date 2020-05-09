using UnityEngine;


public class Bomb : MonoBehaviour
{
    public float speed = 0.5f;
    public Rigidbody2D rb;
    



    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector2(0, 1) * speed);
        Destroy(gameObject, 2f);

        
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Ball ball = hitInfo.GetComponent<Ball>();
        
        if ( ball != null)
        {
            
            ball.MakeScore();
            Destroy(gameObject);

        }
       

   
    }



}
