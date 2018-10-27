# MovieApp
A small single page web application that utilizes https://www.themoviedb.org API.
![Screenshot Preview](https://i.gyazo.com/b9ee9feac2cb1393a6fd6ca6e834b567.jpg)

### Built With
- C# - Web App Framework and API
- AngularJS - Front end controller
- Bootstrap - Styling

### About
The goal was to keep it as simple as possible and only allowing the user to search for Movies. I made a few imporvements that made sense to me for a single page application given the requirements. The first was that I load the page with 10 most popular movies according to TheMovieDB. The user then can use the search bar above to find specific movie titles. Another improvement I made was to add the release date and title to the movie results to give the posters more context. I would have added more info but It seemed to stray far from the requirements.

### Requirements
The following Nuget packages are required to build and run the project:
- MicrosoftAspNet.MVC
- MicrosoftAspNet.Razor
- MicrosoftAspNet.WebAPI
- MicrosoftAspNet.WebAPI.Client
- MicrosoftAspNet.WebAPI.Core
- MicrosoftAspNet.WebAPI.WebHost
- MicrosoftAspNet.WebPages
- Microsoft.CodeDom.Providers.DotNetCompilerPlatform
- Microsfot.Web.Infrastructure
- Newtonsoft.Json
- RestSharp
