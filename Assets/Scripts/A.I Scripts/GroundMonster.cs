using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GroundMonster : MonoBehaviour {

    GameObject eventManager;
    GameObject playerPos;
    Transform playerTrans;
    NavMeshAgent navMeshAgent;
    CapsuleCollider lanternTrigger;

    //Where the monster is currently headed.
    public Vector3 destination;

    //Last position monster saw player at.
    Vector3 lastPos;

    //An array of waypoints.
    public GameObject[] waypoints;
    int maxWaypoints;
    int currentWaypoint;
    int determinedWaypoint;

    /* -------------------------
     * Monster phase values.
     * -------------------------*/


    //View range and forward raycast.
    float posAngle, lineOfSight = 5.0f;

    /*-------------------------------------------------------------
     * 1 Sneak - Monster hasn't noticed player.
    * 2 Evasion - Monster is chasing player's last known position.
    * 3 Alert - Monster is chasing player.
    --------------------------------------------------------------*/

    public int phase = 1;
    public int phaseTimer;
    float movSpeed;

    RaycastHit hit;

    private void Start ()
    {

        eventManager = GameObject.Find("EventManager");
        playerPos = GameObject.Find("PlayerCollision");
        playerTrans = playerPos.transform;

        lanternTrigger = GameObject.Find("LanternTrigger").GetComponent<CapsuleCollider>();
        maxWaypoints = waypoints.Length;

        StartCoroutine(SetWaypoint());
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update () {

        //Get player position angle relative to monster.
        Vector3 playerLocation = playerTrans.position - transform.position;
        posAngle = Vector3.Angle(playerLocation, transform.forward);
        Debug.DrawRay(transform.position, playerLocation, Color.red, 1);

        //Determine sight by current phase.
        lineOfSight = phase * 4.0f;
        movSpeed = phase * 2.4f;

        /*------------------
        * Player Detection
        * ----------------*/

        /* ---------------------------------------------------------
        * Checks the current location of the player to the monster.
        * Depending on whether the player is spotted or not,
        * a sequence determines the monsters phase.  
        * 
        * The raycast also check for the player's lantern light.
        ----------------------------------------------------------*/


        if (Physics.Raycast(transform.position, playerLocation, out hit, lineOfSight))
        {
            if (hit.transform == playerTrans && posAngle < 40.0f || hit.collider == lanternTrigger)
            {

                lastPos = playerTrans.position;
                AlertPhase();
            } else
            {
                NoHit();
            }
        }


        //Set waypoint as next destination when not chasing player.
        if (phase == 1)
        {
            if (transform.position == destination)
            {

                StartCoroutine(SetWaypoint());
            }
        }

        if (transform.position != destination)
        {
            transform.LookAt(destination, transform.up);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }

        navMeshAgent.speed = movSpeed;
        navMeshAgent.SetDestination(destination);
    }

    //Once the player has been spotted.
    void AlertPhase()
    {
        phase = 3;
        phaseTimer = 300;
        destination = playerTrans.position;
    }

    //When the raycast doesn't hit the player.
    void NoHit()
    {
        if (phase > 1)
        {
            phaseTimer--;
            if (phaseTimer < 0)
            {
                phaseTimer = 0;
            }

            if (phase == 3)
            {

                EvasionPhase();
            } else if (phase == 2 && phaseTimer == 0)
            {

                SneakPhase();
            }
        }
    }

    //After the alert phase, when the player hasn't been spotted for a while.
    void EvasionPhase()
    {

        phase = 2;
        destination = lastPos;
        phaseTimer = 300;
    }

    void SneakPhase()
    {

        phase = 1;
        phaseTimer = 300;
        StartCoroutine(SetWaypoint());
    }

    //Randomly sets a waypoint to head towards.
    IEnumerator SetWaypoint()
    {

        bool solved = false;

        determinedWaypoint = Random.Range(0, maxWaypoints);

        while (!solved)
        {

            if (determinedWaypoint != currentWaypoint)
            {
                currentWaypoint = determinedWaypoint;
                destination = waypoints[currentWaypoint].transform.position;
                solved = true;
                break;
            } else
            {

                determinedWaypoint = Random.Range(0, maxWaypoints);
                yield return null;
            }
        }

        solved = false;
    }

    //TAking health when colliding with player.
    void OnTriggerEnter(Collider other)
    {

        int damage;

        damage = Random.Range(1, 2);

        if (other.gameObject.name == "PlayerCollision")
        {
            Debug.Log("damage");
            //other.gameObject.GetComponent<PlayerData>().health -= damage;
        }
    }
}
