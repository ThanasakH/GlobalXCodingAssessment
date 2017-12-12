# GlobalXCodingAssessment
The GlobalX coding assessment is just that, an assessment. The problem domain is deliberately simple, and you could very
easily write an extremely terse solution that satisfies the requirement. But our goal is not to see you implement a trivial sorting
algroithm. Most importantly it is to understand how your code communicates it's purpose clearly and with empathy to your
potential team members. What do we mean by empathy? Empathy here is caring about how easy your code is to understand
and navigate for the next engineer who touches it. Secondly it is to understand your ability to compose quality code that
adheres to SOLID (https://en.wikipedia.org/wiki/SOLID_(object-oriented_design)) principles. Thirdly, to see how you write
tests.

## The Goal: Name Sorter
Build a name sorter. Given a set of names, order that set first by last name, then by any given names the person may have. A
name must have at least 1 given name and may have up to 3 given names.

## Assessment Criteria
We will execute your submission against a list with a thousand names.
### Your submission must meet the following criteria.
The solution should be available for review on github.
- The names should be sorted correctly.
- It should print the sorted list of names to screen.
- It should write/overwrite the sorted list of names to a file called sorted-names-list.txt.
- Unit tests should exist.
- Minimal, practical documentation should exist.

# Practical Documentation
NameSorterApp is a project for GlobalXCodingAssessment to sort person name from text file in executing directory. The application supports on <i>Windows10 64bit, Ubuntu.16.10 64bit and OSX 64bit</i>.

1) Open <B>Commond prompt</B>.
2) Go to <B>Release directory</B> + <B>your operation system</B> </br>
  <i>(e.g. for Windows10 \NameSorterApp\bin\Release\netcoreapp2.0\win10-x64</br>
  for Ubuntu.16.10 \NameSorterApp\bin\Release\netcoreapp2.0\ubuntu.16.10-x64</br>
  for OSX \NameSorterApp\bin\Release\netcoreapp2.0\osx-x64
  )</i>
3) Execute command <B>NameSorterApp ./unsorted-names-list.txt</B>.
4) Check result on <B>screen</B> and <B>sorted-names-list.text</B> in operating directory.
