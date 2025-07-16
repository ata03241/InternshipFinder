import { BrowserRouter} from 'react-router';
import './App.css'
import { Header } from './Component/header';
import { Home } from './Pages/home';
import { Footer } from './Component/footer';

function App() { 
  return (
    <>
      <BrowserRouter>
          <Header />
          <Home/>
          {/* <Footer /> */}
      </BrowserRouter>
    </>
  )
}

export default App
