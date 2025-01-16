
var get_id;
function showmessage(id) {
    get_id = id;
    $('#del').modal('show');
}
function confirmdelete() {
    window.location.href = "DeleteCategory?id=" + get_id

}
function confirmdelete2() {
    $.ajax({
        url: 'DeleteCategory',
        type: "get",
        data: { id: get_id },
        success: function (result) {
            window.location.href = "Categories"
        
        }
    
    });

}
function confirmdeleteTable() {
    $.ajax({
        url: 'DeleteTable',
        type: "get",
        data: { id: get_id },
        success: function (result) {
            window.location.href = "TableFootball"

        }

    });

}
function confirmdeleteStadium() {
    $.ajax({
        url: 'DeleteStadium',
        type: "get",
        data: { id: get_id },
        success: function (result) {
            window.location.href = "Stadiums"

        }

    });

}

function confirmdeletehotel() {
    $.ajax({
        url: 'DeleteHotel',
        type: "get",
        data: { id: get_id },
        success: function (result) {
            window.location.href = "Hotels"

        }

    });

}
