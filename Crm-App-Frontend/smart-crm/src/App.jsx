import { useState } from "react";

export default function Login() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();
    if (!email || !password) {
      setError("Lütfen email ve şifre girin.");
      return;
    }
    setError("");
    alert(`Giriş denemesi: ${email} / ${password}`);
  };

  return (
    <div className="min-h-screen flex items-center justify-center bg-gradient-to-r from-indigo-500 via-purple-500 to-pink-500 px-4">
      <div className="max-w-md w-full bg-white bg-opacity-90 backdrop-blur-md rounded-xl shadow-lg p-10">
        <h2 className="text-3xl font-extrabold mb-8 text-center text-gray-800">
          Giriş Yap
        </h2>

        {error && (
          <div className="bg-red-100 text-red-700 p-3 mb-6 rounded-lg font-medium">
            {error}
          </div>
        )}

        <form onSubmit={handleSubmit} className="space-y-6">
          <div>
            <label className="block mb-2 font-semibold text-gray-700">Email</label>
            <input
              type="email"
              className="w-full px-4 py-3 rounded-lg border border-gray-300 focus:border-indigo-500 focus:ring focus:ring-indigo-300 focus:outline-none transition"
              placeholder="example@mail.com"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              required
              autoFocus
            />
          </div>

          <div>
            <label className="block mb-2 font-semibold text-gray-700">Şifre</label>
            <input
              type="password"
              className="w-full px-4 py-3 rounded-lg border border-gray-300 focus:border-indigo-500 focus:ring focus:ring-indigo-300 focus:outline-none transition"
              placeholder="Şifrenizi girin"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              required
            />
          </div>

          <button
            type="submit"
            className="w-full py-3 bg-indigo-600 text-white font-semibold rounded-lg shadow-md hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-1 transition transform hover:scale-105"
          >
            Giriş Yap
          </button>
        </form>

        <p className="mt-6 text-center text-gray-600">
          Hesabınız yok mu?{" "}
          <a href="#" className="text-indigo-600 font-semibold hover:underline">
            Kayıt Ol
          </a>
        </p>
      </div>
    </div>
  );
}
