using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    //we can declare an array instead of declaring 2 seperate variables
    public GameObject[] waypoints;//where name of array is waypoints->> so instead of 1 GameObject we can place as many game objects as we want into this array
                           //All objects in our hierarchy are GameObjects so by declaring this variable as GameObject array 
                           //our waypoints are just empty game objects

    
    int currentWaypointIndex = 0;//keeping track of what waypoint we are currently moving towards

    public float speed = 1f;


    // Update is called once per frame
    void Update()
        //in each Update() call ,check how far we are from currently active waypoint,if we touch it we switch to the next one,if we dont touch it we dont switch it to next one
    {   if(Vector3.Distance(transform.position,waypoints[currentWaypointIndex].transform.position)<0.1f)
        {
            currentWaypointIndex++;
            if(currentWaypointIndex>=waypoints.Length)//i.e if we are at last waypoint
            {
                currentWaypointIndex = 0;
            }
        }


        //we need reference to our 2 way points as we need to move between them so we need to have their positions
        //we will move our platform differently from the way we move our player
        //we move platform directly by its position frame by frame
        //to change the position of this platform
        //we move towards the currently active waypoint no matter 1st one or 2nd one ,we move towards it by calculating a new position between the platform's current position and and currently active waypoint and then by multiplying speed*Time.deltaTime we make it frame rate independent so that we always move this 1 game units per second no matter if we have 12 or 30 or 60 or 100 frames per second
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
