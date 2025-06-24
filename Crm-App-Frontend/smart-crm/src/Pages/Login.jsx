import { useState } from "react";
import { FiMail, FiLock } from "react-icons/fi";

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
    <div className="flex items-center justify-center min-h-screen bg-gradient-to-br from-indigo-600 via-purple-600 to-pink-500 px-4 py-12">
      <div className="w-full max-w-md bg-white bg-opacity-95 rounded-2xl shadow-xl p-10 backdrop-blur-md">
        <div className="text-center mb-8">
          <h1 className="text-4xl font-bold text-gray-800 mb-2">Smart CRM</h1>
          <p className="text-gray-500">Hesabınıza giriş yapın</p>
        </div>

        {error && (
          <div className="bg-red-100 text-red-700 p-3 mb-6 rounded-lg font-semibold text-center">
            {error}
          </div>
        )}

        <form onSubmit={handleSubmit} className="space-y-6">
          <div className="relative">
            <FiMail className="absolute left-3 top-1/2 -translate-y-1/2 text-gray-400" size={20} />
            <input
              type="email"
              placeholder="Email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              className="pl-10 w-full py-3 rounded-lg border border-gray-300 focus:border-indigo-500 focus:ring focus:ring-indigo-300 focus:outline-none transition"
              required
            />
          </div>

          <div className="relative">
            <FiLock className="absolute left-3 top-1/2 -translate-y-1/2 text-gray-400" size={20} />
            <input
              type="password"
              placeholder="Şifre"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              className="pl-10 w-full py-3 rounded-lg border border-gray-300 focus:border-indigo-500 focus:ring focus:ring-indigo-300 focus:outline-none transition"
              required
            />
          </div>

          <div className="flex justify-between text-sm text-gray-600">
            <label className="flex items-center space-x-2">
              <input type="checkbox" className="form-checkbox h-4 w-4 text-indigo-600" />
              <span>Beni Hatırla</span>
            </label>
            <a href="#" className="hover:underline text-indigo-600">
              Şifremi Unuttum?
            </a>
          </div>

          <button
            type="submit"
            className="w-full py-3 bg-indigo-600 text-white font-semibold rounded-lg shadow-md hover:bg-indigo-700 transition transform hover:scale-[1.03] focus:ring-2 focus:ring-indigo-400"
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
