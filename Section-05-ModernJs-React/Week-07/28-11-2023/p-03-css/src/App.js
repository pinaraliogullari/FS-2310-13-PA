import './App.css';
import Header from "./Header.js";
import { Container, Row, Col, Nav, Navbar, Image, Button, Card } from "react-bootstrap";
import Products from './Products.js';

function App() {
  return (
    <>
      <Header />
      <Products />
    </>
  );
}

export default App;
