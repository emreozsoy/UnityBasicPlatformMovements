using UnityEngine;

public class GroundMoveDiagonel : MonoBehaviour
{
    [SerializeField] private float thrust, maxPos = -5,minPos= -12;
    [SerializeField] private bool busyUP, busyDown;

    private void Start()
    {
        busyUP = true;
    }
    private void FixedUpdate()
    {
        if (this.transform.position.y >= minPos && busyDown)
        {
            transform.Translate(Vector3.down * thrust * Time.deltaTime);
            transform.Translate(Vector3.left * thrust * Time.deltaTime);

            if (this.transform.position.y < minPos)
            {
                busyUP = true;
                busyDown = false;
            }
        }
        else if (this.transform.position.y <= minPos || maxPos+1 > this.transform.position.y && busyUP)
        {
            transform.Translate(Vector3.up * thrust * Time.deltaTime);
            transform.Translate(Vector3.right * thrust * Time.deltaTime);

            if (this.transform.position.y > maxPos)
            {
                busyUP = false;
                busyDown = true;
            }
        }


    }
}

