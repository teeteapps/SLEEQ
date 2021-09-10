function staffformvalidation() {
    var fn = document.getElementById('firstname').value;
    if (fn == "") {
        document.getElementById('firstname').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('firstname').style.borderColor = "green";
    }
    if (/^[0-9]+$/.test(document.getElementById("firstname").value)) {
        document.getElementById('firstname').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('firstname').style.borderColor = "green";
    }
    if (fn.length <= 2) {
        document.getElementById('firstname').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('firstname').style.borderColor = "green";
    }

    var ln = document.getElementById('lastname').value;
    if (ln == "") {
        document.getElementById('lastname').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('lastname').style.borderColor = "green";
    }
    if (/^[0-9]+$/.test(document.getElementById("lastname").value)) {
        document.getElementById('lastname').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('lastname').style.borderColor = "green";
    }
    if (ln.length <= 2) {
        document.getElementById('lastname').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('lastname').style.borderColor = "green";
    }

    var ea = document.getElementById('emailaddress').value;
    if (ea == "") {
        document.getElementById('emailaddress').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('emailaddress').style.borderColor = "green";
    }
    if (/^[0-9]+$/.test(document.getElementById("emailaddress").value)) {
        document.getElementById('emailaddress').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('emailaddress').style.borderColor = "green";
    }
    if (ea.length <= 2) {
        document.getElementById('emailaddress').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('emailaddress').style.borderColor = "green";
    }

    var pn = document.getElementById('phonenumber').value;
    if (pn == "") {
        document.getElementById('phonenumber').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('phonenumber').style.borderColor = "green";
    }
    if (/^[A-Za-z]+$/.test(document.getElementById("phonenumber").value)) {
        document.getElementById('phonenumber').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('phonenumber').style.borderColor = "green";
    }
    if (pn.length <= 2) {
        document.getElementById('phonenumber').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('phonenumber').style.borderColor = "green";
    }

    var rc = document.getElementById('rolecode').value;
    if (rc == 0) {
        document.getElementById('rolecode').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('rolecode').style.borderColor = "green";
    }
}

function vehicletypeformvalidation() {
    var tn = document.getElementById('typename').value;
    if (tn == "") {
        document.getElementById('typename').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('typename').style.borderColor = "green";
    }
    if (/^[0-9]+$/.test(document.getElementById("typename").value)) {
        document.getElementById('typename').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('typename').style.borderColor = "green";
    }
    if (tn.length <= 2) {
        document.getElementById('typename').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('typename').style.borderColor = "green";
    }

    var cp = document.getElementById('capacity').value;
    if (cp == 0) {
        document.getElementById('capacity').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('capacity').style.borderColor = "green";
    }

    var ct = document.getElementById('cartype').value;
    if (ct == 0) {
        document.getElementById('capacity').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('capacity').style.borderColor = "green";
    }
}


function vehiclehiretermsformvalidation() {
    var mp = document.getElementById('mondayprice').value;
    if (mp == "") {
        document.getElementById('mondayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('mondayprice').style.borderColor = "green";
    }
    if (/^[A-Za-z]+$/.test(document.getElementById("mondayprice").value)) {
        document.getElementById('mondayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('mondayprice').style.borderColor = "green";
    }

    var tp = document.getElementById('tuesdayprice').value;
    if (tp == "") {
        document.getElementById('tuesdayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('tuesdayprice').style.borderColor = "green";
    }
    if (/^[A-Za-z]+$/.test(document.getElementById("tuesdayprice").value)) {
        document.getElementById('tuesdayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('tuesdayprice').style.borderColor = "green";
    }

    var wp = document.getElementById('wednesdayprice').value;
    if (wp == "") {
        document.getElementById('wednesdayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('wednesdayprice').style.borderColor = "green";
    }
    if (/^[A-Za-z]+$/.test(document.getElementById("wednesdayprice").value)) {
        document.getElementById('wednesdayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('wednesdayprice').style.borderColor = "green";
    }

    var thp = document.getElementById('thursdayprice').value;
    if (thp == "") {
        document.getElementById('thursdayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('thursdayprice').style.borderColor = "green";
    }
    if (/^[A-Za-z]+$/.test(document.getElementById("thursdayprice").value)) {
        document.getElementById('thursdayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('thursdayprice').style.borderColor = "green";
    }

    var fp = document.getElementById('fridayprice').value;
    if (fp == "") {
        document.getElementById('fridayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('fridayprice').style.borderColor = "green";
    }
    if (/^[A-Za-z]+$/.test(document.getElementById("fridayprice").value)) {
        document.getElementById('fridayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('fridayprice').style.borderColor = "green";
    }

    var sp = document.getElementById('saturdayprice').value;
    if (sp == "") {
        document.getElementById('saturdayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('saturdayprice').style.borderColor = "green";
    }
    if (/^[A-Za-z]+$/.test(document.getElementById("saturdayprice").value)) {
        document.getElementById('saturdayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('saturdayprice').style.borderColor = "green";
    }

    var sup = document.getElementById('sundayprice').value;
    if (sup == "") {
        document.getElementById('sundayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('sundayprice').style.borderColor = "green";
    }
    if (/^[A-Za-z]+$/.test(document.getElementById("sundayprice").value)) {
        document.getElementById('sundayprice').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('sundayprice').style.borderColor = "green";
    }
}