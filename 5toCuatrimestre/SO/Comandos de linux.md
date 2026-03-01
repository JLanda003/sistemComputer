/ comando para la raíz de Linux



/etc Editable Text Configuration -> Se configura todo el sistema aquí



/home usuarios normales

/root usuario administradores



/var archivos variables;

(carpeta de logs) -> /var/log(aquí se revisan los logs) es la carpeta que mas rápido se llena

## 

## Comandos de supervivencia

pwd(Print Working Directory) imprime el directorio de trabajo, donde estas posicionados.

ls(lista el contenido)

ls -lh(lista formato largo y legible por humanos)

cd(change directory) permite cambiar la dirección

con dos puntos permite ir hacia atrás y con cd mas el nombre la carpeta entra en la carpeta

mkdir(Make Directory) permite crear carpetas

touch originalmente es para cambiar la fecha de un archivo, pero si no existe crea uno vacio

cp origen destino, Crea una copia, se queda el origen

mv origen destion, permite mover un archivo de un lado a otro, permite renombrar aquí.

rm (Remove), permite eliminar archivos no hay papelera de reciclaje, se pierde por completo

rm -rf / (Fuerza el borrado recursivo desde la raíz)



#### COMANDOS PARA VISUALIZAR

cat(Concatenate) te escupe todo el contenido del archivo de golpe

less Te muestra el archivo pagina por pagina

sudo (SuperUser Do) Permite tener todos los permisos temporalmente



Herramientas

nano permite edición básica y fácil de usar -> nano no siempre se encuentra en linux

nano archiveName.txt para abrir

ctrl+o para guardar -- ctrl+x para salir

vi si entras a un archivo sera complicado salir

vim



Permisos y propiedad, básicamente que puede hacer cada persona

tres geraquias

User(u): El dueño del archivo o creador. TU habitación

Group(g): El grupo de usuarios asociados. Una familia

Others(o): El resto del mundo. La gente de la calle



Letras de permisos - R - W - X

Ejemplo cuando colocamos ls -l, nos mostrara las letras -rwxr-xr-

r (Read / Leer) Ver el contenido del archivo o listar la carpeta  vale 4

w (Write / Escribir): Modificar, guardar cambios o borrar el archivo. vale 2

X (Execute / Ejecutar): vale 1

  En archivos correr el programa o script

  En carpetas

rwx : 4 + 2 + 1: 7

rw- = 4 + 2 + 0: 6

r-x 0 4 + 0 + 1: 5



chmod (Change Mode) permite cambiar quien puede leer, escribir o ejecutar

 chmod +x archivo.sh -> Da permisos de ejecución a todo

 chmod u\*w archivo.sh -> Da permisos solos al usuario

chown (Change Owner) permite cambiar el propietario





Comandos de 20260201

whoami -> saber con que usuario estoy logeado



cat /etc/passwd | tail -n 5 -> muestra la información del archivo y trae los 5 primeros, es la información de los ususarios registrados



useradd-> sirve para crear un usuario, se requiere de sudo o ser administrador, se recomienda siempre sudo



passwd -> se le da una contraseña al usuario que creamos, se recomienda siempre usar sudo

(usuario jefe, redhat123)

(usuario cto, redhat123)

(usuario becario\*, becario123)

(usuario usuario\*, user123)



sudo mkdir banco ->creamos la carpeta dentro de la raíz



sudo touch nomina\_secreta.txt -> creamos el archivo de nominas



sudo groupadd directivos -> creamos el grupo directicos



sudo usermod -aG directivos jefe -> agregamos el usuario jefe al grupo directivos



sudo chown :directivos banco -> al grupo de directivos le pasamos el propietario de la carpeta de banco



ls -ld banco -> permite observar la información de una carpeta en especifico



su - userName cambias de usuario desde consola





sudo usermod -a? groupName userName -> permite asignar un grupo al usuario si la g es minúscula este sera principal, si es G mayuscula este sera secundario

sudo gpasswd -a userName groupName -> añade como grupo secundario al usuario

sudo chmod g+s folder -> seteamos el group id

sudo chmod +t folder -> creamos el stick bit el cual protege que únicamente el usuario que creo pueda eliminar el archivo que creo.



sudo dnf upgrade --refresh -> actualización general de controladores. Preguntar si es viable.

sudo dnf check-update -> permite actualizar las paqueterias

dnf -> gestor de actualizaciones

INSTALAR EN PRODUCCION VERSIONES MENORES A RHE 7

sudo dnf install epel-release -y -> instal la paqueteria de epel

sudo dnf install htop nano tree -y -> instala las paqueterías de nano y tree





tar -> comando para comprimir

-cvf

-c = crear

-v = ver

-f = archivo

comando completo tar -cvf nombreArchivo.tar -CREAMOS LA CAJA DE ALMACENAJE PERO NO ESTA COMPRIMIDO



gzip nombreArchivo.tar -COMPRIME EL ARCHIVO

chmod +x nameScript.sh -> Le damos los permisos de ejecución al archivo



crontab -e -> modo programador

\*\*\*\*\* -> con espacios entre el asterisco



