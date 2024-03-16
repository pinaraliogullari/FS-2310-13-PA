import { StyleSheet, Text, View, Button } from 'react-native'
import { Card } from '@rneui/themed'
import React from 'react'
import { useDispatch } from 'react-redux'

const CardComponent = ({ item }) => {

    const dispatch = useDispatch()
    const handleCart = () => {
        dispatch(addToCart(item))
    }
    return (
        <Card>
            <Card.Title>{item.title}</Card.Title>
            <Card.Divider />
            <Card.Image source={{
                uri: item.thumbnail
            }} />
            <Text>{item.price}$</Text>
            <Button title='Add to Cart' onPress={handleCart} />
        </Card>
    )
}

export default CardComponent

const styles = StyleSheet.create({})