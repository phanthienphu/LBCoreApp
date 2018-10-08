var productController = function () {
    this.Initialize = function () {
        LoadCategory();
        LoadData();
        RegisterEvents();
    }

    function RegisterEvents() {
        //todo: binding events to controls
        $('#ddlShowPage').on('change', function () {
            common.configs.pageSize = $(this).val();
            common.configs.pageIndex = 1;
            LoadData(true);
        });

        $('#btnSearch').on('click', function () {
            LoadData();
        });

        $('#txtKeyword').on('keypress', function (e) {
            if (e.which === 13) {
                //e.preventDefault();
                LoadData();
            }
        });
    }

    function LoadCategory() {
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAllCategories',
            dataType: 'json',
            success: function (response) {
                var render = "<option value=''>------Chọn danh mục------</option>";
                $.each(response, function (i, item) {
                    render += "<option value=' " + item.Id + " ' >" + item.Name + "</option>"
                });
                $('#ddlCategorySearch').html(render);
            },
            error: function (status) {
                console.log(status);
                common.notify('Cannot loading product category data!', 'error');
            }
        })
    }

    function LoadData(isPageChanged) {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAllPaging',
            data: {
                categoryId: $('#ddlCategorySearch').val(),
                keyword: $('#txtKeyword').val(),
                page: common.configs.pageIndex,
                pageSize: common.configs.pageSize
            },
            dataType: 'json',
            success: function (response) {
                $.each(response.Results, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Name,
                        Name: item.Name,
                        Image: item.Image === null ? '<img src="/admin-side/images/user.png" width=25' : '<img src="' + item.Image + '" width = 25',
                        CategoryName: item.ProductCategory.Name,
                        Price: common.formatNumber(item.Price, 0),
                        CreatedDate: common.dateTimeFormatJson(item.DateCreated),
                        Status: common.getStatus(item.Status)
                    });
                    $('#lblTotalRecords').text(response.RowCount);
                    if (render !== '') {
                        $('#tbl-Content').html(render);
                    }
                    wrapPaging(response.RowCount, function () {
                        LoadData();
                    }, isPageChanged)
                });
            },
            error: function (status) {
                console.log(status);
                common.notify('Cannot loading data!', 'error');
            }
        })
    }

    function wrapPaging(recordCount, callBack, changePageSize) {
        var totalsize = Math.ceil(recordCount / common.configs.pageSize);
        //Unbind pagination if it existed or click change pagesize
        if ($('#paginationUL a').length === 0 || changePageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData("twbs-pagination");
            $('#paginationUL').unbind("page");
        }
        //Bind Pagination Event
        $('#paginationUL').twbsPagination({
            totalPages: totalsize,
            visiblePages: 7,
            first: 'Đầu',
            prev: 'Trước',
            next: 'Tiếp',
            last: 'Cuối',
            onPageClick: function (event, p) {
                if (common.configs.pageIndex !== p) {
                    common.configs.pageIndex = p;
                    setTimeout(callBack(), 200);
                }
            }
            //onPageClick: function (event, p) {
            //    common.configs.pageIndex = p;
            //    setTimeout(callBack(), 200);
            //}
        });
    }
}