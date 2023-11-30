import { useState } from 'react';
import './App.css';
import ProductList from './Components/ProductList/ProductList';
import TickTock from './Components/TicTock/TickTock';

function App() {
  // const firstName = "Engin";
  // const lastName = "Ergül";
  // const age = 48;


  //diyelim ki apidan ya da bir veri tabanından ürün listesini çektik.
  let products = [
    { id: 1, name: "Iphone 14", desc: "Hoş bir telefon", price: 43000 },
    { id: 2, name: "Iphone 15", desc: "Hoş bir telefon", price: 53000 },
    { id: 3, name: "Iphone 16", desc: "Hoş bir telefon", price: 63000 },
    { id: 4, name: "Iphone 17", desc: "Hoş bir telefon", price: 73000 }

  ];
  let [number, setNumber] = useState(10);
  function numberAdd() {
    setNumber(++number);
  }
  return (

    <>
      <div>
        {/* <TickTock firtName={firstName} lastName={lastName} age={age} />
        <TickTock firtName={"Alex de"} lastName={"Sauza"} age={43} /> */}
        <button onClick={numberAdd}>Tıkla</button>
        <label>{number}</label>
        <ProductList products={products} />


      </div>
    </>
  );
}

export default App;
