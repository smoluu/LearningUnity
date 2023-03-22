using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rakentaja : MonoBehaviour
{
    public GameObject kuutio;
    public int m‰‰r‰ = 10;
    public int sein‰Korkeus = 5;
    private int alaraja = 2;
    private int yl‰raja = 10;
    public List<GameObject> PalikkaLista;

    private void Start()
    {
        /*
        for (int i = 0;i < m‰‰r‰; i++)
        {
            for(int j = 0;j < m‰‰r‰ ; j++)
            {
                for (int k = 0;k < Random.Range(1,5); k++)
                {
                Instantiate(kuutio,new Vector3(i,k,j),Quaternion.identity);

                }


            }
        }

        for (int i = 0;i < m‰‰r‰; i++)
        {
            for(int j = 0;j < sein‰Korkeus; j++)
            {
                Instantiate(kuutio,new Vector3(0,j,i),Quaternion.identity);
            sein‰Korkeus += Random.Range(-1, 2);
            if (sein‰Korkeus < alaraja)
            {
                sein‰Korkeus = alaraja;
            }
            if (sein‰Korkeus > yl‰raja)
            {
                sein‰Korkeus = yl‰raja;
            }
            }
        }
        */
        for (int i = 0;i < m‰‰r‰;i++)
        {
            for (int j = 0; j < m‰‰r‰; j++)
            {
                Instantiate(PalikkaLista[Random.Range(0,PalikkaLista.Count)],new Vector3(i*10,0,j*10),Quaternion.identity);
            }
        }

    }
}
