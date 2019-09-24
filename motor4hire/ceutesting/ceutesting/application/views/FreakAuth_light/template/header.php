<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="en" xml:lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title><?=$this->heading.' &raquo; '.$this->config->item('FAL_website_name')?></title>
<link href="<?=base_url().$this->config->item('FAL_assets_front').'/'.$this->config->item('FAL_css');?>/fal_style.css" rel="stylesheet" type="text/css" media="screen, projection" />
<link href="<?=base_url().$this->config->item('FAL_assets_front').'/'.$this->config->item('FAL_css');?>/forms.css" rel="stylesheet" type="text/css" media="screen, projection" />
<link href="<?=base_url().$this->config->item('FAL_assets_front').'/'.$this->config->item('FAL_css');?>/print.css" rel="stylesheet" type="text/css" media="print" />
<script src="<?=base_url().$this->config->item('FAL_assets_shared').'/'.$this->config->item('FAL_js');?>/jquery.js" type="text/javascript"></script>
<script src="<?=base_url().$this->config->item('FAL_assets_shared').'/'.$this->config->item('FAL_js');?>/flash.js" type="text/javascript"></script>
</head>
<body class="<?php echo $page_class; ?>">

<div id="container">
<div id="container_inside">

<div id="header">
	<h1 id="logo"><a href="/index.php">AlphaNet</a></h1>
	<h1 id="program">Continuing Nursing Education Programs</h1>
	
	<ul id="nav_utility">
		<li id="nav_utility_login"><?=anchor($this->config->item('FAL_login_uri'), 'login')?></li>
	</ul>	
</div> <!-- close #header -->

<div id="wrap">

<div id="wrap_inside">

<?=$this->load->view('template/nav');?> 
		
<div id="content" class="full">