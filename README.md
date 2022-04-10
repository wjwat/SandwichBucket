# 🥪 The Sandwich Bucket 🥪

## Now hosted live at [sandwichbucket.club](http://sandwichbucket.club)

<img src="https://i.imgur.com/ExbewZk.png" />

#### "One of the worst websites I've ever seen." -- The Guy At The Bus Stop That I Showed It To

* Andy Plymate ([@Plymatea](https://github.com/Plymatea))
* Drew Henderson ([@DrewHendersonGitHub](https://github.com/DrewHendersonGitHub))
* Josh Tillinghast ([@jwtill](https://github.com/jwtill))
* Ryan Bass ([@probablynotryan](https://github.com/probablynotryan))
* William Jameson ([@wcjameson](https://github.com/wcjameson))
* William Watkins ([@wjwat](https://github.com/wjwat))

## :computer: Technologies Used

* C# / .NET 5.0
* ASP.NET Core
* Razor Pages
* Entity Framework Core
* JavaScript / JQuery
* HTML / CSS
* Python

## :memo: Description

Got a bucket? Got some sandwiches? Put the sandwiches in a bucket. Buckets are great for a lot of things. I think at some point in everyone's life they should have a moment where they say to themselves "This situation would be improved if I had a bucket with me right now". Then on top of that what if in that moment you were hungry as well? And the bucket had sandwiches? Phew, now you're talking about a completely different level to this thing. Chilling out, eating sandwiches, you've got a bucket; what else is there?

Second scenario: You're a prominent physician, the talk of the town, and someone murders the love of your life: your wife. The police blame you, but you're innocent. What do you do? You escape, you go on the run, you take your sandwich bucket and do your best to prove your innocence. "PUT THE SANDWICH DOWN!" they yell, but you can't. That sandwich will prove your innocence. So you jump. You jump for freedom, for America, for your wife. You've just made an enemy for life in Tommy Lee Jones. And he hates buckets.

## :gear: Setup/Installation & Usage Instructions

- [Install the MySQL Community Server & MySQL Workbench](https://dev.mysql.com/downloads/mysql/)
- [Install the .NET 5 SDK](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)
- Install the [dotnet-ef](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) tool with this command: `dotnet tool install --global dotnet-ef`
- [Clone this
  repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)
  to your device
- Create `appsettings.json` in the top level of this repo
  - Copy the contents of the code below into this file. *Make sure to change the password to the password you used to setup your MySQL server*
  ```JSON
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=sandwich_bucket;uid=root;pwd=<PASSWORD>;"
    }
  }
  ```
- [Using your
  terminal](https://www.freecodecamp.org/news/how-you-can-be-more-productive-right-now-using-bash-29a976fb1ab4/)
  navigate to the directory where you have cloned this repo.
- Run `dotnet build` in the top level directory of this repo.
- Once the project has been built run `dotnet ef database update` to create the database necessary to run the app.
- Run `dotnet run` to get the program running, and the site hosted locally.
- Open your browser and visit `http://localhost:5000/`
- Bask

## :page_facing_up: Notes

## :lady_beetle: Known Bugs

- Visiting the URL for the site allows you to view it.

## :warning: License

[MIT License](https://opensource.org/licenses/MIT)

Copyright (c) 2022 SandwichBucket Team