using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [SerializeField] bool busyUP, busyDown;
    [SerializeField] float thrust, maxY = -4,minY=3;//Change numbers

    private void Start()
    {
        busyUP = true;
    }
    private void FixedUpdate()
    {
        if (this != null)
        {
            if (this.transform.position.y >= minY && busyDown)
            {
                transform.Translate(Vector3.down * thrust * Time.deltaTime);
                if (this.transform.position.y < minY)
                {
                    busyUP = true;
                    busyDown = false;
                }
            }
            else if (this.transform.position.y <= minY || maxY > this.transform.position.y && busyUP)
            {
                transform.Translate(Vector3.up * thrust * Time.deltaTime);
                if (this.transform.position.y > maxY - 0.5f)
                {
                    busyUP = false;
                    busyDown = true;
                }
            }


        }
    }
}
