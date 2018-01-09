
    //$(document).ready is used to define a function that is guaranteed to be called only after the DOM has been initialized.
    $(document).ready(function () {
        //Hide the div
        if (Route::currentRouteName()!=="Index") { $(".date-show-hide").hide();}
        
        //conversely do the following to show it again if needed later
        //$('#showdiv').show();
    });
    