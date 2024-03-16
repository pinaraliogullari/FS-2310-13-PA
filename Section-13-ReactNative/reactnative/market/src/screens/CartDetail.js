import { FlatList, StyleSheet, Text, View } from 'react-native'
import React from 'react'

const CartDetail = () => {
    const products = useSelector(state => state.Cart.products)
    return (
        <View>
            <FlatList
                data={products}
                renderItem={({ item }) => <CartItem item={item} />}
            />
            <Button title='Clear Cart' onPress={null} color={'red'}/>
        </View>
    )
}

export default CartDetail

const styles = StyleSheet.create({})