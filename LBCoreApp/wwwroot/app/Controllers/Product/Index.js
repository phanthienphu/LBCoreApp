var productController = function () {
    this.Initialize = function () {
        LoadData();
    }

    function RegisterEvents() {
        //todo: binding events to controls
    }

    function LoadData() {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAll',
            dataType: 'json',
            success: function (response) {
                $.each(response, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Name,
                        Name: item.Name,
                        Image: item.Image == null ? '<img src="/admin-side/images/user.png" width=25' : '<img src="' + item.Image + '" width = 25',
                        CategoryName: item.ProductCategory.Name,
                        Price: common.formatNumber(item.Price, 0),
                        CreatedDate: common.dateTimeFormatJson(item.DateCreated),
                        Status: common.getStatus(item.Status)
                    });
                    if (render != '') {
                        $('#tbl-Content').html(render);
                    }
                });
            },
            error: function (status) {
                console.log(status);
                common.notify('Cannot loading data!','error');
            }
        })
    }
}