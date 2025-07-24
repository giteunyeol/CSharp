using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; //유일성이 보장
    public static Managers Instance { get { Init(); return s_instance;} } // 유일한 매니저를 갖고온다

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {

    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject ("@Managers");
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }
    }
}
