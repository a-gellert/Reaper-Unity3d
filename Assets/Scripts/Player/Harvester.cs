using UnityEngine;

public class Harvester : MonoBehaviour
{
    [SerializeField]
    private Backpack _backpack;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Grass")
        {
            other.gameObject.GetComponentInParent<Grass>().CutGrass();
            Debug.Log(other.gameObject.tag);
        }
        if (other.gameObject.tag == "Ambar")
        {
            _backpack.ReleaseBackpack(other.gameObject.transform);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Stack")
        {
            _backpack.AddGrassStack(other.gameObject.GetComponent<GrassStack>());

        }
    }
}


