import { StyleSheet, Text, View, Button, FlatList } from 'react-native'
import React from 'react'
import { NavigationContainer } from '@react-navigation/native'
import Home from './src/screens/Home'
import Login from './src/screens/Login'
import { createNativeStackNavigator } from '@react-navigation/native-stack'

const Stack = createNativeStackNavigator()

const App = () => {
    return (
        <NavigationContainer>
            <Stack.Navigator>
                <Stack.Screen name='Login' component={Login} />
                <Stack.Screen name='Home' component={Home} options={{ headerShown: false }} />
            </Stack.Navigator>
        </NavigationContainer>
    )
}
export default App

const styles = StyleSheet.create({})