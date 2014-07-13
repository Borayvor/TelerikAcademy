
define(['data', 'combobox'], function (stories, combobox) {
    var run = function () {
        var myCombobox = combobox.getComboBoxController(stories);
        myCombobox.renderTemplate('#combobox-template');
        myCombobox.createCombo('#combobox-root');
    }

    return {
        run: run
    }
})