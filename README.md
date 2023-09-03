# MitigationAngularNET

## Mitigación
![image](![image](https://github.com/CintiaLeal/MitigationAngularNET/assets/66495366/115a4c1a-3f8c-4fe3-8884-33c576948803))
Esta mitigación se realizó para resolver problemas de CORS al conectar el frontend con el backend.

### Angular:

1. **Instalación de Node.js:** [Descargar Node.js](https://nodejs.org/es)

2. **Instalación de Visual Studio Code:** [Descargar Visual Studio Code](https://code.visualstudio.com/download)

3. **Opcional:** Dentro de Visual Studio Code, instala la extensión de Angular.

4. Crea una carpeta en la ubicación que desees, por ejemplo, "FrontAngular".

5. Abre la carpeta en Visual Studio Code.

6. Abre la consola.

7. Ejecuta los siguientes comandos:

    ```bash
    npm install -g @angular/cli
    ng new pruebaNet
    cd pruebaNet
    ng add @angular/material
    ng serve
    ```

8. Dentro del proyecto, crea tres carpetas: "Modelos," "Servicios," y "Page."

9. Desde la consola, muévete a la carpeta "Page" y crea un componente. Todos los componentes deben estar dentro de esta carpeta para mantener la organización.

    ```bash
    ng generate component usuario
    ```

10. En la carpeta "Model," crea un archivo llamado "usuario.ts" para declarar un modelo de la clase Usuario que se utilizará en otros lugares.

11. En la carpeta "Servicios," crea un archivo para la conexión.

12. En el archivo "app-routing.module.ts," configura las rutas. Por ejemplo, puedes especificar que cuando la ruta esté vacía ("''"), se dirija al componente Usuario.

13. En el archivo "app.module.ts," asegúrate de declarar tu nuevo componente.

14. En el archivo "app.component.html," asegúrate de incluir la línea necesaria.

15. En tu componente, utiliza ngOnInit para obtener datos del backend al cargar la página.

16. Para la parte visible en el archivo HTML, utiliza los componentes de Angular Material. Puedes recorrer e imprimir los datos de la matriz JSON que recibe desde el backend utilizando ngFor.

### Angular Material:

Para más información sobre Angular Material, consulta [Angular Material](https://material.angular.io/).

### .NET

Instrucciones para crear una Web API en .NET:

1. **Instalación:** [Instalar .NET](https://dotnet.microsoft.com/download)

2. En el archivo "Program.cs," configura las reglas de CORS.

3. En los controladores, asegúrate de incluir el espacio de nombres necesario y agregar la etiqueta en la línea 11.

### Ejecución:

1. Ejecuta el proyecto .NET desde Visual Studio.

2. Desde la consola de Visual Studio Code, ejecuta el comando para iniciar el frontend.

3. Ahora puedes observar en Angular los datos obtenidos desde el backend.
![image](https://github.com/CintiaLeal/MitigationAngularNET/assets/66495366/4c029ac1-0fd3-4c19-a306-f0ec21b5caa9)

