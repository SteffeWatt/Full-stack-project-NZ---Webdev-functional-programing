
// ------------------------------------------------------------------------------
// All the functions that handles the different tabs on the website
// ------------------------------------------------------------------------------

let HomeSection = document.getElementById("Home_Tab");
let LoginSection = document.getElementById("Login_Tab");
let RegisterSection = document.getElementById("Register_Tab");
let GuestBookSection = document.getElementById("GuestBook_Tab");
let GameSection = document.getElementById("GameOfChess_Tab");
let ShopSection = document.getElementById("Shop_Tab");

getServerVersion();



// ------------------------------------------------------------------------------
// All the functions that handles the different tabs on the website
// ------------------------------------------------------------------------------
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
    fetchItems();
    ShopSection.style.display = "block";
}

function ChangeDivContentGuestBook(){
    HideAllContent();
    fetchComments();
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

// ------------------------------------------------------------------------------
// functions that handles logic on the website
// ------------------------------------------------------------------------------

function getServerVersion(){
    fetch('https://cws.auckland.ac.nz/gas/api/Version').then((data) => {

        return data.text();
    }).then((completedData) => {

        document.getElementById("Home_Version").innerHTML="Version "+completedData;
    })
}

function fetchComments() {
    fetch('https://cws.auckland.ac.nz/gas/api/Comments').then((data) => {

        //document.getElementById("commentSection").innerHTML = response.text();
        //console.log(data);

        return data.text();

    }).then((completedData)=>{
        //console.log(completedData);
        document.getElementById("commentSection").innerHTML=completedData;
    })
}

function WriteComment(){

    let comment = document.querySelector('#Comment_Input').value;
    let name = document.querySelector('#Comment_NameInput').value;

    if (comment.trim()) {

        var httpRequest = new XMLHttpRequest();
        var url = 'https://cws.auckland.ac.nz/gas/api/Comment';

        httpRequest.open("POST", url , true);
        httpRequest.setRequestHeader("Content-Type", "application/json");


        var data =JSON.stringify({"comment": comment,
            "name": name});

        httpRequest.send(data);
        alert("your comment is received!");

        document.querySelector('#Comment_Input').value = "";
        document.querySelector('#Comment_NameInput').value = "";

        fetchComments();
    }

    if (!comment.trim()) {
        alert("please write a comment!");

        document.querySelector('#Comment_Input').value = "";

    }

}

function fetchItems() {
    fetch('https://cws.auckland.ac.nz/gas/api/AllItems').then((data) => {

        return data.json();

    }).then((completedData)=>{

        let  itemData="";
        completedData.map((values)=>{
            itemData+=`<div class="card">
                    <H1 class="product_name">${values.name}</H1>
                    <h2 class="product_id">item-id: ${values.id}</h2>
                    <img src="https://cws.auckland.ac.nz/gas/api/ItemPhoto/${values.id}">
                    <p class="description">${values.description}</p>
                    <div id="bottom_Card">
                    <p class="price">Price: ${values.price}</p>
                    <button class="buyButton" onclick="buyItem('${values.name}')">Buy</button>
                    </div>
                    
                   </div>`
                    //${values.id}

        })


        document.getElementById("itemSection").innerHTML=itemData;
    })
}

function fetchItemsBySearch() {

    var search = document.getElementById("Shop_Search").value;

    if (!document.getElementById("Shop_Search").value); {

        fetch('https://cws.auckland.ac.nz/gas/api/Items/'+search).then((data) => {

            return data.json();

        }).then((completedData)=>{

            let  itemData="";
            completedData.map((values)=>{
                itemData+=`<div class="card">
                    <H1 class="product_name">${values.name}</H1>
                    <h2 class="product_id">item-id: ${values.id}</h2>
                    <img src="https://cws.auckland.ac.nz/gas/api/ItemPhoto/${values.id}">
                    <p class="description">${values.description}</p>
                    <div id="bottom_Card">
                    <p class="price">Price: ${values.price}</p>
                    <button class="buyButton" onclick="buyItem('${values.name}')">Buy</button>
                    </div>
                    
                   </div>`
                //${values.id}

            })


            document.getElementById("itemSection").innerHTML=itemData;
        })

    }

    if (document.getElementById("Shop_Search").value == "") {

        fetchItems();
    }




}

function buyItem(productname) {
    alert("Thank you for purchasing: " + productname);

}

function RegisterUser() {

    var name = document.querySelector('#Register_Form_User').value;
    var password = document.querySelector('#Register_Form_Password').value;
    var address = document.querySelector('#Register_Form_Address').value;


    if (name.trim() && password.trim() && address.trim()) {

        var httpRequest = new XMLHttpRequest();
        var url = 'https://cws.auckland.ac.nz/gas/api/Register';

        httpRequest.open("POST", url , true);
        httpRequest.setRequestHeader("Content-Type", "application/json");
        httpRequest.onreadystatechange = function () {

            if (httpRequest.readyState == XMLHttpRequest.DONE){


                if (httpRequest.responseText === "Username not available"){
                    alert(httpRequest.responseText + ": please enter another Username");
                }
                else {
                    alert(httpRequest.responseText + ": Welcome to The Game Academy")
                    ChangeDivContentHome();
                }
            }
        };

        var data =JSON.stringify({"username": name,
                                        "password": password,
                                        "address": address});

        httpRequest.send(data);

        document.querySelector('#Register_Form_User').value = "";
        document.querySelector('#Register_Form_Password').value = "";
        document.querySelector('#Register_Form_Address').value = "";
    }

    if (!name.trim() || !password.trim() || !address.trim()) {
        alert("please fill out the necessary fields!");
    }

}

function LoginUser() {
    alert("This function does not work :(")
    document.querySelector('#Login_Form_Name').value = "";
    document.querySelector('#Login_Form_Password').value = "";
    ChangeDivContentHome();

}