using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunForvard : MonoBehaviour
{
   
    private Rigidbody rb;
    public GameObject player;
    public int TurnSpeed = 2;
    private int Velocity = 4;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpeedIncrease());

        SwipeDetection.SwipeEvent += SwipeDetection_SwipeEvent;
    }

    private void SwipeDetection_SwipeEvent(Vector2 direction)
    {
        Vector3 dir =
            direction == Vector2.up ? Vector3.forward :
            direction == Vector2.down ? Vector3.back : (Vector3)direction;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Translate(0, 0, Velocity * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Translate(Vector3.left * TurnSpeed * Time.deltaTime);
            transform.Rotate(new Vector3(0, -1, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Translate(Vector3.right * TurnSpeed * Time.deltaTime);
            transform.Rotate(new Vector3(0, 1, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.Translate(Vector3.forward * TurnSpeed * 4 * Time.deltaTime);
        }

    }
    private IEnumerator SpeedIncrease()
    {
        yield return new WaitForSeconds(10);
        if (Velocity < 11)
        {
            Velocity += 1;
            StartCoroutine(SpeedIncrease());
        }
    }
   
}