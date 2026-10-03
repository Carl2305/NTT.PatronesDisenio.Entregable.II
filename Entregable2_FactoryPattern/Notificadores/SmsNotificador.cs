namespace Entregable2_FactoryPattern.Notificadores;

public class SmsNotificador : INotificador
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine($"[SMS] {mensaje}");
    }
}
