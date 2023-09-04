using UnityEngine;

public class PlantRotation : MonoBehaviour
{
    public float rotationSpeed = 120.0f; // Grados por segundo

    void Update()
    {
        // Calcula la rotaci�n en funci�n de la velocidad y el tiempo
        float rotation = rotationSpeed * Time.deltaTime;

        // Realiza la rotaci�n sobre el eje Y
        transform.Rotate(Vector3.back, rotation);
    }
}
