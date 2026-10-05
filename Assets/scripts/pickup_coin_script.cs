using UnityEngine;

public class pickup_coin_script : MonoBehaviour
{
    public float rotationSpeed = 1000f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            Destroy(gameObject);
        }
    }



        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
