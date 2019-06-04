using UnityEngine;

public abstract class SingletonBehaviour<T> : MonoBehaviour where T : SingletonBehaviour<T>
{
    public static T Instance;
    protected void Awake()
    {
        if (Instance is null)
        {
            Instance = GetComponent<T>();
            SingletonAwake();
            return;
        }
        Destroy(this);
    }

    protected abstract void SingletonAwake();
}
