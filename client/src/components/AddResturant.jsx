import React, { useContext, useState } from "react";
import { RestaurantFinder } from "../apis/ResturantFinder";
import { RestaurantContext } from "../context/ResturantsContext";

function AddResturant() {
  const { addRestaurants } = useContext(RestaurantContext);
  const [name, setName] = useState("");
  const [location, setLocation] = useState("");
  const [priceRange, setPriceRange] = useState("Price Range");

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const response = await RestaurantFinder.post("/", {
        name,
        location,
        price_range: priceRange,
      });
      addRestaurants(response.data.data);
      console.log("Create Restaurant Api response", response.data.data);
    } catch (error) {
      console.log(error);
    }
  };
  return (
    <div className="mb-4">
      <form action="" className="">
        <div className="form-group row" style={{ paddingRight: "15px" }}>
          <div className="col">
            <input
              value={name}
              onChange={(e) => setName(e.target.value)}
              type="text"
              className="form-control"
              placeholder="name"
            />
          </div>
          <div className="col">
            <input
              value={location}
              onChange={(e) => setLocation(e.target.value)}
              type="text"
              className="form-control"
              placeholder="location"
            />
          </div>
          <div className="col">
            <select
              value={priceRange}
              onChange={(e) => setPriceRange(e.target.value)}
              className="custom-select my-1 mr-sm-2"
            >
              <option disabled>Price Range</option>
              <option value="1">$</option>
              <option value="2">$$</option>
              <option value="3">$$$</option>
              <option value="4">$$$$</option>
              <option value="5">$$$$$</option>
            </select>
          </div>
          <button
            type="submit"
            onClick={handleSubmit}
            className="btn btn-primary col "
          >
            Add
          </button>
        </div>
      </form>
    </div>
  );
}

export default AddResturant;
