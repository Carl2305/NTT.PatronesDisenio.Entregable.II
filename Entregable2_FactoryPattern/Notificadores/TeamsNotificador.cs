namespace Entregable2_FactoryPattern.Notificadores;

public class TeamsNotificador : INotificador
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine($"[Teams] {mensaje}");
    }
}
