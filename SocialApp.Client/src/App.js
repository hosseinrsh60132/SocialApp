import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { useEffect } from 'react';

function App() {
  // const [activities, setActivities] = useState([])

  useEffect(() => {

    axios.get("https://localhost:7122/api/activities")
      .then((response) => {

        console.log('ine ha:', response)

        // setActivities(response.data)
      })

  }, [])
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />



      </header>
    </div>
  );
}

export default App;
