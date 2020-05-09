using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    
    Rigidbody2D rb2;
    public float moveSpeed=10;
    GameData data = new GameData();
    AudioSource audioSource;
    //Score
    public static int Score { get; private set; }
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (SaveLoadManager.Load() != null)
        {
            data = SaveLoadManager.Load();
            Score = data.score;
            scoreText.text = data.score.ToString();
        }
        Invoke("StartBall", 2f);

    }

    void StartBall()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(1, 0) * moveSpeed;
    }

    public void MakeScore()
    {
        Score++;
        scoreText.text = Score.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();
    }

}
