var cart = {
    init: function () {
        cart.regEvents();
        
    },
    
    regEvents: function () {
        
        
        $('#btnAdd').off('click').on('click', function () {
            window.location.href = "/";
        });
        $('#btnContinue').off('click').on('click', function () {
            window.location.href = "/";
        });
        $('#btnPayment').off('click').on('click', function () {
            window.location.href = "/Cart/Payment";
        });

        $('#btnUpdate').off('click').on('click', function (e) {
            e.preventDefault();
            var listProduct = $('.txtQuantity');
            var cartList = [];
            $.each(listProduct, function (i, item) {
                cartList.push({
                    SP: {
                        MaSp: $(item).data('id')
                    },
                    SoLuong: $(item).val()
                });
            });
            $.ajax({
                data: { id: JSON.stringify(cartList) },
                url: '/Cart/Update',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {

                        window.location.href = "/Cart/Index";
                    }
                    else {
                        location.reload();
                        alert("Cập nhật thất bại, số lượng sản phẩm tồn kho không đủ!")
                    }
                }
            })
        });

        $('#btnDeleteAll').off('click').on('click', function () {


            $.ajax({
                url: '/Cart/DeleteAll',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/Cart/Index";
                    }
                }
            })
        });

        $('.btn-delete').off('click').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                data: { id: $(this).data('id') },
                url: '/Cart/Delete',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {

                        window.location.href = "/Cart/Index";
                    }
                }
            })
        });


    }
}
cart.init();