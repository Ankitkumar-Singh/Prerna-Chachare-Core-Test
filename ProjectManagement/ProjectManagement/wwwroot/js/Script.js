$(document).ready(function () {

    $('#btnDelete').click(function () {
        toastr.success('Deleted successfully.');
    })

    $('#projectForm').submit(function () {
        if ($(this).valid())
            toastr.success("Project added successfully");
        else
            toastr.error("Project couldn't be added");
    })

    $('#projectManagerForm').submit(function () {
        if ($(this).valid())
            toastr.success("Project Manager added successfully");
        else
            toastr.error("Project Manager couldn't be added");
    })
});