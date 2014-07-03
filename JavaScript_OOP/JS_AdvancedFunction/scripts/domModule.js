
////Create a module for working with DOM. The module should have the following functionality
////Add DOM element to parent element given by selector
////Remove element from the DOM  by given selector
////Attach event to given selector by given event type and event hander
////Add elements to buffer, which appends them to the DOM when their count for some selector becomes 100
////The buffer contains elements for each selector it gets
////Get elements by CSS selector
////The module should reveal only the methods


var domModule = function () {

    var buffer = {},
        MAX_BUFFER_SIZE = 100;

    var addElement = function (parentSelector, element) {

        var parent = document.querySelector(parentSelector);

        parent.appendChild(element);
    }

    var removeElement = function (parentSelector, element) {

        var parent = document.querySelectorAll(parentSelector),            
            parentLength = parent.length,
            child,
            i;

        for (i = 0; i < parentLength; i++) {
            child = parent[i].querySelector(element);
            parent[i].removeChild(child);
        }
        
    }

    var addEventHandler = function (selector, eventType, eventHandler) {

        var elements = document.querySelectorAll(selector),
            elemntsLength = elements.length,
            i;

        for (i = 0; i < elemntsLength; i++) {
            if (elements[i].addEventListener)
            {
            elements[i].addEventListener(eventType, eventHandler, false);
            }
            else
            {
                elements.attachEvent("on" + eventType, eventHandler);
            }
        }
    }

    var addToBuffer = function (parentSelector, element) {

        var parent = document.querySelector(parentSelector);

        if (!buffer[parentSelector]) {
            buffer[parentSelector] = document.createDocumentFragment();
        }

        buffer[parentSelector].appendChild(element);

        if (buffer[parentSelector].childNodes.length === MAX_BUFFER_SIZE) {
            parent.appendChild(buffer[parentSelector]);
            buffer[parentSelector] = null;
        }        
    }
        
    return {
        addElement: addElement,
        removeElement: removeElement,
        addEventHandler: addEventHandler,
        addToBuffer: addToBuffer        
    };
}();