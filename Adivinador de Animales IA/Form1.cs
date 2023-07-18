using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdivinadorAnimalesIA
{
    public partial class Form1 : Form
    {
        private NodoArbolDecision nodoActual;
        private NodoArbolDecision raizArbolDecisiones;

        public Form1()
        {
            InitializeComponent();
            InicializarJuego();
        }

        private void InicializarJuego()
        {
            // Construir el árbol de decisiones inicial
            NodoArbolDecision perro = new NodoArbolDecision("¿Es un perro?");
            NodoArbolDecision gato = new NodoArbolDecision("¿Es un gato?");
            NodoArbolDecision arbol = new NodoArbolDecision("¿Es un árbol?");
            NodoArbolDecision elefante = new NodoArbolDecision("¿Es un elefante?");

            perro.Si = new NodoArbolDecision("Perro");
            perro.No = gato;
            gato.Si = new NodoArbolDecision("Gato");
            gato.No = arbol;
            arbol.Si = new NodoArbolDecision("Árbol");
            arbol.No = elefante;
            elefante.Si = new NodoArbolDecision("Elefante");
            elefante.No = new NodoArbolDecision("No sé. ¿Cuál es el animal?");

            raizArbolDecisiones = perro;
            nodoActual = raizArbolDecisiones;

            MostrarPregunta();
        }

        private void MostrarPregunta()
        {
            lblPregunta.Text = nodoActual.Pregunta;
            btnSi.Enabled = (nodoActual.Si != null);
            btnNo.Enabled = (nodoActual.No != null);
            textBoxNombreAnimal.Visible = false;
            textBoxPregunta.Visible = false;
            btnEnviar.Visible = false;
        }

        private void MostrarRespuesta()
        {
            lblPregunta.Text = "¿Es correcto?";
            btnSi.Enabled = true;
            btnNo.Enabled = true;
            textBoxNombreAnimal.Visible = true;
            textBoxPregunta.Visible = true;
            btnEnviar.Visible = true;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            if (nodoActual.Si != null)
            {
                nodoActual = nodoActual.Si;
                if (nodoActual.EsHoja())
                {
                    MostrarRespuesta();
                    if (nodoActual.Animal != null)
                    {
                        lblPregunta.Text = $"¡Adiviné! ¿El animal que estabas pensando es un {nodoActual.Animal}?";
                    }
                    else
                    {
                        lblPregunta.Text = $"¡Adiviné! ¿El animal que estabas pensando es {nodoActual.Pregunta}?";
                    }
                }
                else
                {
                    MostrarPregunta();
                }
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (nodoActual.No != null)
            {
                nodoActual = nodoActual.No;
                if (nodoActual.EsHoja())
                {
                    MostrarRespuesta();
                }
                else
                {
                    MostrarPregunta();
                }
            }
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            string nombreAnimal = textBoxNombreAnimal.Text;
            string pregunta = textBoxPregunta.Text;

            if (!string.IsNullOrEmpty(nombreAnimal) && !string.IsNullOrEmpty(pregunta))
            {
                string preguntaAnterior = nodoActual.Pregunta;
                nodoActual.Pregunta = pregunta;
                nodoActual.Si = new NodoArbolDecision(nombreAnimal);
                nodoActual.No = new NodoArbolDecision(preguntaAnterior);

                MessageBox.Show("Gracias por enseñarme algo nuevo. Reiniciemos el juego.");

                ReiniciarJuego();
            }
            else
            {
                MessageBox.Show("Debes ingresar el nombre del animal y una pregunta.");
            }
        }

        private void ReiniciarJuego()
        {
            nodoActual = raizArbolDecisiones;
            textBoxNombreAnimal.Text = string.Empty;
            textBoxPregunta.Text = string.Empty;
            MostrarPregunta();
        }
    }

    public class NodoArbolDecision
    {
        public string Pregunta { get; set; }
        public NodoArbolDecision Si { get; set; }
        public NodoArbolDecision No { get; set; }
        public string Animal { get; set; }

        public NodoArbolDecision(string pregunta)
        {
            Pregunta = pregunta;
        }

        public bool EsHoja()
        {
            return Si == null && No == null;
        }
    }
}

/*
 Form1(): Este es el constructor de la clase Form1, que se ejecuta al iniciar la aplicación. Aquí se inicializa el juego
llamando al método InicializarJuego().

InicializarJuego(): Este método construye el árbol de decisiones inicial. Se crean instancias de la clase NodoArbolDecision
que representan las preguntas y animales del juego. Se establecen las conexiones entre los nodos mediante las propiedades Si y
No. Al final, se establece perro como la raíz del árbol y se asigna a nodoActual. Luego, se llama a MostrarPregunta() para
mostrar la primera pregunta al usuario.

MostrarPregunta(): Este método se encarga de mostrar la pregunta actual en la etiqueta lblPregunta. También habilita o
deshabilita los botones btnSi y btnNo según si hay opciones disponibles. Los campos de texto textBoxNombreAnimal, textBoxPregunta
y el botón btnEnviar se ocultan.

MostrarRespuesta(): Este método se llama cuando se llega a una hoja del árbol, es decir, cuando se adivina el animal o se
necesita una nueva pregunta. Cambia el texto de lblPregunta a "¿Es correcto?" y habilita los botones btnSi y btnNo. También
muestra los campos de texto textBoxNombreAnimal, textBoxPregunta y el botón btnEnviar para que el usuario pueda ingresar una
nueva respuesta.

btnSi_Click(): Este método se ejecuta cuando se hace clic en el botón "Sí". Verifica si hay un nodo hijo en la dirección "Sí"
(nodoActual.Si). Si existe, se actualiza nodoActual con ese nodo y se verifica si es una hoja. Si es una hoja, se llama a
MostrarRespuesta() y se muestra el mensaje de adivinanza del animal. Si no es una hoja, se llama a MostrarPregunta() para mostrar
la siguiente pregunta.

btnNo_Click(): Este método se ejecuta cuando se hace clic en el botón "No". Al igual que en btnSi_Click(), se verifica si hay
un nodo hijo en la dirección "No" (nodoActual.No). Si existe, se actualiza nodoActual con ese nodo y se verifica si es una hoja.
Si es una hoja, se llama a MostrarRespuesta() para que el usuario pueda ingresar una nueva respuesta. Si no es una hoja, se llama
a MostrarPregunta() para mostrar la siguiente pregunta.

btnEnviar_Click_1(): Este método se ejecuta cuando se hace clic en el botón "Enviar". Obtiene el texto ingresado en
textBoxNombreAnimal y textBoxPregunta. Si ambos campos tienen valores válidos, se actualiza nodoActual con la nueva pregunta y
se crean dos nuevos nodos hijos: uno con el nombre del animal ingresado y otro con la pregunta anterior. Luego, se muestra un
mensaje de agradecimiento y se reinicia el juego llamando a ReiniciarJuego().

ReiniciarJuego(): Este método reinicia el juego a su estado inicial. Establece nodoActual como la raíz del árbol y limpia los
campos de texto textBoxNombreAnimal y textBoxPregunta. Luego, llama a MostrarPregunta() para mostrar la primera pregunta al
usuario.

NodoArbolDecision: Esta es la clase que representa un nodo del árbol de decisiones. Tiene las propiedades Pregunta, Si, No y
Animal. Pregunta almacena la pregunta o descripción del nodo, Si y No son referencias a los nodos hijas en las respuestas "Sí"
y "No" respectivamente, y Animal almacena el nombre del animal si el nodo es una hoja.

En resumen, el juego de adivinanzas utiliza un árbol de decisiones para realizar preguntas binarias (Sí/No) y adivinar el animal
pensado por el usuario. Si el juego no puede adivinar el animal, permite al usuario agregar una nueva pregunta para mejorar el
árbol de decisiones. Esto se logra mediante la navegación entre los nodos del árbol y la actualización de la interfaz de usuario
para mostrar las preguntas y respuestas correspondientes.
 */

