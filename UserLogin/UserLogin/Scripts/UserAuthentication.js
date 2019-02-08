

//$(document).ready(function () {
//    $('#login').click(function () {

//        window.location.href = 'Home/Index';

//    });

//});
//    $(document).ready(function () {
//    $('#login').click(function () {
//        $.ajax({
//            type: 'GET',
//            url: 'http://localhost:50618/api/Values?username=' + $('#username').val() + '&password=' + $('#password').val(),
//            dataType: 'json',
//            success: function (data) {
//                if (data === "Welcome") {
//                    window.location.href = 'Home/Welcome';
                    
//                }
//                else {
//                    alert("SomeThing went wrong \n" + data);
//                }
//                //var json = $.parseJSON(data); // create an object with the key of the array
//                //alert(data.upassword + ' ' + $('#password').val());
//                /*if (data.upassword === $('#password').val()) {
//                    window.location.href = 'Home/Homepage';
//                }
//                else {
//                    alert('Error');
//                }*/
//            },
//            error: function (data) {
//                var json = $.parseJSON(data);
//                alert(json.error);
//            }

//        });
//        //alert($('#username').val())
//    });
//});



$(document).ready(function () {
    $('#login').click(function () {
        $.ajax({
            type: 'GET',
            url: 'http://localhost:50618/api/Values',
            headers: { 'Authorization': 'Basic ' + btoa(username + ':' + password) }, 
                //? username = ' + $('#username').val()+' & password='+$('#password').val(),
            dataType: 'json',
            success: function (data) {
                if (data === "Welcome")
                    window.location.href = 'Home/Welcome';
            },
            error: function (data) {
                var json = $.parseJSON(data);
                alert(json.error);
            }

        });
        //alert($('#username').val())
    });
});
