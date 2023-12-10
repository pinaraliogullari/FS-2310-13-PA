import React, { useContext, useEffect, useState } from 'react'
import { Container, Form, InputGroup, Button } from 'react-bootstrap'
import { AppContext } from '../Contexts/AppContext';

const SearchForm = () => {
    const context = useContext(AppContext);
    const [keyword, setKeyword] = useState("");
    const handleSubmit = (e) => {
        e.preventDefault();
        context.searchUsers(keyword);

    }
    const handleClearAllClick = () => {
        context.setUsers([]);
        setKeyword("");
        context.setIsClearButtonShow(false);
    }
    useEffect(() => {
        handleClearAllClick();
    }, [])

    return (

        <>
            <Container className='py-3'>
                <Form onSubmit={handleSubmit}>
                    <InputGroup>
                        <Form.Control value={keyword} onChange={(e) => { setKeyword(e.target.value) }} placeholder='Enter search user name'>
                        </Form.Control>
                        <Button variant='primary' type='submit'>Search</Button>
                    </InputGroup>
                    {context.isClearButtonShow &&
                        <div className='d-grid mt-2'>
                            <Button onClick={handleClearAllClick} variant='danger'>
                                Clear All
                            </Button>
                        </div>
                    }
                </Form>
            </Container>
        </>
    )
}

export default SearchForm