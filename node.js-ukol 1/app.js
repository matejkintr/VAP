let Person = require("./person")
const express = require("express")
const jmena =  ["Paštika", "Novák", "Novotný"]
const prijmeni = ["Kvído", "Evžen", "Jirka"]
const app = express()

app.use(express.static(__dirname))
app.get("/", (req, res) => {
    res.sendFile( __dirname +"/index.html");
})
app.get("/person",(req,res) => {
    res.send({name:"Radim"})
})
app.get("/random-person", (req,res) => {
    const randomId = randInt(1, 10)
    const randomPerson = new Person(randomName(), randomSurname(), randomId)
    res.json(randomPerson)
})

function randomName(){
    let randomN = Math.floor(Math.random() * jmena.length)
    return prijmeni[randomN]
}

function randomSurname(){
    let randomS = Math.floor(Math.random() * prijmeni.length)
    return jmena[randomS]
}

function randInt(low, high){
    return Math.floor(Math.random() * (high - low) + low)
}

app.listen(7707);