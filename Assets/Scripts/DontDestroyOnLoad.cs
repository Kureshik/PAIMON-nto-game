using UnityEngine;
 
public class DontDestroyOnLoad : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    void Awake()
    {
        if(GameObject.Find(prefab.name) == null)
        {
            var obj = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            obj.name = prefab.name;
            DontDestroyOnLoad(obj);
        }
    }
}