import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import Header from './Components/Header';
import HomePage from './Pages/HomePage/HomePage.js';
import SearchPage from './Pages/SearchPage/SearchPage.js';
import UserDetailsPage from './Pages/UserDetailsPage/UserDetailsPage.js';
import Footer from './Pages/Footer/Footer.js';
import { AppContext } from './Contexts/AppContext.js';
import { useEffect, useState } from 'react';
import Axios from 'axios';

function App() {
  const token = "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";
  const config = {
    headers: { Authorization: `Bearer ${token}` }
  }
  const [users, setUsers] = useState([]);
  const [user, setUser] = useState({});
  const [userRepos, setUserRepos] = useState([]);

  const searchUsers = (keyword) => {
    Axios
      .get('https://api.github.com/users', config)
      .then((response) => {
        // get isteği tamamlandıktan sonra buradaki kodları çalıştır
        setUsers(response.data);
      })
  }

  const getUser = (userName) => {
    Axios
      .get(`https://api.github.com/users/${userName}`, config)
      .then(response => { setUser(response.data) });
  }

  const getRepos = (userName) => {
    Axios
      .get(`https://api.github.com/users/${userName}/repos`, config)
      .then(response => { setUserRepos(response.data) });
  }
  useEffect(() => {
    searchUsers();
  }, []);

  return (
    <>
      <AppContext.Provider value={{ users, getUser, user, userRepos, getRepos }}>
        <BrowserRouter>
          <Header />
          <Routes>
            <Route path="/" element={<HomePage />} />
            <Route path="/search" element={<SearchPage />} />
            <Route path="/getuser/:login" element={<UserDetailsPage />} />
          </Routes>
          <Footer />
        </BrowserRouter>
      </AppContext.Provider>
    </>
  );
}

export default App;
