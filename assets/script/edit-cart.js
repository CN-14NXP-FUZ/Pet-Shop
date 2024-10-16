const listBtnDecrease = document.querySelectorAll('.btn-decrease');
const listBtnIncrease = document.querySelectorAll('.btn-increase');
const listQuantityInput = document.querySelectorAll('.quantity-input');
console.log(listBtnDecrease);
console.log(listBtnIncrease);
console.log(listQuantityInput);
if (listBtnDecrease) {
    listBtnDecrease.forEach(btn => {
        btn.addEventListener('click', () => {
            var productId = btn.getAttribute('data-product-id');
            let quantityInput = document.querySelector(`input[data-product-id=${productId}]`);
            let currentValue = parseInt(quantityInput.value);
            console.log(quantityInput);

            if (quantityInput && currentValue > 1) {
                currentValue--;
                quantityInput.value = currentValue;
            }
        })
    })
}

if (listBtnIncrease) {
    listBtnIncrease.forEach(btn => {
        btn.addEventListener('click', () => {
            var productId = btn.getAttribute('data-product-id');
            let quantityInput = document.querySelector(`input[data-product-id=${productId}]`);
            let currentValue = parseInt(quantityInput.value);
            let maxValue = parseInt(quantityInput.max);
            console.log(quantityInput);
            console.log(maxValue);

            if (currentValue + 1 <= maxValue) {
                currentValue++;
                quantityInput.value = currentValue;
            }
        })
    })
}


const listBtnDelete = document.querySelectorAll('.delete-btn');
console.log("Deleted");
console.log(listBtnDelete);
if (listBtnDelete) {
    listBtnDelete.forEach(btn => {
        btn.addEventListener("click", () => {
            let productId = btn.getAttribute('data-product-id');
            let quantityInput = (document.querySelector(`input[data-product-id=${productId}]`)).value;
            const listProduct = document.querySelector('.list-product-item');
            
            const productRow = Array.from(listProduct.querySelectorAll('tr')).find(row => {
                return row.getAttribute('data-product-id') === productId;
            });

            if (productRow) {
                // Tạo form
                const form = document.createElement('form');
                form.action = 'deleted-product-incart.aspx';
                form.method = 'POST';

                const inputId = document.createElement('input');
                inputId.type = 'hidden';
                inputId.name = 'id';
                inputId.value = productId;
                form.appendChild(inputId);


                const inputId2 = document.createElement('input');
                inputId2.type = 'hidden';
                inputId2.name = 'quantity';
                inputId2.value = quantityInput;
                form.appendChild(inputId2);

                document.body.appendChild(form);
                form.submit();
            } 

        })
    })
}

