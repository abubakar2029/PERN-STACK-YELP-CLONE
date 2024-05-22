const pg = require("pg");
const { Pool } = pg;

const pool = new Pool({
  user: "postgres",
  host: "localhost",
  database: "yelpDB",
  password: "123",
  port: 5432,
});

const query = (text, params) => pool.query(text, params);
module.exports = { query };
