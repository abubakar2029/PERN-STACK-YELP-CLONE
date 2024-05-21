-- \? for help

-- list databases \l

-- connect to a db "\c dbName"

-- create-table
CREATE TABLE products(
    id BIGSERIAL PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    price INT NOT NULL,
    onsale boolean NOT NULL
);
ALTER SEQUENCE products_id_seq RESTART WITH 1000;

CREATE TABLE resturants(
    id BIGSERIAL PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    price_range INT check(price_range>=1 and price_range<=5) NOT NULL,
    location VARCHAR(50) NOT NULL
);
ALTER SEQUENCE restaurants_id_seq RESTART WITH 1000;

-- \d relations-list
-- \d tableName -> list col

-- Inserting 3 records into the first table
INSERT INTO products (name, price, onsale) VALUES
('Product A', 100, true),
('Product B', 150, false),
('Product C', 200, true);

-- Inserting 3 records into the second table
INSERT INTO restaurants (name, price_range, location) VALUES
('Restaurant A', 3, 'Location X'),
('Restaurant B', 5, 'Location Y'),
('Restaurant C', 1, 'Location Z');