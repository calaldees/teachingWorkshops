App Development
===============

Session 1 - Development Process Overview
----------------------------------------

* Overview
    * Introduction
        * Global Professional Background (role in team)
        * How a professional app development team works
            * 'Agile' Methodology
            * Business Objectives (Solution providers)
* Roles in an agile development team
    * Developer
    * Test Engineer
    * Sysadmins
    * Scrum Master (Head of Software)
    * Product Manager
    * Product Owner
    * Design
    * User Experience (UX)
    * Analytics
    * (caution about any weak link in this chain)
* Agile software development team practice
    * Concept of a Sprint (2 Week Period)
        * Tickets Lifecycle ([Jira](https://www.atlassian.com/software/jira))
            * Deliverable Feature
                * Title from business/user perspective
                * COS's (Conditions of success)
            * Sizing (Fibonacci)
            * Feature Review
            * QA/Testing
            * Defenition of 'Done' (Bringing business value)
        * Sprint Planning
        * Daily Standups
        * Bug Triage
            * Remove 'opinion'. The secret [formula](http://)
        * Retrospective
            * Sailboat: Rocks, Anchor, Wind
* Avocado - App Interaction
    * Business objectives
        * Live Radio
            * Localization
        * Articles/Gallery's
        * My Radio (Half way between spotify and live radio)
            * Allow Skip (not presenters or adverts)
        * Listen Again (Episode expiry)
        * Adverts
        * Login (tracking)
        * Terms and Conditions
* The difference between Android and iOS
    * Android
        * 1000's devices/os combinations
        * [Material Design](https://material.io/)
    * iOS
        * App store approval
        * [Human Interface Guidelines](https://developer.apple.com/ios/human-interface-guidelines/overview/themes/)
            * No physical back button
            * Bounce Scroll
* Guacamole
    * Current Objectives
        * Global as a public facing brand
        * Moods (that span brands)
        * Listen Again Episodes/subscription
            * Offline
            * Notifications
        * Login required (for analytics)

Session 2 -
-----------------------------------------------


Futher Notes
------------

* The lifecycle of app development
    * Iterations, MVP, Sizing the backlog
    * Feature Releasing
    * Beta split user base releasing
    * Monitoring/Analytics
* Software tooling
    * Device Simulators/Devices
    * Design Sharing ([Zeplin](https://zeplin.io/))
    * Continuous Integration Pipelines ([Jenkins](https://jenkins.io/))
        * Automated Tests ([Appium](http://appium.io/))
        * Android Auto Upload - Release per sprint
    * App Configuration ([Herald](http://herald.musicradio.com/api/avocado/services/))
        * Turning features on/off
    * Crash Feedback ([Fabric](http://www.fabric.io/))
    * Useage Feedback ([Firebase](https://firebase.google.com/))
    * Push Notification ([Swrve](https://www.swrve.com/))
* Three Pillars
    * Quality
    * Cost
    * Time
* The bad (Reflection)
    * Features Features Features
        * Situation: The only thing that is valued/measured/rewarded is user features
        * Problem: No time is spent on maintaining developer tooling
        * Outcome: Rising cost of future features and higher daily running costs
    * Automated Testing (a second class citizen)
        * Situation: Time invested in automated testing is neglected to get tickets through faster
        * Problem: Inconstant slow repetitive manual testing must now take places continuously. More bugs and live outages.
        * Outcome: Quality of the product goes down
    * 'Design Lead' Product
        * Situation: Design make nice pictures. Business says 'We want the shiny pictures'
        * Problem: The shiny thing is actually not workable as a user interface when the whole journey is considered
        * Outcome: More time is spent implementing features that will not yield business value/objectives
