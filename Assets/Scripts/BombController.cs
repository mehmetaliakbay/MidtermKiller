using UnityEngine;

public class BombController : MonoBehaviour
{

    public GameObject bombPrefab;
    public Transform spawnPoint;
    

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
         Instantiate(bombPrefab, spawnPoint.position, spawnPoint.rotation);
        
    }

 
}
