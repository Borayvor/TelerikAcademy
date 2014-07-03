window.onload = function () {

    $('<button>').text('Test').on('click', testFunctionality).appendTo('body');

    var $theDiv = $('<div>').text('THE DIV').prependTo('body');

    function insertBefore(sibling, insertedElement) {
        $(sibling).prepend($(insertedElement));
    }

    function insertAfter(sibling, insertedElement) {
        $(sibling).append($(insertedElement));
    }

    function testFunctionality() {        

        var $newElement = $('<div>').text('Insert Before.');
        insertBefore($theDiv, $newElement);

        $newElement = $('<div>').text('Insert After.');
        insertAfter($theDiv, $newElement);
    }
}