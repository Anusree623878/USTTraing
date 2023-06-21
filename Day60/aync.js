async function findCityWithHighestTemperature() {

    try {
   
     const response = await fetch('weatherData.json');
   
     const data = await response.json();
   
     let maxTemperature = -Infinity;
   
     let cityWithHighestTemperature = '';
   
     data.forEach(city => {
   
      if (city.temperature > maxTemperature) {
   
       maxTemperature = city.temperature;
   
       cityWithHighestTemperature = city.name;
   
      }
   
     });
   
      console.log('City with the highest temperature:');
   
      console.log('City:', cityWithHighestTemperature);
   
      console.log('Temperature:', maxTemperature);
   
    } catch (error) {
   
        console.log('Error:', error);
   
    }
   
   }
   
   findCityWithHighestTemperature();