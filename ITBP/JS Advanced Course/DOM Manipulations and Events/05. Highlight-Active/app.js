function focused() {
    var inputFields = document.querySelectorAll('input');

    inputFields.forEach(function(input) {
        input.addEventListener('focus', function() {
            var div = input.parentElement;
            div.classList.add('focused');
        });

        input.addEventListener('blur', function() {
            var div = input.parentElement;
            div.classList.remove('focused');
        });
    });
}
