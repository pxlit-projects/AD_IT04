var verstuurVragenlijstViewModel;

function patientMantelzorger(id, vnaam, anaam, email) {
    var self = this;

    self.Id = id;
    self.Vnaam = ko.observable(vnaam);
    self.Anaam = ko.observable(anaam);
    self.Email = ko.observable(email);

    self.getId = function () {
        return self.Id;
    }
}

function vragenlijst(id, beschrijving) {
    var self = this;

    self.Id = id;
    self.Beschrijving = ko.observable(beschrijving);

    self.getId = function () {
        return self.Id;
    }
}

function verstuurTemplate() {
    var self = this;

    // observable are update elements upon changes, also update on element data changes [two way binding]
    self.Patienten = ko.observableArray([]);
    self.Mantelzorgers = ko.observableArray([]);
    self.Vragenlijsten = ko.observableArray([]);
    self.selectedPatient = ko.observable();
    self.selectedMantelzorger = ko.observable();
    self.selectedVragenlijst = ko.observable();

    self.getValues = function () {
        $.getJSON('/api/patientmantelzorger/1/false', function (data) {
            $.each(data, function (key, value) {
                self.Patienten.push(new patientMantelzorger(value.Id, value.Vnaam, value.Anaam, value.Email));
            });
        });

        $.getJSON('/api/patientmantelzorger/1/true', function (data) {
            $.each(data, function (key, value) {
                self.Mantelzorgers.push(new patientMantelzorger(value.Id, value.Vnaam, value.Anaam, value.Email));
            });
        });

        $.getJSON('/api/vragenlijst/1', function (data) {
            $.each(data, function (key, value) {
                self.Vragenlijsten.push(new vragenlijst(value.Id, value.Beschrijving));
            });
        });
    }

    self.verstuur = function () {
        var patient = self.selectedPatient();
        var mantelzorger = self.selectedMantelzorger();
        var vragenlijst = self.selectedVragenlijst();
        var dokterId = document.getElementById("dokterId").value;
        var rapportId;

        var dataObject = ko.toJSON({
            Patient_Id: patient.Id,
            Mantelzorger_Id: mantelzorger.Id,
            Vragenlijst_Id: vragenlijst.Id,
            Dokter_Id: dokterId,
            Date: getDate()
        });

        function ajax1() {
            return $.ajax({
                url: '/api/rapport',
                type: 'post',
                data: dataObject,
                contentType: 'application/json',
                success: function (data) {
                    console.log("Rapport_Id: " + data.Id)
                    rapportId = data.Id;
                }
            });
        }

        $.when(ajax1()).done(function (a1, a2, a3, a4) {
            var data = "{'patientId': '" + patient.Id
               + "', 'mantelzorgerId': '" + mantelzorger.Id
               + "', 'rapportId': '" + rapportId
               + "', 'vragenlijstId': '" + vragenlijst.Id + "'}";

            return $.ajax({
                type: "post",
                url: "VragenlijstVersturenMVC/_SendMessage",
                data: data,
                contentType: "application/json; charset=utf-8",
                dataType: "json"
            });
        })

        window.location.href = 'VragenlijstVersturenMVC/VragenlijstVerstuurd' +
               '?patientNaam=' + patient.Vnaam() + ' ' + patient.Anaam() +
               '&mantelzorgerNaam=' + mantelzorger.Vnaam() + ' ' + mantelzorger.Anaam() +
               '&vragenlijstBeschrijving=' + vragenlijst.Beschrijving();
    };
}

// create index view view model 
verstuurVragenlijstViewModel = { verstuurVragenlijstViewModel: new verstuurTemplate() };

// on document ready
$(document).ready(function () {

    // bind view model to referring view
    ko.applyBindings(verstuurVragenlijstViewModel);

    // load student data
    verstuurVragenlijstViewModel.verstuurVragenlijstViewModel.getValues();
});

function getDate() {
    var today = new Date();
    var DD = today.getDate();
    var MM = today.getMonth() + 1; //January is 0!
    var YYYY = today.getFullYear();
    var hh = today.getHours();
    var mm = today.getMinutes();
    var ss = today.getSeconds();

    if (DD < 10) {
        DD = '0' + DD;
    }

    if (MM < 10) {
        MM = '0' + MM;
    }

    today = YYYY + "-" + MM + "-" + DD + " " + hh + ":" + mm + ":" + ss;

    return today;
}