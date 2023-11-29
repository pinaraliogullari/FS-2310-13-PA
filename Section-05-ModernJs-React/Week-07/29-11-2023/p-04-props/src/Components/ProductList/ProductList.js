import React from 'react';
import Product from '../Product/Product';

function ProductList(products) {
  return (
    <>
  {
    products.forEach(p => {
    <Product product={p}/>  
    })};
  

    </>
  )
}

export default ProductList;