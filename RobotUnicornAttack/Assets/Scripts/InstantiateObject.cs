using Unity.Mathematics;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
   [SerializeField]
   private GameObject _objectInstantiate;

   public void InstantiateObjectAtPosition(Transform asset)
   {
     Instantiate(_objectInstantiate,asset.position,quaternion.identity);
   }

}
