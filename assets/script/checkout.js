const btnUsingCoupon = document.getElementById('use-coupon-btn');

if (btnUsingCoupon) {
    btnUsingCoupon.addEventListener('click', function () {
        const name = document.querySelector('input[name="name"]').value;
        const email = document.querySelector('input[name="email"]').value;
        const phone = document.querySelector('input[name="phone"]').value;
        const address = document.querySelector('input[name="address"]').value;
        const city = document.querySelector('select[name="city"]').value;
        const district = document.querySelector('select[name="district"]').value;
        const ward = document.querySelector('select[name="ward"]').value;
        const paymentMethod = document.querySelector('input[name="payment"]:checked').value;
        const couponCode = document.querySelector('input[name="couponCode"]').value; // Assuming you have an input for the coupon code

        const form = document.createElement('form');
        form.action = 'handleUsingCoupon.aspx'; 
        form.method = 'POST';

        const inputs = [
            { name: 'name', value: name },
            { name: 'email', value: email },
            { name: 'phone', value: phone },
            { name: 'address', value: address },
            { name: 'city', value: city },
            { name: 'district', value: district },
            { name: 'ward', value: ward },
            { name: 'payment', value: paymentMethod },
            { name: 'couponCode', value: couponCode } 
        ];

        inputs.forEach(input => {
            const hiddenInput = document.createElement('input');
            hiddenInput.type = 'hidden';
            hiddenInput.name = input.name;
            hiddenInput.value = input.value;
            form.appendChild(hiddenInput);
        });

        document.body.appendChild(form);
        form.submit();
    });
}
