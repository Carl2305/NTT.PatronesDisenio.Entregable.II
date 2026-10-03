namespace Entregable2_FactoryPattern.Notificadores;

public class EmailNotificador : INotificador
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine($"[Email] {mensaje}");
    }
}
