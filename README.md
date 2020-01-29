# DealerOn Coding Test

## Alexander Stuart

I chose to do the "Mars Rover" option. My solution uses a toal of 4 classes:

1. Command Line Interface
2. Rover 
3. DirectionStateMachine 
4. Point

1) The command line interface is responsible for all the IO of the application. It reads from the console, parses and error checks the input, and passes along commands to a Rover object. The CLI also contains a function describing the proper usage of the application. 

2) The Rover object contains all the logic for tracking the bounds of the area and the current position of the rover. It exposes public functions for turning andmoving. It uses a Point object to track the bounds of the area and the current location of the rover. It uses a DirectionStateMachine to track the current direction the rover is facing. It has a custom error type for when the rover leaves the bounds of the area, in this case the rover does not move and notifies the user. It has a toString function for convenience.

3) The DirectionStateMachine is a simple state machine that tracks a Direction enumeration and exposes left and right turn functions. It also has a toString function for convenience.

4) The Point class is a very simple point abstraction that only allows the incrementing and decrementing of the internal (x, y) values. It also has a toString function for convenience.