Singleton is a creational pattern as it is used to control class instantiation. The pattern ensures that only one object of a particular class is ever created. 
All further references to objects of the singleton class refer to the same underlying instance.

The singleton pattern is useful when a single, global point of access to a limited resource is required. It is more appropriate than creating a global variable as 
this may be copied, leading to multiple access points and the risk that the duplicates become out of step with the original.