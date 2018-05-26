*A simple Windows program made in C# to test C++ console applicatios for different test cases, speed and memory usage.*
[Directly Download The Release](https://github.com/vesk4000/Local-CPP-Judge-System/releases/tag/1.0.0)
## How to Use

**!Remember to temporarily turn off your antivirus program to stop it from interfering with the program, or put ```%appdata%\Vesk``` in the exceptions of your antivirus**

1. Run ```Release\Local C++ Judge System.exe```

3. Select your g++ compiler (it should get saved, so next time you don't have to select it); if you have [Code::Blocks](http://www.codeblocks.org/) installed it should have installed g++ with it; if you don't have g++ you can install [MinGW](http://www.mingw.org/)

3. Select the ```.cpp``` source file of your program (the program doesn't support programs with more than one source file)

4. Select the folder in which the tests are; each test is a ```.in``` input file and a ```.sol``` expected output;

5. Set the time limit (in milliseconds) for the program (the time limit is for each test case, not all of them combined)

6. Set the memory limit (in bytes) for the program (same as the time limit)

7. Press *Evaluate*

8. ```ok``` means that the output is right, ```wa``` means that the output is wrong, ```tl``` means that on the particular test your program's runtime exceeded the time limit, ```ml``` means that on the particular test your program's memory usage exceeded the memory limit
