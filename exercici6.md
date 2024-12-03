# Guion

Por cada titulo ### are un corte, juntando los videos en post produccion

## Google slides:
### Slide 1
Buenos dias, me llamo Miquel i en el video de hoy voy a hablar sobre los analizadores de codigo y como aplicarlo, con un ejemplo practico. Let's go.

### Slide 2
Los analizadores de código son herramientas utilizadas para inspeccionar automáticamente el código fuente con el fin de mejorar la calidad, seguridad y eficiencia del software. Se utilizan principalmente para identificar errores, vulnerabilidades de seguridad, incumplimiento de estándares y otros, siendo esenciales para mantener estándares elevados en el desarrollo de software

### Slide 3
Principalmente, tenemos dos tipos de analisis.. Análisis Estáticos, basado en flujos, basado en patrones, que inspeccionan el código sin ejecutarlo, enfocandose en sintaxis y logica, y luego tenemos los Análisis Dinámicos, que se realiza durante la ejecución del programa para encontrar problemas en tiempo real, enfocandose en fugas de memoria o errores de ejecución.

### Slide 4
Utilizando este tipo de software podemos ser mas agiles a la hora de escrivir codigo, ya que te corrige de forma automatica, ademas de aseguramos de no cometer errores graves. Dependiendo del analizador, tambien podremos disponer de informes detallados con nuestros defectos y possibles mejoras a tener encuenta... las possibilidades son infinitas!

### Slide 5
Ahora vamos a poner a prueba el analizador de codigo SonarQube, a ver si es capaç de corregirme.



## Tutorial SonarQube en mi codigo
### Aclarimiento Documentacion
Este tutorial se basa en la documentacion oficial de SonarQube que podras encontrarla en la descripccion de este video, si me acuerdo, o en la bibliografia del repositorio de la practica.

Estas son estas paginas que seguiremos para realizar las pruebas:

https://docs.sonarsource.com/sonarqube-server/10.6/try-out-sonarqube/ Set Up Guide

https://docs.sonarsource.com/sonarqube-server/10.6/analyzing-source-code/languages/csharp/ C# especifico


### Instalacio y configuracio de programari
Siguiendo la documentacion oficial, ahora vamos a proceder con la instalacion de SonarQube, pero antes devemos de verificar si tenemos intalado Java 17, si no es el caso lo instalamos.

Nosotros vamos a realizar una instalacion de una instancia local, pero tenemos la opcion de montar un servidor.

Vamos al apartado de Descargas de la pagina oficial de SonarQube..

Tenemos varias versiones del programa, nosotros usaremos la "Community Build", porque las demas son solo gratuitas los primeros 14 dias.

Ahora llega la parte del video que digo que "yo no lo instalo porque ya lo instale", pero voy a hacer una instalacion limpia para enseñar los pasos.

Se nos descargara un zip, y solo tendremos que descomprimirlo en la carpeta donde queremos guardar nuestro programa, es portable.

Al descomprimirlo iremos a la ruta del programa y buscaremos este fitxero .bat, y lo iniciamos, esto iniciara el programa SonarQube. :P