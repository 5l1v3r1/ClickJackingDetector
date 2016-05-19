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

<br />
Appearance
<img src='http://i.imgur.com/HOhMqLX.png' /> <br />
ico <img src='https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQyEFO2l3Nu2eDBeHMnwxBkLOFL3W6UMT6zl1qR7T6Lxze0ozX7PoH51w' />


<h2> Download </a>
<a href= 'http://www.mediafire.com/download/e9cjalnb85q1l2y/ClickJacking+Detector.rar' >Executable </a>
