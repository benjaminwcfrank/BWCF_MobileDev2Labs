using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinMgr : MonoBehaviour
{
    [Header("Coin Transform Visuals")]
    public float bobScaling = 0.5f;
    public float spinSpeed = 50f;
    public AnimationCurve bobCurve;

    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, (bobCurve.Evaluate((Time.time % bobCurve.length)) * bobScaling) + startPos.y , transform.position.z);
        transform.RotateAround(transform.position, Vector3.up, spinSpeed * Time.deltaTime);
    }
}
