using System.Collections.Generic;

using UnityEngine;

public class PlatformInstantiate : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _platforms;
    [SerializeField]
    private List<GameObject>_safeplatforms;
    [SerializeField]
    
    private Transform _platformPosition;
    [SerializeField]
    private float _distancePlatform=2f;
    [SerializeField]
    private int _InitialPlatforms=10;
    private float _OffSetPositionX=0f;
    private float platformsindex;
      void Start()
    {
        platformsindex=0;
        _OffSetPositionX=0;
        InstantiatePlatforms(_InitialPlatforms);
    }
    public void InstantiatePlatforms(int amount)
    {
        for(int i=0;i<amount;i++)
        {
            List<GameObject>platformstouse= platformsindex<2? _safeplatforms: _platforms;
             int randomIndex= Random.Range(0,platformstouse.Count);
           
             if(_OffSetPositionX!=0)
             {
                 _OffSetPositionX+=platformstouse[randomIndex].GetComponent<BoxCollider>().size.x*0.5f;
                
             }
              GameObject platform= Instantiate(platformstouse[randomIndex], Vector3.zero,Quaternion.identity);
               _OffSetPositionX+=_distancePlatform+platform.GetComponent<BoxCollider>().size.x*0.5f;
                platform.transform.SetParent(transform);
                platform.transform.localPosition = new Vector3(_OffSetPositionX, 0, 0);
                platformsindex++;

            
        }

    }
    public void Restart()
    {
        foreach(Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
