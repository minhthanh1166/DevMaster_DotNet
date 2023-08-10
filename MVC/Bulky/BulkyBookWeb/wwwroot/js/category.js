var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $("#tblDataCategory").DataTable({
        responsive: true,
        "ajax": { url:'/admin/category/getall'},
        "columns": [
            { data: 'name' },
            { data: 'displayOrder' },
            {
                data: 'id',
                "render": function (data) {
                    return (
                        `
                        <div class="w-lg-75 btn-group" rore="group">
                            <a class="btn btn-primary me-lg-2" href="/admin/category/edit?id=${data}">
                                <i class="bi bi-pencil-square"></i> Edit
                            </a>
                            <a class="btn btn-danger" onclick=Delete("/admin/category/delete/${data}")>
                                <i class="bi bi-trash"></i> Delete
                            </a>
                        </div>   
                        `
                    )
                }
                ,"width": "15%"
            }
        ]
    });
}


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
            Swal.fire(
                $.ajax({
                    url: url,
                    type: "DELETE",
                    success: function (data) {
                        dataTable.ajax.reload();
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
            )
        }
    })
}
