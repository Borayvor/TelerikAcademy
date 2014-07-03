
window.onload = function () {
    'use strict';

    var addButton = document.getElementById("addButton");
    var removeButton = document.getElementById("removeButton");
    var hideButton = document.getElementById("hideButton");
    var showButton = document.getElementById("showButton");
    var container = document.getElementById("container");

    function addItem() {
        var item = document.getElementById("item").value;
        document.getElementById("item").value = "";

        if (item == "" || item == null) {
            alert("Cannot add an emtpy item!");
            return;
        };

        var checkbox = document.createElement("input");
        checkbox.type = "checkbox";
        checkbox.name = "checkbox";

        var label = document.createElement("label");
        label.style.display = "block";

        label.appendChild(checkbox);
        label.appendChild(document.createTextNode(item));
        container.appendChild(label);

        event.target.item = '';
    }

    function removeItems() {
        var allCheckBoxes = document.querySelectorAll("input[type=checkbox]");

        for (var i = 0; i < allCheckBoxes.length; i++) {
            if (allCheckBoxes[i].checked && allCheckBoxes[i].parentNode.style.display == "block") {
                var label = allCheckBoxes[i].parentNode;
                label.parentNode.removeChild(label);
            };
        };
    }

    function hideItems() {
        var allCheckBoxes = document.querySelectorAll("input[type=checkbox]");

        for (var i = 0; i < allCheckBoxes.length; i++) {
            if (allCheckBoxes[i].checked) {
                allCheckBoxes[i].parentNode.style.display = "none";
            };
        };
    }

    function showHiddenItems() {
        var allCheckBoxes = document.querySelectorAll("input[type=checkbox]");

        for (var i = 0; i < allCheckBoxes.length; i++) {
            if (allCheckBoxes[i].parentNode.style.display == "none") {
                allCheckBoxes[i].parentNode.style.display = "block";
            };
        };
    }

    addButton.addEventListener("click", addItem, false);
    removeButton.addEventListener("click", removeItems, false);
    hideButton.addEventListener("click", hideItems, false);
    showButton.addEventListener("click", showHiddenItems, false);
}

