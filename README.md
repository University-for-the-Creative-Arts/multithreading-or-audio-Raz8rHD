# Commentary
- For this task, I decided to integrate a professional audio middleware system in Unity. In order to integrate FMOD, I had to download the FMOD Unity package from the website.
After I completed this step, I proceeded to install Unity on my Mac, as my audio design software is located there (Logic Pro, FMOD). I made sure to have everything prepared before starting the task.
- I opened Unity, clicked on “Assets”, then “Import Package”, from which I selected “Custom Package” and managed to add FMOD. From here, I clicked on FMOD in the top bar of Unity, went into the settings
and opened “Bank Import.” I had to choose the “Studio Project Path” but was greeted with an error stating that there was no existing “build” of this project. To fix this, I opened FMOD, assigned my track
to a default bank called “Master,” and then, from File, selected Build All Platforms. Now, the path was detected in Unity, and I could carry on.
- In Unity, I created an empty object and named it “Audio Master.” I added a new component and selected “FMOD Studio Event Emitter.” I could choose the start trigger for this event, so I selected
“Object Start” since I wanted my music to play as soon as the game opened. In the event section, I copied and pasted the name of the event that I wanted FMOD to play — for example, “event:/23.10.”
Immediately after entering Play Mode, the song started playing, so everything worked accordingly.
- To get my Unity project ready for a platform, I clicked on File, then selected “Build Profiles.” Here, I had two options: to either build my project for macOS or Windows. To make sure I got the most out of this task,
I proceeded to build for both platforms and tested to see if they were working. After the builds were completed, I tested both and got positive results, as both were functioning correctly.
- Since both projects worked completely fine, I opened GitHub to commit the changes but faced another problem. Because I had not placed the project in the cloned folder on my laptop, but rather on the desktop,
GitHub did not detect any changes made to my Unity project. So, I moved the entire folder into the cloned repository, but I had over 38,000 changes, which I was not allowed to commit since they exceeded the limit.
One of my colleagues suggested adding a “.gitignore” file to my original repository, as this would ignore the unnecessary files and allow me to commit my project properly. After adding this file, my number of commits
was reduced significantly, and I was able to commit and finish the task successfully.
