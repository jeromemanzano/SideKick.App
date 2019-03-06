# Requirements
- Initial screen says, "Hello World". After a few seconds, transition to a new screen.
- The new screen shows a username, avatar, and their local timezone HH:MM in 24 hours mode (local time).
- In the middle of the new screen, show a dynamic face clock with that time, and a button that makes the time go backward by 1 hour everytime it is pressed.
- Clicking a button at the very bottom of the screen will exit the application.

# Output
- Created a Custom Splash Screen with "Hello World" display. Splash Screen will show until the next screen has been loaded

![Alt Text](https://i.ibb.co/ZK5CXXd/Hello-world-splash.png)
- Created a new screen as requested in the requirements 

![Alt Text](https://i.ibb.co/7NJ6rxD/Portrait-Side-Kick.png)

# Nuget Packages used
- [Autofac](https://www.nuget.org/packages/Autofac/) - Used as IoC Container
- [Plugin.CurrentActivity](https://www.nuget.org/packages/Plugin.CurrentActivity/) - Used for getting the Current Activity instance

# Additional Feature
- Added handling for Landscape Orientation
- Setup AppCenter. App can be downloaded [here](https://install.appcenter.ms/users/jeromemanzano-personal.com/apps/sidekick-test/distribution_groups/public)

![Alt Text](https://i.ibb.co/jf0d5Kp/Landscape-Side-Kick.png)
