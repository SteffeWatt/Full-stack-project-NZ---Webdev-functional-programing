
// ------------------------------------------------------------------------------
// All the functions that handles the different tabs on the website
// ------------------------------------------------------------------------------

let HomeSection = document.getElementById("Home_Tab");
let LoginSection = document.getElementById("Login_Tab");
let RegisterSection = document.getElementById("Register_Tab");
let GuestBookSection = document.getElementById("GuestBook_Tab");
let GameSection = document.getElementById("GameOfChess_Tab");
let ShopSection = document.getElementById("Shop_Tab");



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

function fetchItems() {
    fetch('https://cws.auckland.ac.nz/gas/api/AllItems').then((data) => {

        //document.getElementById("commentSection").innerHTML = response.text();
        //console.log(data);


        return data.json();



    }).then((completedData)=>{

        let  itemData="";
        completedData.map((values)=>{
            itemData+=`<div class="card">
                    <H1 class="id">item-id: ${values.id}</H1>
                    <h2 class="name">${values.name}</h2>
                    <img src="https://cws.auckland.ac.nz/gas/api/ItemPhoto/${values.id}">
                    <p class="description">${values.description}</p>
                    <p class="price">Price: ${values.price}</p>
                    <button class="buyButton" onclick="buyItem(${values.name})">Buy</button>
                   </div>`
                    //${values.id}

        })

        console.log(completedData);
        document.getElementById("itemSection").innerHTML=itemData;
    })
}

function buyItem(test) {
    alert(test);
}