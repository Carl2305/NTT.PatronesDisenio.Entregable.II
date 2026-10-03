namespace Entregable2_FactoryPattern.Factories;

using Entregable2_FactoryPattern.Enums;
using Entregable2_FactoryPattern.Notificadores;

public static class NotificadorFactory
{
    public static INotificador CrearNotificador(TipoNotificador tipo)
    {
        return tipo switch
        {
            TipoNotificador.Email => new EmailNotificador(),
            TipoNotificador.Sms => new SmsNotificador(),
            TipoNotificador.Teams => new TeamsNotificador(),
            _ => throw new ArgumentOutOfRangeException(nameof(tipo), $"Tipo de notificador no soportado: {tipo}")
        };
    }

    public static INotificador CrearNotificador(string tipo)
    {
        if (Enum.TryParse<TipoNotificador>(tipo, ignoreCase: true, out var tipoEnum))
        {
            return CrearNotificador(tipoEnum);
        }

        throw new ArgumentException($"El parámetro '{tipo}' no es un tipo de notificador válido.", nameof(tipo));
    }
}
