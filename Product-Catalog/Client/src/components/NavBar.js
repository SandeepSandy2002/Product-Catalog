import React, { useContext } from 'react';
import { AppContext } from '../context/AppContext';
import { Link, useNavigate } from 'react-router-dom';
import './NavBar.css';

const Navbar = () => {
  const { logout, cartItems, isLoggedIn, setShowLoginModal } = useContext(AppContext);
  const navigate = useNavigate();

  const handleLogout = () => {
    logout();
    navigate('/');
  };

  return (
    <nav className="navbar navbar-expand-lg navbar-dark bg-dark px-4 custom-navbar">
      <div className="container-fluid">
        {/* Left Nav Items */}
        <div className="d-flex align-items-center">
          <Link to="/home" className="nav-link">Home</Link>
          <Link to="/catalog" className="nav-link">Catalog</Link>
        </div>

        {/* Center Brand */}
        <span className="navbar-brand mx-auto app-name">
          🛍️ SP MART 🛍️
        </span>

        {/* Right Nav Items */}
        <div className="d-flex align-items-center">
          <Link to="/orders" className="nav-link">Orders</Link>
          <Link to="/cart" className="nav-link">Cart
            <i className="bi bi-cart-fill"></i> ({cartItems.length})
          </Link>
          {isLoggedIn ? (
            <button className="btn btn-outline-light ms-3" onClick={handleLogout}>
              Logout
            </button>
          ) : (
            <button className="btn btn-outline-light ms-3" onClick={() => setShowLoginModal(true)}>
              Login
            </button>
          )}
        </div>
      </div>
    </nav>
  );
};

export default Navbar;
