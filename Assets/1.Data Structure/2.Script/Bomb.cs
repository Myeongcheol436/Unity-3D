using System.Collections;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private Rigidbody bombRb;
    public float bombTime = 4f;
    public float bombRange = 10f;
    public LayerMask layerMask;

    private void Awake()
    {
        bombRb = GetComponent<Rigidbody>();   
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(bombTime);

        BombForce();
    }

    void BombForce()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 10f, layerMask);
       
        foreach (var collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();

            //Add(Æø¹ß ÆÄ¿ö, Æø¹ß À§Ä¡, Æø¹ß ¹üÀ§, Æø¹ß ³ôÀÌ)
            rb.AddExplosionForce(500f, transform.position, bombRange, 1f);
        }

        Destroy(gameObject);
    }
}
