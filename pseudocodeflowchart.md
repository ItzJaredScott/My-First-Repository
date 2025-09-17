pseudocode 
---------------------------------------------------------
START
ASK for first name
READ firstName
ASK for last name
READ lastName
SET fullName = firstName + " " + lastName
PRINT "Hello " + fullName
ASK for first number
READ x
ASK for second number
READ y
ASK for third number
READ z
SET a = x + y + z
PRINT "Sum = " + a
PRINT "Subtraction = " + (x - y)
PRINT "Multiplication = " + (x * y)
PRINT "Division = " + (x / y)
END
------------------------------------------------
flowchart 
-----------------------------------------------
┌───────────────┐
│ START │
└──────┬────────┘
▼
┌─────────────────────────┐
│ Ask user for first name │
└─────────┬───────────────┘
▼
┌────────────────────────┐
│ Ask user for last name │
└─────────┬──────────────┘
▼
┌────────────────────────┐
│ Combine names & greet │
└─────────┬──────────────┘
▼
┌────────────────────────┐
│ Ask for first number │
└─────────┬──────────────┘
▼
┌────────────────────────┐
│ Ask for second number │
└─────────┬──────────────┘
▼
┌────────────────────────┐
│ Ask for third number │
└─────────┬──────────────┘
▼
┌────────────────────────────┐
│ Calculate sum (x+y+z) │
│ Calculate subtraction (x-y)│
│ Calculate multiplication │
│ Calculate division │
└─────────┬─────────────────┘
▼
┌────────────────────┐
│ Show all results │
└─────────┬──────────┘
▼
┌───────────────┐
│ END │
└───────────────┘
