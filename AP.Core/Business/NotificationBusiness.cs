using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Core.Business
{
    public class NotificationBusiness
    {

        // 1. Implementar Notification Repository mediante una instancia de la clase RepositoryNotification.
        // 2. Crear Notification Repository
        // 3. Debe crear las siguientes funcionalidades:
        //  3.1 GetNotifications(int id = 0): Devuelve una lista de notificaciones. Si se proporciona un ID, devuelve la notificación específica.
        //  3.2 SaveOrUpdate(Notification notification): Guarda una nueva notificación o actualiza una existente.   
        //  3.3 Delete(int id): Elimina una notificación por su ID.
        //  3.4 SearchNotifications(string criteria, string field): Busca notificaciones basadas en un criterio específico y un campo determinado (por ejemplo, "Message", "CreatedBy", etc.).
        //  3.5 Funcion que traiga las ultimas 10 por usuario
        //  3.6 Funcion que traiga las primeras 10 por usuario
        //  3.7 Funcion que traiga solo las PARES
        //  3.8 Funcion que traiga solo las IMPARES
        // 4. Asegúrese de manejar las excepciones adecuadamente, especialmente al guardar o actualizar notificaciones. (o sea usar try catch en el CONTROLLER)
    }
}
