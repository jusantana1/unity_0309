
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public projectile projectilePrefab;
    public float speed = 5f;
    void Update()
    {
        ApplyMoviment();
        FireProjectile();
    }
    void FireProjectile()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }

    void ApplyMoviment()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        transform.Translate(Time.deltaTime * speed * new Vector3(horizontal, vertical));
    }
}
