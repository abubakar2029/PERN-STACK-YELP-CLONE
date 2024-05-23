import React, { useContext, useEffect, useState } from "react";
import { useParams, useNavigate } from "react-router-dom";
// import { RestaurantContext } from "../context/ResturantsContext";
import { RestaurantFinder } from "../apis/ResturantFinder";

function UpdateRestaurant() {
  const { id } = useParams();
  const [name, setName] = useState("");
  const [location, setLocation] = useState("");
  const [priceRange, setPriceRange] = useState(1);
  console.log("Id in params", id);
  const navigate = useNavigate();
  useEffect(() => {
    async function fetchData() {
      const response = await RestaurantFinder.get(`/${id}`);
      console.log("Hi : ", response.data);
      setName(response.data.data.name);
      setLocation(response.data.data.location);
      setPriceRange(response.data.data.price_range);
    }
    fetchData();
  }, [id]);

  //   const { restaurants } = useContext(RestaurantContext);

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      await RestaurantFinder.put(`${id}`, {
        name,
        location,
        price_range: priceRange,
      });
      navigate("/");
    } catch (error) {
      console.log(error);
    }
  };
  return (
    <div className="container mt-5 d-flex justify-content-center">
      <div className="w-50">
        <form>
          <div className="form-group">
            <label htmlFor="name">Name</label>
            <input
              type="text"
              className="form-control"
              id="name"
              placeholder="Enter name"
              value={name}
              onChange={(e) => setName(e.target.value)}
            />
          </div>
          <div className="form-group">
            <label htmlFor="location">Location</label>
            <input
              type="text"
              className="form-control"
              id="location"
              placeholder="Enter location"
              value={location}
              onChange={(e) => setLocation(e.target.value)}
            />
          </div>
          <div className="form-group">
            <label htmlFor="priceRange">Price Range</label>
            <input
              type="number"
              className="form-control"
              id="priceRange"
              placeholder="Enter price range"
              value={priceRange}
              onChange={(e) => setPriceRange(e.target.value)}
            />
          </div>
          <button
            type="submit"
            onClick={handleSubmit}
            className="btn btn-primary btn-block mt-3"
          >
            Submit
          </button>
        </form>
      </div>
    </div>
  );
}

export default UpdateRestaurant;
