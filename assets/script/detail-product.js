const btnAddToCart = document.querySelector('#btnAddToCart');

if (btnAddToCart) {
    btnAddToCart.addEventListener('click', () => {
        // Lấy thông tin sản phẩm
        const productId = document.getElementById("product-id").innerText.trim();
        const quantityInput = document.querySelector("#quantity-product");
        const quantity = quantityInput ? quantityInput.value : 1; 

        console.log(productId, quantity);

        // Tạo form
        const form = document.createElement('form');
        form.action = 'addToCart.aspx';
        form.method = 'POST';

        const inputId = document.createElement('input');
        inputId.type = 'hidden';
        inputId.name = 'id';
        inputId.value = productId;
        form.appendChild(inputId);

        const inputQuantity = document.createElement('input');
        inputQuantity.type = 'hidden';
        inputQuantity.name = 'quantity';
        inputQuantity.value = quantity;
        form.appendChild(inputQuantity);


        document.body.appendChild(form);
        form.submit();


    });
}


const quantityInput = document.getElementById('quantity-product');
const decreaseButton = document.querySelector('.quantity-btn-decrease');
const increaseButton = document.querySelector('.quantity-btn-increase');

if (decreaseButton) {
    decreaseButton.addEventListener('click', () => {
        let currentValue = parseInt(quantityInput.value);
        if (currentValue > 1) { 
            currentValue--;
            quantityInput.value = currentValue;
        }
    });
}

if (increaseButton) {
    increaseButton.addEventListener('click', () => {
        let currentValue = parseInt(quantityInput.value);
        const max = parseInt(quantityInput.max); 

        if (currentValue < max) {
            currentValue++;
            quantityInput.value = currentValue;
        }
    });
}