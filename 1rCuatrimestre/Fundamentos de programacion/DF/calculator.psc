Algoritmo calculadora

	Escribir "Bienvenido a tu primera calculadora"
	Escribir "Por favor ingrese el numero de la operacion que desea realizar"
	Escribir "1-Suma"
	Escribir "2-Resta"
	Escribir "3-Multiplicacion"
	Escribir "4-Division"
	Leer typeOperation
	si typeOperation >= 1 Y typeOperation <= 4 Entonces

		Escribir "Por favor ingrese el primer numero"
		Leer firstNumerber
		Escribir "Por favor ingrese el segundo numero"
		Leer secondtNumerber
		Escribir "Calculando espere un momento..."
		Esperar 300 Milisegundos
		Segun typeOperation Hacer
			1: 
				result <- firstNumerber + secondtNumerber
			2:
				result <- firstNumerber - secondtNumerber
			3:
				result <- firstNumerber * secondtNumerber
			4:
				result <- firstNumerber / secondtNumerber
				
		Fin Segun
		Escribir "Obtuvimos un el resultado de la operacion de los valores: " firstNumerber " y " secondtNumerber " el cual es: " result
		SiNo
			Escribir "Favor de ingresar una operacion correcta, tenga un buen dia"

	FinSi

Fin Algoritmo
	