window.onload = function () {

    function sliders() {
        var slides = [
        {
            title: 'Darko-page01',
            img: '10-28.jpg'
        },
        {
            title: 'Darko-page02',
            img: '10-29.jpg'
        },
        {
            title: 'Darko-page03',
            img: '10-30.jpg'
        },
        {
            title: 'Darko-page04',
            img: '10-31.jpg'
        },
        ];

        var post = {
            slides: slides
        }

        var sliderTemplate = document.getElementById('slider-template').innerHTML;
        var handlebarsTemplate = Handlebars.compile(sliderTemplate);
        document.getElementById('slider-root').innerHTML = handlebarsTemplate(post);

    }

    function cool() {
        $.fn.coolSlider = function () {
            $container = this;
            $container.addClass('cool-slider');
            $slideElements = $container.find('.slide-element');
            $slideElements.hide();
            currentSlideIndex = 0;
            $($slideElements[currentSlideIndex]).show();

            var leftBtnTop = document.createElement('button');
            var rightBtnTop = document.createElement('button');

            var leftBtnBottom = document.createElement('button');
            var rightBtnBottom = document.createElement('button');

            leftBtnTop.className = 'coolBtn leftBtn';
            rightBtnTop.className = 'coolBtn rightBtn';

            leftBtnBottom.className = 'coolBtn leftBtn bottomBtn';
            rightBtnBottom.className = 'coolBtn rightBtn bottomBtn';
                 
            $container.on('click', '.leftBtn', function () {
                if (currentSlideIndex > 0) {
                    $($slideElements[currentSlideIndex]).fadeOut();
                    currentSlideIndex--;
                    $($slideElements[currentSlideIndex]).fadeIn();
                }
            });

            $container.on('click', '.rightBtn', function () {
                if (currentSlideIndex < $slideElements.length - 1) {
                    $($slideElements[currentSlideIndex]).fadeOut();
                    currentSlideIndex++;
                    $($slideElements[currentSlideIndex]).fadeIn();
                }
            });

            $container[0].appendChild(leftBtnTop);
            $container[0].appendChild(rightBtnTop);

            $container[0].appendChild(leftBtnBottom);
            $container[0].appendChild(rightBtnBottom);

            return this;
        }

        $('#slider').coolSlider();
    }

    sliders();
    cool();
}