
window.onload = function () {

    $.fn.dropdown = function () {
        
        var $selectTag = this;
        $selectTag.hide();
        var optionsArr = [];
        var options = $selectTag.children();

        for (var i = 0; i < options.length; i++) {
            optionsArr.push({
                option: options[i].innerHTML,
                value: options[i].value
            });
        }
        
        var $container = $('<div>').addClass('dropdown-list-container');
        var $ul = $('<ul>').addClass('dropdown-list-options');
        var $selectionContainer = $('<li>')
                .addClass('dropdown-list-selectionContainer')
                .text('Choose your color name')
                .attr('data-value', 'not-selected')
                .appendTo($ul);

        for (var j = 0; j < optionsArr.length; j++) {
            var currOption = $('<li>')
                    .text(optionsArr[j].option)
                    .attr('data-value', optionsArr[j].value)
                    .on('click', function () {
                        $target = $(this);
                        $('.dropdown-list-options li[selected]').removeAttr('selected');
                        $target.attr('selected', 'selected');
                        $selectionContainer.text($target.text());
                        $selectionContainer.attr('data-value', $target.attr('data-value'));
                        $('.dropdown-list-options li:not(.dropdown-list-selectionContainer)').slideUp('fast');
                    })
                    .appendTo($ul);
        }
        $allOptions = $selectionContainer.siblings().hide();

        $selectionContainer.on('click', function () {
            $allOptions.slideToggle();
        })
        $ul.appendTo($container);
        $container.appendTo($('body'));
    };

    $('#dropdown').dropdown();
}