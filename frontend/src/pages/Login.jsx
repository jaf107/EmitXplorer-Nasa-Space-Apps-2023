import { useState } from "react";
import { Link } from "react-router-dom";

export default function Login() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [errors, setErrors] = useState({});

  const handleSubmit = (e) => {
    e.preventDefault();

    setEmail("");
    setPassword("");
  };

  function LoginButton() {
    return (
      <div>
        <button
          type="submit"
          className="w-full bg-secondary text-md lg:text-lg text-white font-bold py-2 px-4 mt-12 mb-8 rounded"
          onClick={handleSubmit}
        >
          Login
        </button>
      </div>
    );
  }

  return (
    <>
      <div className="p-8 flex flex-col h-screen items-center justify-center bg-emit font-title">
        <h1 className="font-title text-3xl mt-12 text-white">
          Welcome to <span className="text-5xl font-bold">EmitXplorer</span>
        </h1>
        <div className="flex flex-col my-8 md:my-12 lg:my-16 w-1/4">
          <form>
          <label className="text-secondary text-xl font-bold mb-12">Email</label>
          <input
            className='w-full mt-4 mb-8 bg-gray-400 appearance-none border-2 border-primary rounded-lg py-2 px-4 placeholder:text-white text-black text-sm md:text-lg lg:text-lg focus:outline-none focus:bg-gray-200 focus:border-primary"'
            type="text"
            label="Email"
            placeholder="Enter your email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          ></input>
          <label className="text-secondary text-xl font-bold mb-12">Password</label>
          <input
            className='w-full my-4 bg-gray-400 appearance-none border-2 border-primary rounded-lg py-2 px-4 placeholder:text-white text-black text-sm md:text-lg lg:text-lg focus:outline-none focus:bg-gray-200 focus:border-primary"'
            type="password"
            label="Password"
            placeholder="Enter your password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
          ></input>
          <LoginButton />
          <h2 className="text-white text-center text-lg mt-12">Don't have an account? <span className="text-2xl font-bold text-secondary">Create One!</span></h2>
          </form>
        </div>
      </div>
    </>
  );
}
