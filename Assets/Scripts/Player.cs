using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    string axisName = "Horizontal1";
    public float moveSpeed = 10;
    private Vector2 playerPosition = new Vector2(0, -4.26f);
    GameData data = new GameData();

    private void Start()
    {
        if (SaveLoadManager.Load() != null)
        {
            data = SaveLoadManager.Load();
            transform.position = new Vector2(0,data.yLocation);
        }
    }

    private void Update()
    {
     
            CheckScore();
     
    }

    int tempScore;
    private void CheckScore()
    {
        
        if( SaveLoadManager.Load() != null)
        {
            data = SaveLoadManager.Load();
            if(data.score < Ball.Score)
            {
                data.score = Ball.Score;
                SaveLoadManager.Save(data);
            }
        }
        else
        {
            data.score = Ball.Score;
            SaveLoadManager.Save(data);
        }


            if (Ball.Score % 5 == 0 && Ball.Score != 0 && tempScore != Ball.Score)
            {
            tempScore = Ball.Score;
            transform.position = new Vector2(transform.position.x, transform.position.y + 1);
            data.yLocation = transform.position.y + 1;
            SaveLoadManager.Save(data);
            }
        
    }


   

    void FixedUpdate()
    {
        float moveAxis = Input.GetAxis(axisName) * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveAxis, 0);



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.name == "Ball")
        {

            transform.position = playerPosition;
        }

    }


   


}
