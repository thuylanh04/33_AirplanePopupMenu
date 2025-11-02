using UnityEngine;

public class EnterGame : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Airplane"))
        {
            // Hiện popup khi máy bay chạm tường
            gameManager.ShowPopup();

            // Dừng máy bay lại
            other.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
