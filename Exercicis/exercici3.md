# Guion

Link: https://youtu.be/SaRQfWQr4bI

## Google slides:
### Slide 1
Hola, me llamo Miquel i hoy voy a hacer un videotutorial sobre que significa la Integración Continua y el Despliegue Continuo, a mas de ver como aplicarlo en GitHub Actions en un entorno dotnet.


Jaja broma inical (wrong slide) para que no se vea aburrido el video, mas visitas

### Slide 2
Segun un articulo de la pagina Redhat:

La Integración Continua (CI) se refiere a la práctica de integrar automáticamente y con frecuencia los cambios de código en un repositorio compartido de código fuente. La Entrega Continua y/o Despliegue Continuo (CD) es un proceso en dos partes que implica la integración, prueba y entrega de los cambios de código. La Entrega Continua detiene el proceso justo antes del despliegue automático en producción, mientras que el Despliegue Continuo libera automáticamente las actualizaciones en el entorno de producción.

Pero para entenderlo mejor..


### Slide 3
Supongamos que un equipo desarrolla una aplicación web. Cada vez que un desarrollador hace un commit, el servidor de Integración Continua (CI) ejecuta pruebas para verificar que no se introduzcan errores. Si las pruebas pasan, el sistema despliega automáticamente el código en producción, permitiendo que los usuarios reciban actualizaciones frecuentes sin interrupciones.


### Slide 4
Ahora veremos como aplicar un sistema de Integración Continua en GitHub con la ayuda de GitHub Actions, para un entorno dotnet

## Tutorial GitHub Actions on dotnet
### Aclarimiento Documentacion
Este tutorial se basa en la documentacion oficial de GitHub que podras encontrarla en la descripccion de este video, si me acuerdo, o en la bibliografia del repositorio de la practica.

Estas son estas paginas que seguiremos para realizar las pruebas:

https://docs.github.com/es/actions/writing-workflows/quickstart

https://docs.github.com/en/actions/use-cases-and-examples/building-and-testing/building-and-testing-net


### Que es necessario tener y saber
Para este tutorial es necessario tener nociones basicas del uso de GitHub y haber echado un ojo a la documentacion relacionada con GitHub Actions start up
Necessitarem tener creado un repositorio con nuestro projecto .NET, con sus test y cositas. -- enseñar fitxeros projecto mas recordar gitignore


### WorkFlow, que es, cual usar?
Un WorKflow es el archivo de configuracion que usaremos para configurar nuestro GitHub actions adecuadamente, suelen ser fitxeros YAML o YML
Si miramos la documentacion relacionada al GiHub Actions, podremos ver que tenemos una cantidad enorme de plantillas para varios lenguajes, nosotros usaremos el fitxero de ejemplo de la guia de inicio para ver como es su funcionamiento.

pagina: https://github.com/actions/starter-workflows