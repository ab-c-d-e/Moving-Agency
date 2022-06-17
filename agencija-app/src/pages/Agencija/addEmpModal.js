import React,{Component} from 'react';
import {Modal,Button, Row, Col, Form,Image} from 'react-bootstrap';
import "./Agencija.css"

export default class AddEmpModal extends Component{
    constructor(props){
        super(props);
        this.state={deps:[]};
        this.handleSubmit=this.handleSubmit.bind(this);
        this.handleFileSelected=this.handleFileSelected.bind(this);
    }

    photofilename = "anonymous.png";
    imagesrc = process.env.REACT_APP_PHOTOPATH+this.photofilename;

    handleSubmit(event){
        event.preventDefault();
        fetch("https://localhost:5001/Korisnik/register/radnikP",
        {
          method:"POST",
          headers: {"Content-Type":"application/json"},
          body: JSON.stringify({
            ime:event.target.Ime.value,
            prezime:event.target.Prezime.value,
            userName:event.target.Username.value,
            email:event.target.Email.value,
            password:event.target.Password.value
          })
        }).then(r=>{
            if(r.ok){
                this.props.onHide();
            }
            else
            {
              r.json().then(res=>
                {
                  alert(res.message);
                })
            }
          });
    }


    handleFileSelected(event){
        event.preventDefault();
        this.photofilename=event.target.files[0].name;
        const formData = new FormData();
        formData.append(
            "myFile",
            event.target.files[0],
            event.target.files[0].name
        );

        fetch(process.env.REACT_APP_API+'Employee/SaveFile',{
            method:'POST',
            body:formData
        })
        .then(res=>res.json())
        .then((result)=>{
            this.imagesrc=process.env.REACT_APP_PHOTOPATH+result;
        },
        (error)=>{
            alert('Failed');
        })
        
    }

    render(){
        return (
            <div className="container">

<Modal
{...this.props}
aria-labelledby="contained-modal-title-vcenter"
centered
>
    <Modal.Header closeButton>
        <Modal.Title id="contained-modal-title-vcenter">
        <i class="bi bi-plus-circle"></i> Dodaj radnika za procene
        </Modal.Title>
    </Modal.Header>
    <Modal.Body style={{height:"100%"}}>

                <Form onSubmit={this.handleSubmit}>
                    <Form.Group controlId="Ime">
                        <Form.Label>Ime radnika</Form.Label>
                        <Form.Control type="text" name="Ime" required 
                        placeholder="Ime radnika"/>
                    </Form.Group>

                    <Form.Group style={{marginTop:"10px"}} controlId="Prezime">
                        <Form.Label>Prezime radnika</Form.Label>
                        <Form.Control type="text" name="Prezime" required 
                        placeholder="Prezime radnika"/>
                    </Form.Group>

                    <Form.Group style={{marginTop:"10px"}} controlId="Username">
                        <Form.Label><i class="bi bi-person"></i> Username radnika</Form.Label>
                        <Form.Control type="text" name="Username" required 
                        placeholder="Username radnika"/>
                    </Form.Group>

                    <Form.Group style={{marginTop:"10px"}} controlId="Email">
                        <Form.Label><i class="bi bi-envelope"></i> Email radnika</Form.Label>
                        <Form.Control type="text" name="Email" required 
                        placeholder="Email radnika"/>
                    </Form.Group>

                    <Form.Group style={{marginTop:"10px"}} controlId="Password">
                        <Form.Label><i class="bi bi-key"></i> Password radnika</Form.Label>
                        <Form.Control type="password" name="Password" required 
                        placeholder="Password radnika"/>
                    </Form.Group>

                    <Form.Group>
                        <Button style={{marginTop:"20px"}} variant="primary" type="submit">
                            Dodaj radnika 
                        </Button>
                    </Form.Group>
                </Form>
    </Modal.Body>
    
    <Modal.Footer>
        <Button variant="danger" onClick={this.props.onHide}>Zatvori</Button>
    </Modal.Footer>

</Modal>

            </div>
        )
    }

}