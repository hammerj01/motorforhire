<html>
<head>
  <title><?php echo $fulltitle; ?></title>
</head>

<body>
  <div align="center">
    <table border="2" cellpadding="4" style=
    "border-collapse: collapse" width="35%" id="table1"
    bordercolorlight="#FF0000" bordercolordark="#FF0000" height=
    "100">
      <tr>
        <td>
          <?
	
 	  $show="yes"; 


          if($show == "no") {
          $fulltitle = "$title - Error : $errortype"; }
          else {
          $fulltitle = "$title - Error $error : $errortype"; }
          ?>

          <p><font face="Verdana" size="-2">
          <? if($show == "no") { ?>
          </font></p>

          <center>
            <h2><font face="Verdana" size="-2"><font color=
            "#FF0000">Error</font> :
            <?php echo $errortype; ?></font></h2>
          </center><? } else {  ?>

          <center>
            <h2><font color="#FF0000">Error</font>
            <?php echo $error; ?> : <?php echo $errortype; ?></h2>
          </center><? } ?>

          <p><font size="2"><? if($error == "401") { ?>
          </font></p>
        </td>
      </tr>
    </table>

    <p>&nbsp;</p>

    <table border="2" cellpadding="4" style=
    "border-collapse: collapse" width="80%" id="table2"
    bordercolorlight="#FF0000" bordercolordark="#FF0000">
      <tr>
        <td>
          <b><font size="2">The document you requested 
          <? if(!$location) { }
          else { ?>
           (<font color="red"><?php echo $location; ?></font>) 
          <? } ?>
           has been password locked for a reason. If you have
          misplaced your password, or have a compelling reason to
          view the restricted information, please contact the
          <?php echo $emailcode; ?>site administrator.</font></b>

          <p><b><font size="2">Otherwise, please <a href=
          "javascript:history.back();" onmouseover=
          "window.status='Return to the previous page';return true"
          onmouseout="window.status='';return true" $title=
          "Return to the previous page">return</a> to the page you
          were at before. 
<? } elseif($error == "403") { ?>
           The access to this location <? if(!$location) { }
          else { ?>
           (<font color="red"><?php echo $location; ?></font>) 
          <? } ?>
           is denied. Please contact the
          <?php echo $emailcode; ?>webmaster if you think you
          should be allowed to view the information on this
          location.</font></b></p>

          <p><b><font size="2">Otherwise, please <a href=
          "javascript:history.back();" onmouseover=
          "window.status='Return to the previous page';return true"
          onmouseout="window.status='';return true" $title=
          "Return to the previous page">return</a> to the page you
          were at before. 
<? } elseif($error == "404") { ?>
           The document <? if(!$location) { }
          else { ?>
           (<font color="red"><?php echo $location; ?></font>) 
          <? } ?>
           you were searching for has either expired or migrated
          elsewhere. <? if($display_referer == "yes") { ?>
           Please inform the owner of <a href=
          "%3C?php%20echo%20$referer;%20?%3E" onmouseover=
          "window.status='Please inform the owner of the referring page';return true"
          onmouseout="window.status='';return true" $title=
          "Please inform the owner of the referring page">the
          referring page</a> about the malformed link.<? } ?>
           To find documents which have moved, we suggest you start
          at our <a href="/" target="_top" onmouseover=
          "window.status='Go to our mainpage';return true"
          onmouseout="window.status='';return true" $title=
          "Go to our mainpage">main page</a> or contact our
          <?php echo $emailcode; ?>webmaster. 

<%
          echo Location:  . $location . <br>
          echo "Error: " . $error . "<br>";
          echo "Error Type: " . $errortype . "<br>";
          echo "display_referer: " . $display_referer . "<br>";
%>


<? } elseif($error == "500") { ?>
           The script <? if(!$location) { }
          else { ?>
           (<font color="red"><?php echo $location; ?></font>) 
          <? } ?>
           you're trying to access has suffered a fatal error.
          Please try again at a later time. The site administrator
          has already been notified of the error; it may be helpful
          if you could contact our
          <?php echo $emailcode; ?>webmaster with any additional
          information about your form input. <? } else { ?>
           There was an unexplained error in retrieving your
          requested file <? if(!$location) { ?>
           . <? } else { ?>
           (<font color="red"><?php echo $location; ?></font>). 
          <? } ?>
           You may wish to try again from our <a href="/" target=
          "_top" onmouseover=
          "window.status='Go to our mainpage';return true"
          onmouseout="window.status='';return true" $title=
          "Go to our mainpage">main page</a>, or contact our
          <?php echo $emailcode; ?>webmaster with any additional
          details about what you did to reach this error message. 
          <? } ?>
          </font></b></p>
        </td>
      </tr>
    </table>
  </div>
</body>
</html>
