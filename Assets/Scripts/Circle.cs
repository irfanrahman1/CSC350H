using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.UIElements;

public class Circle : MonoBehaviour
{
    [SerializeField] float movingSpeedPerSecond = 5;
//
    float colliderHalfWidth, colliderHalfHeight;

    // Start is called before the first frame update
    void Start()
    {

        ScreenUtils.initialize();


        CircleCollider2D collider = GetComponent<CircleCollider2D>();
        Vector3 circleColliderDim = collider.bounds.max - collider.bounds.min;

        colliderHalfWidth = circleColliderDim.x / 2;
        colliderHalfHeight = circleColliderDim.y / 2;

        Debug.Log(ScreenUtils.ScreenLeft + " " + ScreenUtils.ScreenRight + " " + ScreenUtils.ScreenBottom + " " + colliderHalfHeight + " " + colliderHalfHeight);


    }



    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
       // transform.position = position;
        float horizontalInput = Input.GetAxis("Horizontal");
        position.x+= horizontalInput * movingSpeedPerSecond * Time.deltaTime ;
        transform.position = position;


        float verticalInput = Input.GetAxis("Vertical");
        position.y += verticalInput * movingSpeedPerSecond * Time.deltaTime; 
        transform.position = position;


        CheckBounds();

    }

    void CheckBounds()
    {
        Vector3 position = transform.position;

        if (position.x - colliderHalfWidth < ScreenUtils.ScreenLeft)
        {
            position.x = ScreenUtils.ScreenLeft + colliderHalfWidth;
        }

        if (position.x + colliderHalfWidth > ScreenUtils.ScreenRight)
        {
            position.x = ScreenUtils.ScreenRight - colliderHalfWidth;
        }
        if (position.y - colliderHalfHeight < ScreenUtils.ScreenBottom)
        {
            position.y = ScreenUtils.ScreenBottom + colliderHalfHeight;
        }

        if (position.y + colliderHalfHeight > ScreenUtils.ScreenTop)
        {
            position.y = ScreenUtils.ScreenTop - colliderHalfHeight;
        }

        transform.position = position;
    }


}
