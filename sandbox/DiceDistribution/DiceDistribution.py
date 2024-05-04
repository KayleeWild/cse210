import random

tallies = []   # for counting the results of dice throws
experimentSize = 10_000_000   # how many times to throw virtual dice

def prepare_tally_list():
# initialize the list for counting rolls of dice
    for i in range(13):
        tallies.append(0)
        # the minimum roll of two dice is 2, "snake eyes,"
        # so tallies[0] and tallies[1] will not be used

def throw_lots_of_dice():
# roll dice many times and track the results
    print(f"Now rolling {experimentSize:,} pairs of dice.")
    for roll in range(experimentSize):
        die1 = random.randint(1,6)
        die2 = random.randint(1,6)
        total = die1 + die2
        tallies[total] += 1
    print(" ... finished rolling. Distribution graph:")

def display_results():
# display a graph of the tallies; should look somewhat like a triangular "bell curve"
    scale = experimentSize//200
    for i in range(2,13):
        print(f"{i: 3d}: ", end='')
        for graph_unit in range(tallies[i]//scale):
            print("#", end='')
        print(f" ({tallies[i]:,})")
    print(f" (Scale: each # represents {scale:,} rolls.)")

# The main program starts here. It just calls the three previously defined funcitons.
prepare_tally_list()
throw_lots_of_dice()
display_results()