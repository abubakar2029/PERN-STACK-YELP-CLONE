import React, { useContext, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { RestaurantFinder } from "../apis/ResturantFinder";
import { RestaurantContext } from "../context/ResturantsContext";

export default function RestaurantList() {
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
  }, [setRestaurants]);

  let navigate = useNavigate();

  const handleUpdate = async (e, id) => {
    e.stopPropagation();
    navigate(`/restaurants/${id}/update`);
  };

  const handleDelete = async (e, id) => {
    e.stopPropagation();
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

  const handleRestaurantSelect = (id) => {
    navigate(`/restaurants/${id}`);
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
          {restaurants &&
            restaurants.map((restaurant) => (
              <tr
                key={restaurant.id}
                onClick={() => handleRestaurantSelect(restaurant.id)}
              >
                <td>{restaurant.name}</td>
                <td>{restaurant.location}</td>
                <td>{"$".repeat(restaurant.price_range)}</td>
                <td> </td>
                <td>
                  <button
                    className="btn btn-warning"
                    onClick={(e) => handleUpdate(e, restaurant.id)}
                  >
                    Update
                  </button>
                </td>
                <td>
                  <button
                    className="btn btn-danger"
                    onClick={(e) => handleDelete(e, restaurant.id)}
                  >
                    Delete
                  </button>
                </td>
              </tr>
            ))}
        </tbody>
      </table>
    </div>
  );
}
