$("#Dueño").val($("#Nombre").val() + " " + $("#Apellido").val())
$("#Nombre").change(function () {
    $("#Dueño").val($("#Nombre").val() + " " + $("#Apellido").val())
});
$("#Apellido").change(function () {
    $("#Dueño").val($("#Nombre").val() + " " + $("#Apellido").val())
});