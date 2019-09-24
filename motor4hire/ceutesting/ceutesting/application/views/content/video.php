<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="en" xml:lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title><?=$this->heading.' &raquo; '.$this->config->item('FAL_website_name')?></title>
<link href="/public/frontend/css/fal_style.css" rel="stylesheet" type="text/css" media="screen, projection" />
<link href="/public/frontend/css/forms.css" rel="stylesheet" type="text/css" media="screen, projection" />
<link href="/public/frontend/css/print.css" rel="stylesheet" type="text/css" media="print" />
<script src="/public/shared/js/jquery.js" type="text/javascript"></script>
<script src="/public/shared/js/swfobject.js" type="text/javascript"></script>
</head>
<body class="video">
	
<div id="flashcontent">
<h2>Download the Flash Player</h2>
<p>Please <a href="http://www.adobe.com/products/flashplayer/">upgrade your Flash Player</a> to view this video.</p>
</div>

<script type="text/javascript">
// <![CDATA[

var so = new SWFObject("/public/shared/flash/video-2013a.swf?v=1.3", "sotester", "720", "526", "9", "#99cbed");
so.write("flashcontent");

// ]]>
</script>
		
</body>
</html>