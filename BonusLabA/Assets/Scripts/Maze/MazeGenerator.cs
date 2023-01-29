using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    [Header("Maze Size Properties")]
    public int mazeWidth = 8;
    public int mazeDepth = 8;

    private Transform tileParent;

    private GameObject[] tileArray;
    private List<GameObject> tileList;
    private GameObject startTilePrefab;
    private GameObject startTileRef;
    private GameObject endTilePrefab;
    private GameObject endTileRef;
    private GameObject playerPrefab;



    private void Awake()
    {
        startTilePrefab = Resources.Load<GameObject>("Tiles/StartTile");
        endTilePrefab = Resources.Load<GameObject>("Tiles/EndTile");

        tileParent = GameObject.Find("[TILES]").transform;

        tileArray = new GameObject[4];
        tileArray[0] = Resources.Load<GameObject>("Tiles/BarnTile");
        tileArray[1] = Resources.Load<GameObject>("Tiles/FactoryTile");
        tileArray[2] = Resources.Load<GameObject>("Tiles/EmptyTile");
        tileArray[3] = Resources.Load<GameObject>("Tiles/EmptyTile");

        tileList = new List<GameObject>();

        playerPrefab = Resources.Load<GameObject>("Player/Player");
    }

    private void Start()
    {
        BuildTileList();
        Invoke("SpawnPlayer", 0.1f);
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


        
        startTileRef = BuildCustomTile(startTilePrefab, 0, Random.Range(0, mazeWidth + 1));
        endTileRef = BuildCustomTile(endTilePrefab, Random.Range(1, mazeDepth + 1), Random.Range(1, mazeWidth + 1));
    }



    private void SpawnPlayer()
    {
        Instantiate(playerPrefab, startTileRef.transform.position + new Vector3(0f, 5f, 0f), startTileRef.transform.rotation);
    }

    private GameObject BuildCustomTile(GameObject newTilePrefab, int colPos, int rowPos)
    {


        var newTileIndex = (rowPos * mazeDepth) + colPos;
        var newTileTransform = tileList[newTileIndex].transform;
        Destroy(tileList[newTileIndex]);
        tileList[newTileIndex] = Instantiate(newTilePrefab, newTileTransform.position, newTileTransform.rotation, tileParent);
        return tileList[newTileIndex];
    }

}
