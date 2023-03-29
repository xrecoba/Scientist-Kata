# Scientist-Kata
Goal: Kata to practice the Scientist technique

# Situation
Imagine you are the new developer working for a restaurant high in the mountains.

There's a piece of Software in charge of deciding how will stock be refilled on a daily basis, and a function in in particular which is in charge of deciding how much of an item should we buy.
The rationale behind that function is fuzzy, looks like the decision depends on the weather, the stock and who knows what else. To make it worse, the implementation giberish, so you have decided to rewrite it from scratch to get a better understanding of the system.

You'd like to avoid running risks while gaining ownership of that code since you don't wanna mess up with stock. To refactor that code in a safe way, you have decided to use a Scientist approach:

> The idea is to create an alternative implementation of the code and then run multiple experiments to compare how does the new implementation behave in comparison to the old one.
An experiment consists of running the old code in production and the new code at the same time and then comparing the results. Once results are the same for a good bunch of your traffic then you can be confident that the behavior is the same (or almost, some cases may be uncovered with production traffic).

# Setup
* Open Scientist Kata solution and run all your tests (they are inside `TodaysTraffic` and `TomorrowsTraffic`). They should be passing.
* Take a look at `YourSystem` class, you'll see a call to `DependencyYouWannaReplace`. 
* Note there's a TODO in class `NewDependency`, you are expected to complete this class in order to be able to drop `DependencyYouWannaReplace`.

# The kata
* Create an experiment, with [.Net Scientist library](https://github.com/scientistproject/Scientist.net) 
* Re-run the tests from `TodaysTraffic` or `TomorrowsTraffic`, they should be failing now with a long error message. At the end of the error message you should see the difference between the outcome of the `NewDependency` and the `DependencyYouWannaReplace`.
* Implement logic in `NewDependency` until all the tests for `TodaysTraffic` pass.
* Check what happens now with tomorrow's traffic :)


Credits: Kata created while working as Agile Tech Coach for [SunwebGroup](https://www.sunwebgroup.com/).
