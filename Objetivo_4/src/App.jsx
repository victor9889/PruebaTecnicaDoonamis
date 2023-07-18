import Register from './components/register';
import Login from './components/Login';
import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';

function App() {

  return (
    <BrowserRouter>
        <Routes>
          <Route path="/" element={<Register />} />
          <Route path="/login" element ={<Login/>} />
          {/* <Route path="/login" element={<Login/>}/>
          <Route path="/doctor" element={<VistaDoctores/>}/>
          <Route path="/pacientes" element={<VistaPacientes/>}/> */}
        </Routes>

    </BrowserRouter>
  )
}

export default App
