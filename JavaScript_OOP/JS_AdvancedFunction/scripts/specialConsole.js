////Create a module to work with the console object.Implement functionality for:
////Writing a line to the console 
////Writing a line to the console using a format
////Writing to the console should call toString() to each element
////Writing errors and warnings to the console with and without format

var specialConsole = (function () {      

    function parseString() {
        var thisArguments = arguments;
             
        if (thisArguments[0] != undefined && thisArguments[0] != "") {
            var text = thisArguments[0];
            var valuesArray = Array.prototype.slice.call(thisArguments, 1);

            return text.replace(/{(\d+)}/g, function (match, number) {

                var result = typeof valuesArray[number] != 'undefined' ? valuesArray[number] : "";

                return result;
            });
        }
        else {
            return "";
        }
    }

    function writeLine() {
        console.log(parseString.apply(null, arguments));
    }
    function writeError() {
        console.error(parseString.apply(null, arguments));
    }
    function writeWarn() {
        console.warn(parseString.apply(null, arguments));
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarn: writeWarn
    }
}())