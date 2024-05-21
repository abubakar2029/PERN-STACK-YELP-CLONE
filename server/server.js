require("dotenv").config();
const express = require("express");

const app = express();

const port = process.env.PORT;

// Get all Resturants
app.get("/api/v1/resturants", (req, res) => {
  res.status(200).json({
    status: "success",
    data: {
      resturant: ["mcdonalds,kfc"],
    },
  });
});

// Get a Resturant
app.get("/api/v1/resturants/:resturantid", (req, res) => {

});

// Create a resturant
app.post("/api/v1/resturants", (req, res)=>{
    
})
app.listen(port, () => {
  console.log(`App is listening on PORT ${port}`);
});
