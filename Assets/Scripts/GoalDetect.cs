using UnityEngine;

public class GoalDetect : MonoBehaviour
{
    [HideInInspector]
    public PushAgentBasic agent; 

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("goal"))
        {
            agent.ScoredAGoal();
        }
    }
}
