using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    [SerializeField] Transform player;

    NavMeshAgent agent;

    Animator animator;

    bool chasing = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (chasing)
        {
            // FOLLOW PLAYER
            agent.SetDestination(player.position);

            // PLAY WALK/RUN ANIMATION
            animator.Play("Run");
        }
    }

    // CALLED AFTER DOOR OPENS
    public void StartChasing()
    {
        chasing = true;
    }
}