# Antiracist Screening Program

## System Requirements

This program can only run on Windows. It also requires access to .NET framework, which should already be included on a Windows machine.

## Installation

“Antiracist-Resource-Screening.zip” contains the “publish” folder, which contains setup.exe. Double-clicking setup.exe will prompt the user to install the desktop application Antiracist Resource Screening. On my computer, after installation, the executable was located at: 

    C:\Users\YourName\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Antiracist-Resource-Screening

It should be located somewhere similar for the grader's computer, but if otherwise, “Antiracist-Resource-Screening" should be searchable via the Windows search bar, where you can open and run the program.

## Usage

Running the program will display a single window titled “Antiracist Resource Screening.” This window allows the user to upload a file with the button “Select a file…” as well as select race-specific categories with a checkbox. After selecting a file and category/categories, the “Submit” button will commence with the screening process. The window displays an output message at the bottom of the screen once the program has finished screening the file, which states: “Document has been scanned. Please see new updated file: [FilePath].” The updated file will appear in the same directory as the original scanned file. If the user tries to upload a file without an extension that matches one of the 3 allowed, the screen instead displays: “Not a valid file type!” The user is able to select a different file and choose different categories multiple times in the same window without restarting the program.

There are several provided sample files (found in the "publish\samples" folder):
- terms.txt, terms.docx, and terms.pdf: contain terms/phrases found in the database of problematic language
- noterms.txt, noterms.docx, and noterms.pdf: do NOT contain terms/phrases found in the database

The program will work for .txt, .docx, and .pdf files with the following features/restrictions:
- .txt
    - Case-insensitive
    - Works for any length, but currently not scalable or efficient for very large files
    - Searches only for the first instance of the term
- .docx
    - Case-insensitive
    - Only works with documents <= 20 paragraphs
    - Searches for every instance of the term
- .pdf
    - Case-sensitive
    - Leaves watermark header of API
    - Searches for every instance of the term

The output of the program depends on the type of file scanned:
- .txt: Outputs a new file with asterisks on the terms found (to the same directory as the original file) with an endnote listing helpful resources pertaining to why the found terms are problematic. The new file name is [FileName]UPDATED.txt.
- .docx: Outputs markups to a new .docx file (to the same directory as the original file) with problem terms highlighted and footnoted with helpful information for the document author. The new file name is [FileName]UPDATED.docx.
- .pdf: Outputs markups to a new .pdf file (to the same directory as the original file) with problem terms highlighted and footnoted with helpful information for the document author. The new file name is [FileName]UPDATED.pdf

## Additional Information

As well as the "Samples" folder, the "publish" directory contains the folder "Source code (Relevant)", which has the main program's C# code, Form1.cs. Please use this for reference on how specifically the program is structured. There is also the folder "Source code (All)", which houses the entirety of the project's code. 

## Authors

Team Polar (Matt Koenig and Holly McLean) 
