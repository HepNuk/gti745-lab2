using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class FollowPath : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 1.0f;
    float disantanceTravelled;

    // Update is called once per frame
    void Update()
    {
        disantanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(disantanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(disantanceTravelled);
    }
}
