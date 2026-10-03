using Entregable2_FactoryPattern.Enums;
using Entregable2_FactoryPattern.Factories;

// Uso del patrón Factory para desacoplar la creación de objetos de notificación

var notificadorEmail = NotificadorFactory.CrearNotificador(TipoNotificador.Email);
notificadorEmail.Enviar("Bienvenido al sistema.");

var notificadorSms = NotificadorFactory.CrearNotificador(TipoNotificador.Sms);
notificadorSms.Enviar("Su código de verificación es 123456.");

var notificadorTeams = NotificadorFactory.CrearNotificador(TipoNotificador.Teams);
notificadorTeams.Enviar("Reunión de equipo iniciada.");

// Ejemplo creando notificador mediante parámetro tipo cadena
var notificadorDesdeString = NotificadorFactory.CrearNotificador("Email");
notificadorDesdeString.Enviar("Notificación enviada mediante parámetro de texto.");

// Mantiene la aplicación abierta para permitir visualizar los mensajes en consola
Console.ReadLine();
