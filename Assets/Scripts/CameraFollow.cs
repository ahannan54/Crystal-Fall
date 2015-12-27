using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public PlayerControl theplayer;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;
    // Use this for initialization
    void Start()
    {
        theplayer = FindObjectOfType<PlayerControl>();
        lastPlayerPosition = theplayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToMove = theplayer.transform.position.y - lastPlayerPosition.y;

        transform.position = new Vector3(transform.position.x, transform.position.y + distanceToMove, transform.position.z);

        lastPlayerPosition = theplayer.transform.position;
    }
}
