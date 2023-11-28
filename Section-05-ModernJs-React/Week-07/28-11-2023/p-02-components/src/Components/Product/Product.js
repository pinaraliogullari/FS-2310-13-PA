import React from 'react'
import "./Product.css";

function Product() {
    return (
        <>
            <div className='Product'>
                <img src='https://picsum.photos/id/237/50/75' />
                <h5>IPhone 13 Pro</h5>
                <p>How is it going</p>
                <button type='button'>Sepete ekle</button>

            </div>
        </>
    )
}

export default Product;