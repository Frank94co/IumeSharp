## IumeWindows

Esta aplicaci�n de Windows readapta el port hacia C# mostrado en IumeSharp, poni�ndole interfaz gr�fica, como siempre, Iume es una creaci�n original de @Fafnir98 en [este repositorio](https://github.com/Fafnir98/iume) . 

La funcionalidad de la aplicaci�n de Windows cuenta con seis botones, que funcionan de la siguiente manera:

 1. Partido en campo neutral: Haciendo clic en este bot�n, se hace una simulaci�n de un encuentro en cancha neutral, emitiendo un mensaje con el resultado. 
 2. Partido con local y visitante: Haciendo clic en este bot�n, sale una nueva ventana donde se ha de indicar el nivel tanto del local como del visitante, entre 4 opciones: top, alto, medio y bajo. Una vez se indican los niveles, se puede emitir el mensaje con el resultado con el bot�n de Resultado. 
 3. Partido de Copa: Haciendo clic en este bot�n, sale una nueva ventana donde se ha de indicar la *divisi�n* de los rivales, entre 1� y 15�. Haciendo clic en el bot�n de resultado, sale un mensaje con el resultado.
 4. Copa entera: Haciendo clic en este bot�n, se muestra una ventana en la que se pueden cargar archivos .CSV o .TXT con el formato que se muestra en el archivo `equipos_copa.csv` en [esta carpeta](https://github.com/Frank94co/IumeSharp/tree/master/IumeWindows/Plantillas). Se pueden ejecutar tantas rondas como se desee. Si la copa acaba, el archivo que se almacena con la recapitulaci�n de la copa se llama `informe_completo_copa.txt` y si se decide acabar prematuramente, la recapitulaci�n se llamar� `informe_parcial_copa.txt`.
 5. Multijornada: Haciendo clic en este bot�n, se muestra una ventana en la que se pueden cargar archivos .CSV o .TXT con el formato que se muestra en el archivo `multiliga.csv` en [esta carpeta](https://github.com/Frank94co/IumeSharp/tree/master/IumeWindows/Plantillas). Si se carga un archivo del formato correcto, emitir� los resultados de todas las jornadas cargadas con una tabla de posiciones al final del archivo llamado `informe_completo_multi.txt`, donde el factor de desempate es, aparte de los puntos, la diferencia de goles general y luego los goles marcados, por simplicidad. 
 6. Reportar bug: Se emite un mensaje con la informaci�n de contacto para reportar alg�n bug. 

De la misma forma que lo ha comunicado Fafnir en su README, se permiten modificaciones o *ports* de c�digo siempre que se den cr�ditos a la obra original, o que no se haga con fines de lucro.