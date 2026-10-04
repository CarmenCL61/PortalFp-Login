\# Portal FP - Login



Pantalla de acceso (login) para el portal de gestión escolar de un centro de FP, 

desarrollada en WPF con .NET 10 como práctica de la UD01 del módulo de 

Desarrollo de Interfaces (DAM 2º curso).



\## Funcionalidades



\- Formulario de login centrado en pantalla

\- Validación de campos vacíos

\- Validación de credenciales (usuario: `admin`, contraseña: `1234`)

\- Accesibilidad: mnemónicos de teclado, TabIndex, AutomationProperties



\## Tecnologías



\- C# / .NET 10

\- WPF (Windows Presentation Foundation)

\- XAML



\## Uso de Inteligencia Artificial



Durante el desarrollo de esta práctica utilicé Claude (Anthropic) como asistente 

para resolver dudas conceptuales y técnicas. Por ejemplo, le consulté cómo 

estructurar correctamente el reparto de espacio en un `Grid` de WPF usando 

`RowDefinitions` con `Auto` y `\*`, ya que al principio no tenía claro cómo 

visualizar el resultado. La explicación me ayudó a entender que `\*` reparte 

el espacio \*sobrante\* después de calcular las filas `Auto`, no el total de 

la ventana — y a diseñar el layout final con filas de relleno arriba/abajo 

para mantener el contenido centrado y compacto sin deformarse al redimensionar 

la ventana.



\## Autora



Carmen - DAM 2º curso

