using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Necesario para trabajar con UI como Image y Text

public class UsuaryMaterialChanger : MonoBehaviour
{
    public LogIn LI;

    // El GameObject cuyo material cambiará
    private GameObject TargetObject;

    // Materiales para cambiar
    public Material RaxxarMaterial;
    public Material RagnavaldrMaterial;
    public Material KaironMaterial;
    public Material PrometeoMaterial;
    public Material AlmaMaterial;
    public Material BarledMaterial;
    public Material PepeLouxMaterial;
    public Material InvitadoMaterial;

    public bool KeepDefault;

    void Start()
    {
        // Asignamos automáticamente el GameObject en el que está el script
        TargetObject = this.gameObject;

        LI = GameObject.Find("Usuary").GetComponent<LogIn>();
    }

    void Update()
    {
        if (LI != null)
        {
            if (KeepDefault == false)
            {
                // Cambia el material dependiendo del usuario
                if (LI.Anibal)
                {
                    ChangeMaterial(RaxxarMaterial);
                }
                else if (LI.Chispo)
                {
                    ChangeMaterial(RagnavaldrMaterial);
                }
                else if (LI.Armando)
                {
                    ChangeMaterial(KaironMaterial);
                }
                else if (LI.Pablo)
                {
                    ChangeMaterial(PrometeoMaterial);
                }
                else if (LI.Samuel)
                {
                    ChangeMaterial(AlmaMaterial);
                }
                else if (LI.Ruben)
                {
                    ChangeMaterial(BarledMaterial);
                }
                else if (LI.Jaime)
                {
                    ChangeMaterial(PepeLouxMaterial);
                }
                else if (LI.Invitado)
                {
                    ChangeMaterial(InvitadoMaterial);
                }
            }
            else if (KeepDefault == true)
            {
                // Si se mantiene el estado predeterminado, no cambies el material
                ChangeMaterial(null);
            }
        }
        else
        {
            KeepDefault = true;
        }
    }

    // Método para cambiar el material del objeto objetivo (también para UI)
    private void ChangeMaterial(Material material)
    {
        if (TargetObject != null)
        {
            // Verificar si el objeto tiene un Renderer (para objetos 3D)
            Renderer renderer = TargetObject.GetComponent<Renderer>();
            if (renderer != null && material != null)
            {
                renderer.material = material;
            }

            // Si es un objeto de UI, con un componente Graphic como Image o Text
            else
            {
                Graphic graphic = TargetObject.GetComponent<Graphic>();
                if (graphic != null && material != null)
                {
                    graphic.material = material; // Cambiar el material del Graphic
                }
            }
        }
    }
}
