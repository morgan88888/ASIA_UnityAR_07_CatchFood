using UnityEngine;
using UnityEngine.AI;

public class Food : MonoBehaviour
{
    [Header("爆")]
    public GameObject explosion;

    private NavMeshAgent nma;

    private void Start()
    {
        nma = GetComponent<NavMeshAgent>();
    }

    private void CreateEffect()
    {
        GameObject expl = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(expl, 0.5f);
        Destroy(gameObject);
    }



    private void ClickAndDead()
    {
        CreateEffect();
    }
    
    private void OnMouseDown()
    {
        ClickAndDead();
    }

}
