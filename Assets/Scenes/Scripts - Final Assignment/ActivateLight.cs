using UnityEngine;

public class ActivateLight : MonoBehaviour
{
    Collider col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        print("entering");
        if (other.gameObject.CompareTag("Generator"))
        {
            other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
