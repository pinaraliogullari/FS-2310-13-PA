import { StyleSheet, Text, View, Button, FlatList } from 'react-native'
import React from 'react'
import { NavigationContainer } from '@react-navigation/native'
import Home from './src/screens/Home'
import Login from './src/screens/Login'
import { createNativeStackNavigator } from '@react-navigation/native-stack'
import LoginFormik from './src/screens/LoginFormik'
import Toast from 'react-native-toast-message'
import { Provider } from 'react-redux'
import { store } from './src/store/store'
import CartDetail from './src/screens/CartDetail'

const Stack = createNativeStackNavigator()

const App = () => {
    return (
        <Provider store={store}>
            <NavigationContainer>
                <Stack.Navigator>
                    <Stack.Screen name='Login' component={LoginFormik} />
                    <Stack.Screen name='Home' component={Home} options={{ headerShown: false }} />
                    <Stack.Screen name='CartDetail' component={CartDetail} options={{ headerShown: false }} />
                </Stack.Navigator>
            </NavigationContainer>
            <Toast />
        </Provider>

    )
}
export default App

const styles = StyleSheet.create({})