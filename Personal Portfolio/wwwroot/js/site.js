document.addEventListener('DOMContentLoaded', function () {
    // Using an object to keep track of slide indices for each modal
    var slideIndex = {};

    // Initialize slide indices and show the first slide for each modal
    document.querySelectorAll('.popup-modal').forEach(function (modal) {
        var modalId = modal.id;
        slideIndex[modalId] = 1; // Explicitly initialize slide index for each modal
        showSlides(1, modalId); // Show the first slide for each modal
    });

    window.plusSlides = function (n, modalId) {
        showSlides(slideIndex[modalId] += n, modalId);
    }

    window.currentSlide = function (n, modalId) {
        showSlides(slideIndex[modalId] = n, modalId);
    }

    function showSlides(n, modalId) {
        var slidesSelector = "#" + modalId + " .mySlides";
        var dotsSelector = "#" + modalId + " .dot";
        var slides = document.querySelectorAll(slidesSelector);
        var dots = document.querySelectorAll(dotsSelector);

        if (n > slides.length) { slideIndex[modalId] = 1; }
        if (n < 1) { slideIndex[modalId] = slides.length; }
        for (var i = 0; i < slides.length; i++) {
            slides[i].style.display = "none";
        }
        for (var i = 0; i < dots.length; i++) {
            dots[i].className = dots[i].className.replace(" active", "");
        }
        if (slides.length > 0 && dots.length > 0) {
            slides[slideIndex[modalId] - 1].style.display = "block";
            dots[slideIndex[modalId] - 1].className += " active";
        }
    }
});

