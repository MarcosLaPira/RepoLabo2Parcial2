# RepoLabo2Parcial2
EL TRUCO FANTASIA

Soy Marcos La Pira, estudiante de la Utn cursando mi segundo cuatrimestre, correspondiente a laboratorio 2, idioma c#.

Este trabajo me parecio un buen desafio para medirme que tan listo o no estoy de crear una aplicacion sin una guia previa Mi mayor desafio, fue la logica del juego en si,
Implementar todo a gusto y de la manera en la que lo 
y en lo que mas tiempo me llevo.Logre resolverlo mediante varios flags y funciones que soy consiente que pueden ser optimiables, pero una vez andando, creí 
 conveniente dedicarle el tiempo restante al resto de los temas vistos durante la cursasda.

Mi aplicacion:

  Este programa, ejecuta el juego de cartas Truco. En el que, jugará la maquina automaticamente mientras que el usuario podrá ver los movimientos 
  de cada jugador(ficticio) en tiempo real. Tambien el usuario podra acceder a un historial de encuentros en el que vera un resumen detallado con 
  informacion de partidas anteriores.
  
  Temas aplicados y su justificacion:
  
  Sql: aplique Sql, en la clase SemillaSql y Sql. Aqui lo que hago es una relacion entre la base de datos y mi programa. Mi clase sql, será la relació directa entre 
  el progrma y sql, y SemillaSql tendra el rol de administrador del mismo.
  
  Manejo de excepciones: Manejo excepciones en distintas partes del codigo, pero si tengo que destacar en algun lugar en especifico, lo haré con mis propias excepciones
  que cree para manejar los archivos. Ya que es factible que pueda ocurrir un error allí.
  
  Unit Testing: Lo usé en varias clases, lo vi muy conveniente para probar diferentes metodos y su funcionalidad
  
  Generics: Decidi implementerlo a la hora de serializar mi archivo json. Es cierto que siempre recibo una sala para serializar, pero trnquilamente si tengo que refactorizar 
  y persistir alguna informacion extra, podré hacerlo tranquilamente ya que mi json es genérico.
  
  Escritura de archivos: Utulicé el formato JSON para persistir mis datos, en el guardo mis salas para en un futuro poder mostrar un historial con sus detalles.
  
  Interfaces: Cree una interfaz llamada IArchivo de tipo genérico.Esta interfaz es utilizada en mi clase json, la cual obliga a esta misma a hacer uso de determinados metodos 
  importantes para un buen funcionamiento.
  
  Delegados: Los delegados, son utilizados entre mi clase sala y mi FormSala. Me encontré con que tenia que mostrar lo que estaba pasadno dentro de mi sala a travez del form
  por lo que crei conveniente utilizar delegados. FormSala le otorgara un metodo al delegado notificacion y en este se iran guardando las diferentes acciones ocurrias hasta el momento.
  
  Task: Al momento de correr mi sala, mi programa se congelaba hasta eu ele metodo comenzar partida de la clase sala, termine. Por lo que ahí implemenete un task, de forma
  que se ejecute en segundo plano.
  
