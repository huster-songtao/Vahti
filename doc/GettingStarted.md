# Getting started
Starting to use Vahti requires setting up different kind of things depending on what you want to achieve. The tutorials focus on Android.

- [Full setup tutorial](FullTutorial.md) describes how to set up system where full functionality of Vahti is used: read data using Vahti.Collector, relay data to cloud database using Vahti.DataBroker and show it in mobile app on Android.
- [No Azure notifications tutorial](NoAzureNotificationsTutorial.md) describes show to set up system like in full tutorial, except that no Azure notifications are configured. You can configure email notifications, however, using [Alert tutorial](AlertTutorial.md)
- [Alert tutorial](AlertTutorial.md) describes how to get just alerts without having mobile app
- [Robotic lawn mower tutorial](RoboticLawnMowerTutorial.md) shows how to use RuuviTag to check that robotic lawn mower has returned to charging station
- [Web application tutorial](WebAppTutorial.md) shows how to set up the web application to use it with or without the mobile app

Configuration file options have been described in [Configuration](Configuration.md). Latest released binaries can be found from [Releases page](https://github.com/ilpork/vahti/releases/latest/).

If you want to have other devices to publish their data using MQTT via Vahti, check [Add other data sources](AddOtherDataSources.md).

Mobile app only shows the information provided by Vahti.Server. The current approach is quite limiting but clear. Vahti.Server publishes measurement data so, that mobile app knows how the data should be shown. In practice it happens by declaring which kind of data do they send.

`Sensor.Class` is an essential part of it. Each sensor, like temperature sensor, must define its class. For temperature sensor it's `temperature`. That way mobile app knows that it's temperature data, and should be shown in UI in certain way. 
```
{
    "id": "temperature",
    "name": "Temperature",
    "class": "temperature",
    "unit": "°C"
}
```

Each `SensorDevice`, respectively, has `Location` defined. Location is used to group different measurements under same header in mobile app.
```
{
    "id": "ruuviGarage",
    "address": "12:34:56:78:90:AB",
    "name": "RuuviTag in garage",
    "sensorDeviceTypeId": "RuuviTag",
    "location": "Garage"
},
```

