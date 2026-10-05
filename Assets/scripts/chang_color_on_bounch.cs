using UnityEngine;

public class chang_color_on_bounch : MonoBehaviour
{
    private Renderer ObjectRenderer;
    string renderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ObjectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        ObjectRenderer.material.color = Random.ColorHSV();
    }
}
