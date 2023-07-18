import React, { useState } from "react";
import { useNavigate } from 'react-router-dom';

const Login = (props) => {
    const [email, setEmail] = useState("");
    const [pass, setPass] = useState("");
    const [name, setName] = useState("");
    const navigate = useNavigate();

    const handleSubmit = (e) => {
        e.preventDefault();

    };

    return (
        <div className="">
            <div className="items-center ">
                <div className="bg-white shadow-md   items-center   mx-auto   flex items-center justify-center h-screen">
                    <form onSubmit={handleSubmit}>
                        <div id="Registro" className="">
                            <h1 className="text-center text-5xl">Login</h1> <br />

                        </div>

                        <div id="Registro" className="">
                            <label className="block text-black uppercase font-bold">
                                Correo Electronico
                            </label>
                            <input
                                id="emailUser"
                                type="text"
                                onChange={(ev) => setEmail(ev.target.value)}
                                className=" mb-5 border-2 w-full p-2 mt-2  placeholder-gray-400  rounded-md"
                                placeholder="Introduzca su Email"
                            ></input>
                        </div>

                        <div className="">
                            <label className="block text-black uppercase font-bold">
                                Contraseña
                            </label>
                            <input
                                id="Password"
                                type="password"
                                onChange={(ev) => setPass(ev.target.value)}
                                className=" mb-5 border-2 w-full p-2 mt-2 placeholder-gray-400 rounded-md"
                                placeholder="Contraseña"
                            ></input>
                        </div>

                        <input
                            type="submit"
                            onSubmit={handleSubmit}
                            className=" py-2 px-2 bg-blue-700 w-full p-3 text-white uppercase font-bold rounded-md hover:scale-105 cursor-pointer"
                        />
                    </form>
                </div>
            </div>
        </div>
    );
};

export default Login;
