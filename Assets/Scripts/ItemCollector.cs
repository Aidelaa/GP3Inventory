using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public float detectionRange;
    public LayerMask itemLayerMask;
    public KeyCode itemCollectionKey;
    public InventorySystem inventorySystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        detectItems();
    }

    void detectItems()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.forward);
        
        if (Physics.Raycast(ray, out hit, detectionRange, itemLayerMask))
        {
            Debug.Log("ItemDetected : " + hit.collider.gameObject.name);
        }

        if (Input.GetKeyDown(itemCollectionKey))
        {
            hit.collider.gameObject.GetComponent<CollectibleItem>().CollectItem();
        }
    }

    public void collectItem(Items item)
    {
        inventorySystem.addItem(item);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, Vector3.forward * detectionRange);
    }
}
