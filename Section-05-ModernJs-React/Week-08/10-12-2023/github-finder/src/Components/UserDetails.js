import React, { useContext, useEffect } from 'react'
import { useParams } from 'react-router-dom'
import { AppContext } from '../Contexts/AppContext';
import { Container, Card, Row, Col, ListGroup, CardBody, CloseButton, CardHeader } from 'react-bootstrap';
import UserRepo from './UserRepo';

const UserDetails = ({ login }) => {
    const context = useContext(AppContext);

    useEffect(() => {
        context.getUser(login);
        context.getRepos(login);
    }, [])
    return (
        <>
            <Card>
                <Row>
                    <Col xs={12}>
                        <Card.Header className='d-flex justify-content-between align-items-center display-6 text-danger'>
                            {context.user.name} ({context.user.login})
                            <CloseButton onClick={() => { context.setUser({}) }} className='fs-4' />
                        </Card.Header>
                    </Col>
                </Row>
                <Row>
                    <Col xs={4}>
                        <CardBody>
                            <Card.Img className="mb-3" src={context.user.avatar_url} />
                            <div className='d-flex justify-content-between align-items-center'>
                                <Card.Title className='fs-6'>Followers: {context.user.followers} </Card.Title>
                                <Card.Title className='fs-6'>Following: {context.user.following}</Card.Title>
                            </div>
                        </CardBody>
                    </Col>
                    <Col xs={8}>
                        <CardBody>
                            <ListGroup className='flex-row flex-wrap'>
                                {context.userRepos.map(userRepo => <UserRepo key={userRepo.id} userRepoName={userRepo.name} userRepoUrl={userRepo.html_url} />)}
                            </ListGroup>
                        </CardBody>
                    </Col>
                </Row>
            </Card>
        </>
    )
}

export default UserDetails;