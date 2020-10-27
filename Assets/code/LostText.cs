using UnityEngine;

public class LostText : MonoBehaviour
{
    
    public Transform player;
    public MeshRenderer meshRenderer;
    public Vector3 offset;
 
    void Start()
    {
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {    

        transform.position = player.position + offset;

        if (player.position.z < 250 && player.position.y < 40) {
            Debug.Log("Lost");
            meshRenderer.enabled = true;
        }
        
    }
}
