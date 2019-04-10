Imports System



Module Program

	Sub Main()
		Dim opcion As Integer = 0

		While opcion >= 0 And opcion <= 5
			Console.WriteLine("1-Multiplo")
			Console.WriteLine("2-Resultado Academico")
			Console.WriteLine("3-Temperatura")
			Console.WriteLine("4-Tick Tock")
			Console.WriteLine("5-Personajes Favoritos")
			Console.WriteLine("Elija una opcion <1-5> o presione cualquier otro numero para salir")
			opcion = Console.ReadLine
			If opcion = 1 Then
				Multiplo()
			End If
			If opcion = 2 Then
				ResultadoAcademico()
			End If
			If opcion = 3 Then
				Temperatura()
			End If
			If opcion = 4 Then

				TickTock()
			End If
			If opcion = 5 Then
				PersonajesFavoritos()
			End If


		End While
	End Sub



	Sub Multiplo()
		Dim Num As Integer
		Dim nu As Integer
		Console.WriteLine("Escribe un numero")
		Num = Console.ReadLine()
		If Num Mod 5 = 0 Then
			Console.WriteLine("Es multiplo de 5")
		Else
			Console.WriteLine("No es multiplo de 5")
		End If
		Console.ReadLine()
		Console.WriteLine("Escribe un segundo numero")
		nu = Console.ReadLine()
		If (nu Mod 3 = 0) Then
			Console.WriteLine("Es multiplo de 3")
		Else
			Console.WriteLine("No es multiplo de 3")
		End If
		Console.ReadLine()
	End Sub



	Sub ResultadoAcademico()

		Dim no As String
		Dim ap As String
		Dim asistencia As Integer
		Dim nota As Decimal
		Console.WriteLine("Escriba sus nombres ")
		no = Console.ReadLine()
		Console.WriteLine("Escriba sus apellidos ")
		ap = Console.ReadLine()
		Console.WriteLine("Escriba su asistencia ")
		asistencia = Console.ReadLine()
		If asistencia < 0 Or asistencia > 100 Then
			Console.WriteLine("ERROR asstencia fuera del rango permitido")
		End If
		Console.WriteLine("Escriba su nota ")
		nota = Console.ReadLine()
		If nota > 6 And asistencia > 75 Then
			Console.WriteLine("Con una calificacion de:" & nota)
			Console.WriteLine("Y una asistencia de:" & asistencia)
			Console.WriteLine("El estudiante:" & no & ap)
			Console.WriteLine("Ha sido APROBADO")

			Console.ReadLine()
		End If
		If nota < 6 And asistencia < 75 Then
			Console.WriteLine("Con una calificacion de:" & nota)
			Console.WriteLine("Y una asistencia de:" & asistencia)
			Console.WriteLine("El estudiante:" & no & ap)
			Console.WriteLine("Ha sido REPROBADO")
			Console.ReadLine()

		End If
		If nota > 5 And nota < 6 And asistencia > 75 Then
			Console.WriteLine("Con una calificacion de:" & nota)
			Console.WriteLine("Y una asistencia de:" & asistencia)
			Console.WriteLine("El estudiante:" & no & ap)
			Console.WriteLine("Debera realizar un examen complementario")
			Console.ReadLine()

		End If


	End Sub



	Sub Temperatura()
		Dim tem As Integer
		Console.WriteLine("Ingrese la temperatura actual.")
		tem = Console.ReadLine()
		Select Case tem
			Case <= 5
				Console.WriteLine("Hace demasiado frio, no salgas de casa.")
				Console.ReadLine()
			Case <= 18
				Console.WriteLine("Ve por un abrigo.")
				Console.ReadLine()

			Case < 40
				Console.WriteLine("Es un dia agradable.")
				Console.ReadLine()

			Case >= 40
				Console.WriteLine("Hace mucho calor, toma bastante agua.")

				Console.ReadLine()

			Case Else
				Console.WriteLine("Al parecer la temperatura ingresada es incorrecta.")
				Console.ReadLine()

		End Select


	End Sub



	Sub TickTock()

		Dim i As Integer = 3
		Dim a As Integer = 5
		For index = 1 To 100

			If (index Mod 3 = 0) Then
				Console.WriteLine("TIck")


			ElseIf (index Mod 5 = 0) Then
				Console.WriteLine("Tock")


			ElseIf (index Mod 3 = 0) And (index Mod 5 = 0) Then
				Console.WriteLine("tick tock")

			Else
				Console.WriteLine(index)
					End If
		Next


			Console.ReadLine()


	End Sub



	Sub PersonajesFavoritos()
		Dim favorito1 As String
		Dim favorito2 As String
		While True
			Console.WriteLine("EQUIPOS")
			Console.WriteLine("1-Barcelona, 2-Liverpool, 3-Chelsea")
			Console.WriteLine("Escribe el nombre de tu equipo favorito")
			favorito1 = Console.ReadLine()
			If (favorito1 = "Barcelona") Then
				Console.WriteLine("Ahora elige a tu jugador favorito")
				Console.WriteLine("1-Messi, 2-Rakitic, 3-Dembele")
				favorito2 = Console.ReadLine()

				END If

			If (favorito1 = "Liverpool") Then
				Console.WriteLine("Ahora elige a tu jugador favorito")
				Console.WriteLine("1-Mane, 2-Firmino, 3-Sala")
				favorito2 = Console.ReadLine()

			End If
			If (favorito1 = "Chelsea") Then
				Console.WriteLine("Ahora elige a tu jugador favorito")
				Console.WriteLine("1-Hazard, 2-Willian, 3-David Luiz")
				favorito2 = Console.ReadLine()
			End If



			Exit While
		End While

		Console.WriteLine("Su equipo favorito es:" & favorito1)
		Console.WriteLine("Su jugador favorito es:" & favorito2)
		Console.ReadLine()


	End Sub

End Module