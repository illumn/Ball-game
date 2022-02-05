using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    [SerializeField] GameObject losePanel;

    private Rigidbody componentRigidbody;

    public int Velocity = 4;
    public int TurnSpeed = 2;
    private string sceneID;


    public int Getter()
    {
        return Velocity;
    }
    public void Setter(int value)
    {
        Velocity = value;
    }
    void Start()
    {

        StartCoroutine(SpeedIncrease());
        componentRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {

    }
    void FixedUpdate()
    {
        Vector3 velocity = componentRigidbody.velocity;
        velocity.z = Velocity;
        componentRigidbody.velocity = velocity;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            componentRigidbody.AddForce(Vector3.left * TurnSpeed * 4);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            componentRigidbody.AddForce(Vector3.right * TurnSpeed * 4);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            componentRigidbody.AddForce(Vector3.forward * (Velocity * 5));
        }

    }


    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "obstacle")
        {
            PlayerManager.GameOver=false;
            FindObjectOfType<PlayerManager>().GameoverPanel();

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