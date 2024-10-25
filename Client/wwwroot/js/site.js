function applyPhoneMask(elementId) {
    var inputElement = document.getElementById(elementId);
    if (inputElement) {
        Inputmask({ "mask": "(999) 999-99-99" }).mask(inputElement);
    }
}