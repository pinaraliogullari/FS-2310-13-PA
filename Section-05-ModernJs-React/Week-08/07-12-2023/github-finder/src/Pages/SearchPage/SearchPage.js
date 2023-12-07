import React from 'react';
import SearchForm from '../../Components/SearchForm';

const SearchPage = () => {
    return (
        <>
            {/* buraya search işlemleri için bir Component
bir de sonuçları göstereceğimiz bir component hazırlayacağız. */}
            <SearchForm />
        </>
    )
}

export default SearchPage;