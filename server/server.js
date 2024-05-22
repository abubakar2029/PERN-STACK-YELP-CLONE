require("dotenv").config();
const express = require("express");

const app = express();
const morgan = require("morgan");
const db = require("./db");
// Middlewares
app.use(morgan("dev"));
app.use(express.json());

const port = process.env.PORT;

// Get all restaurants
app.get("/api/v1/restaurants", async (req, res) => {
  const result = await db.query("SELECT * FROM restaurants");
  console.log(result);
  res.status(200).json({
    status: "success",
    data: {
      resturant: ["mcdonalds,kfc"],
    },
  });
});

// Get a Resturant
app.get("/api/v1/restaurants/:id", (req, res) => {
  console.log(req);
  res.send(req.params);
});

// Create a resturant
app.post("/api/v1/restaurants", (req, res) => {});
app.post("/a", (req, res) => {
  console.log("Oki");
});

// Update a Resturant
app.put("/api/v1/restaurants/:id", (req, res) => {
  console.log(req.body);
  res.status(200).send({
    status: "success",
  });
});

// Delete a Resturant
app.delete("/api/v1/restaurants/:id", (req, res) => {
  console.log(req.body);
  res.status(200).send({
    status: "resturant deleted",
  });
});
app.listen(port, () => {
  console.log(`App is listening on PORT ${port}`);
});
