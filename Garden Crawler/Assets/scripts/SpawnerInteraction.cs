using UnityEngine;

public class SpawnerInteraction : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject.FindWithTag("Player").SetActive(false);
                GameObject.FindWithTag("Map").SetActive(false);
                GameObject.FindWithTag("UI").SetActive(true);
            }
        }
    }
}
