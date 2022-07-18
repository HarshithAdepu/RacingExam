using UnityEngine;
public enum DriveType
{
    FrontWheelDrive,
    RearWheelDrive,
    FourWheelDrive
}

[CreateAssetMenu(fileName = "CarSettings", menuName = "")]
public class CarSettings : ScriptableObject
{
    public string typeName;
    public DriveType driveType;
    public float maxSpeed;
    public float maxSteering;
    public float maxTorque;
    public float maxBrakeTorque;
}