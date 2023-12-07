import React from 'react'
import { Button, Container, Form, InputGroup } from 'react-bootstrap'

const SearchForm = () => {

    const handleSubmit = (e) => {
        e.preventDefault();
    }
    return (
        <>
            <Container className='py-3'>

                <Form onSubmit={handleSubmit}>
                    <InputGroup>
                        <Form.Control placeholder='Please enter a github account name'>

                        </Form.Control>
                        <Button type='submit' variant='primary'>Search</Button>
                    </InputGroup>
                </Form>
            </Container>
        </>
    )
}

export default SearchForm