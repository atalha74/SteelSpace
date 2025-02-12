using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Mermi prefab�
    public Transform firePoint;     // Merminin ��k�� noktas�
    public float bulletSpeed = 10f; // Mermi h�z�
    

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space)) // Space tu�una bas�nca ate� et
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Mermiyi olu�tur
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = firePoint.up * bulletSpeed; // Mermiyi ileri do�ru f�rlat
    }
}

