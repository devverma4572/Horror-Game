using UnityEngine;

public class DoorJumpScare : MonoBehaviour
{
    [SerializeField] AudioSource pianoScarefx;
    [SerializeField] AudioSource doorSlamfx;
    [SerializeField] AudioSource Monsterfx;
    [SerializeField] GameObject theDoor;
    [SerializeField] Animator demonAnimator;
    [SerializeField] MonsterAI monsterAI;

    void OnTriggerEnter(Collider other)
    {
        theDoor.GetComponent<Animator>().Play("DoorOpen");
        pianoScarefx.Play();
        doorSlamfx.Play();
        Monsterfx.Play();
        demonAnimator.Play("Shout");
        Invoke(nameof(StartMonster), 2f);
        this.GetComponent<BoxCollider>().enabled = false;
    }
    void StartMonster()
    {
        monsterAI.StartChasing();
    }
}
