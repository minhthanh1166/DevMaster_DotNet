var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblDataCompany').DataTable({
        responsive: true,
        "ajax": { url: '/admin/company/getall' },
        "columns": [
            { data: 'name'},
            { data: 'city' },
            { data: 'streetAddress',"width":"30%"},
            { data: 'state'},
            { data: 'phoneNumber'},
            {
                data: 'id',
                "render": function (data) {
                    return (
                        `
                        <div class="w-lg-75 btn-group" rore="group">
                            <a class="btn btn-primary me-lg-2" href="/admin/company/upsert?id=${data}">
                                <i class="bi bi-pencil-square"></i> Edit
                            </a>
                            <a class="btn btn-danger" onclick=Delete("/admin/company/delete/${data}")>
                                <i class="bi bi-trash"></i> Delete
                            </a>
                        </div>   
                        `
                    );
                }
                 ,"width": "15%",
            }
        ]
    });
};


function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: "DELETE",
                success: function (data) {
                    dataTable.ajax.reload();
                    /*toastr.success(data.message);*/
                    if (data.success) {
                        Swal.fire(
                            'Deleted!',
                            `${data.message}`,
                            'success'
                        );
                    } else {
                        Swal.fire(
                            'Deleted!',
                            `${data.message}`,
                            'error'
                        );
                    }
                }
            })
        }
    })
}