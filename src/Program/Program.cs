using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact luli = new Contact("Luli", "92611831", "sdjfn");
            Contact flor = new Contact("Flor", "93878806", "skefnsn");
            Contact wpp = new Contact("wpp", "+14155238886", "reegerg");

            // Crear la lista de contactos
            Phonebook phonebook = new Phonebook(luli);

            // Agregar contactos a la lista
            phonebook.AddContact(flor);
            phonebook.AddContact(luli);

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos
            phonebook.SendMessage(luli, flor, "papafrita");

            // Enviar un SMS a algunos contactos
        }
    }
}
