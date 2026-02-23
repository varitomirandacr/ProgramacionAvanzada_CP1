using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Core.Business
{
    public class NotificationBusiness
    {
        // PARTE 1
        // 1. Implementar Notification Repository mediante una instancia de la clase RepositoryNotification.
        // 2. Crear Notification Repository
        // 3. Debe crear las siguientes funcionalidades PRICIPALES:
        //  3.1 GetNotifications(int id = 0): Devuelve una lista de notificaciones. Si se proporciona un ID, devuelve la notificación específica.
        //  3.2 SaveOrUpdate(Notification notification): Guarda una nueva notificación o actualiza una existente.   
        //  3.3 Delete(int id): Elimina una notificación por su ID.
        //  3.4 SearchNotifications(string criteria, string field): Busca notificaciones basadas en un criterio específico y un campo determinado (por ejemplo, "Message", "CreatedBy", etc.).
        // 4. Debe crear las siguientes funcionalidades SECUNDARIAS:
        //  3.5 Funcion que traiga las ultimas 10 por usuario
        //  3.6 Funcion que traiga las primeras 10 por usuario
        //  3.7 Funcion que traiga solo las PARES
        //  3.8 Funcion que traiga solo las IMPARES
        //  3.9 Funcion que filtre por ACTIVOS e INACTIVOS
        // 5. Asegúrese de manejar las excepciones adecuadamente, especialmente al guardar o actualizar notificaciones. (o sea usar try catch en el CONTROLLER)

        // PARTE 2
        // 1. Crear Controller de Notifications: NotificationsController
        // 2. Crear las Vistas correspondientes para cada una de las funcionalidades implementadas en el NotificationBusiness.
        // 3. Debe asegurarse de que utilice el mismo "look & feel" (o sea estilo)
        // 4. La Pantalla de Index debe tener un componente de busqueda igual al de "Products"
        // 5. En la pantalla de Index, cada notificación debe tener opciones para Editar, Detalles y Eliminar, tal cual el ejemplo de products
        // 6. Para las funcionalidades secundarias, puede crear botones en la pantalla de Index para acceder a ellas...
        //      ...o bien, integrarlas como filtros dentro del mismo componente de búsqueda.
    }
}
