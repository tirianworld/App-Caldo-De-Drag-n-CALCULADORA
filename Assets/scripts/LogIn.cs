using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogIn : MonoBehaviour
{
    public bool Jaime;
    public bool Anibal;
    public bool Pablo;
    public bool Armando;
    public bool Ruben;
    public bool Samuel;
    public bool Chispo;
    public bool Invitado;
    public TMP_InputField inputField;
    private static LogIn instance;
    public loginscreens LS;
    public LogIn login;

    public GameObject cargarUsuarioPanel;  // Panel que se activa si hay un usuario guardado
    public GameObject guardarUsuarioPanel; // Panel que se activa cuando se guarda un usuario
    public GameObject confirmacionGuardarPanel; // Panel de confirmación para guardar el usuario

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Si hay un usuario guardado, mostrar el panel de cargar usuario
        if (PlayerPrefs.HasKey("SelectedUser"))
        {
            cargarUsuarioPanel.SetActive(true); // Activamos el panel de cargar usuario
        }
        else
        {
            cargarUsuarioPanel.SetActive(false); // No hay usuario guardado, no mostramos el panel de cargar usuario
        }

        // Desactivamos el panel de confirmación al inicio
        confirmacionGuardarPanel.SetActive(false);
    }

    public void CargarUsuarioGuardado()
    {
        // Obtener el usuario guardado en PlayerPrefs
        string selectedUser = PlayerPrefs.GetString("SelectedUser");

        // Cargar la escena según el usuario guardado
        switch (selectedUser)
        {
            case "Gilgamesh":
                PepeLoux();
                break;
            case "Sombrior":
                Raxxar();
                break;
            case "Perseo":
                Prometeo();
                break;
            case "mistborn":
                Kairon();
                break;
            case "Clash_Of_Clans":
                Barlem();
                break;
            case "avutarda":
                Cuñao();
                break;
            case "20052005":
                Ragnavaldr();
                break;
            default:
                // Si no se encuentra el usuario, muestra la selección normal
                cargarUsuarioPanel.SetActive(false);
                return;
        }

        // Después de cargar, ir a la escena correspondiente
        SceneManager.LoadScene("Home");
    }

    public void GuardarUsuario()
    {
        // Guardar el usuario seleccionado en PlayerPrefs
        if (Jaime)
        {
            PlayerPrefs.SetString("SelectedUser", "Gilgamesh");
        }
        else if (Anibal)
        {
            PlayerPrefs.SetString("SelectedUser", "Sombrior");
        }
        else if (Pablo)
        {
            PlayerPrefs.SetString("SelectedUser", "Perseo");
        }
        else if (Armando)
        {
            PlayerPrefs.SetString("SelectedUser", "mistborn");
        }
        else if (Ruben)
        {
            PlayerPrefs.SetString("SelectedUser", "Clash_Of_Clans");
        }
        else if (Samuel)
        {
            PlayerPrefs.SetString("SelectedUser", "avutarda");
        }
        else if (Chispo)
        {
            PlayerPrefs.SetString("SelectedUser", "20052005");
        }

        PlayerPrefs.Save(); // Guardar el valor

        // Mostrar el panel de confirmación de guardar usuario
        confirmacionGuardarPanel.SetActive(true);
    }

    public void PepeLoux()
    {
        Jaime = true;
        Anibal = false;
        Pablo = false;
        Armando = false;
        Ruben = false;
        Samuel = false;
        Chispo = false;
        Invitado = false;

        if (LS != null)
        {
            LS.ScreenPepe.SetActive(true);
            inputField = LS.InputPepe;
        }

        // Llamar a la función que pregunta si guardar
        ComprobarInput();
    }

    public void Raxxar()
    {
        Jaime = false;
        Anibal = true;
        Pablo = false;
        Armando = false;
        Ruben = false;
        Samuel = false;
        Chispo = false;
        Invitado = false;

        if (LS != null)
        {
            LS.ScreenRaxxar.SetActive(true);
            inputField = LS.InputRaxxar;
        }

        ComprobarInput();
    }

    public void Prometeo()
    {
        Jaime = false;
        Anibal = false;
        Pablo = true;
        Armando = false;
        Ruben = false;
        Samuel = false;
        Chispo = false;
        Invitado = false;

        if (LS != null)
        {
            LS.ScreenPrometeo.SetActive(true);
            inputField = LS.InputPrometeo;
        }

        ComprobarInput();
    }

    public void Kairon()
    {
        Jaime = false;
        Anibal = false;
        Pablo = false;
        Armando = true;
        Ruben = false;
        Samuel = false;
        Chispo = false;
        Invitado = false;

        if (LS != null)
        {
            LS.ScreenKairon.SetActive(true);
            inputField = LS.InputKairon;
        }

        ComprobarInput();
    }

    public void Barlem()
    {
        Jaime = false;
        Anibal = false;
        Pablo = false;
        Armando = false;
        Ruben = true;
        Samuel = false;
        Chispo = false;
        Invitado = false;

        if (LS != null)
        {
            LS.ScreenBarlem.SetActive(true);
            inputField = LS.InputBarlem;
        }

        ComprobarInput();
    }

    public void Cuñao()
    {
        Jaime = false;
        Anibal = false;
        Pablo = false;
        Armando = false;
        Ruben = false;
        Samuel = true;
        Chispo = false;
        Invitado = false;

        if (LS != null)
        {
            LS.ScreenAlma.SetActive(true);
            inputField = LS.InputAlma;
        }

        ComprobarInput();
    }

    public void Ragnavaldr()
    {
        Jaime = false;
        Anibal = false;
        Pablo = false;
        Armando = false;
        Ruben = false;
        Samuel = false;
        Chispo = true;
        Invitado = false;

        if (LS != null)
        {
            LS.ScreenRagnavaldr.SetActive(true);
            inputField = LS.InputRagnavaldr;
        }

        ComprobarInput();
    }

    public void Probador()
    {
        Jaime = false;
        Anibal = false;
        Pablo = false;
        Armando = false;
        Ruben = false;
        Samuel = false;
        Chispo = false;
        Invitado = true;

        if (LS != null)
        {
            LS.ScreenInvitado.SetActive(true);
            inputField = LS.InputInvitado;
        }

        ComprobarInput();
    }

    public void ComprobarInput()
    {
        string entradaUsuario = inputField.text.Trim();

        if (Jaime == true && entradaUsuario.Equals("Gilgamesh", System.StringComparison.OrdinalIgnoreCase))
        {
            // Preguntar si desea guardar el usuario
            confirmacionGuardarPanel.SetActive(true);
        }
        else if (Anibal == true && entradaUsuario.Equals("Sombrior", System.StringComparison.OrdinalIgnoreCase))
        {
            confirmacionGuardarPanel.SetActive(true);
        }
        else if (Pablo == true && entradaUsuario.Equals("Perseo", System.StringComparison.OrdinalIgnoreCase))
        {
            confirmacionGuardarPanel.SetActive(true);
        }
        else if (Armando == true && entradaUsuario.Equals("mistborn", System.StringComparison.OrdinalIgnoreCase))
        {
            confirmacionGuardarPanel.SetActive(true);
        }
        else if (Ruben == true && entradaUsuario.Equals("Clash_Of_Clans", System.StringComparison.OrdinalIgnoreCase))
        {
            confirmacionGuardarPanel.SetActive(true);
        }
        else if (Samuel == true && entradaUsuario.Equals("avutarda", System.StringComparison.OrdinalIgnoreCase))
        {
            confirmacionGuardarPanel.SetActive(true);
        }
        else if (Chispo == true && entradaUsuario.Equals("20052005", System.StringComparison.OrdinalIgnoreCase))
        {
            confirmacionGuardarPanel.SetActive(true);
        }
    }

    // Método para aceptar guardar el usuario
    public void AceptarGuardar()
    {
        GuardarUsuario();
        SceneManager.LoadScene("Home");
        // Cargar la escena
    }

    // Método para cancelar y no guardar el usuario
    public void CancelarGuardar()
    {
        SceneManager.LoadScene("Home");
        // Solo cargar la escena sin guardar
    }
}
