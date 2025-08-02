using UnityEngine;

public class EggCollectible : MonoBehaviour, ICollectible
{
    public void Collect()
    {
        GameManager.Instance.OnEggCollected();

        CameraShake.Instance.ShakeCamera(0.5f, 0.5f);

        Destroy(gameObject);
    }
}
