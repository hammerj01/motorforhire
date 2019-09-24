<?php
/*
*/


// Server Variables
$error = $_SERVER['REDIRECT_STATUS'];
$requested_url = $_SERVER['REQUEST_URI'];
$remote_ip_address = $_SERVER['REMOTE_ADDR'];
$server_name = $_SERVER['SERVER_NAME'];


function get_header($error_type) {

$top_table = '
    <center><table border="2" cellpadding="6" style=
    "border-collapse: collapse" width="50%" id="table1"
    bordercolorlight="#FF0000" bordercolordark="#FF0000" height=
    "100"><tr><td>
<center><font color="red" face="arial"><b><H2>' . $error_type . '</H2></b></font></center>';
return $top_table;
}

$bot_table = '<br><br><center><hr noshade color="red" width="100%"></center><font face=arial size=2><b>Technical Details</b><br> Error Number: '. $error . '
<br> Requested Document: ' . $server_name . $requested_url . '
<br> Referring IP: ' . $remote_ip_address . '
<br> Visiting Web Site: ' . $server_name . '<br>
        </td>
      </tr>
    </table></center>';


// Different error messages to display
switch ($error) {

# -----< Error 400 >---------------------------------------------------------------------------
case 400:
$top_table = get_header("Error 400 :: Bad Request");
$error_message = $top_table . '
        The URL that you requested, was a bad request.</p>
        mentioning the error message received and the page you were trying to
        reach. We are sorry for any inconvenience caused and we will do all we
        can to fix the error as soon as possible.</p>'
. $bot_table;
   break;


# -----< Error 401 >---------------------------------------------------------------------------
case 401:
$top_table = get_header("Error 401 :: Authorization Required");
$error_message = $top_table . '
        The URL that you requested, requires authorization to access it.
        Please contact the webmaster should you require further assistance.'
. $bot_table;
   break;


# -----< Error 403 >---------------------------------------------------------------------------
case 403:
$top_table = get_header("Error 403 :: Access Forbidden");
$error_message = $top_table . '
        Access to the URL that you requested, is forbidden.'
. $bot_table;
   break;


# -----< Error 404 >---------------------------------------------------------------------------
case 404:
$top_table = get_header("Error 404 :: Page Not Found");
$error_message = $top_table . '

           The document you were searching for is either outdated or has been moved.
           We suggest you start at our <a href="/" target="_top" onmouseover= "window.status=\'main page\';return true"
          onmouseout="window.status=\'\';return true" $title=
          "Go to our mainpage">main page</a> or contact our
          webmaster.
	' 

. $bot_table;
   break;

# -----< Error 500 >---------------------------------------------------------------------------
case 500:
$top_table = get_header("Error 500 :: Server Configuration Error");
$error_message = $top_table . '
        The URL that you requested, resulted in a server configuration error.'
. $bot_table;
   break;


# Unknown error
default:
$top_table = get_header("Unknown Error");
$error_message = $top_table . '
        <p>The URL that you requested, resulted in an unknown error.
        It is possible that the condition causing the problem will be gone by
        the time you finish reading this.'
. $bot_table;
}

// Display selected error message
echo($error_message);


?>
