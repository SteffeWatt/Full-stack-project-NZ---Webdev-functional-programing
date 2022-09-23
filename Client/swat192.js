
let HomeSection = document.getElementById("Home_Tab");
let LoginSection = document.getElementById("Login_Tab");
let RegisterSection = document.getElementById("Register_Tab");
let GuestBookSection = document.getElementById("GuestBook_Tab");
let GameSection = document.getElementById("GameOfChess_Tab");
let ShopSection = document.getElementById("Shop_Tab");



function ChangeDivContentHome(){
    HideAllContent();
    HomeSection.style.display = "block";
}

function ChangeDivContentLogin(){
    HideAllContent();
    LoginSection.style.display = "block";
}

function ChangeDivContentRegister(){
    HideAllContent();
    RegisterSection.style.display = "block";
}

function ChangeDivContentAcademyShop(){
    HideAllContent();
    ShopSection.style.display = "block";
}

function ChangeDivContentGuestBook(){
    HideAllContent();
    GuestBookSection.style.display = "block";
}

function ChangeDivContentGameOfChess(){
    HideAllContent();
    GameSection.style.display = "block";
}



function HideAllContent(){
    HomeSection.style.display = "none";
    LoginSection.style.display = "none";
    RegisterSection.style.display = "none";
    ShopSection.style.display = "none";
    GameSection.style.display = "none";
    GuestBookSection.style.display = "none";
}

