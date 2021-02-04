# language: es
Característica: InformacionPersonal
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple programa que agrege el perfil profesional a un profesor

@mytag
Escenario: Guardar Datos Personales de un profesor
	Dado que un profesor tiene <nombre>
	Y tambien <apellido>
	Cuando ingresa los datos
	Entonces se almacenan los datos <nombre> <apellido>