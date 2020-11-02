using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetParticleHandler : MonoBehaviour
{
    public GameObject sunParticles;

    public GameObject mercuryParticles;

    public GameObject venusParticles;

    public GameObject earthParticles;

    public GameObject marsParticles;

    public GameObject jupiterParticles;

    public GameObject saturnParticles;

    public GameObject uranusParticles;

    public GameObject neptuneParticles;

    public GameObject[] planetParticles;

    void Start()
    {
        planetParticles = new GameObject[9];
        planetParticles[0] = sunParticles;
        planetParticles[1] = mercuryParticles;
        planetParticles[2] = venusParticles;
        planetParticles[3] = earthParticles;
        planetParticles[4] = marsParticles;
        planetParticles[5] = jupiterParticles;
        planetParticles[6] = saturnParticles;
        planetParticles[7] = uranusParticles;
        planetParticles[8] = neptuneParticles;
    }

    public void showPlanetParticles()
    {
        for (int i = 0; i < planetParticles.Length; i++)
        {
            planetParticles[i].SetActive(true);
        }
    }

    public void hidePlanetParticles()
    {
        for (int i = 0; i < planetParticles.Length; i++)
        {
            planetParticles[i].SetActive(false);
        }
    }
}
