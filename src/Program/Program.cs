using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact contact = new Contact("Luli", "92611831", "sdjfn");

            // Crear la lista de contactos
            Phonebook phonebook = new Phonebook(contact);

            // Agregar contactos a la lista
            phonebook.AddContact("Ramallo", "23456789", "skefnsn");
            phonebook.AddContact("Luli", "92611831", "sdjfn");

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
