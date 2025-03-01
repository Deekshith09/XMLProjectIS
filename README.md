**MOVIE RECOMMENDATION**

![MicrosoftTeams-image](https://user-images.githubusercontent.com/90084383/140229869-7ca45c4f-bcdb-4a42-b3d1-1f158f25d1ab.png)
________________________________________
**Introduction**
Discover all the movie recommendations you need for your mood. Find movies by genres, ratings and cast. BingWatch.com provides you with list of movie recommendations as per your needs.

•	Search movie by popularity/ audience ratings

•	Search movie by genre

•	Search movie by cast and crew

•	Details regarding Movie Title, Release date, Production Country, Original language, Revenue generated, Runtime and Ratings will be populated

________________________________________

**Data Feeds**

Dataset of 50,000 movies: [Movie Repository](https://raw.githubusercontent.com/prust/wikipedia-movie-data/master/movies.json)

Dataset of Movies with their details and ratings: [Movie ratings](https://github.com/Anukriti007/XMLProjectIS/blob/master/csvjson(2).json)

Dataset of Movies with their cast & crew: [Movie cast & crew](https://github.com/Anukriti007/XMLProjectIS/blob/master/csvjson(1).json)


________________________________________
**Functional Requirements**
Search a movie by popularity, genre, cast and crew.

**_Scenario_**: A person wants to search a movie by different parameters. 

**_Dependencies_**: Movie recommendation data are available and accessible.

**_Assumptions_**: Ratings are out of 5.0



**Example 1.1**
Given: Data of Movie recommendations is available

When Search for "Comedy"

Then Should receive at least one result with these attributes
1.	Movie Title
2.	Release Date
3.	Production Country
4.	Original Language
5.	Runtime
6.	Cast & Crew
7.	Revenue generated
8.	Ratings

**Example 1.2**
Given: Data of Movie recommendations is available

When Search for "Jim Carrey"

Then Should receive at least one result with these attributes
1.	Movie Title
2.	Release Date
3.	Production Country
4.	Original Language
5.	Runtime
6.	Cast & Crew
7.	Revenue generated
8.	Ratings

________________________________________
**SCRUM Roles**

-Product Owner/ Scrum Master: Sukanya Wadawadagi

-DevOps/ Frontend Developer: Vaishnavi Dubal and Anukriti Sharma

-Integration Developer: Anukriti Sharma and Sukanya Wadawadagi
________________________________________
**Weekly Meetings**

Tuesday at 6 pm in-person (during Lecture)

Friday at 1 pm on Teams

