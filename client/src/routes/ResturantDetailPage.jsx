import React, { useContext, useEffect } from "react";
import { useParams } from "react-router-dom";
import { RestaurantContext } from "../context/ResturantsContext";
import { RestaurantFinder } from "../apis/ResturantFinder";
import StarRating from "../components/StarRating";
import Reviews from "../components/Reviews";
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

    return (
      <div>
        {selectedrestaurant && (
          <>
            <h1 className="text-center display-1">
              {selectedrestaurant.restaurant.name}
            </h1>
            <div className="text-center">
              <StarRating rating={selectedrestaurant.restaurant.average_rating} />
              <span className="text-warning ml-1">
                {selectedrestaurant.restaurant.count
                  ? `(${selectedrestaurant.restaurant.count})`
                  : "(0)"}
              </span>
            </div>
            <div className="mt-3">
              <Reviews reviews={selectedrestaurant.reviews} />
            </div>
            {/* <AddReview /> */}
          </>
        )}
      </div>
  );
}

export default ResturantDetailPage;
