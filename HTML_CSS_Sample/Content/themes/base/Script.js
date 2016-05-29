
var pageElement = null;

function getHtmlObject(x) {
    return document.getElementById(x);
}


//********************* Registration Page Validations *********************
function ValidateUser() {
    getHtmlObject("userValidation").innerHTML = "";
    getHtmlObject("passwordValidation").innerHTML = "";
    var formObject = getHtmlObject("registerform");
    var userName = document.getElementsByName("UserName")[0].value;
    var password = document.getElementsByName("Password")[0].value;

    if (userName == null || userName == "") {
       getHtmlObject("userValidation").innerHTML = "<h3> UserName cannot be empty</h3>";
        return false;
    }

    if (password == null || password == "") {
        getHtmlObject("passwordValidation").innerHTML = "<h3> Password cannot be empty</h3>";
        return false;
    }
}

//********************* To Login a user and redirect to the same page *********************

var currentUrl = window.location.pathname;

function LoginMe() {
    var url = '/Account/Login?returnUrl=' + currentUrl
    window.location.href = url;
};


//********************* Enables Video for Valid User ***********************/


$(document).on("click", ".userBase", function () {

    var username = $(this).data('value');

    //********************* User check for login *********************

    if (username == null || username == "") {
        alert('Please Login to Continue');
        var url = '/Account/Login?returnUrl=' + currentUrl
        window.location.href = url;
    }
    else {
        //alert('you have access to see a Video now');
        if (pageElement != null) {
            pageElement.style.display = "block";
        }
    }
});

//********************* HTML Quiz *********************

var quizQuestions = [
    ["What does HTML stand for?", "Hyperlinks and Text Markup Language", "Home Tool Markup Language", "Hyper Text Markup Language", "Hyper and Text Markup Language", "C"],
	["Who is making the Web standards?", "Mozilla", "Microsoft", "The World Wide Web Consortium", "None", "C"],
	["Choose the correct HTML tag for the largest heading", "h6", "heading", "head", "h1", "D"],
	["What does vlink mean ?", "visited link", "vlink", "active link", "virtual link", "A"],
    ["How do I add scrolling text to my page?", "scroll", "marquee", "ciruler", "All of the above", "B"]
];

var currentQuest = 0, htmlObj, quizstatus, quizQuestion, selectedAns, answer, choiceA, choiceB, choiceC, choiceD, gainedPoints = 0;


function displayQuizQuestions() {
    htmlObj = getHtmlObject("htmlQuestions");
    if (htmlObj != null) {
        if (currentQuest >= quizQuestions.length) {
            htmlObj.innerHTML = "<h2>You have answered " + gainedPoints + " of " + quizQuestions.length + " questions correct</h2>";
            getHtmlObject("nextQuest").style.display = "none";
            getHtmlObject("quizstatus").innerHTML = "Your Quiz is Completed";
            rentQuest = 0;
            gainedPoints = 0;
            return false;
        }

        quizQuestion = quizQuestions[currentQuest][0];
        choiceA = quizQuestions[currentQuest][1];
        choiceB = quizQuestions[currentQuest][2];
        choiceC = quizQuestions[currentQuest][3];
        choiceD = quizQuestions[currentQuest][4];
        htmlObj.innerHTML = "<h3>" + quizQuestion + "</h3>";
        htmlObj.innerHTML += "<input type='radio' name='answer' value='A'> " + choiceA + "<br>";
        htmlObj.innerHTML += "<input type='radio' name='answer' value='B'> " + choiceB + "<br>";
        htmlObj.innerHTML += "<input type='radio' name='answer' value='C'> " + choiceC + "<br>";
        htmlObj.innerHTML += "<input type='radio' name='answer' value='D'> " + choiceD + "<br><br>";

        getHtmlObject("quizstatus").innerHTML = "You are on Question " + (currentQuest + 1) + " of " + quizQuestions.length + "<br><br/>";
    }
}

function verifyAns() {
    answer = document.getElementsByName("answer");
    for (var i = 0; i < answer.length; i++) {
        if (answer[i].checked) {
            selectedAns = answer[i].value;
        }
    }
    if (selectedAns == quizQuestions[currentQuest][5]) {
        gainedPoints++;
    }
    currentQuest++;
    displayQuizQuestions();
}

window.addEventListener("load", displayQuizQuestions, false);

//********************* Model Window *********************

$(document).ready(function () {

    pageElement = getHtmlObject("page");

    if (pageElement != null) {
        pageElement.style.display = "none";
    }

    $(".dialog-box").dialog({
        modal: true,
        draggable: false,
        resizable: false,
        position: { my: "center", at: "center" },
        show: 'blind',
        hide: 'blind',
        width: 400,
        dialogClass: 'ui-dialog-popup',
        buttons: {
            "I agree": function () {
                $(this).dialog("close");
            },
            "Don't want to proceed": function () {
                var url = '/Home/About'
                window.location.href = url;
            }
        }
    });

    /******************************* Video Player ******************************/

    $("[data-media]").on("click", function (e) {
        e.preventDefault();
        var $this = $(this);
        var videoUrl = $this.attr("data-media");
        var placeholder = $this.attr("href");
        var $popupIframe = $(placeholder).find("iframe");

        $popupIframe.attr("src", videoUrl);

        $this.closest(".videoText").addClass("show-popup");
    });

    $(".placeholder").on("click", function (e) {
        e.preventDefault();
        e.stopPropagation();

        $(".videoText").removeClass("show-popup");
    });

    $(".placeholder > iframe").on("click", function (e) {
        e.stopPropagation();
    });

});

