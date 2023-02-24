
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerPos;
    public Vector3 cameraPos;
    // Update is called once per frame
    void Update()
    {
        transform.position = playerPos.position + cameraPos;
    }
}
