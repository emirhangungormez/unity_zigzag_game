using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kutuhareketi : MonoBehaviour
{
    Vector3 yön;
    public float hız;
    public spawn spawnscript; // iki kodu tanıştırdık
    public static bool düştü_mü;
    public float eklenecekhız;

    void Start()
    {
      düştü_mü = false;
      yön = Vector3.forward;
    }

    void Update()
    {
        if(transform.position.y <= -0.5f)
        {
            düştü_mü = true;
        }
        if(düştü_mü == true)
        {
            Debug.Log("sana düştüm <3");
            return;
        }
    
    // tıklandıkça gerçekleşen olaylar
      if(Input.GetMouseButtonDown(0)) // 0 sol click, 1 sağ click
      {
          if(yön.x == 0)
          {
              yön = Vector3.left;
          }
          else
          {
              yön = Vector3.forward;
          }
          hız += eklenecekhız * Time.deltaTime; 
      }
    }
    private void FixedUpdate()
    {
        Vector3 hareket = yön * Time.deltaTime * hız;
        transform.position += hareket;
    }

    private void OnCollisionExit(Collision Collision) // temastan çıkıldığı vakit
    {
        
        if(Collision.gameObject.tag == "zemin")
        {
            skor.Skor = skor.Skor + 1;
            Collision.gameObject.AddComponent<Rigidbody>();
            spawnscript.zemin_oluştur();
            StartCoroutine(zeminisil(Collision.gameObject)); // ayrılınan zemini tanımladık
        }
    }

    IEnumerator zeminisil(GameObject silinecekzemin) // void yerine IEnumerable ile tanımlıyoruz, böylece zamanı kullanabiliriz.
    {
        yield return new WaitForSeconds(3f); // 3 saniye bekle
        Destroy(silinecekzemin); // ardından nesneyi yok et.
    }
}
