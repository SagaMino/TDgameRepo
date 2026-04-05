using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager main;


    //Array
    public Transform[] checkpoint;


    void Awake()
    {
        main = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
