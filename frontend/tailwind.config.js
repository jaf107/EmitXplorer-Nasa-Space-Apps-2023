/** @type {import('tailwindcss').Config} */
export default {
  content: [
    "./index.html",
    "./src/**/*.{js,ts,jsx,tsx}",],
  theme: {
    fontFamily: {
      title: ['Montserrat', 'sans-serif'],
      body: ['Open Sans', 'sans-serif']
    },
    extend: {
      colors: {
        'primary': '#1D3D27',
        'secondary': '#22873E'
      },
      backgroundImage: {
        'emit': "url('/bg.png')",
      }
    },
  },
  plugins: [],
}

