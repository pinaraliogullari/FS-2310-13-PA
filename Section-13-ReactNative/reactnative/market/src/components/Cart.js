import { StyleSheet, Text, View, Button } from 'react-native'
import React from 'react'
import { useSelector } from 'react-redux'

const Cart = ({ goToDetail }) => {

    const cartNumber = useSelector(state => state.Cart)
    return (
        <View style={styles.container}>
            <View style={styles.buttonContainer}>
                <Button title={`${cartNumber}`} onPress={goToDetail}></Button>
            </View>
        </View>
    )
}

export default Cart

const styles = StyleSheet.create({
    container: {
        display: 'flex',
        marginVertical: 10
    },
    buttonContainer: {
        width: 100,
        alignSelf: 'flex-end'
    }
})