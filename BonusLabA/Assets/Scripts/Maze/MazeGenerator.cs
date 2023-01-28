using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    [Header("Maze Size Properties")]
    public int mazeWidth = 8;
    public int mazeDepth = 8;

    public Transform tileParent;

    private GameObject[] tileArray;
    private List<GameObject> tileList;
    public GameObject startTile;
    public GameObject endTile;




    private void Awake()
    {
        startTile = Resources.Load<GameObject>("Tiles/StartTile");
        endTile = Resources.Load<GameObject>("Tiles/EndTile");

        tileArray = new GameObject[4];
        tileArray[0] = Resources.Load<GameObject>("Tiles/BarnTile");
        tileArray[1] = Resources.Load<GameObject>("Tiles/FactoryTile");
        tileArray[2] = Resources.Load<GameObject>("Tiles/EmptyTile");
        tileArray[3] = Resources.Load<GameObject>("Tiles/EmptyTile");

        tileList = new List<GameObject>();
         
    }

    private void Start()
    {
        BuildTileList();
    }
    private void BuildTileList()
    {
        for (int row = 0; row < mazeDepth; row++)
        {
            for (int coll = 0; coll < mazeWidth; coll++)
            {
                var tempTile = Instantiate(tileArray[Random.Range(0, 4)], new Vector3(coll * 16, 0.0f, row * 16), Quaternion.Euler(0.0f, Random.Range(1, 4) * 90, 0.0f), tileParent);

                tileList.Add(tempTile);


            }
        }
    }
}
