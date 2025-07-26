using UnityEngine;

// 1. 위치벡터
// 2. 방향벡터
struct MyVector
{
    public float x;
    public float y;
    public float z;

    public float magnitude{get { return Mathf.Sqrt(x * x + y * y + z * z); }} // 크기벡터
    public MyVector normalized{ get { return new MyVector(x / magnitude, y / magnitude, z / magnitude); }} //방향벡터

    public MyVector(float x, float y, float z) {this.x = x; this.y = y; this.z = z;}

    public static MyVector operator + (MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    public static MyVector operator -(MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    public static MyVector operator * (MyVector a, float b)
    {
        return new MyVector(a.x * b, a.y * b, a.z * b);
    }
}
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;
    
    void Start()
    {
        MyVector to = new MyVector(10.0f, 0.0f, 0.0f);
        MyVector from = new MyVector(5.0f, 0.0f, 0.0f);
        MyVector dir = to - from; // -5, 0, 0 . 방향벡터

        dir = dir.normalized; // (1.0f, 0.0f, 0.0f)

        MyVector newPos = from + dir * _speed;

        // 방향벡터
            //1. 거리(크기) 5 : magnitude
            //2. 실제방향   : normalize
    }
    
    //GameObject (player)
       //Transform
       //PlayerController (*)
    void Update()
    {
        //Global -> local
        //transform.TransformDirection

        //Local -> Global
        //Inversetransform.TransformDirection
        

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed); // =transform.position += transform.TransformDirection(Vector3.forward * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
        }
        //transform
    }
}
