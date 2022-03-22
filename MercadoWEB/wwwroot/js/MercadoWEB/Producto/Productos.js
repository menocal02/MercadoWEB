
$(document).ready(function () {


});

function InsertProducto()
{
    $.ajax({
        type: 'POST',
        url: '/Producto/InsertProducto',
        data: { Descripcion: textDescripcionPlantilla, Estado: estado },        
        success: function (response) {
            if (response.result) {
                Notify('Grabando', response.mensaje, 'success', 'fa fa-check-square', 'fade', 'normal');
              
                $.ajax({
                    type: 'POST',
                    url: '/Producto/InsertProducto',
                    data: { Descripcion: textDescripcionPlantilla, Estado: estado },
                    success: function (response) {
                        if (response.result) {
                            Notify('Grabando', response.mensaje, 'success', 'fa fa-check-square', 'fade', 'normal');
                            TablePlantillas();
                            // $(location).attr('href', "");

                        } else {
                            Notify('ERROR', response.mensaje, 'error', 'fa fa-times-circle', 'fade', 'normal');
                        }
                    },
                    error: function (msg) {
                        Notify('ERROR', 'Ocurrio un error inesperado,Contáctese con la oficina de Sistemas.', 'error', 'fa fa-times-circle', 'fade', 'normal');
                    }
                });

            } else {
                Notify('ERROR', response.mensaje, 'error', 'fa fa-times-circle', 'fade', 'normal');
            }
        },
        error: function (msg) {
            Notify('ERROR', 'Ocurrio un error inesperado,Contáctese con la oficina de Sistemas.', 'error', 'fa fa-times-circle', 'fade', 'normal');
        }
    });
}