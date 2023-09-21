document.getElementById("form").addEventListener("submit", function(event) {
    event.preventDefault(); // Prevenir la recarga de la página
    
    // Obtener los valores de los campos del formulario
    var id_P = document.getElementById("id_P").value;
    var Nombre_P = document.getElementById("Nombre_P").value;
    var Descrip = document.getElementById("Descrip").value;
    var Imagen = document.getElementById("Imagen").value;
    var Precio = document.getElementById("Precio").value;


  
    // Crear un objeto de datos JSON que deseas enviar
    var data = {
        id_P: id_P,
      Nombre_P: Nombre_P,
      Descrip: Descrip,
      Imagen: Imagen,
      Precio: Precio
      
    };
  
    // Realizar la solicitud POST utilizando la API fetch
    fetch("https://localhost:44387/api/producto", {
      method: "POST",
      headers: {
        "Content-Type": "application/json" // Establecer el encabezado para JSON
      },
      body: JSON.stringify(data) // Convertir el objeto de datos en una cadena JSON
    })
      .then(function (response) {
        if (response.ok) {
          return response.json(); // Parsear la respuesta JSON
        } else {
          throw new Error("Error en la solicitud POST");
        }
      })
      .then(function (responseData) {
        // Manejar la respuesta de la API aquí
        console.log(responseData);
      })
      .catch(function (error) {
        // Manejar errores aquí
        console.error(error);
      });
      document.getElementById('data').innerHTML = body;
  });
  