[![Build status](https://ci.appveyor.com/api/projects/status/7a2472615jflqgit?svg=true)](https://ci.appveyor.com/project/pnewhook/uavdb)

#UAVdb
An online repository of your drone flights

##Dev instructions
UAVdb is an ASP.Net MVC 6 applicaiton. That framework is still under development so expect a few hiccups. 
### Dependencies
 - node
 
 
### Environment Setup
#### Platform Agnostic
```
npm install -g gulp bower nodemon
```

#### Windows
```
powershell -NoProfile -ExecutionPolicy unrestricted -Command "iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/aspnet/Home/master/kvminstall.ps1'))"
```