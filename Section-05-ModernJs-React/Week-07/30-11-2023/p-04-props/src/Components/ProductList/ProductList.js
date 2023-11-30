import React from 'react';
import Product from '../Product/Product';

function ProductList( props ) {
  return (
    <>
      {
       props.products.map(p => <Product key={p.id} product={p} />)
       
       //yukarıdaki map satırınad aslında bunları yapıyoruz.
      //  <Product product={products[0]}/>
        //  <Product product={products[1]}/>
        //  <Product product={products[2]}/>
        //  <Product product={products[3]}/>

      }
    </>
  )
}

export default ProductList;