using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using System;

public enum Axel
{
    //Wheel Pos
    Front,
    Rear
}

[Serializable]
public struct Wheel
{
    //Wheel Properties
    public string name;
    public GameObject model;
    public WheelCollider collider;
    public Axel axel;
}

public class CarMoveScript : MonoBehaviour
{
    public static CarMoveScript instance;
    [SerializeField] private List<Wheel> wheelsList;
    [SerializeField] CarSettings carSettings;

    Vector3 centerOfMassOffset = new Vector3(0, -0.5f, 0);
    float currentAcceleration, inputX, inputY, timer = 0;
    PlayerInputActions carInput;
    Rigidbody rb;
    bool isBraking;
    public int time, laps = 0;

    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody>();

        carInput = new PlayerInputActions();
        carInput.Car.Enable();
        carInput.Car.Handbreak.started += ctx => isBraking = true;
        carInput.Car.Handbreak.canceled += ctx => isBraking = false;

        rb.centerOfMass = centerOfMassOffset;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        time = (int)timer;
        GetInput();
        AnimateWheels();
    }
    private void FixedUpdate()
    {
        Move();
        Turn();
        Brake();
    }
    public void Brake()
    {
        foreach (Wheel wheel in wheelsList)
        {
            if (isBraking)
            {
                wheel.collider.brakeTorque = carSettings.maxBrakeTorque;
            }
            else
            {
                wheel.collider.brakeTorque = 0;
            }
        }
    }
    private void GetInput()
    {
        inputX = carInput.Car.Horizontal.ReadValue<float>();
        inputY = carInput.Car.Vertical.ReadValue<float>();
    }
    private void Move()
    {
        float currentSpeed = rb.velocity.magnitude;
        currentAcceleration = (currentSpeed > carSettings.maxSpeed) ? 1f : carSettings.maxTorque;

        foreach (var wheel in wheelsList)
        {
            if (carSettings.driveType == DriveType.FrontWheelDrive)
            {
                if (wheel.axel == Axel.Front)
                    wheel.collider.motorTorque = inputY * currentAcceleration * Time.deltaTime;
            }
            if (carSettings.driveType == DriveType.RearWheelDrive)
            {
                if (wheel.axel == Axel.Rear)
                    wheel.collider.motorTorque = inputY * currentAcceleration * Time.deltaTime;
            }
            if (carSettings.driveType == DriveType.FourWheelDrive)
                wheel.collider.motorTorque = inputY * currentAcceleration * Time.deltaTime;
        }
    }
    private void Turn()
    {
        foreach (var wheel in wheelsList)
        {
            if (wheel.axel == Axel.Front)
            {
                var _steerAngle = inputX * carSettings.maxSteering;
                wheel.collider.steerAngle = Mathf.Lerp(wheel.collider.steerAngle, _steerAngle, 0.1f);
            }
        }
    }
    private void AnimateWheels()
    {
        foreach (var wheel in wheelsList)
        {
            Vector3 Pos;
            Quaternion rot;
            wheel.collider.GetWorldPose(out Pos, out rot);
            wheel.model.transform.position = Pos;
            wheel.model.transform.rotation = rot;
        }
    }
    private void OnDisable()
    {
        carInput.Car.Disable();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            if (laps != 0)
                FindObjectOfType<UIManager>().DisplayRecap(time);
            timer = 0;
            laps++;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        AudioManager.audioManagerInstance.PlaySound("CarHit");
    }
}
