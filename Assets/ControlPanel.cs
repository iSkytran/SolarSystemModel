using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlPanel : MonoBehaviour
{
    public GameObject pathRings;

    public CameraMovement cameraMovementObj;

    public PlanetParticleHandler planetParticleHandlerObj;

    public PlanetInfoHandler planetInfoHandlerObj;

    public void SolarSystemView()
    {
        pathRings.SetActive(true);
        planetParticleHandlerObj.showPlanetParticles();
        planetInfoHandlerObj.setPlanetInfoBox(CameraMovement.CameraState.SolarSystemState);
        cameraMovementObj.currentCameraState = CameraMovement.CameraState.SolarSystemState;
    }

    public void MercuryView()
    {
        pathRings.SetActive(false);
        planetParticleHandlerObj.hidePlanetParticles();
        planetInfoHandlerObj.setPlanetInfoBox(CameraMovement.CameraState.MercuryState);
        cameraMovementObj.currentCameraState = CameraMovement.CameraState.MercuryState;
    }

    public void VenusView()
    {
        pathRings.SetActive(false);
        planetParticleHandlerObj.hidePlanetParticles();
        planetInfoHandlerObj.setPlanetInfoBox(CameraMovement.CameraState.VenusState);
        cameraMovementObj.currentCameraState = CameraMovement.CameraState.VenusState;
    }

    public void EarthView()
    {
        pathRings.SetActive(false);
        planetParticleHandlerObj.hidePlanetParticles();
        planetInfoHandlerObj.setPlanetInfoBox(CameraMovement.CameraState.EarthState);
        cameraMovementObj.currentCameraState = CameraMovement.CameraState.EarthState;
    }

    public void MarsView()
    {
        pathRings.SetActive(false);
        planetParticleHandlerObj.hidePlanetParticles();
        planetInfoHandlerObj.setPlanetInfoBox(CameraMovement.CameraState.MarsState);
        cameraMovementObj.currentCameraState = CameraMovement.CameraState.MarsState;
    }

    public void JupiterView()
    {
        pathRings.SetActive(false);
        planetParticleHandlerObj.hidePlanetParticles();
        planetInfoHandlerObj.setPlanetInfoBox(CameraMovement.CameraState.JupiterState);
        cameraMovementObj.currentCameraState = CameraMovement.CameraState.JupiterState;
    }

    public void SaturnView()
    {
        pathRings.SetActive(false);
        planetParticleHandlerObj.hidePlanetParticles();
        planetInfoHandlerObj.setPlanetInfoBox(CameraMovement.CameraState.SaturnState);
        cameraMovementObj.currentCameraState = CameraMovement.CameraState.SaturnState;
    }

    public void UranusView()
    {
        pathRings.SetActive(false);
        planetParticleHandlerObj.hidePlanetParticles();
        planetInfoHandlerObj.setPlanetInfoBox(CameraMovement.CameraState.UranusState);
        cameraMovementObj.currentCameraState = CameraMovement.CameraState.UranusState;
    }

    public void NeptuneView()
    {
        pathRings.SetActive(false);
        planetParticleHandlerObj.hidePlanetParticles();
        planetInfoHandlerObj.setPlanetInfoBox(CameraMovement.CameraState.NeptuneState);
        cameraMovementObj.currentCameraState = CameraMovement.CameraState.NeptuneState;
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
