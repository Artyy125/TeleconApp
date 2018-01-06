$(function () {
    $("#SplicerDate").datepicker({
        maxDate: 0
    });
});
$('#SplicerTime').timepicker({
    maxHours: 24,
    minuteStep: 1,
    showSeconds: false,
    showMeridian: false,
    showInputs: false,
    template: 'modal',
    defaultTime: false
});
$('#SplicerEnterTime').timepicker({
    maxHours: 24,
    minuteStep: 1,
    showSeconds: false,
    showMeridian: false,
    showInputs: false,
    template: 'modal',
    defaultTime: false
});
$('#SplicerTime').timepicker({
    maxHours: 24,
    minuteStep: 1,
    showSeconds: false,
    showMeridian: false,
    showInputs: false,
    template: 'modal',
    defaultTime: false
});
$("#SplicerCable1").keyup(function () {
    if ($("#SplicerCable1").val().length > 0) {
        $(".SplicerCable1").prop("disabled", false);
    }
    else {
        $(".SplicerCable1").prop("disabled", true);
        $(".SplicerCable1").prop('checked', false);
        $('#SplicerNoFibre1').val('');
    }
});
$("#SplicerCable2").keyup(function () {
    if ($("#SplicerCable2").val().length > 0) {
        $(".SplicerCable2").prop("disabled", false);
    }
    else {
        $(".SplicerCable2").prop("disabled", true);
        $(".SplicerCable2").prop('checked', false);
        $('#SplicerNoFibre2').val('');
    }
});
$("#SplicerCable3").keyup(function () {
    if ($("#SplicerCable3").val().length > 0) {
        $(".SplicerCable3").prop("disabled", false);
    }
    else {
        $(".SplicerCable3").prop("disabled", true);
        $(".SplicerCable3").prop('checked', false);
        $('#SplicerNoFibre3').val('');
    }
});
$("#SplicerCable4").keyup(function () {
    if ($("#SplicerCable4").val().length > 0) {
        $(".SplicerCable4").prop("disabled", false);
    }
    else {
        $(".SplicerCable4").prop("disabled", true);
        $(".SplicerCable4").prop('checked', false);
        $('#SplicerNoFibre4').val('');
    }
});
$("#SplicerCable5").keyup(function () {
    if ($("#SplicerCable5").val().length > 0) {
        $(".SplicerCable5").prop("disabled", false);
    }
    else {
        $(".SplicerCable5").prop("disabled", true);
        $(".SplicerCable5").prop('checked', false);
        $('#SplicerNoFibre5').val('');
    }
});
$("#SplicerCable6").keyup(function () {
    if ($("#SplicerCable6").val().length > 0) {
        $(".SplicerCable6").prop("disabled", false);
    }
    else {
        $(".SplicerCable6").prop("disabled", true);
        $(".SplicerCable6").prop('checked', false);
        $('#SplicerNoFibre6').val('');
    }
});
$("#SplicerCable7").keyup(function () {
    if ($("#SplicerCable7").val().length > 0) {
        $(".SplicerCable7").prop("disabled", false);
    }
    else {
        $(".SplicerCable7").prop("disabled", true);
        $(".SplicerCable7").prop('checked', false);
        $('#SplicerNoFibre7').val('');
    }
});
$("#STARB1").keyup(function () {
    if ($("#STARB1").val().length > 0) {
        $(".STARB1").prop("disabled", false);
    }
    else {
        $(".STARB1").prop("disabled", true);
        $(".STARB1").prop('checked', false);
    }
});
$("#STARB2").keyup(function () {
    if ($("#STARB2").val().length > 0) {
        $(".STARB2").prop("disabled", false);
    }
    else {
        $(".STARB2").prop("disabled", true);
        $(".STARB2").prop('checked', false);
    }
});
$("#STARB3").keyup(function () {
    if ($("#STARB3").val().length > 0) {
        $(".STARB3").prop("disabled", false);
    }
    else {
        $(".STARB3").prop("disabled", true);
        $(".STARB3").prop('checked', false);
    }
});
$("#STARB4").keyup(function () {
    if ($("#STARB4").val().length > 0) {
        $(".STARB4").prop("disabled", false);
    }
    else {
        $(".STARB4").prop("disabled", true);
        $(".STARB4").prop('checked', false);
    }
});
$("#STARB5").keyup(function () {
    if ($("#STARB5").val().length > 0) {
        $(".STARB5").prop("disabled", false);
    }
    else {
        $(".STARB5").prop("disabled", true);
        $(".STARB5").prop('checked', false);
    }
});
$("#STARB6").keyup(function () {
    if ($("#STARB6").val().length > 0) {
        $(".STARB6").prop("disabled", false);
    }
    else {
        $(".STARB6").prop("disabled", true);
        $(".STARB6").prop('checked', false);
    }
});
$("#STARB7").keyup(function () {
    if ($("#STARB7").val().length > 0) {
        $(".STARB7").prop("disabled", false);
    }
    else {
        $(".STARB7").prop("disabled", true);
        $(".STARB7").prop('checked', false);
    }
});
$(function () {
    $('.multiselect-ui').multiselect({
        includeSelectAllOption: true
    });
});
