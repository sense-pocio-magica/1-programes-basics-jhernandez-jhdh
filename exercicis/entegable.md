## Exercici 1

En aquest exercici amb **Console.WriteLine** el que fem es imprimir el que volem demanar-li al usuari (el seu nom i el seu cognom). Un cop li demanem i l'usuari ens dona la informació, el que fem es guardar el nom en una variable anomenada **nom** i de la mateixa manera el cognom en una variable anomenada **cognom**. Finalment fem un altre **Console.WriteLine** utilitzant les **"** per posar el text normal i el **+** per separar el text de les variables que ens donara la informació que hem pogut aconseguir.

## Exercici 2

De la mateixa manera que a l'exercici 1, en aquest li volem demanar una informació a l'usuari (Carrer,número,codi postal i població). Per que l'usuari ens ho doni utilitzem el **Console.WriteLine** per fer la pregunta i imprimir-la i el resultat ho guardem en una variable com per exemple Carrer a la variable **carrer**. Respecte al anterior exercici aquest té la diferencia que en el cas del número i codi postal que són números, els hem de convertir al tipus enter **(int)** pel fet de que es puguin guardar correctament i que no falli el programa. Finalment ho imprimim tot amb la informació que hem aconseguit de les variables. (El Console.ReadLine ho utilitzem pel fet de que el programa ho pugui llegir).

## Exercici 3

En aquest exercici definim tres variables: el nom del producte, el preu i l’estat de l’estoc.
Utilitzem un string amb la variable **Nom_Producte** per poder guardar el nom del producte.
A continuació, assignem el preu amb un enter **(int)** i utilitzem un **bool** per a la variable estoc, que ens permet indicar si el producte està disponible **(true)** o no **(false)**.

Amb una estructura ****if–else**, comprovem si la variable estoc és **true**.
Si ho és, el programa imprimeix **“Sí, hi ha estoc”**.
En cas contrari (false), executa el bloc else i mostra **“No, no hi ha estoc”**.

Finalment, imprimim el nom del producte i el seu preu, i després el programa mostra el missatge corresponent segons si hi ha estoc o no.

## Exercici 4

En aquest exercici volem fer un programa que converteixi euros a pessetes.
Per això, primer demanem a l’usuari quants euros té amb **Console.WriteLine**, i el programa ho llegeix amb **Console.ReadLine**, guardant el resultat a la variable euro.

Com que el valor que entra l’usuari pot tenir decimals (per exemple 2.50 euros), el convertim a **double** amb **Convert.ToDouble**, i el guardem a la variable euros.

Després fem la operació multiplicant els euros per 166.386, ja que **1 euro equival a 166.386 pessetes**.
Aquesta operació ens donarà el resultat en pessetes.

Finalment, utilitzem Console.WriteLine per imprimir el resultat a la pantalla, mostrant a l’usuari quantes pessetes són els euros que ha introduït.

## Exercici 5

En aquest exercici el que fem és demanar a l’usuari el seu nom i l’any de naixement.
Primer utilitzem **Console.WriteLine** per fer la pregunta **“Quin és el teu nom?”** i el que escrigui l’usuari ho guardem en la variable nom amb **Console.ReadLine**.

Després tornem a utilitzar **Console.WriteLine** per preguntar **“Quin és el teu any de naixement?”**, i el valor que ens doni l’usuari es guarda en la variable **any**.
Com que aquesta dada és un número, la convertim a enter amb **Convert.ToInt16** i la guardem a la variable **any1**, ja que la farem servir per fer una operació.

A continuació fem la resta entre l’any actual (2025) i l’any de naixement per poder calcular l’edat de la persona.

Finalment, imprimim el missatge per pantalla amb **Console.WriteLine**, mostrant **“Hola [nom]! Ja tens [edat] anys?”**, on el nom i l’edat surten de les variables que hem demanat abans.

## Exercici 6

En aquest exercici el que fem és calcular el perímetre d’un quadrat.
Primer demanem a l’usuari de quant és el costat del quadrat amb **Console.WriteLine**, i el que escrigui l’usuari ho guardem a la variable costat amb **Console.ReadLine**.

Com que el valor del costat és un número, el convertim a enter amb **Convert.ToInt16** i el guardem a la variable **costat1**, així el programa podrà fer l’operació correctament.

Després declarem una variable anomenada perimetre amb el valor 4, ja que un quadrat té quatre costats iguals.

Finalment, fem la operació matemàtica multiplicant el costat pel nombre 4 per obtenir el perímetre total del quadrat, i ho imprimim a la pantalla amb **Console.WriteLine** mostrant **“El perímetre del teu quadrat és** juntament amb el resultat.

## Exercici 7

En aquest exercici el que fem és calcular la mitjana de tres notes numèriques.
Primer definim tres variables amb els valors **num1, num2 i num3**, que representen les notes que té l’alumne.

Després declarem una altra variable anomenada **numnotes** amb el valor 3, ja que tenim tres notes en total i la necessitem per poder calcular la mitjana.

A continuació, fem la operació sumant les tres notes **(num1 + num2 + num3)** i dividint-ho entre **numnotes** per obtenir la mitjana.

Finalment, utilitzem ***Console.WriteLine** per imprimir per pantalla el resultat, mostrant **“La mitjana de les teves notes numèriques és”** juntament amb el valor calculat.

## Exercici 8

En aquest exercici el que fem és convertir un total de minuts en hores i minuts restants.
Primer declarem una variable anomenada **minuts** amb un valor numèric, en aquest cas 140, que representa el total de minuts que volem convertir.

Després creem una altra variable anomenada **hores**, on fem la divisió dels minuts entre 60, ja que una hora té 60 minuts, i així podem saber quantes hores senceres hi ha dins del total.

A continuació, declarem una variable anomenada **minutsrestants**, on fem servir el **símbol % (mòdul)**per calcular els minuts que sobren després de fer la divisió per hores.

Finalment, utilitzem **Console.WriteLine** per imprimir el resultat mostrant a la pantalla **“La mitjana és de [hores] i [minutsrestants] minuts”**, de manera que l’usuari pugui veure quantes hores i minuts corresponen al total que hem introduït.

## Exercici 9

En aquest exercici el que fem és convertir un valor en metres a peus.
Primer demanem a l’usuari que ens doni un valor en metres amb **Console.WriteLine**, i el que escrigui l’usuari ho llegim amb **Console.ReadLine**.

Com que el valor pot tenir decimals, el convertim a tipus **double** amb **Convert.ToDouble** i ho guardem a la variable valor per poder fer els càlculs correctament.

Després declarem una nova variable anomenada **peus**, on fem la operació multiplicant el valor en metres per 3.28084, ja que **1 metre equival a 3.28084 peus**.

Finalment, utilitzem **Console.WriteLine** per imprimir el resultat a la pantalla, mostrant **“Tens [peus] peus”**, que és el valor convertit segons la quantitat de metres que ha introduït l’usuari.

## Exercici 10

En aquest exercici el que fem és crear una contrasenya bàsica a partir del nom i l’any de naixement d’una persona.
Primer declarem una variable de tipus **string** anomenada **no**m, on hi guardem el nom de la persona, en aquest cas “Jose”.

Després declarem una altra variable de tipus **int** anomenada **data**, on hi guardem l’any de naixement, en aquest exemple 2007.

A continuació, fem servir **String.Concat** per ajuntar les dues variables, és a dir, el nom i la data, i el resultat el guardem dins de la variable **resultat**.
Això farà que el programa combini el nom i l’any formant una contrasenya com per exemple Jose2007.

Finalment, utilitzem **Console.WriteLine** per imprimir la contrasenya bàsica a la pantalla mostrant **“La contrasenya bàsica és”** seguit del valor que hem obtingut.

## Exercici 11

En aquest exercici el que fem és crear una adreça de correu electrònic completa a partir del nom d’usuari i el domini.
Primer declarem una variable de tipus **string** anomenada **nom**, on hi guardem el nom d’usuari, en aquest cas “jhernandezdeharo”.

Després declarem una altra variable de tipus **string** anomenada **domini**, on hi guardem el domini del correu, aquí “cendrassos.cat”.

També declarem una variable simbol amb el valor **“@”**, que necessitem per separar el nom d’usuari del domini en un correu electrònic.

A continuació, fem servir **String.Concat** per combinar les tres parts: el nom, el símbol i el domini, i el resultat el guardem dins de la variable **resultat**.
Això ens donarà una adreça de correu electrònic completa com per exemple jhernandezdeharo@cendrassos.cat
.

Finalment, utilitzem **Console.WriteLine** per imprimir la direcció de correu electrònic a la pantalla mostrant **“La teva adreça de correu és”** seguit del resultat.

## Exercici 12

En aquest exercici el que fem és demanar dos números a l’usuari i calcular les operacions bàsiques: suma, resta, multiplicació i divisió.

Primer utilitzem **Console.WriteLine** per preguntar “Dona’m el primer número”, i llegim el valor que introdueix l’usuari amb **Console.ReadLine**, convertint-lo a **int** amb **Convert.ToInt16** i guardant-lo a la variable **num1**.

Després fem el mateix amb el segon número, guardant-lo a la variable **num2**.

A continuació, calculem les quatre operacions:

Suma: guardem **num1 + num2** a la variable suma.

Resta: guardem **num1 - num2** a la variable resta.

Multiplicació: guardem **num1 * num2** a la variable multiplicacio.

Divisió: guardem **num1 / num2** a la variable divisio i calculem el residu amb **num1 % num2** per saber què sobra.

Finalment, utilitzem **Console.WriteLine** per imprimir cada resultat a la pantalla, mostrant la suma, la resta, la multiplicació i la divisió amb el residu.

Així, l’usuari podrà veure totes les operacions fetes amb els números que ha introduït.

## Exercici 13

En aquest exercici el que fem és reformatar una data que està escrita sense separadors per poder-la llegir correctament.
Primer utilitzem **Console.WriteLine** per preguntar **“Quina és la data sense formatar?”**, i llegim el valor que introdueix l’usuari amb **Console.ReadLine**, guardant-lo a la variable **data**.

Després utilitzem **Substring** per separar els components de la data:

dia: agafem els dos primers caràcters **(data.Substring(0, 2))**.

mes: agafem els dos caràcters següents **(data.Substring(2, 2))**.

any: agafem els quatre caràcters restants **(data.Substring(4, 4))**.

A continuació, unim les tres parts amb **“/”** per crear la variable **dataformada**.

Finalment, utilitzem **Console.WriteLine** per imprimir la data formatada a la pantalla, mostrant **“La data formatada és: [dataformada]”**, i així l’usuari pot veure la data correctament.

## Exercici 14

En aquest exercici el que fem és agafar una paraula i mostrar la primera, l’última i la lletra del mig.
Primer utilitzem **Console.WriteLine** per preguntar **“Quina és la paraula que vols declarar?”**, i llegim el que escriu l’usuari amb **Console.ReadLine**, guardant-ho a la variable **paraula**.

Després obtenim la primera lletra amb **paraula[0]** i la guardem a la variable **primeralletra**, que després imprimim amb **Console.WriteLine**.

Per agafar l’última lletra, fem servir **paraula[paraula.Length - 1]**, ja que **Length** ens dona la llargada de la paraula i restant 1 obtenim l’última posició de la cadena.

Finalment, per obtenir la lletra del mig, fem servir **paraula[paraula.Length / 2]**, que ens dona la posició central de la paraula. També ho imprimim amb **Console.WriteLine**.

Amb això, l’usuari pot veure la primera lletra, l’última i la del mig de la paraula que ha introduït.

## Exercici 15

En aquest exercici el que fem és mostrar el nom complet amb la primera lletra de cada paraula en majúscula.
Primer utilitzem **Console.WriteLine** per preguntar **“Quin és el teu nom?”**, i llegim el que escriu l’usuari amb **Console.ReadLine**, guardant-ho a la variable **nom**.

Després fem el mateix amb el cognom, guardant-lo a la variable cognom.

Per assegurar-nos que la primera lletra del nom i del cognom estigui en majúscula, fem servir **char.ToUpper(nom[0])** i **char.ToUpper(cognom[0])**, guardant les lletres a **primeralletranom** i **primeralletracognom**.
Convertim aquestes lletres a **string** amb **ToString()** i guardem-les a **inicialnom** i **inicialcognom**.

Després agafem la resta del nom i del cognom sense la primera lletra amb **Substring(1)**, guardant-ho a **nomsensemajuscula** i **cognomsensemajuscula**.

Finalment unim tot amb **Console.WriteLine**, mostrant la primera lletra en majúscula seguida de la resta del nom i cognom, separats per un espai, per obtenir el nom complet ben escrit.

## Exercici 16

En aquest exercici el que fem és calcular la nota final a partir de la nota de pràctiques i la nota de l’examen.

Primer utilitzem **Console.WriteLine** per preguntar **“Quina és la teva nota de pràctiques?”**, i llegim el que escriu l’usuari amb **Console.ReadLine**, convertint-ho a **float** amb **float.Parse()** per poder treballar amb decimals i guardant-ho a la variable practiques.

Després fem el mateix amb la nota de l’examen, guardant-la a la variable examen.

A continuació calculem la mitjana real sumant practiques + examen i dividint-ho per 2, guardant el resultat a **mitjana1**.
També calculem la mitjana arrodonida a l’enter més proper amb **Math.Round()**, guardant-ho a la variable **mitjana2**, ja que això és el que normalment es mostra com a nota final sense decimals.

Finalment, utilitzem **Console.WriteLine** per imprimir la nota final, mostrant tant la mitjana exacta amb decimals com la nota final arrodonida: **“La nota final és [mitjana1] o sigui un [mitjana2]”**.

## Exercici 17 **

En aquest exercici el que fem és separar els decimals d’un nombre real per obtenir el que anomenen els “nombres meravellosos”.

Primer utilitzem **Console.WriteLine** per preguntar **“Dona’m un número lleig”**, i llegim el que escriu l’usuari amb **Console.ReadLine**, convertint-ho a **float** amb **float.Parse()** i guardant-ho a la variable **numlleig**.

Després calculem només la part decimal restant el nombre enter amb **(int)numlleig**, i guardem el resultat a la variable **numdecimal**.
Així, si l’usuari introdueix 23,45, el càlcul serà 23,45 - 23 = 0,45, i això és el que consideren un nombre meravellós.

Finalment, utilitzem **Console.WriteLine** per imprimir el resultat, mostrant **“El número meravellós és [numdecimal]”**, amb dos decimals gràcies a **:F2**.

## Exercici 18

En aquest exercici el que fem és calcular quina hora serà després d’un cert nombre d’hores.

Primer utilitzem **Console.WriteLine** per preguntar **“Quina hora és actualment?”**, i llegim el que escriu l’usuari amb **Console.ReadLine**, convertint-ho a int amb **Convert.ToInt16** i guardant-ho a la variable **hora_actual**.

Després fem el mateix per preguntar **“Quantes hores vols incrementar?”**, guardant el valor a la variable **hora_incrementar**.

A continuació calculem la hora final sumant **hora_actual + hora_incrementa**r i fent el mòdul **12 amb % 12**, ja que volem que la hora torni a començar després de les 12.
Si el resultat és 0, el canviem a 12 per mostrar correctament el rellotge.

Finalment, utilitzem **Console.WriteLine** per imprimir el resultat, mostrant **“D’aquí a [hora_incrementar] hores l’hora actual serà [hora_final]”**, i així l’usuari sap quina hora serà després de sumar les hores indicades.

## Exercici 19

En aquest exercici el que fem és mostrar una paraula i el seu nombre de caràcters.

Primer utilitzem **Console.WriteLine** per preguntar **“Dona’m una paraula”**, i llegim el que escriu l’usuari amb **Console.ReadLine**, guardant-ho a la variable **paraula**.

Després utilitzem **paraula.Length** per obtenir la longitud de la paraula, és a dir, el nombre de lletres que conté.

Finalment, utilitzem **Console.WriteLine** per imprimir la paraula i el nombre de caràcters a la pantalla, mostrant **“La paraula [paraula] conté un total de [Length] lletres”**.

## Exercici 20

En aquest exercici el que fem és invertir els dígits d’un número de tres xifres.

Primer utilitzem **Console.WriteLine** per preguntar **“Dona’m un número de 3 xifres”**, i llegim el que escriu l’usuari amb **Console.ReadLine**, convertint-ho a **int** amb **Convert.ToInt16** i guardant-ho a la variable **num1**.

Després separem cada dígit del número:

unitats: fem **num1 % 10** per obtenir el dígit de les unitats.

desenes: dividim **num1 / 10 i fem % 10** per obtenir el dígit de les desenes.

centenes: fem **num1 / 100** per obtenir el dígit de les centenes.

Finalment, utilitzem **Console.WriteLine** per imprimir el número invertit, mostrant els dígits en ordre invers amb **“El teu número invertit és [unitats][desenes][centenes]”**.