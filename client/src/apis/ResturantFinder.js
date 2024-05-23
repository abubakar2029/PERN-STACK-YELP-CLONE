import axios from "axios";

export const RestaurantFinder = axios.create({
  baseURL: "http://localhost:1185/api/v1/restaurants",
});
