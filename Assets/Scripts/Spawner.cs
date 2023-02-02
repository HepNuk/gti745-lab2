using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner Instance { get; private set; }

    // Ref to planes prefab
    public GameObject redPlane;
    public GameObject greenPlane;
    public GameObject rainbowPlane;
    

    // Turret position
    private Vector3 turretPosition;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        
    }


    public void setTurretPosition(Vector3 p_turretPosition)
    {
        turretPosition = p_turretPosition;
    }

    public void spawnPlane(GameObject plane)
    {
        GameObject planSpawnPoint = new GameObject();

        // Randoms
        float extraHeight = Random.Range(0.5f, 1.5f);
        float extraDepth = Random.Range(0.5f, 1.5f);
        
        Vector3 planSpawnPosition = new Vector3(0.0f, this.turretPosition.y + extraHeight, this.turretPosition.x + extraDepth);
        planSpawnPoint.transform.position = planSpawnPosition;


        Instantiate(plane, planSpawnPoint.transform);
    }

    public void spawnAllPlanes()
    {
        spawnRedPlane();
        spawnGreenPlane();
        spawnRainbowPlane();
    }

    public void spawnRedPlane()
    {
        spawnPlane(redPlane);
    }

    public void spawnGreenPlane()
    {
        spawnPlane(greenPlane);
    }


    public void spawnRainbowPlane()
    {
        spawnPlane(rainbowPlane);
    }

    public void spawnRedPlaneAfterTime(float time)
    {
        Invoke("spawnRedPlane", time);
    }

    public void spawnGreenPlaneAfterTime(float time)
    {
        Invoke("spawnGreenPlane", time);
    }

    public void spawnRainbowPlaneAfterTime(float time)
    {
        Invoke("spawnRainbowPlane", time);
    }

}
