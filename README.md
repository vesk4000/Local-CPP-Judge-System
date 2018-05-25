*A simple Windows program made in C# to test C++ console applicatios for different test cases, speed and memory usage.*

## How to Use

**!Remember to temporarily turn off your antivirus program to stop it from interfering with the progaram, or put ```%appdata%\Vesk``` in the exceptions of your antivirus**

1. Run ```Release\Local C++ Judge System.exe```

3. Select your g++ compiler (it should get saved, so next time you don't have to select it); if you have [Code::Blocks](http://www.codeblocks.org/) installed it should have installed g++ with it; if you don't have g++ you can install [MinGW](http://www.mingw.org/)

3. Select the ```.cpp``` source file of your program (the program doesn't support programs with more than one source file)

4. Select the folder in which the tests are; each test is a ```.in``` input file and a ```.sol``` expected output;

5. Set the time limit (in milliseconds) for the program (the time limit is for each test case, not all of them combined)

6. Set the memory limit (in bytes) for the program (same as the time limit)

7. Press Evaluate

8. ```ok``` means that the output is right, ```wa``` means that the output is wrong, ```tl``` means that on the particular test your program's runtime exceeded the time limit, ```ml``` means that on the particular test your program's memory usage exceeded the memory limit


### Markdown

Markdown is a lightweight and easy-to-use syntax for styling your writing. It includes conventions for

```markdown
Syntax highlighted code block

# Header 1
## Header 2
### Header 3

- Bulleted
- List

1. Numbered
2. List

**Bold** and _Italic_ and `Code` text

[Link](url) and ![Image](src)
```

For more details see [GitHub Flavored Markdown](https://guides.github.com/features/mastering-markdown/).

### Jekyll Themes

Your Pages site will use the layout and styles from the Jekyll theme you have selected in your [repository settings](https://github.com/vesk4000/Local-CPP-Judge-System/settings). The name of this theme is saved in the Jekyll `_config.yml` configuration file.

### Support or Contact

Having trouble with Pages? Check out our [documentation](https://help.github.com/categories/github-pages-basics/) or [contact support](https://github.com/contact) and we’ll help you sort it out.
