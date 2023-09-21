

let url="https://localhost:44387/api/Producto";

fetch(url)
 .then(response => response.json())
 .then(data => MostrarData(data))
 .catch(error => console.log(error))

const MostrarData = (data) =>{
  console.log(data)
   let body =''
   for (let i=0; i<data.length; i++){

  body +=`<tr><td>${data[i].id_P}</td><td>${data[i].nombre_P}</td><td>${data[i].descrip}</td><td><img src="/img/${data[i].imagen}"></td><td>${data[i].precio}</td</tr>`

   }
   document.getElementById('data').innerHTML = body
}


// const HTMLResponse= document.querySelector('#app');
// const td = document.createElement(`td`)

// fetch ('https://localhost:44361/api/producto').then((response) => response.json()).then((producto)=> {producto.forEach((producto)=>{let elen=document.createElement("tr");
// elen.appendChild(
//   document.createTextNode(`${producto.nombre_P} |` + `| ${producto.descrip} |` + `| ${producto.precio}` +` ${producto.imagen}`  )

// );
// td.appendChild(elen);
// });
// HTMLResponse.appendChild(td)
// })


// const xhr = new XMLHttpRequest();


// function onRequestHandler(){

// if (this.readyState ==4 && this.status ==200){

// const data = JSON.parse(this.response);
// const HTMLResponse= document.querySelector('#app');
// const nombre = data.map((producto) =>`<tr>${producto.nombre_P}</tr>`);
// const id = data.map((producto) =>`<tr>${producto.id_P}</tr>`);
// HTMLResponse.innerHTML = `<td>${nombre}  ${id}</td>`;
//   }
// }

// xhr.addEventListener("load", onRequestHandler);
// xhr.open("GET",'https://localhost:44361/api/producto');
// xhr.send();