using UnityEngine;
using System.Collections;

public class Planks : MonoBehaviour
{

    Rigidbody rb;
    public GameObject plankParts;
    public float maxMagniture = 1f;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {

        InstantiateOurPlank();

    }

    //We have created our plank prefab which has parts of the plank seperated with rigid boddies
    //When magnitude is higer than our max
    //We destroy our original plank and instantiate our destroyed plank
    void InstantiateOurPlank()
    {

        float magniture = rb.velocity.magnitude;

        if (magniture > maxMagniture)
        {
            Destroy(gameObject);
            Instantiate(plankParts, transform.position, transform.localRotation);

        }

    }
}
