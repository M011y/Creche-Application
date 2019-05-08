$("#applicantdropdown").on('change', function () {
    applicantID = $(this).children("option:selected").val();
    $.ajax({
        url: '/data/Applicant/' + applicantID,
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Something went wrong!");
        },
        success: function (data) {
            $('#cfirstname').html(data.cFirstName);
            $('#clastname').html(data.cLastName);
        }

    });

});