# ProyectoXamarin

Aula Virtual

Este proyecto tiene como proposito servir de utilidad tanto para padres de familia como profesores y permitirles administrar notas, calendario de actividades y demas.

El sistema consta de las siguientes capas:
- Profesores: dicha capa consta de la informacion de los profesores(Informacion personal) y las secciones que tienen a cargo.
- Seccion: dicha capa consta de la informacion de la seccion(Numero de seccion y cantidad de estudiantes) y las clases que existen para ella.
- Clases: dicha capa consta de la informacion de la clase y las notas asociadas a la misma.

Pendientes:

- El sistema contara con un login, inicialmente para profesores, posteriormente se evaluara usuarios para padres de familia. Dicha funcionalidad permitira hacer modificaciones dentro de la misma aplicacion y no mediante un cliente web.
- Un calendario para actividades generales y/o especificas que se den en el recinto estudiantil como actos civicos, dias feriados y demas.
- La "Seccion" contara con un listado de estudiantes.
- Contara con un area de comunicacion privada entre profesor-padre de familia, con el fin de mantener un comunicacion clara y documentada ante cualquier caso necesario.

Bugs:

- Al eliminar y/o actualizar una clase y retornar a la pagina anterior no hay un refrescamiento de la informacion.
- Al crear un usuario, no existe un mensaje de confirmacion al igual que no se valida la creacion del mismo.


API - Aula Virtual:

GET    /clase/list : Obtiene la lista completa de clases.
GET    /clase/{id} : Obtiene una clase basado en su id. 
DELETE /clase/{id} : Elimina una clase basado en su id.
POST   /clase/new : Crea una nueva clase.
GET    /clase/seccion/{id} : Obtiene una lista de clases basado en el id de una seccion.

GET    /profesor/list : Obtiene la lista completa de profesor.
GET    /profesor/{id} : Obtiene un profesor basado en su id.
POST   /profesor/register : Crea un nuevo profesor.

GET    /seccion/list : Obtiene la lista completa de clases.
GET    /seccion/{id} : Obtiene una seccion basado en su id.
GET    /seccion/profesor/{id} : Obtiene una lista de secciones basado en el id de un profesor.
