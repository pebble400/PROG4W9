using UnityEngine;

public class DeactivateLights : MonoBehaviour
{
    Collider col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        col = gameObject.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("entering");
        if (collision.gameObject.CompareTag("Generator"))
        {
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("entering");
        if (other.gameObject.CompareTag("Generator"))
        {
            other.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
