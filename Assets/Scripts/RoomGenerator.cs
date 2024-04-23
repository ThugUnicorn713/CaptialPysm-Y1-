using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour {
    
    [SerializeField] GameObject Hall;    
    [SerializeField] GameObject[] rooms;

    private static RoomGenerator Instance; //hold ref of this script

    private void Start() 
    {
        Instance = this; //storing the instance statically (object as far as classes go)


        Debug.Log(RoomGenerator.GetRoom().name);

    }

    public static RoomGenerator GetInstance() //getter
    {
        return Instance;
    }

    public static GameObject GetRoom() 
    {
        GameObject[] rooms = RoomGenerator.GetInstance().rooms;
        int index = Random.Range(0, rooms.Length);
        return rooms[index];
    }
    /*
    public static GameObject GetHall()
    {
        GameObject[] halls = RoomGenerator.GetInstance().halls;
        int index = Random.Range(0, halls.Length);
        return halls[index];
    }
    */
}
