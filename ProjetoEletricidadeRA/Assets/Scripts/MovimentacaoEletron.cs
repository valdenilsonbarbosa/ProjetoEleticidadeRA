using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoEletron : MonoBehaviour
{
    public GameObject[] objeto;
    public Transform posicaoTransicao;
    public GameObject eletron;
    public int i;
    void Start()
    {
        posicaoTransicao.position = objeto[0].transform.position;
        
       
        i = 1;
    }

    // Update is called once per frame
    void Update()
    {
       eletron.transform.position = Vector3.MoveTowards(eletron.transform.position, objeto[i].transform.position,0.5f * Time.deltaTime);

        if(eletron.transform.position == objeto[i].transform.position )
        {
            eletron.transform.position = objeto[i].transform.position;

            if(i != objeto.Length - 1)
            {
               i++;

            }
            else
            {
                 i =0;
            }
   
            
        }
        
    }
}
