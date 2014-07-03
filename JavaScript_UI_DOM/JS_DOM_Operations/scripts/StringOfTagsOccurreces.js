
window.onload = function () {
    'use strict';

    var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "http", "CMS"];
      
    function generateTagCloud(tags, minSize, maxSize) {
        maxSize = parseFloat(maxSize);
        minSize = parseFloat(minSize);

        tags.sort();

        var maxCount = 1;
        var count = 1;

       
        for (var i = 0; i < tags.length - 1; i++) {
            if (tags[i].toLowerCase() == tags[i + 1].toLowerCase()) {
                count++;
                if (count > maxCount) {
                    maxCount = count;
                }
            } else {
                count = 1;
            }
        }

        
        for (var i = 0; i < tags.length - 1; i++) {
            if (tags[i] == tags[i + 1]) {
                count++;
                if (count > maxCount) {
                    maxCount = count;
                }
            } else {
                var div = document.createElement("div");
                div.style.position = "absolute";
                div.style.top = Math.floor(Math.random() * 300) + "px";
                div.style.left = Math.floor(Math.random() * 500) + "px";
                div.style.color = 'black';
                div.innerHTML = tags[i];
                div.style.fontSize = (maxSize - minSize) / (maxCount - 1) * (count - 1) + minSize + "px";
                document.body.appendChild(div);
                count = 1;
            }
        }
    }
    generateTagCloud(tags, 20, 53);
}