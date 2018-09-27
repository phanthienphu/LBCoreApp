var ProductCategoryController = function(){
    this.initialize = function () {
        LoadData();
    }

    function LoadData() {
        $.ajax({
            url: '/Admin/ProductCategory/GetAll',
            dataType: 'json',
            success: function (response) {
                var data = [];
                $.each(response, function (i, item) {
                    data.push({
                        id: item.id,
                        text: item.Name,
                        parentId: item.ParentId,
                        sortOrder: item.SortOrder
                    });
                });
                var treeArr = common.unflattern(data);

                //var $tree = $('#treeProductCategory');

                $('#treeProductCategory').tree({
                    data: treeArr,
                    dnd: true
                });
            }
        });
    }
}