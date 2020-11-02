using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public enum CameraState
    {
        SolarSystemState,
        MercuryState,
        VenusState,
        EarthState,
        MarsState,
        JupiterState,
        SaturnState,
        UranusState,
        NeptuneState
    }

    public float interpolationSpeed;

    public GameObject cameraObj;

    public Vector3 initialCameraPos;

    public GameObject mercury;

    public GameObject venus;

    public GameObject earth;

    public GameObject mars;

    public GameObject jupiter;

    public GameObject saturn;

    public GameObject uranus;

    public GameObject neptune;

    private Dictionary<CameraState, GameObject> planets = new Dictionary<CameraState, GameObject>();

    public CameraState currentCameraState = CameraState.SolarSystemState;

    void Start()
    {
        planets.Add(CameraState.MercuryState, mercury);
        planets.Add(CameraState.VenusState, venus);
        planets.Add(CameraState.EarthState, earth);
        planets.Add(CameraState.MarsState, mars);
        planets.Add(CameraState.JupiterState, jupiter);
        planets.Add(CameraState.SaturnState, saturn);
        planets.Add(CameraState.UranusState, uranus);
        planets.Add(CameraState.NeptuneState, neptune);
    }

    void FixedUpdate()
    {
        float interpolationStep = interpolationSpeed * Time.deltaTime;
        Vector3 currentCameraPos = cameraObj.transform.position;
        Quaternion currentRotation = cameraObj.transform.rotation;

        if (currentCameraState == CameraState.SolarSystemState)
        {
            cameraObj.transform.position = Vector3.Lerp(currentCameraPos, initialCameraPos, interpolationStep);

            Vector3 lookPos = Vector3.zero - cameraObj.transform.position;
            Quaternion desiredRotation = Quaternion.LookRotation(lookPos);
            cameraObj.transform.rotation = Quaternion.Slerp(currentRotation, desiredRotation, interpolationStep);
        }
        else
        {
            Vector3 changeVector = planets[currentCameraState].transform.localScale;
            changeVector = 2 * Vector3.ProjectOnPlane(changeVector, new Vector3(0.0f, 1.0f, 0.0f));
            float angle = Vector3.SignedAngle(Vector3.right, planets[currentCameraState].transform.position, Vector3.up);
            angle *= Mathf.Deg2Rad;
            changeVector.x *= -Mathf.Cos(angle);
            changeVector.z *= Mathf.Sin(angle);
            Vector3 desiredPos = planets[currentCameraState].transform.position + changeVector;
            cameraObj.transform.position = Vector3.Lerp(currentCameraPos, desiredPos, interpolationStep);

            Vector3 lookPos = planets[currentCameraState].transform.position - cameraObj.transform.position;
            Quaternion desiredRotation = Quaternion.LookRotation(lookPos);
            cameraObj.transform.rotation = Quaternion.Slerp(currentRotation, desiredRotation, interpolationStep);
        }
    }
}
