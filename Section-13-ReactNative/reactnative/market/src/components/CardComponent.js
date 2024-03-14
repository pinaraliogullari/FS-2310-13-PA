import { StyleSheet, Text, View, Button } from 'react-native'
import { Card } from '@rneui/themed'
import React from 'react'

const CardComponent = ({ item }) => {
    return (
        <Card>
            <Card.Title>{item.title}</Card.Title>
            <Card.Divider />
            <Card.Image source={{
                uri: item.thumbnail
            }} />
            <Text>{item.price}$</Text>
            <Button title='Add to Cart' onPress={null} />
        </Card>
    )
}

export default CardComponent

const styles = StyleSheet.create({})