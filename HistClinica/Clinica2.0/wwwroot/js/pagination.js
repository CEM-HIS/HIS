$(document).ready(function () {
    $('#example').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        }

    });
    $('#generalgrid').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        },
        "scrollY": "200px",
        "scrollCollapse": true,
    });

    $('#cronogramagrid').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        },
        "scrollY": "200px",
        "scrollCollapse": true,
    });
    $('#citagrid').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        },
        "scrollY": "200px",
        "scrollCollapse": true,
    });
    $('#licenciagrid').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
        },
        "scrollY": "200px",
        "scrollCollapse": true,
    });

    $('.dataTables_length').addClass('bs-select');
});