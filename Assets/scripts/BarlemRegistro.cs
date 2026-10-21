using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class BarlemRegistro : MonoBehaviour
{
    public TextMeshProUGUI Description;
    public TextMeshProUGUI Details;
    public GameObject DetailsGO;


    public void NubeDagas()
    {
        Description.text = "Llenas el aire con dagas giratorias en un cubo de 5 pies de cada lado, centrado en un punto que elijas dentro del alcance. Una criatura sufre 4d4 de daño cortante cuando entra en el área del hechizo por primera vez en un turno o comienza su turno allí." +
            "       En niveles más altos Cuando lanzas este conjuro usando un espacio de conjuro de nivel 3 o superior, el daño aumenta en 2d4 por cada nivel de espacio por encima del segundo";
    }
    public void NubeDagasDatos()
    {
     Details.text = "Conjuración de nivel 2" + "                                                                               Tiempo de lanzamiento: 1 acción" + "                                                           Alcance: 60 pies (5 pies)" + "                                                                                                                 Duración: Concentración, hasta 1 minuto" + "                                                                         Tipo de daño: cortante";
    }
    public void InmovilizarPersona()
    {
        Description.text = "Elige a un humanoide que puedas ver dentro del alcance. El objetivo debe superar una tirada de salvación de Sabiduría para no quedar paralizado mientras dure el conjuro. Al final de cada uno de sus turnos, puede hacer otra tirada de salvación de Sabiduría. Si tiene éxito, el conjuro termina." +
            "                                          En niveles superiores. Cuando lanzas este conjuro usando un espacio de conjuro de nivel 3 o superior, puedes elegir como objetivo a otro humanoide adicional por cada espacio de conjuro por encima de 2. Los humanoides deben estar a 30 pies o menos entre sí.";
    }
    public void InmovilizarpersonaDatos()
    {
        Details.text = "Conjuración de nivel 2" + "                                                                               Tiempo de lanzamiento: 1 acción" + "                                                           Alcance: 60 pies" + "                                                                                                                 Duración: Concentración, hasta 1 minuto" + "                                                                         Tirada de salvación: Sabiduría niega";
    }
    public void OlaAtronadora()
    {
        Description.text = "Una ola de una fuerza atronadora surge de ti. Cada criatura que se encuentre en un cubo de 15 pies adyacente a ti debe hacer una tirada de salvación de Constitución. Si falla, recibe 2d8 puntos de daño por trueno y es empujada lejos de ti a 10 pies. Si tiene éxito, recibe la mitad del daño y no es empujada." +
            "                                          Además, los objetos que no estén sujetos y que se encuentren completamente dentro del área son alejados de ti 10 pies debido al efecto del conjuro, y el conjuro emite un bum atronador que se oye a una distancia de 300 pies." +
            "                                          En niveles superiores. Cuando lanzas este conjuro usando un espacio de conjuro de nivel 2 o superior, el daño aumenta en 1d8 por cada nivel por encima de 1."; 
    }
    public void OlaAtronadoraDatos()
    {
        Details.text = "Conjuración de nivel 1" + "                                                                               Tiempo de lanzamiento: 1 acción" + "                                                           Alcance: Personal(15 pies)" + "                                                                                                                 Duración: Instantaneo" + "                                                                         Tipo de daño: Eléctrico";
    }
    public void FuegoFeerico()
    {
        Description.text = "El conjuro ilumina con luz azul, verde o violeta, a tu elección, el contorno de todos los objetos en un cubo de 20 pies dentro del alcance. Se ilumina también el contorno de cualquier criatura dentro del área que falle una tirada de salvación de Destreza. Hasta el final de la duración del conjuro, los objetos y criaturas afectados emiten luz tenue en un radio de 10 pies." +
            "                                          Todas las tiradas de ataque contra una criatura u objeto afectado tienen ventaja si el atacante puede ver a su objetivo. Además, aunque sean invisibles no recibirán ninguno de los beneficios de ese estado mientras sigan afectados por fuego feérico.";
            
    }
    public void FuegoFeericoDatos()
    {
        Details.text = "Conjuración de nivel 1" + "                                                                               Tiempo de lanzamiento: 1 acción" + "                                                           Alcance: 60 pies" + "                                                                                                                 Duración: Concentración, hasta 1 minuto" + "                                                                         Tipo de daño: Daño x2";
    }
    public void CurarHeridas()
    {
        Description.text = "Una criatura que tocas recupera un número de puntos de golpe igual a 1d8 + tu modificador por característica para lanzar conjuros. Este conjuro no tiene efecto ni en no muertos ni en constructos." +
            "                                                                                    En niveles superiores. Cuando lanzas este conjuro usando un espacio de conjuro de nivel 2 o superior, la curación aumentan 1d8 por cada nivel por encima del nivel 1.";

    }
    public void CurarHeridasDatos()
    {
        Details.text = "Conjuración de nivel 1" + "                                                                               Tiempo de lanzamiento: 1 acción" + "                                                           Alcance: Toque" + "                                                                                                                 Duración: Instanteneo";
    }
    public void DataText()
    {
        if(DetailsGO.activeSelf == true)
        {
            DetailsGO.SetActive(false);
        }
        else if(DetailsGO.gameObject.activeSelf == false)
        {
        DetailsGO.SetActive(true);
        }
    }
}
