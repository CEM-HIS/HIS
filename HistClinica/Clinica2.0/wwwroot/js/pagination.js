﻿$(document).ready(function () {
    $('#example').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        }

    });
    $('#generalgrid').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        },
        "scrollY": "300px",
        "scrollCollapse": true,
    });

    $('#cronogramagrid').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        },
        "scrollY": "300px",
        "scrollCollapse": true,
    });
    $('#citagrid').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        },
        "scrollY": "600px",
        "scrollCollapse": true,
    });
    $('#licenciagrid').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        },
        "scrollY": "300px",
        "scrollCollapse": true,
    });
    $('#personalgrid').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        },
        "scrollY": "300px",
        "scrollCollapse": true,
    });
    $('#detallegrid').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        },
        "scrollY": "300px",
        "scrollCollapse": true,
    });

    $('#cajagrid').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        },
        "scrollY": "300px",
        "scrollCollapse": true,
    });


    $('.dataTables_length').addClass('bs-select');
});

$("li.nav-item.menu-burger").hover(
    function () {
        $("aside").addClass('open');
    },
    function () {
        $("aside").removeClass('open');
    }
);