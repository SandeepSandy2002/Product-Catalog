import React, { useContext, useEffect, useState } from 'react';
import { AppContext } from '../context/AppContext';
import axios from 'axios';
import './Catalog.css';

const Catalog = () => {
  const { addToCart, isLoggedIn, setShowLoginModal } = useContext(AppContext);
  const [products, setProducts] = useState([]);
  const [selectedCategory, setSelectedCategory] = useState('');

  const categories = [...new Set(products.map(product => product.Category))];

  useEffect(() => {
    const fetchProducts = async () => {
      try {
        const response = await axios.get('https://productserver-f2dycfc9cpg2dggu.canadacentral-01.azurewebsites.net/api/Product');
        if (response.data && response.data.$values && Array.isArray(response.data.$values)) {
          setProducts(response.data.$values);
        } else {
          console.error('Expected an array of products in "$values", but got:', response.data);
        }
      } catch (error) {
        console.error('Error fetching products:', error);
      }
    };

    fetchProducts();
  }, []);

  const handleCategoryChange = (e) => {
    setSelectedCategory(e.target.value);
  };

  const filteredProducts = selectedCategory
    ? products.filter(product => product.Category === selectedCategory)
    : products;

  const handleAddToCart = (product) => {
    addToCart(product);
  };

  return (
    <div className="catalog-container">
      <h2 className="catalog-title">Product Catalog</h2>

      <div className="mb-3 container">
        <label htmlFor="category" className="form-label">Select Category</label>
        <select
          id="category"
          className="form-select"
          onChange={handleCategoryChange}
          value={selectedCategory}
        >
          <option value="">All Categories</option>
          {categories.map((Category) => (
            <option key={Category} value={Category}>
              {Category}
            </option>
          ))}
        </select>
      </div>

      <div className="row container mx-auto">
        {filteredProducts.length > 0 ? (
          filteredProducts.map((product) => (
            <div key={product.Id} className="col-md-3 mb-4">
              <div className="card shadow-sm h-100">
                {product.ImageUrl && (
                  <img
                    src={product.ImageUrl}
                    alt={product.Name}
                    className="card-img-top"
                    style={{ height: '180px', objectFit: 'cover' }}
                  />
                )}
                <div className="card-body text-center">
                  <h5 className="card-title">{product.Name}</h5>
                  <p className="card-text">Price: ${product.Price}</p>
                  <button
                    className="btn btn-primary"
                    onClick={() => handleAddToCart(product)}
                  >
                    Add to Cart
                  </button>
                </div>
              </div>
            </div>
          ))
        ) : (
          <p>No products found in this category.</p>
        )}
      </div>
    </div>
  );
};

export default Catalog;
