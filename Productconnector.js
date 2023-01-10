const mongoose = require("mongoose");

const Productschema = new mongoose.Schema({
    name:String,
    price: String,
    Company :String,
    userId: String
    
})

module.exports = mongoose.model('products',Productschema)