window.onload = function () {
    'use strict';

    function addEventListener(selector, eventName, listener) {
        document.querySelector(selector).addEventListener(eventName, listener, false);
    }

    var textEl = document.querySelector('#text');
    textEl.style.color = 'blue';
    textEl.style.backgroundColor = 'green';

    addEventListener('#text-color', 'change', function (event) {
        textEl.style.color = event.target.value;
    });

    addEventListener('#bg-color', 'change', function (event) {
        textEl.style.backgroundColor = event.target.value;
    });
};