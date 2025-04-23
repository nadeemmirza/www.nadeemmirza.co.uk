// Wait for the DOM to be fully loaded
document.addEventListener('DOMContentLoaded', function () {
    console.log('Static Web App loaded successfully!');

    // Add smooth scrolling to all links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            e.preventDefault();

            const target = document.querySelector(this.getAttribute('href'));
            if (target) {
                window.scrollTo({
                    top: target.offsetTop - 70,
                    behavior: 'smooth'
                });
            }
        });
    });

    // Add animation to features on scroll
    const featureCards = document.querySelectorAll('.feature-card');

    if (featureCards.length > 0) {
        window.addEventListener('scroll', function () {
            featureCards.forEach(card => {
                const cardPosition = card.getBoundingClientRect().top;
                const screenPosition = window.innerHeight / 1.3;

                if (cardPosition < screenPosition) {
                    card.style.opacity = '1';
                }
            });
        });

        // Set initial opacity for animation
        featureCards.forEach(card => {
            card.style.opacity = '0';
            card.style.transition = 'opacity 0.5s ease-in-out';
        });
    }
});