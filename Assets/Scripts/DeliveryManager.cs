using UnityEngine;

public class DeliveryManager : MonoBehaviour
{
    public static DeliveryManager Instance { get; private set; }

    public bool OrderAccepted { get; private set; }
    public bool HasPickedUp { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void AcceptOrder()
    {
        if (OrderAccepted) return;
        OrderAccepted = true;
        Debug.Log("주문을 수락했습니다. 가게로 이동하세요.");
    }

    public void CompletePickup()
    {
        if (!OrderAccepted || HasPickedUp) return;
        HasPickedUp = true;
        Debug.Log("음식을 픽업했습니다!");
    }
}
