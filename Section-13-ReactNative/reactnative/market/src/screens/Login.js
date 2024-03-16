import { StyleSheet, Text, View, Button, TextInput } from 'react-native'
import React, { useState } from 'react'
import axios from 'axios'

const Login = ({ navigation }) => {
  const [username, setUsername] = useState("")
  const [password, setPassword] = useState("")
  const handleLogin = async () => {
    try {
      let requestObj = {
        username: username,
        password: password,
      }
      await axios.post("https://dummyjson.com/auth/login", requestObj)
        .then(res => console.log(res.data))
    } catch (error) {
      console.log(error)
      console.log("Login Error", error)
    }
  }
  return (
    <View>

      <TextInput style={styles.input}
        placeholder='Username'
        value={username}
        onChangeText={setUsername} />
      <TextInput style={styles.input}
        placeholder='Password'
        value={password}
        onChangeText={setPassword} />

      <Button title='Login'
        onPress={() => handleLogin()}
      />

      {/* <Button title='Go Home'
        onPress={() => navigation.navigate('Home')}
         /> */}
    </View>
  )
}

export default Login

const styles = StyleSheet.create({
  input: {
    height: 40,
    margin: 12,
    borderWidth: 1,
    padding: 10,
  },
})