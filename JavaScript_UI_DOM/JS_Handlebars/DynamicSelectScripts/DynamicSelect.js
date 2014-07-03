(function () {
    var selectOptions = [
        {
            value: 1,
            text: 'Javascript'
        },
        {
            value: 2,
            text: 'C#',
            selected: true
        },
        {
            value: 3,
            text: 'CSS'
        },
        {
            value: 4,
            text: 'HTML'
        },
        {
            value: 5,
            text: 'Java'
        }
    ];

    var templateData = document.getElementById("select-template").innerHTML;
    var template = Handlebars.compile(templateData);
    var selectHtml = template({ selectOptions: selectOptions });

    var container = document.getElementById("container");
    container.innerHTML = selectHtml;
})();