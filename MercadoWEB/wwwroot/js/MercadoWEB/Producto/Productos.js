

$(document).ready(function () {

    loadTable();

});

function bin2string(array) {
    var result = "";
    for (var i = 0; i < array.length; ++i) {
        result += (String.fromCharCode(array[i]));
    }
    return result;
}

function loadTable()
{

    tableDet = $('#dtProductos').DataTable({
        responsive: true,
        destroy: true,
        ajax: {
            url: "/Producto/GetProductos",
            method: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            //data: { idPersona: idPersona }
            data: function (d) {
                return JSON.stringify(d);
            }
        },
        dataSrc: "data",
        order: [],
        columns: [
            { "data": "nombreProducto" },
            { "data": "descripcion" },
            { "data": "precio" },
            { "data": "foto" },
            { "data": "existencia" }
        ],
        processing: false,
        language: {

            "lengthMenu": "Mostrar _MENU_ registros",
            "zeroRecords": "No se encontraron resultados",
            "info": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "infoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "infoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sSearch": "Buscar: ",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Ultimo",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "sProcessing": "Procesando...",
        },
        columnDefs: [
            {
                width: "10%",
                targets: 0,
                data: "nombreProducto",
                className: 'dt-left'
            },
            {
                width: "10%",
                targets: 1,
                data: "descripcion",
                className: 'dt-left'
            },
            {
                width: "10%",
                targets: 2,
                data: "precio",
                className: 'dt-left'
            },
            {
                width: "10%",
                targets: 3,
                data: "foto",
                className: 'dt-left',
                render: function (value, type, record, meta) {

                    var Imagen_Bin_String = bin2string(value);
                    var Imagen_Base64 = btoa(Imagen_Bin_String);

                    console.log(value)
                    console.log(Imagen_Bin_String)
                    console.log(Imagen_Base64)

                    return '<img src="data:image/jpg;base64,' + Imagen_Base64 + '">'
                }
            },
            {
                width: "10%",
                targets: 4,
                data: "existencia",
                className: 'dt-left'
            }
        ],
        rowCallback: function (nRow, aData, iDisplayIndex) {

        }

    });
    
}

function InsertProducto(formData)
{
    console.log(formData);

    var nombreProducto = $("#txtNombreProducto").val();
    var descripcion = $("#txtDescripcion").val();
    var idModulo = $("#ddlModulo").val();
    var idCategoria = $("#ddlCategoria").val();
    var precio = $("#txtPrecio").val();
    var existecia = $("#txtExistencia").val();
    var existeciaMin = $("#txtExistenciaMin").val();    

    var ajaxconfig = {
        type: 'POST',
        url: '/Producto/InsertProducto',//, NombreProducto: nombreProducto, IdModulo: idModulo, Descripcion: descripcion, IdCategoria: idCategoria, Precio: precio, Existencia: existecia, ExistenciaMinima: existeciaMin 
        data: { formData },        
        success: function (response) {
            if (response.result) {

                toastr.info(response.mensaje);
              
            } else {
                toastr.error(response.mensaje);
            }
        },
        error: function (msg) {

            toastr.error("Error ocurrido");
        }
    };

    if ($(formData).attr('enctype') == "multipart/form-data") {
        ajaxconfig["contentType"] = false;
        ajaxconfig["processData"] = false;
    }
    $.ajax(ajaxconfig);
    return false;
}