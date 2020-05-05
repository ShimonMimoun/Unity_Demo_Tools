using UnityEngine;

/**
 * This component moves its object in a fixed velocity.
 * NOTE: velocity is defined as speed+direction.
 *       speed is a number; velocity is a vector.
 */
public class Mover: MonoBehaviour {
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 velocity;
    private float yBound = 8;

    void Update() {
        transform.position += velocity * Time.deltaTime;
        if (transform.position.y > yBound || transform.position.y < -yBound) GameObject.Destroy(gameObject);
    }

    public void SetVelocity(Vector3 newVelocity) {
        this.velocity = newVelocity;
    }
}
