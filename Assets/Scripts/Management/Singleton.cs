using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T> 
{
    private static T instance;
    public static T Instance { get { return instance; } }

    protected virtual void Awake() {
        if (instance != null && this.gameObject != null) {
            Destroy(this.gameObject);
        } else {
            instance = (T)this;
        }

        if (!gameObject.transform.parent) {
            DontDestroyOnLoad(gameObject);
        }
    }
}
