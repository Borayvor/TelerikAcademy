
define(['jquery', 'handlebars'], function ($) {
    var ComboBox = function (stories) {
        if (Array.isArray(stories.stories)) {
            this.stories = stories;
        } else {
            this.stories = ["Empty Data Array"];
        }
    };

    ComboBox.prototype = {
        renderTemplate: function (templateSelector) {
            var comboBoxTemplate = document.querySelector(templateSelector).innerHTML;
            var hbTemplate = Handlebars.compile(comboBoxTemplate);
            document.getElementById('combobox-root').innerHTML = hbTemplate(this.stories);
        },
        createCombo: function (selector) {
            var parent = $(selector);
            var allElements = parent.children().hide();
            var selectedElement;

            var selectBtn = $('#selectBtn');
            selectBtn.on('click', function () {
                allElements.show();
                selectBtn.remove();
            });

            allElements.on('click', function () {
                selectedElement = $(this);
                var shownElement = selectedElement.clone().prependTo(parent);
                shownElement.on('click', function () {
                    allElements.show();
                    shownElement.remove();
                });
                allElements.hide();
            });
        }
    };

    function getNewComboBox(data) {
        return new ComboBox(data)
    }



    return {
        getComboBoxController: getNewComboBox
    }
});