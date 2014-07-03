function useQuerySelectorAll() {

    var bodyItems = document.querySelectorAll('body div > div');

    for (var i = 0; i < bodyItems.length; i++) {

        console.log(bodyItems[i].innerHTML);
        console.log("count = " + i);
    }
}

function useGetElementsByTagName() {
    var bodyItems = document.getElementsByTagName('div');
    var count = 0;

    for (var i = 0; i < bodyItems.length; i++) {

        if (bodyItems[i].parentElement.nodeName == 'DIV') {

            console.log(bodyItems[i].innerHTML);
            console.log("count = " + count++);
        }
    }
}

function PrintValue() {

    var inputValue = document.querySelector('input[type="text"]');

    if (inputValue.value != null && inputValue.value !== '') {

        console.log(inputValue.value);
    }
}

function ChangeBackground() {

    var inputValue = document.querySelector('input[type="color"]');

    document.body.style.backgroundColor = inputValue.value;
}