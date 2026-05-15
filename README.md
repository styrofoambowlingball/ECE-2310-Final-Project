# ECE-2310-Final-Project
Repository for storing files for my ECE2310 Pool Cleaning project

# -- Overview --

Design and implement a C# program that models a community with seven swimming
pools. Each Pool object composes a Temperature and a Location. Your program must
simulate a maintenance crew that visits all pools starting from (0, 0), always moving to
the nearest unvisited pool (greedy routing), and sets pool temperatures within the range
98°F to 104°F. https://imgur.com/NeviipG (image link for coordinate grid reference)

# Implement the following behaviors and constraints:

• Create three classes: Pool, Temperature, and Location.
• Pool has-a Temperature and has-a Location (composition).
• Temperature has: degree (numeric) and scale (e.g., 'F').
• Location has: x and y (e.g., doubles).
• Provide ToString() for all three classes for readable output.
• Provide additional public member methods as appropriate (e.g., distance between
pools).
• All methods must be public (per specification).
• Pool must have a static data member Count. Print Count before any Pool is created
and after each instantiation.
• Maintenance crew sets each pool’s temperature to a random integer in [98, 104] °F
(inclusive). Seed randomness once.
• Starting at (0, 0), visit the nearest unvisited pool; repeat until all seven pools are visited.
Each pool visited once.
• Display the full route and temperature set at each stop.
