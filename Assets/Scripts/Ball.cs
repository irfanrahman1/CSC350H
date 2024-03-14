using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    static int numCollisions = 0;
    const float minImpulseForce = 3.0f;
    const float maxImpulseForce = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is the first game.");
        //Vector3 position = transform.position;
        //position.x = 5;
        //transform.position = position;

        //// Double the size along the x-axis
        //Vector3 newScale = transform.localScale;
        //newScale.x = 2;
        //newScale.y = 2;
        //transform.localScale = newScale;
        ////transform.localScale = new Vector3(2, 2);

        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        //rb2d.AddForce(new Vector2(-10,0),ForceMode2D.Impulse);
        //float randomMagnitude = Random.Range(3f, 5f);
        //float randomAngle = Random.Range(0f, 2f * Mathf.PI);
        //float forceX = randomMagnitude * Mathf.Cos(randomAngle);
        //float forceY = randomMagnitude * Mathf.Sin(randomAngle);
        //rb2d.AddForce(new Vector2(forceX, forceY), ForceMode2D.Impulse);

        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(minImpulseForce, maxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(magnitude * direction, ForceMode2D.Impulse);



    }

    //// Update is called once per frame
    void Update()
    {
        //if(numCollisions==20) {
        //    UnityEditor.EditorApplication.isPaused = true; // either isPlaying
        //}
        // Get horizontal input
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        numCollisions++;
        Debug.Log("Number of collisions " + numCollisions);
    }
}
