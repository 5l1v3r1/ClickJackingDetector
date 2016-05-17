# ClickJackingDetector
Check for vulnerable-to-clickjacking  web pages 


ClickJacking Detector

Small lightweight program that help web developers and security researchers to test
 certain web page for clickjacking or  UI redressing AKA.

This program sends an http request with custom method indicated by the user and
 check response headers , specially  'the  X-Frame-Options' header  which stands for
 the mentioned vulnerability it displays its value and determine if the page is 
vulnerable or not  , also it display all other headers 

Note :404 response could not be checked as .NET throughs an exception on 404 and 
can not receive response headers  so can not check for UI Redressing 


