import React, { useState } from "react";
import { useNavigate } from 'react-router-dom';

const Register = (props) => {
    const [email, setEmail] = useState("");
    const [pass, setPass] = useState("");
    const [name, setName] = useState("");
    const navigate = useNavigate();



    const handleSubmit = (e) => {
        e.preventDefault();

        fetch("http://localhost:5238/auth/User/register", {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify({
                userName: name,
                userEmail: email,
                userPassword: pass,
            }),
        })
            .then((response) => {
                if (response.ok) {
                    alert("¡Registro satisfactorio!");
                    navigate("/login");
                } else {
                    alert("El email ya está en uso.");
                }
            })
            .catch((error) => {
                console.error(error);
                // Manejo de errores, por ejemplo, mostrar un mensaje de error al usuario
            });
    };

    return (
        <div className="flex items-center justify-center h-screen">
            <div className="bg-white shadow-md  mx-auto">
                <form onSubmit={handleSubmit}>
                    <div id="Registro" className="">
                        <h1 className="text-center text-5xl">Registro</h1> <br />
                        <label className="block text-black uppercase font-bold">
                            Tipo de usuario
                        </label>
                        <input
                            id="nombreUsuario"
                            type="text"
                            onChange={(ev) => setName(ev.target.value)}
                            className=" mb-5 border-2 w-full p-2 mt-2  placeholder-gray-400  rounded-md"
                            placeholder="Introduzca su Nombre"
                        ></input>

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
    );
};

export default Register;
