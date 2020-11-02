using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlanetInfoHandler : MonoBehaviour
{
    public TextMeshProUGUI planetInfoBox;

    public void setPlanetInfoBox(CameraMovement.CameraState currentState)
    {
        switch (currentState)
        {
            case CameraMovement.CameraState.SolarSystemState:
                readTextFile("SolarSystemInfo");
                break;
            case CameraMovement.CameraState.MercuryState:
                readTextFile("MercuryInfo");
                break;
            case CameraMovement.CameraState.VenusState:
                readTextFile("VenusInfo");
                break;
            case CameraMovement.CameraState.EarthState:
                readTextFile("EarthInfo");
                break;
            case CameraMovement.CameraState.MarsState:
                readTextFile("MarsInfo");
                break;
            case CameraMovement.CameraState.JupiterState:
                readTextFile("JupiterInfo");
                break;
            case CameraMovement.CameraState.SaturnState:
                readTextFile("SaturnInfo");
                break;
            case CameraMovement.CameraState.UranusState:
                readTextFile("UranusInfo");
                break;
            case CameraMovement.CameraState.NeptuneState:
                readTextFile("NeptuneInfo");
                break;
        }
    }

    private void readTextFile(string textPath)
    {
        TextAsset text = (TextAsset) Resources.Load(textPath);
        planetInfoBox.text = text.text;
    }
}
