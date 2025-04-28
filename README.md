# EventEaseApp
A Blazor WebAssembly project created as part of the Coursera Blazor for Front-End Development course

Full Disclosure: I opted to use Github Copilot rather than Microsoft Copilot.

Step 1: Using Copilot to Generate Blazor Code
    This step almost certainly went the smoothest. I asked GitHub Copilot to generate code based on the necessary fields for an Event. I also learned something not mentioned in the course, that adding a new folder requires adding that folder/namespace to _Imports.razor, though I had to prompt Copilot a handful of times with the error before it notified me of that issue. But, overall, the actual coding went smoothly.

Step 2: : Using Microsoft Copilot for Debugging and Optimization

    This step also went very smoothly. I simply asked Github Copilot for recommendations on how to optimize the areas specified in the project. It quickly generated a list of ten optimizations, some of which it pointed out were already used in the codebase. I implemented two that it hadn't and moved on.

Step 3: Develop a Comprehensive Blazor Project with Microsoft Copilot
    This is where things went off-the-rails. After a brief side comment by the instructor in the video, about switching reading the data from JSON so the data would persist, I decided I wanted to try that.
    Little did I know that Blazor Web Assembly wouldn't be able to update a JSON file in the wwwroot folder, as that is static content. But, this is where Github Copilot recommended that I put the events.json file I wanted to replace my hard-coded list of events. What followed was an hour of Copilot recommending technologies, the VSCode terminal spouting errors, then when I informed the Copilot of the errors, the response was "well, that wouldn't work, do this instead" which only led to more errors.

    Eventually, I decided this sidequest wasn't worth the migraine, I implemented the additional features specified in Activity Three, then typed this out.