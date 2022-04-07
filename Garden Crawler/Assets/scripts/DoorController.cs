using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float X;
    public float Y;
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {     
        if (collisionInfo.collider.tag == "Player")
        {
            GameObject.FindWithTag("Player").transform.position = new Vector3(X, Y, -.5f);
            GameObject.FindWithTag("MainCamera").transform.position = new Vector3(X, Y, -10.5f);
            GameObject.FindWithTag("UI").transform.position = new Vector3(X, Y, -1f);
        } 
    }
}
