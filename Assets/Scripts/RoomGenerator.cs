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

    public Vector3 FindPlayerPosition()
    {
        spawnRoom = GetRoom();

        Collider[] colliders = spawnRoom.GetComponentsInChildren<Collider>(true);
        foreach (Collider collider in colliders)
        {
            if (collider.gameObject != spawnRoom && collider.gameObject.transform.childCount == 0)
            {
                return collider.gameObject.transform.position;
            }
        }
        return Vector3.zero;
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

    public Vector3 FindPlayerHallPosition()
    {
        hall = GetHall();

        Collider[] colliders = hall.GetComponentsInChildren<Collider>(true);
        foreach (Collider collider in colliders)
        {
            if (collider.gameObject != hall && collider.gameObject.transform.childCount == 0)
            {
                return collider.gameObject.transform.position;
            }
        } 
        return Vector3.zero;
    }
    public GameObject GetHall()
    {
        RoomGenerator roomGenerator = GetInstance();

        GameObject hall = GameObject.Find("Hall");
        return hall;
    }
    public Vector3 FindPlayerBossPosition()
    {
        bossRoom = GetBossRoom();

        Collider[] colliders = bossRoom.GetComponentsInChildren<Collider>(true);
        foreach (Collider collider in colliders)
        {
            if (collider.gameObject != bossRoom && collider.gameObject.transform.childCount == 0)
            {
                return collider.gameObject.transform.position;
            }
        }
        return Vector3.zero;
    }
    public GameObject GetBossRoom()
    { 
        RoomGenerator roomGenerator = GetInstance();

        GameObject bossRoom = GameObject.Find("BigBenni");
        return bossRoom;
    
    }

}
        
    
