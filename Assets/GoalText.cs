using UnityEngine;

public class GoalText : MonoBehaviour
{
    
    public Transform player;
    public MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer.enabled = false;
    }

    void Update()
    {
        if (player.position.z > 250) {
            Debug.Log("You are winner");

            meshRenderer.enabled = true;
        }
    }
}
