using UnityEngine;
using UnityEngine.Video;

public class PlayerPosition : MonoBehaviour
{
    [SerializeField]
    private Transform _Player;
    [SerializeField]
    private Transform _StartingPosition;

    public void SetPlayerPosition()
    {
        _Player.position=_StartingPosition.position;
        Rigidbody PlayerRiggidBody=_Player.GetComponent<Rigidbody>();
        PlayerRiggidBody.linearVelocity=Vector3.zero;
        PlayerRiggidBody.angularVelocity=Vector3.zero;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
