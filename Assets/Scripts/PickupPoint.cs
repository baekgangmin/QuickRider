using UnityEngine;

public class PickupPoint : MonoBehaviour
{
    public bool PlayerInRange { get; private set; }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        PlayerInRange = true;

        if (DeliveryManager.Instance != null && DeliveryManager.Instance.OrderAccepted)
        {
            DeliveryManager.Instance.CompletePickup();
        }
        else
        {
            Debug.Log($"{name}: 아직 주문을 수락하지 않았어요.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        PlayerInRange = false;
    }
}
