Algoritmo ageRange
	Escribir "Bienvenido a tu primer rango de edades."
	Escribir "Por favor ingrese la primera edad."
	Leer  firstAge
	Escribir "Por favor ingrese la segunda edad."
	Leer secondAge
	si firstAge >= 0 Y secondAge >= 0 Entonces
		Escribir "Las edades dentro del rango de edad es el siguiente entre: " firstAge " y " secondAge " es el siguiente"
		range <- ""
		Para item <- firstAge Hasta secondAge
			si range = "" entonces
				range = "" + ConvertirATexto(item)
			sino
				range = range + ", " + ConvertirATexto(item)
			FinSi
		FinPara
		Escribir range
	SiNo
		Escribir "Por favor, ingrese una edad valida."
	FinSi
FinAlgoritmo
