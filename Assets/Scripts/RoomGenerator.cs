using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour
{

    [SerializeField] GameObject hall;
    [SerializeField] GameObject[] rooms;

    public GameObject spawnRoom;
    private static RoomGenerator Instance; //hold ref of this script
    public GameObject bossRoom;
    private void Start()
    {
        Instance = this; //storing the instance statically (object as far as classes go)
    }

    public static RoomGenerator GetInstance() //getter
    {

        return Instance;
    }

    public Transform FindPlayerPosition()
    {
        spawnRoom = GetRoom();

        Collider[] colliders = spawnRoom.GetComponentsInChildren<Collider>(true);
        foreach (Collider collider in colliders)
        {
            if (collider.gameObject != spawnRoom && collider.gameObject.transform.childCount == 0)
            {
                return collider.gameObject.transform;
            }
        }
        return null;
    }

    public GameObject GetRoom()
    {
        RoomGenerator roomGenerator = GetInstance();

        if (roomGenerator != null)
        {
            GameObject[] rooms = roomGenerator.rooms;
            if (rooms.Length > 0)
            {
                int spawnRoom = Random.Range(0, rooms.Length);
                return rooms[spawnRoom];
            }
            else
            {
                Debug.LogWarning("No rooms found in the RoomGenerator.");
            }
        }
        else
        {
            Debug.LogWarning("RoomGenerator instance is null.");
        }

        return null;
    }

    public Transform FindPlayerHallPosition()
    {
        hall = GetHall();

        if (hall != null)
        {
            Transform transform = hall.transform.Find("PlacePlayer");
            Debug.Log("TRANSFORM: " + transform.parent.name);

            if (transform != null)
            {
                Debug.Log("SPAWN: " + transform.parent.name + " | " + transform.gameObject.transform.position);
       
                return transform;
            }
        }

        return null;

    }
    public GameObject GetHall()
    {
        RoomGenerator roomGenerator = GetInstance();

        GameObject hall = GameObject.Find("Hall");
        return hall;
    }
    public Transform FindPlayerBossPosition()
    {
        bossRoom = GetBossRoom();

        Collider[] colliders = bossRoom.GetComponentsInChildren<Collider>(true);
        foreach (Collider collider in colliders)
        {
            if (collider.gameObject != bossRoom && collider.gameObject.transform.childCount == 0)
            {
                return collider.gameObject.transform;
            }
        }
        return null ;
    }
    public GameObject GetBossRoom()
    { 
        RoomGenerator roomGenerator = GetInstance();

        GameObject bossRoom = GameObject.Find("BigBenni");
        return bossRoom;
    
    }

}
        
    
