using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Marcador;
    [SerializeField] TextMeshProUGUI RPM;
    [SerializeField] float turnSpeed = 45.0f;
    [SerializeField] float horizontalInput;
    [SerializeField] float forwardInput;
    [SerializeField] float horsepower = 0;
    [SerializeField] GameObject CenterofMass;
    [SerializeField] float speed;
    [SerializeField] float rpm_speed;
    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsonground;
    private Rigidbody playerRB;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerRB.centerOfMass = CenterofMass.transform.position;
    }
    // Update is called once per frame
    private void Update()
    {
        speed = Mathf.Round(playerRB.velocity.magnitude * 3.6f);
        Marcador.SetText("Velocidad: " + speed + "Km/h");
        rpm_speed = Mathf.Round((speed % 30) * 40);
        RPM.SetText("RPM: " + rpm_speed);
    }

    void FixedUpdate()
    {
        if (isOnGround())
        {
            horizontalInput = Input.GetAxis("Horizontal"); //Toma el input horizontal
            forwardInput = Input.GetAxis("Vertical"); //Toma el input Vertical
            playerRB.AddRelativeForce(Vector3.forward * horsepower * forwardInput);
            //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //Utiliza el imput vertical para mover hacia adelante
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime); ///Utiliza el input horizontal para rotar

        }
    }

    bool isOnGround()
    {
        wheelsonground = 0;
        foreach(WheelCollider wheel in allWheels)
        {
            if(wheel.isGrounded)
            {
                wheelsonground++;
            }
        }
        if(wheelsonground >= 2)
        {
            return true;
        }else
        {
            return false;
        }
    }
}
