import React from 'react';
import './Home.css';

const Home = () => {
  return (
    <div className="home-container">
      <div className="overlay"></div>
      <div className="home-content">
        <h2>Welcome to SP MART!</h2>
        <p>Browse through our catalog and shop your favorite products.</p>
      </div>

      {/* Product Banner Carousel */}
      <div id="productCarousel" className="carousel slide banner-container" data-bs-ride="carousel" data-bs-interval="2000">
        <div className="carousel-inner">
          <div className="carousel-item active">
            <img src="https://www.shutterstock.com/image-vector/creative-vector-illustration-big-sale-260nw-1364474708.jpg" className="d-block w-100 banner-img" alt="Electronics" />
          </div>
          <div className="carousel-item">
            <img src="https://media.craftyartapp.com/uploadedFiles/thumb_file/3a96346d7a3bc66918131a98ca732493b316a7151674533164.jpg" className="d-block w-100 banner-img" alt="Fashion" />
          </div>
          <div className="carousel-item">
            <img src="https://img.freepik.com/free-vector/flat-supermarket-sale-background_23-2149379271.jpg" className="d-block w-100 banner-img" alt="Grocery" />
          </div>
        </div>
        <button className="carousel-control-prev" type="button" data-bs-target="#productCarousel" data-bs-slide="prev">
          <span className="carousel-control-prev-icon"></span>
        </button>
        <button className="carousel-control-next" type="button" data-bs-target="#productCarousel" data-bs-slide="next">
          <span className="carousel-control-next-icon"></span>
        </button>
      </div>
    </div>
  );
};

export default Home;
