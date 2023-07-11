import React, { useState } from 'react';
import axios from 'axios';
import { useEffect } from 'react';
import './styles.css';
import { Activity } from '../models/activity';
import Navbar from './AppBarr'
import ActivityList from './Activity/dashboard/ActivityList';
function App() {

const [activities, setActivities] = useState<Activity[]>([]);

  useEffect(() => {

    // axios.get("https://localhost:7122/api/activities")
    //   .then((response) => {

    //     console.log('ine ha:', response)

    //     // setActivities(response.data)
    //   })

  }, [])
  return (
    // <div className="App">
    //   <ul>
    //   {
    //     activities.map((activity : Activity)=>(
    //       <li key={activity.id}>
    //         {activity.title}
    //       </li>
    //     ))
    //   }

    //   </ul>
    // </div>
    <div>
      <Navbar />

<ActivityList/>
<br/>

      </div>
  );
}

export default App;
