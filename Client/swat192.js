
let HomeSection = document.getElementById("Home_Tab");
let LoginSection = document.getElementById("Login_Tab");
let GuestBookSection = document.getElementById("GuestBook_Tab")



function ChangeDivContentHome(){
    HomeSection.style.display = "block";
    LoginSection.style.display = "none";
    GuestBookSection.style.display = "none";
}

function ChangeDivContentLogin(){
    HomeSection.style.display = "none";
    LoginSection.style.display = "block";
    GuestBookSection.style.display = "none";
}

function ChangeDivContentGuestBook(){
    HomeSection.style.display = "none";
    LoginSection.style.display = "none";
    GuestBookSection.style.display = "block";
}

