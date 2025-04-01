using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
   [SerializeField]
   private GameObject _objectInstantiate;
   [SerializeField]
   private Stack<GameObject> _objectPool= new Stack<GameObject>();
   public GameObject ObjectToInstantiate=>_objectInstantiate;
   

   public void InstantiateObjectAtPosition(Transform asset)
   {
     GameObject obj=CreateInstance();
     obj.transform.position=asset.position;
   }
   public GameObject CreateInstance()
   {
    GameObject obj;
    if(_objectPool.Count>0)
    {
      obj=_objectPool.Pop();
      obj.SetActive(true);
    }
    else
    {
      obj= Instantiate(_objectInstantiate,transform.position,Quaternion.identity);
      obj.GetComponent<ObjectFromPool>().onDeactivate.AddListener(OnObjectDeactivate);
    }
    return obj;

   }
   public void OnObjectDeactivate(GameObject obj)
   {
    _objectPool.Push(obj);

   }

}
