var addVragenlijstViewModel;

function Vraag(beschrijving) {
    var self = this;

    // observable are update elements upon changes, also update on element data changes [two way binding]
    self.Beschrijving = ko.observable(beschrijving);
}

function Vragenlijst() {
    var self = this;

    self.Id;
    self.Titel = ko.observable();

    // observable arrays are update binding elements upon array changes
    self.vragen = ko.observableArray([]);

    self.addVraag = function () {
        self.vragen.push(new Vraag(""));
    };

    self.addVragenlijst = function () {
        var dokterId = document.getElementById("dokterId").value;

        var dataObject = ko.toJSON({ Beschrijving: self.Titel, Dokter_Id: dokterId });

        $.ajax({
            url: '/api/vragenlijst',
            type: 'post',
            data: dataObject,
            contentType: 'application/json',
            success: function (data) {
                ko.utils.arrayForEach(self.vragen(), function (vraag) {
                    var vraagObject = ko.toJSON(
                        { Beschrijving: vraag.Beschrijving, Vragenlijst_Id: data.Id });

                    $.ajax({
                        url: '/api/vraag',
                        type: 'post',
                        data: vraagObject,
                        contentType: 'application/json',
                        success: function (data) {
                        }
                    });
                })
                window.location.href = 'Index';
            }
        });
    }
};


// create index view view model which contains model for partial view
addVragenlijstViewModel = { addVragenlijstViewModel: new Vragenlijst() };

// on document ready
$(document).ready(function () {

    // bind view model to referring view
    ko.applyBindings(addVragenlijstViewModel);

    addVragenlijstViewModel.addVragenlijstViewModel.addVraag();
});