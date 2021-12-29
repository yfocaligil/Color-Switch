using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class renkler : MonoBehaviour
{
    
    public SpriteRenderer renk;
    public Color mor,sari,turkuaz,pembe;
    public string mevcutrenk;
    public Transform renkdegistirici,kare,iclicember,cember,kontrol1,kontrol2,kontrol3;
    public TextMeshProUGUI skoryazisi;
    private int skor;
    



    
    void Start()
    {
        
        renkver();
        cemberdond.donushizi=0.1f;
    }

    
    void Update()
    {
        skoryazisi.text="SKOR:"+" "+skor;
        Debug.Log(cemberdond.donushizi);
    }
 void renkver()
    {
        int rastgele=Random.Range(0,4);
        switch(rastgele)
        {
            case 0:
            mevcutrenk="mor";
            renk.color=mor;
            break;
            case 1:
            mevcutrenk="sari";
            renk.color=sari;
            break;
            case 2:
            mevcutrenk="turkuaz";
            renk.color=turkuaz;
            break;
            case 3:
            mevcutrenk="pembe";
            renk.color=pembe;
            break;
        }
    }
    private void OnTriggerEnter2D(Collider2D temas) 
    {
        if(temas.tag!=mevcutrenk && temas.tag!="renkdegistirici" && temas.tag!="kontrol1" && temas.tag!="kontrol2" && temas.tag!="kontrol3")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(temas.tag=="renkdegistirici")
        {
           renkver(); 
           skor++;
           renkdegistirici.position=new Vector2(renkdegistirici.position.x,renkdegistirici.position.y+7f);
           cemberdond.donushizi+=0.1f;
        }
        

        
        
        if(temas.tag=="kontrol2")
        {
         cember.position=new Vector2(cember.position.x,cember.position.y+14f); 
         kontrol2.position=new  Vector2(kontrol2.position.x,kontrol2.position.y+14f);
        }
         if(temas.tag=="kontrol3")
        {
         iclicember.position=new Vector2(iclicember.position.x,iclicember.position.y+14f); 
         kontrol3.position=new  Vector2(kontrol3.position.x,kontrol3.position.y+14f);
        }

        
        
    }
}
