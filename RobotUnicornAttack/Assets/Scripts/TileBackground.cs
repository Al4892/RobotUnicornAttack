using UnityEngine;

public class TileBackground : MonoBehaviour
{
    [SerializeField]
    private float _speed=0.5f;
    private Renderer _renderUsed;
    private Vector2 _offset= Vector2.zero;
    private bool _isMoving;
    public bool IsMoving
    {
        get =>_isMoving;
        set
        {
            _isMoving=value;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _renderUsed=GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!_isMoving) return;
        _offset.x += _speed * Time.deltaTime;
        _renderUsed.material.mainTextureOffset = _offset;
        
    }
}
