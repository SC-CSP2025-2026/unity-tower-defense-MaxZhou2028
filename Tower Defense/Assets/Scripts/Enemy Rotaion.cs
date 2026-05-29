using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [field: SerializeField]
    public float RotaionSpeed { get; private set;} = 90f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotaionSpeed * Time.deltaTime, 0);
    }
}
