window.JsInteropDatepicker = function () {
    //$("#datepickertest").datepicker({
    //    dateFormat: "yy/mm/dd",
    //    minDate: 0,
    //    constrainInput: false,
    //    changeMonth: true,
    //    changeYear: true,
    //    onSelect: function (selectedDate) {
    //        var myElement = document.getElementById('datepickertest');
    //        myElement.value = selectedDate;
    //        var event = new Event('change');
    //        myElement.dispatchEvent(event);

    //        $(this).datepicker("hide");
    //    },
    //});
    $("#datepicker_planstart").datepicker({
        dateFormat: "dd/mm/yy",
        
        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('datepicker_planstart');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#datepicker_actualstart").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('datepicker_actualstart');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#datepicker_plansdone").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('datepicker_plansdone');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#datepicker_actualdone").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('datepicker_actualdone');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#date_1").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('date_1');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#date_2").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('date_2');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#date_3").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('date_3');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#date_4").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('date_4');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#date_5").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('date_5');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#date_6").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('date_6');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#date_7").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('date_7');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#date_7").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('date_7');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#date_8").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('date_8');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#date_9").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('date_9');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#date_10").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('date_10');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });
    $("#date_11").datepicker({
        dateFormat: "dd/mm/yy",

        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate, evnt) {
            var myElement = document.getElementById('date_11');
            myElement.value = selectedDate;
            var event = new Event('change');
            myElement.dispatchEvent(event);
            $(this).datepicker("hide");
        }

    });

}