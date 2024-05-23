import "./App.css";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from "./routes/Home";
import ResturantDetailPage from "./routes/ResturantDetailPage";
import UpdateResturantPage from "./routes/UpdateResturantPage";
import { RestaurantsContextProvider } from "./context/ResturantsContext";

function App() {
  return (
    <RestaurantsContextProvider>
      <div className="px-5">
        <BrowserRouter>
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/restaurants/:id" element={<ResturantDetailPage />} />
            <Route
              path="/restaurants/:id/update"
              element={<UpdateResturantPage />}
            />
          </Routes>
        </BrowserRouter>
      </div>
    </RestaurantsContextProvider>
  );
}

export default App;
