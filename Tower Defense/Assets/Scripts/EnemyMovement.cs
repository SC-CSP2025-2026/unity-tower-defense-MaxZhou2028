using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [field: SerializeField]
    public float Speed { get; private set;} = 1f;
    // start is called once before the first ececution of Update after the MonoBehavir
    void Start ()
{
    
}
    // Update is called once per frame
    void Update()
    {
    
        transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime;
}
    }
    