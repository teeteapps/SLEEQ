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

function companycustomerformvalidation() {
    var cfn = document.getElementById('firstname').value;
    if (cfn == "") {
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
    if (cfn.length <= 2) {
        document.getElementById('firstname').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('firstname').style.borderColor = "green";
    }
    var cln = document.getElementById('lastname').value;
    if (cln == "") {
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
    if (cln.length <= 2) {
        document.getElementById('lastname').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('lastname').style.borderColor = "green";
    }
    var cpn = document.getElementById('phonenumber').value;
    if (cpn == "") {
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
    var cin = document.getElementById('idnumber').value;
    if (cin == "") {
        document.getElementById('idnumber').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('idnumber').style.borderColor = "green";
    }
    if (/^[A-Za-z]+$/.test(document.getElementById("idnumber").value)) {
        document.getElementById('idnumber').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('idnumber').style.borderColor = "green";
    }
    var cea = document.getElementById('emailaddress').value;
    if (cea == "") {
        document.getElementById('emailaddress').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('emailaddress').style.borderColor = "green";
    }
    var cop = document.getElementById('occupation').value;
    if (cop == "") {
        document.getElementById('occupation').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('occupation').style.borderColor = "green";
    }
    if (/^[0-9]+$/.test(document.getElementById("occupation").value)) {
        document.getElementById('occupation').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('occupation').style.borderColor = "green";
    }
    if (cop.length <= 2) {
        document.getElementById('occupation').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('occupation').style.borderColor = "green";
    }
    var crs = document.getElementById('residence').value;
    if (crs == "") {
        document.getElementById('residence').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('residence').style.borderColor = "green";
    }
    if (/^[0-9]+$/.test(document.getElementById("residence").value)) {
        document.getElementById('residence').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('residence').style.borderColor = "green";
    }
    if (crs.length <= 2) {
        document.getElementById('residence').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('residence').style.borderColor = "green";
    }
}

function vehicleownerformvalidation() {
    var cfn = document.getElementById('firstname').value;
    if (cfn == "") {
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
    if (cfn.length <= 2) {
        document.getElementById('firstname').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('firstname').style.borderColor = "green";
    }
    var cln = document.getElementById('lastname').value;
    if (cln == "") {
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
    if (cln.length <= 2) {
        document.getElementById('lastname').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('lastname').style.borderColor = "green";
    }
    var cea = document.getElementById('emailaddress').value;
    if (cea == "") {
        document.getElementById('emailaddress').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('emailaddress').style.borderColor = "green";
    }
    var cpn = document.getElementById('phonenumber').value;
    if (cpn == "") {
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
    var cin = document.getElementById('idnumber').value;
    if (cin == "") {
        document.getElementById('idnumber').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('idnumber').style.borderColor = "green";
    }
    if (/^[A-Za-z]+$/.test(document.getElementById("idnumber").value)) {
        document.getElementById('idnumber').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('idnumber').style.borderColor = "green";
    }
    var cvt = document.getElementById('customertype').value;
    if (cvt == 0) {
        document.getElementById('customertype').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('customertype').style.borderColor = "green";
    }
    var desc = document.getElementById('description').value;
    if (desc == "") {
        document.getElementById('description').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('description').style.borderColor = "green";
    }
    if (/^[0-9]+$/.test(document.getElementById("description").value)) {
        document.getElementById('description').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('description').style.borderColor = "green";
    }
    if (cop.length <= 2) {
        document.getElementById('description').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('description').style.borderColor = "green";
    }
    
}

function companyvehicleformvalidation() {
    var vr = document.getElementById('vehiclereg').value;
    if (vr == "") {
        document.getElementById('vehiclereg').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('vehiclereg').style.borderColor = "green";
    }
    if (vr.length <= 2) {
        document.getElementById('vehiclereg').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('vehiclereg').style.borderColor = "green";
    }

    var ft = document.getElementById('fueltype').value;
    if (ft == "") {
        document.getElementById('fueltype').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('fueltype').style.borderColor = "green";
    }
    if (/^[0-9]+$/.test(document.getElementById("fueltype").value)) {
        document.getElementById('fueltype').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('fueltype').style.borderColor = "green";
    }
    if (cln.length <= 2) {
        document.getElementById('fueltype').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('fueltype').style.borderColor = "green";
    }
    var vc = document.getElementById('color').value;
    if (vc == "") {
        document.getElementById('color').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('color').style.borderColor = "green";
    }
    if (/^[0-9]+$/.test(document.getElementById("color").value)) {
        document.getElementById('color').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('color').style.borderColor = "green";
    }
    if (vc.length <= 2) {
        document.getElementById('color').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('color').style.borderColor = "green";
    }
    var es = document.getElementById('enginesize').value;
    if (es == "") {
        document.getElementById('enginesize').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('enginesize').style.borderColor = "green";
    }
    if (es.length <= 2) {
        document.getElementById('enginesize').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('enginesize').style.borderColor = "green";
    }
    var vcn = document.getElementById('chasenumber').value;
    if (vcn == "") {
        document.getElementById('chasenumber').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('chasenumber').style.borderColor = "green";
    }
    if (vcn.length <= 2) {
        document.getElementById('chasenumber').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('chasenumber').style.borderColor = "green";
    }
  
    var vtc = document.getElementById('vehicletypecode').value;
    if (vtc == 0) {
        document.getElementById('vehicletypecode').style.borderColor = "red";
        return false;
    } else {
        document.getElementById('vehicletypecode').style.borderColor = "green";
    }
}