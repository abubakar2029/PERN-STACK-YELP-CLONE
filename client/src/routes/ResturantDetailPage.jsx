import React, { useContext, useEffect } from "react";
import { useParams } from "react-router-dom";
import { RestaurantContext } from "../context/ResturantsContext";
import { RestaurantFinder } from "../apis/ResturantFinder";

function ResturantDetailPage() {
  const { id } = useParams();
  const { selectedrestaurant, setSelectedRestaurant } =
    useContext(RestaurantContext);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await RestaurantFinder.get(`${id}`);
        console.log("Detail page api response", response);
        setSelectedRestaurant(response.data.data);
      } catch (error) {
        console.log(error);
      }
    };
    fetchData();
  }, []);

  return <div>
    <h1 className="text-center">{selectedrestaurant && selectedrestaurant.name}</h1>
  </div>;
}

export default ResturantDetailPage;
