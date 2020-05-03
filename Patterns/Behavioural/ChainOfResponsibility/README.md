Chain of responsibility is a behavioural pattern as it defines a manner for controlling communication between classes or entities. The chain of responsibility 
pattern is used to process varied requests, each of which may be dealt with by a different handler. The design pattern promotes loose coupling by allowing a 
series of handlers to be created in a linked list or chain. The request is passed to the first handler in the chain, which will either process it or pass it on 
to its successor. This continues until the request is processed or the end of the chain is reached. The handler responsible for the final processing of the 
request need not be known beforehand.

This style of processing is used by the exception handling system in C#. When an exception is thrown, the method that caused the exception is given the chance to
process it, via a try-catch block. If no suitable catch is available, the exception moves up to the calling method, which may include a try-catch. This continues
until the exception is handled or until there are no more possible handlers. The try-catch block itself can be thought of as using the chain of responsibility 
when multiple catches, each for a different type of exception, are given the option to handle an exception.