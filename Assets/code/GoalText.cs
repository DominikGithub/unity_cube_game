using UnityEngine;

public class GoalText : MonoBehaviour
{
    
    public Transform player;
    public MeshRenderer meshRendererLost;
    public MeshRenderer meshRendererSuccess;

    void Start()
    {
        meshRendererSuccess.enabled = false;
    }

    void Update()
    {
        if (player.position.z > 250) {
            Debug.Log("You are winner");

            meshRendererSuccess.enabled = true;
            meshRendererLost.enabled = false;
        }
    }
}
