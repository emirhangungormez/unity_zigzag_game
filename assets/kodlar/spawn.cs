using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject son_zemin;
    
    void Start()
    {
        for(int i = 0; i<50; i++)
        {
            zemin_oluştur();
        }
    }
    public void zemin_oluştur()
    {
        Vector3 yön; 
        if(Random.Range(0,2) == 0) // rastgaele değer oluşturan komut; 0 ya da 1.
        {
            yön = Vector3.left; // 0 ise yönü sol kabul et
        }
        else
        {
            yön = Vector3.forward; // 1 ise yönü ön kabul et
        }
        son_zemin = Instantiate(son_zemin,son_zemin.transform.position+yön, son_zemin.transform.rotation);
        // zemin spawn komutu (spawn olacak nesne, yer, rotasyon)
    }
}
