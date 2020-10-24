
var whitekeycolor = "#FF0000";
var blackkeycolor = "#000000";

var pianoChart1 = GetElementById("canvasPianoChart1");
var pianoChart2 = GetElementById("canvasPianoChart2");
var pianoChart3 = GetElementById("canvasPianoChart3");

RenderPianoKeyboard(pianoChart1);
RenderPianoKeyboard(pianoChart2);
RenderPianoKeyboard(pianoChart3);


function SetChords() {
    var selectedChord = GetElementById("dropdownChords");

    RenderPianoKeyboard(pianoChart1, selectedChord.value, "Root");
    RenderPianoKeyboard(pianoChart2, selectedChord.value, "First");
    RenderPianoKeyboard(pianoChart3, selectedChord.value, "Second");
}

function SelectInversion(inversion) {

    var Root = GetElementById("radioRoot");
    var First = GetElementById("radioFirst");
    var Second = GetElementById("radioSecond");

    switch (inversion) {
        case "Root":
            Root.checked = true;
            First.checked = false;
            Second.checked = false;
            break;
        case "First":
            Root.checked = false;
            First.checked = true;
            Second.checked = false;
            break;
        case "Second":
            Root.checked = false;
            First.checked = false;
            Second.checked = true;
            break;
        default:
            Root.checked = false;
            First.checked = false;
            Second.checked = false;
            break;
    }
}

function AddChord() {

    var listofChords = GetElementById("listboxSelectedChords");
    var selectedChord = GetElementById("dropdownChords");
    var opt = document.createElement("option");
    var inversion = GetInversion();
  
    if (selectedChord.value == "maj" || selectedChord.value == "min") {
        toastr.warning("Please select a chord.");
        return false;
    }
   
    if (listofChords.options.length > 10) {
        toastr.warning("Only 10 chords are allowed.");
        return false;
    }
    if (inversion == "") {
        toastr.warning("No inversion was selected.");
        return false;
    }

    switch (inversion) {
        case "Root":
            inversion = "Root";
            break;
        case "First":
            inversion = "1st";
            break;
        case "Second":
            inversion = "2nd";
            break;
        default:
        inversion = ""
    }
    
    if (DoesChordExist(selectedChord.value + " - " + inversion)) {
        toastr.warning("This chord already exists.");
        return false;
    }

    opt.text = selectedChord.options[selectedChord.selectedIndex].text + " - " + inversion;
    opt.value = selectedChord.value + " - " + inversion;

    listofChords.options.add(opt);

    toastr.info("Chord successfully added.");

    return true;

}

function GenerateChordSheet() {

    if (GetTotalChords() == 0) {
        toastr.warning("No chords were specified for export.")
        return;
    }

    $.ajax({
            url: '/Home/GenerateChordSheet',
            type: 'POST',
            data: JSON.stringify({                
                chordsList: $("listboxSelectedChords")
            }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            async: true,
            success: function (data) {
                toastr.info(data);
            },
            error: function (data) {
                toastr.error(data);
            }
         });

    return true;
}

function RemoveChord() {
    var listofChords = GetElementById("listboxSelectedChords");
   
    var selectedCount = 1;
    var Index;
    if (listofChords.selectedIndex == -1) {
        toastr.warning("No chords have been selected to remove.");
        return true;
    }
    while (selectedCount > 0) {
        Index = listofChords.selectedIndex;
        if (Index >= 0) {
            listofChords.options[Index] = null;
            --i;
            toastr.info("Item removed sucessfully.")
        }
        else {
            selectedCount = 0;
        }
            
    }
    return true; 


}

function DoesChordExist(ChordToCheck) {
    var list = GetElementById("listboxSelectedChords");

    for (var i = 0; i < list.options.length; ++i) {
        if (list.options[i].value == ChordToCheck) {
            return true;
        }
    }
}

function GetTotalChords() {
    return $("#listboxSelectedChords").find("option").length;
}

function RenderPianoKeyboard(canvasToRender, selectedChord, inversion) {
    var ctx = canvasToRender.getContext("2d");
    var WHITEKEY_H = 75;
    var BLACKKEY_H = 43;
    var BLACKKEY_W = 15;
    var BLACKKEY_Y = 0;
    var WHITEKEY_Y = 0;

    ctx.clearRect(0, 0, ctx.canvas.width, ctx.canvas.height);
    ctx.beginPath();

    var counter = 0;

    //Render Whitekeys
    ctx.beginPath;
    for (i = 0; i < 14; i++) {
        counter += 20;


        ctx.rect(0, WHITEKEY_Y, counter, WHITEKEY_H);
        ctx.fillStyle = whitekeycolor;
    }

    //Render Blackkeys
    ctx.beginPath;
    ctx.fillStyle = blackkeycolor;
    var xposList = [12, 34, 72, 92, 112, 154, 174, 214, 234, 254];

    for (i = 0; i < xposList.length; i++) {
        ctx.fillRect(xposList[i], BLACKKEY_Y, BLACKKEY_W, BLACKKEY_H);
    }

    ctx.stroke();

    //Render Indicators
    var circle = new Path2D();

    ctx.beginPath;
    for (i = 0; i < 14; i++) {

        //Render White Key Indicators
        if (selectedChord != null || selectedChord != undefined) {

            switch (i + 1) {
                case 1:
                    if (selectedChord == "amin" &&
                        inversion == "First") {
                        circle.arc(10, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "cmaj" ||
                        selectedChord == "cmin") &&
                        inversion == "Root") {
                        circle.arc(10, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "gsharpmaj" ||
                        selectedChord == "aflatmaj") && inversion == "First") {
                        circle.arc(10, 60, 7, 0, 2 * Math.PI);
                    }

                    break;
                case 2:
                    if ((selectedChord == "asharpmaj" ||
                        selectedChord == "bflatmaj") && inversion == "First") {
                        circle.arc(30, 60, 7, 0, 2 * Math.PI);
                    }
                    if (selectedChord == "bmin" && inversion == "First") {
                        circle.arc(30, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "dmaj" || selectedChord == "dmin")
                        && inversion == "Root") {
                        circle.arc(30, 60, 7, 0, 2 * Math.PI);
                    }
                    break;
                case 3:
                    if ((selectedChord == "amaj" ||
                        selectedChord == "amin") &&
                        (inversion == "First" || inversion == "Second")) {
                        circle.arc(50, 60, 7, 0, 2 * Math.PI);
                    }
                    if (selectedChord == "cmaj" &&
                        (inversion == "Root" || inversion == "First")) {
                        circle.arc(50, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "csharpmin" ||
                        selectedChord == "dflatmin") &&
                        (inversion == "Root" || inversion == "First")) {
                        circle.arc(50, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "emaj" ||
                        selectedChord == "emin") &&
                        inversion == "Root") {
                        circle.arc(50, 60, 7, 0, 2 * Math.PI);
                    }


                    break;
                case 4:
                    if ((selectedChord == "asharpmin" ||
                        selectedChord == "asharpmaj" ||
                        selectedChord == "bflatmin" ||
                        selectedChord == "bflatmaj") &&
                        (inversion == "First" || inversion == "Second")) {
                        circle.arc(70, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "csharpmaj" ||
                        selectedChord == "dflatmaj")
                        && (inversion == "Root" || inversion == "First")) {
                        circle.arc(70, 60, 7, 0, 2 * Math.PI);
                    }
                    if (selectedChord == "dmin"
                        && (inversion == "Root" || inversion == "First")) {
                        circle.arc(70, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "fmaj" || selectedChord == "fmin")
                        && inversion == "Root") {
                        circle.arc(70, 60, 7, 0, 2 * Math.PI);
                    }

                    break;
                case 5:
                    if ((selectedChord == "cmaj" ||
                        selectedChord == "cmin") &&
                        (inversion == "Root" ||
                            inversion == "First" ||
                            inversion == "Second")) {
                        circle.arc(90, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "dsharpmaj" ||
                        selectedChord == "eflatmaj") &&
                        (inversion == "Root" || inversion == "First")) {
                        circle.arc(90, 60, 7, 0, 2 * Math.PI);
                    }
                    if (selectedChord == "emin" &&
                        (inversion == "Root" || inversion == "First")) {
                        circle.arc(90, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "gmaj" ||
                        selectedChord == "gmin") && inversion == "Root") {
                        circle.arc(90, 60, 7, 0, 2 * Math.PI);
                    }
                    break;
                case 6:
                    if ((selectedChord == "amaj" ||
                        selectedChord == "amin") &&
                        (inversion == "Root" || inversion == "First" || inversion == "Second")) {
                        circle.arc(110, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "dmaj" || selectedChord == "dmin") &&
                        (inversion == "Root" || inversion == "First" || inversion == "Second")) {
                        circle.arc(110, 60, 7, 0, 2 * Math.PI);
                    }
                    if (selectedChord == "fmaj" &&
                        (inversion == "Root" || inversion == "First")) {
                        circle.arc(110, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "fsharpmin" ||
                        selectedChord == "gflatmin") &&
                        (inversion == "Root" || inversion == "First")) {
                        circle.arc(110, 60, 7, 0, 2 * Math.PI);
                    }

                    break;
                case 7:
                    if ((selectedChord == "bmaj" ||
                        selectedChord == "bmin") &&
                        (inversion == "Root" || inversion == "First" || inversion == "Second")) {
                        circle.arc(130, 60, 7, 0, 2 * Math.PI);
                    }
                    // if ((selectedChord == "dsharpmaj" ||
                    //     selectedChord == "eflatmaj") && inversion == "Root") {
                    //     circle.arc(130, 60, 7, 0, 2 * Math.PI);
                    // }
                    if ((selectedChord == "emaj" ||
                        selectedChord == "emin") &&
                        (inversion == "Root" || inversion == "First" || inversion == "Second")) {
                        circle.arc(130, 60, 7, 0, 2 * Math.PI);
                    }
                    if (selectedChord == "gmaj" &&
                        (inversion == "Root" ||
                            inversion == "First")) {
                        circle.arc(130, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "gsharpmin" ||
                        selectedChord == "aflatmin") &&
                        (inversion == "Root" || inversion == "First" || inversion == "Second")) {
                        circle.arc(130, 60, 7, 0, 2 * Math.PI);
                    }

                    break;
                case 8:
                    if ((selectedChord == "cmaj" ||
                        selectedChord == "cmin") &&
                        (inversion == "First" || inversion == "Second")) {
                        circle.arc(150, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "fmaj" ||
                        selectedChord == "fmin") &&
                        (inversion == "Root" ||
                            inversion == "First" ||
                            inversion == "Second")) {
                        circle.arc(150, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "gsharpmaj" ||
                        selectedChord == "aflatmaj") &&
                        (inversion == "Root" || inversion == "Second")) {
                        circle.arc(150, 60, 7, 0, 2 * Math.PI);
                    }
                    if (selectedChord == "amin" &&
                        (inversion == "Root" || inversion == "Second")) {
                        circle.arc(150, 60, 7, 0, 2 * Math.PI);
                    }
                    break;
                case 9:
                    if ((selectedChord == "asharpmaj" ||
                        selectedChord == "bflatmaj") &&
                        (inversion == "Root" || inversion == "Second")) {
                        circle.arc(170, 60, 7, 0, 2 * Math.PI);
                    }

                    if ((selectedChord == "dmaj" ||
                        selectedChord == "dmin") &&
                        (inversion == "First" || inversion == "Second")) {
                        circle.arc(170, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "gmaj" ||
                        selectedChord == "gmin") &&
                        (inversion == "Root" || inversion == "First" || inversion == "Second")) {
                        circle.arc(170, 60, 7, 0, 2 * Math.PI);
                    }
                    if (selectedChord == "bmin" &&
                        (inversion == "Root" || inversion == "Second")) {
                        circle.arc(170, 60, 7, 0, 2 * Math.PI);
                    }
                    break;
                case 10:
                    if ((selectedChord == "amaj" ||
                        selectedChord == "amin") &&
                        inversion == "Root") {
                        circle.arc(190, 60, 7, 0, 2 * Math.PI);
                    }
                    if (selectedChord == "cmaj" &&
                        inversion == "Second") {
                        circle.arc(190, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "csharpmin" ||
                        selectedChord == "dflatmin") &&
                        inversion == "Second") {
                        circle.arc(190, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "emaj" ||
                        selectedChord == "emin") &&
                        (inversion == "First" || inversion == "Second")) {
                        circle.arc(190, 60, 7, 0, 2 * Math.PI);
                    }

                    break;
                case 11:
                    if ((selectedChord == "asharpmin" ||
                        selectedChord == "asharpmaj" ||
                        selectedChord == "bflatmin" ||
                        selectedChord == "bflatmaj") &&
                        inversion == "Root") {
                        circle.arc(210, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "csharpmaj" ||
                        selectedChord == "dflatmaj") &&
                        inversion == "Second") {
                        circle.arc(210, 60, 7, 0, 2 * Math.PI);
                    }
                    if (selectedChord == "dmin" &&
                        inversion == "Second") {
                        circle.arc(210, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "fmaj" ||
                        selectedChord == "fmin") &&
                        (inversion == "First" || inversion == "Second")) {
                        circle.arc(210, 60, 7, 0, 2 * Math.PI);
                    }
                    break;
                case 12:
                    if ((selectedChord == "dsharpmaj" ||
                        selectedChord == "eflatmaj") &&
                        (inversion == "Second")) {
                        circle.arc(230, 60, 7, 0, 2 * Math.PI);
                    }
                    if (selectedChord == "emin" &&
                        inversion == "Second") {
                        circle.arc(230, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "gmaj" ||
                        selectedChord == "gmin") &&
                        (inversion == "First" || inversion == "Second")) {
                        circle.arc(230, 60, 7, 0, 2 * Math.PI);
                    }
                    break;
                case 13:
                    if (selectedChord == "fmaj" &&
                        inversion == "Second") {
                        circle.arc(250, 60, 7, 0, 2 * Math.PI);
                    }
                    if ((selectedChord == "fsharpmin" ||
                        selectedChord == "gflatmin") &&
                        inversion == "Second") {
                        circle.arc(250, 60, 7, 0, 2 * Math.PI);
                    }
                    break;
                case 14:
                    if (selectedChord == "gmaj" &&
                        inversion == "Second") {
                        circle.arc(270, 60, 7, 0, 2 * Math.PI);
                    }
                    break;
                default:
                    break;
            }
        }
    }

    ctx.fillStyle = "#0000FF";
    ctx.fill(circle);


    ctx.beginPath;

    //Render Black Key Indicators
    for (i = 0; i < 10; i++) {
        switch (i + 1) {
            case 1:
                circle.moveTo(20, 23);
                if ((selectedChord == "asharpmin" ||
                    selectedChord == "bflatmin") &&
                    inversion == "First") {
                    circle.arc(20, 23, 7, 0, 2 * Math.PI);
                }
                if (selectedChord == "amaj" &&
                    inversion == "First") {
                    circle.arc(20, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "csharpmaj" ||
                    selectedChord == "dflatmaj") &&
                    inversion == "Root") {
                    circle.arc(20, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "csharpmin" ||
                    selectedChord == "dflatmin") &&
                    inversion == "Root") {
                    circle.arc(20, 23, 7, 0, 2 * Math.PI);
                }

                break;
            case 2:
                circle.moveTo(42, 23);
                if (selectedChord == "bmaj" &&
                    inversion == "First") {
                    circle.arc(42, 23, 7, 0, 2 * Math.PI);
                }
                if (selectedChord == "cmin" &&
                    (inversion == "Root" ||
                        inversion == "First")) {
                    circle.arc(42, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "dsharpmaj" ||
                    selectedChord == "dsharpmin" ||
                    selectedChord == "eflatmaj" ||
                    selectedChord == "eflatmin") &&
                    inversion == "Root") {
                    circle.arc(42, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "gsharpmaj" ||
                    selectedChord == "aflatmaj") &&
                    (inversion == "First" || inversion == "Second")) {
                    circle.arc(42, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "gsharpmin" ||
                    selectedChord == "aflatmin") &&
                    (inversion == "Second")) {
                    circle.arc(42, 23, 7, 0, 2 * Math.PI);
                }

                break;
            case 3:
                circle.moveTo(80, 23);
                if ((selectedChord == "bmaj" ||
                    selectedChord == "bmin") &&
                    (inversion == "First" ||
                        inversion == "Second")) {
                    circle.arc(80, 23, 7, 0, 2 * Math.PI);
                }
                if (selectedChord == "dmaj" &&
                    (inversion == "Root" ||
                        inversion == "First")) {
                    circle.arc(80, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "dsharpmin" ||
                    selectedChord == "eflatmin") &&
                    (inversion == "Root" ||
                        inversion == "First")) {
                    circle.arc(80, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "fsharpmaj" ||
                    selectedChord == "fsharpmin" ||
                    selectedChord == "gflatmaj" ||
                    selectedChord == "gflatmin") &&
                    inversion == "Root") {
                    circle.arc(80, 23, 7, 0, 2 * Math.PI);
                }
                break;
            case 4:
                circle.moveTo(100, 23);
                if ((selectedChord == "csharpmaj" ||
                    selectedChord == "dflatmaj") &&
                    (inversion == "Root" ||
                        inversion == "First" ||
                        inversion == "Second")) {
                    circle.arc(100, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "csharpmin" ||
                    selectedChord == "dflatmin") &&
                    (inversion == "Root" ||
                        inversion == "First" ||
                        inversion == "Second")) {
                    circle.arc(100, 23, 7, 0, 2 * Math.PI);
                }
                if (selectedChord == "emaj" &&
                    (inversion == "Root" ||
                        inversion == "First")) {
                    circle.arc(100, 23, 7, 0, 2 * Math.PI);
                }
                if (selectedChord == "fmin" &&
                    (inversion == "Root" ||
                        inversion == "First")) {
                    circle.arc(100, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "gsharpmaj" ||
                    selectedChord == "aflatmaj") &&
                    (inversion == "Root" ||
                        inversion == "First" ||
                        inversion == "Second")) {
                    circle.arc(100, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "gsharpmin" ||
                    selectedChord == "aflatmin") &&
                    (inversion == "Root" ||
                        inversion == "Second")) {
                    circle.arc(100, 23, 7, 0, 2 * Math.PI);
                }
                break;
            case 5:
                circle.moveTo(120, 23);
                if ((selectedChord == "asharpmin" ||
                    selectedChord == "asharpmaj" ||
                    selectedChord == "bflatmin" ||
                    selectedChord == "bflatmaj") &&
                    (inversion == "Root" ||
                        inversion == "First" ||
                        inversion == "Second")) {
                    circle.arc(120, 23, 7, 0, 2 * Math.PI);
                }

                if ((selectedChord == "dsharpmaj" ||
                    selectedChord == "dsharpmin" ||
                    selectedChord == "eflatmaj" ||
                    selectedChord == "eflatmin") &&
                    (inversion == "Root" ||
                        inversion == "First" ||
                        inversion == "Second")) {
                    circle.arc(120, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "fsharpmaj" ||
                    selectedChord == "gflatmaj") &&
                    (inversion == "Root" ||
                        inversion == "First")) {
                    circle.arc(120, 23, 7, 0, 2 * Math.PI);
                }
                if (selectedChord == "gmin" &&
                    (inversion == "Root" ||
                        inversion == "First")) {
                    circle.arc(120, 23, 7, 0, 2 * Math.PI);
                }

                break;
            case 6:
                circle.moveTo(162, 23);
                if (selectedChord == "amaj" &&
                    (inversion == "Root" ||
                        inversion == "Second")) {
                    circle.arc(162, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "asharpmin" ||
                    selectedChord == "bflatmin") &&
                    (inversion == "Root" ||
                        inversion == "Second")) {
                    circle.arc(162, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "csharpmaj" ||
                    selectedChord == "dflatmaj" ||
                    selectedChord == "csharpmin") &&
                    (inversion == "First" ||
                        inversion == "Second")) {
                    circle.arc(162, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "fsharpmaj" ||
                    selectedChord == "fsharpmin" ||
                    selectedChord == "gflatmaj" ||
                    selectedChord == "gflatmin") &&
                    (inversion == "Root" || inversion == "First" || inversion == "Second")) {
                    circle.arc(162, 23, 7, 0, 2 * Math.PI);
                }

                break;
            case 7:
                circle.moveTo(182, 23);
                if (selectedChord == "bmaj" &&
                    (inversion == "Root" ||
                        inversion == "Second")) {
                    circle.arc(182, 23, 7, 0, 2 * Math.PI);
                }
                if (selectedChord == "cmin" &&
                    inversion == "Second") {
                    circle.arc(182, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "dsharpmaj" ||
                    selectedChord == "dsharpmin" ||
                    selectedChord == "eflatmaj" ||
                    selectedChord == "eflatmin") &&
                    (inversion == "First" || inversion == "Second")) {
                    circle.arc(182, 23, 7, 0, 2 * Math.PI);
                }

                if ((selectedChord == "gsharpmaj" ||
                    selectedChord == "aflatmaj") &&
                    inversion == "Root") {
                    circle.arc(182, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "gsharpmin" ||
                    selectedChord == "aflatmin") &&
                    (inversion == "Root" ||
                        inversion == "First")) {
                    circle.arc(182, 23, 7, 0, 2 * Math.PI);
                }
                break;
            case 8:
                circle.moveTo(221, 23);
                if ((selectedChord == "bmaj" ||
                    selectedChord == "bmin") &&
                    inversion == "Root") {
                    circle.arc(221, 23, 7, 0, 2 * Math.PI);
                }
                if (selectedChord == "dmaj" &&
                    inversion == "Second") {
                    circle.arc(221, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "dsharpmin" ||
                    selectedChord == "eflatmin") &&
                    inversion == "Second") {
                    circle.arc(221, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "fsharpmaj" ||
                    selectedChord == "fsharpmin" ||
                    selectedChord == "gflatmaj" ||
                    selectedChord == "gflatmin") &&
                    (inversion == "First" || inversion == "Second")) {
                    circle.arc(221, 23, 7, 0, 2 * Math.PI);
                }


                break;
            case 9:
                circle.moveTo(242, 23);
                if (selectedChord == "emaj" &&
                    inversion == "Second") {
                    circle.arc(242, 23, 7, 0, 2 * Math.PI);
                }
                if (selectedChord == "fmin" &&
                    inversion == "Second") {
                    circle.arc(242, 23, 7, 0, 2 * Math.PI);
                }
                if ((selectedChord == "gsharpmin" ||
                    selectedChord == "aflatmin") &&
                    (inversion == "First")) {
                    circle.arc(242, 23, 7, 0, 2 * Math.PI);
                }
                break;
            case 10:
                circle.moveTo(262, 23);
                if ((selectedChord == "fsharpmaj" ||
                    selectedChord == "gflatmaj") &&
                    (inversion == "Second")) {
                    circle.arc(262, 23, 7, 0, 2 * Math.PI);
                }
                if (selectedChord == "gmin" && inversion == "Second") {
                    circle.arc(262, 23, 7, 0, 2 * Math.PI);
                }
                break;
            default:
                break;
        }
    }

    ctx.fillStyle = "#0000FF";
    ctx.fill(circle);

}

function GetElementById(thiselement) {
    return document.getElementById(thiselement)
}

function GetInversion() {

    var Root = GetElementById("radioRoot"); 
    var First = GetElementById("radioFirst");
    var Second = GetElementById("radioSecond");

    if (Root != null) {
        if (Root.checked == true) {
            return "Root";
        }
    }

    if (First != null) {
        if (First.checked == true) {
            return "First";
        }
    }

    if (Second != null) {
        if (Second.checked == true) {
            return "Second";
        }
    }
    

    return "";

}




