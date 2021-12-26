using UnityEngine;

public class GroundMoveToward : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f,max_X = 148f, min_X=145f;
    [SerializeField] bool moveRight = true; 
    
    void FixedUpdate()
    {
        if (transform.position.x > max_X)
            moveRight = false;
        if (transform.position.x < min_X)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);

    }
}
