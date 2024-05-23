import React, { useContext, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { RestaurantFinder } from "../apis/ResturantFinder";
import { RestaurantContext } from "../context/ResturantsContext";

export default function ResturantList() {
  const { restaurants, setRestaurants } = useContext(RestaurantContext);
  useEffect(() => {
    async function fetchData() {
      try {
        const response = await RestaurantFinder.get("/");
        console.log("response.data", response.data);
        setRestaurants(response.data.data);
      } catch (error) {
        console.log(error);
      }
    }
    fetchData();
  }, []);

  let history = useNavigate();
  const handleUpdate = async (id) => {
    try {
      const response = await RestaurantFinder.delete(`/${id}`);
      setRestaurants((prevRestaurants) =>
        prevRestaurants.filter((restaurant) => restaurant.id !== id)
      );
      console.log(response);
    } catch (error) {
      console.log(error);
    }
  };
  const handleDelete = async (id) => {
    try {
      const response = await RestaurantFinder.delete(`/${id}`);
      setRestaurants((prevRestaurants) =>
        prevRestaurants.filter((restaurant) => restaurant.id !== id)
      );
      console.log(response);
    } catch (error) {
      console.log(error);
    }
  };
  return (
    <div className="list-group">
      <table className="table table-hover table-dark">
        <thead>
          <tr className="bg-primary">
            <th scope="col">Restaurant</th>
            <th scope="col">Location</th>
            <th scope="col">Price Range</th>
            <th scope="col">Ratings</th>
            <th scope="col">Edit</th>
            <th scope="col">Delete</th>
          </tr>
        </thead>
        <tbody>
          {/* if restaurants exist than run the map */}
          {restaurants &&
            restaurants.map((restaurant, index) => {
              return (
                <tr key={index}>
                  <td>{restaurant.name}</td>
                  <td>{restaurant.location}</td>
                  <td>{"$".repeat(restaurant.price_range)}</td>
                  <td> </td>
                  <td>
                    <button
                      className="btn btn-warning"
                      onClick={() => handleUpdate(restaurant.id)}
                    >
                      Update
                    </button>
                  </td>
                  <td>
                    <button
                      className="btn btn-danger"
                      onClick={() => handleDelete(restaurant.id)}
                    >
                      Delete
                    </button>
                  </td>
                </tr>
              );
            })}
          {/* <td>mcDonalds</td>
          <td>New York</td>
          <td>$$</td>
          <td>Rating</td>
          <td>
            <button className="btn btn-warning">Update</button>
          </td>
          <td>
            <button className="btn btn-danger">Delete</button>
          </td> */}
        </tbody>
      </table>
    </div>
  );
}
