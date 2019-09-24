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

<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.2/css/bootstrap.min.css">
<link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet">
<style>
	body { background-color:#99cbed;}
.btn {
		padding-bottom: 10px;
		min-width: 220px;
	}

	
		.btn.btn-mnu {
		font-size: 95%;
		color: white;
		font-weight: 700;
		background-color: #17254a;
		background-image: linear-gradient(to bottom, #17254a, #304781);
		border-color: #6a6b6c #6a6b6c #6a6b6c;
		margin-bottom: 10px;
		min-width: 220px;
		box-shadow: 0px 0px 2px 0px black;
	}
	
	.btn.btn-mnu:hover {
		color: #dbdbdc;
		background-color: #a9e46a;
		background-image: linear-gradient(to bottom, #304781, #17254a);
		border-color: #adaeb0 #adaeb0 #adaeb0;
	}
	
	
	
	.btn.btn-register {
		color: #ffffff;
		background-color: #5aa30b;
		background-image: linear-gradient(to bottom, #5aa30b, #a9e46a);
		border-color: #6a6b6c #6a6b6c #6a6b6c;
		margin-bottom: 10px;
		min-width: 220px;
		box-shadow: 0px 0px 2px 0px black;
	}
	
	.btn.btn-register:hover {
		color: #black;
		background-color: #a9e46a;
		background-image: linear-gradient(to bottom, #a9e46a, #5aa30b);
		border-color: #adaeb0 #adaeb0 #adaeb0;
	}
	
	.btn.btn-video {
		color: #ffffff;
		background-color: #216ea0;
		background-image: linear-gradient(to bottom, #216ea0, #9acbeb);
		border-color: #6a6b6c #6a6b6c #6a6b6c;
		margin-bottom: 10px;
		min-width: 220px;
		box-shadow: 0px 0px 2px 0px black;
	}
	
	.btn.btn-video:hover {
		color: #ffffff;
		background-color: #419641;
		background-image: linear-gradient(to bottom, #9acbeb, #216ea0);
		border-color: #adaeb0 #adaeb0 #adaeb0;
	}
	
	.btn.btn-nvideo {
		color: #ffffff;
		background-color: #a0150b;
		background-image: linear-gradient(to bottom, #a0150b, #cc291d);
		border-color: #6a6b6c #6a6b6c #6a6b6c;
		margin-bottom: 10px;
		min-width: 220px;
		box-shadow: 0px 0px 2px 0px black;
	}
	
	.btn.btn-nvideo:hover {
		color: #ffffff;
		background-color: #419641;
		background-image: linear-gradient(to bottom, #cc291d, #a0150b);
		border-color: #adaeb0 #adaeb0 #adaeb0;
}
	
.note-alpha {
	padding: 8px 12px 8px 12px;
	margin-bottom: 16px;
	margin-top: -10px;
	min-width: 220px;
	max-width: 220px;
	border-bottom-left-radius: 5px;
	border-bottom-right-radius: 5px;
}
.note-video {
	background-color: #b7e0fb;
}
.note-nvideo {
	background-color: #f8c7c3;
}
.note-register {
	background-color: #d2f8a9;
}
</style>

<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"" type="text/javascript"></script>


<!-- Add jQuery library -->
	<script type="text/javascript" src="../lib/jquery-1.10.1.min.js"></script>
	<!-- Add mousewheel plugin (this is optional) -->
	<script type="text/javascript" src="../lib/jquery.mousewheel-3.0.6.pack.js"></script>

	<!-- Add fancyBox main JS and CSS files -->
	<script type="text/javascript" src="../source/jquery.fancybox.js?v=2.1.5"></script>
	<link rel="stylesheet" type="text/css" href="../source/jquery.fancybox.css?v=2.1.5" media="screen" />

	<!-- Add Button helper (this is optional) -->
	<link rel="stylesheet" type="text/css" href="../source/helpers/jquery.fancybox-buttons.css?v=1.0.5" />
	<script type="text/javascript" src="../source/helpers/jquery.fancybox-buttons.js?v=1.0.5"></script>

	<!-- Add Thumbnail helper (this is optional) -->
	<link rel="stylesheet" type="text/css" href="../source/helpers/jquery.fancybox-thumbs.css?v=1.0.7" />
	<script type="text/javascript" src="../source/helpers/jquery.fancybox-thumbs.js?v=1.0.7"></script>

	<!-- Add Media helper (this is optional) -->
	<script type="text/javascript" src="../source/helpers/jquery.fancybox-media.js?v=1.0.6"></script>

	<script type="text/javascript">
		$(document).ready(function() {
			/*
			 *  Simple image gallery. Uses default settings
			 */

			$('.fancybox').fancybox();

			/*
			 *  Different effects
			 */
            
            var pageURL = $(location).attr("href");
            if(pageURL != 'https://prolastin.alphanetprofessionaled.org/dashboard'){
             $("#nav_utility").css({"top":"51px","right":"140px"});
            }

			// Change title type, overlay closing speed
			
			$(".fancybox-effects-a").fancybox({
				helpers: {
					title : {
						type : 'outside'
					},
					overlay : {
						speedOut : 0
					}
				}
			});

			// Disable opening and closing animations, change title type
			$(".fancybox-effects-b").fancybox({
				openEffect  : 'none',
				closeEffect	: 'none',

				helpers : {
					title : {
						type : 'over'
					}
				}
			});

			// Set custom style, close if clicked, change title type and overlay color
			$(".fancybox-effects-c").fancybox({
				wrapCSS    : 'fancybox-custom',
				closeClick : true,

				openEffect : 'none',

				helpers : {
					title : {
						type : 'inside'
					},
					overlay : {
						css : {
							'background' : 'rgba(238,238,238,0.85)'
						}
					}
				}
			});

			// Remove padding, set opening and closing animations, close if clicked and disable overlay
			$(".fancybox-effects-d").fancybox({
				padding: 0,

				openEffect : 'elastic',
				openSpeed  : 150,

				closeEffect : 'elastic',
				closeSpeed  : 150,

				closeClick : true,

				helpers : {
					overlay : null
				}
			});

			/*
			 *  Button helper. Disable animations, hide close button, change title type and content
			 */

			$('.fancybox-buttons').fancybox({
				openEffect  : 'none',
				closeEffect : 'none',

				prevEffect : 'none',
				nextEffect : 'none',

				closeBtn  : false,

				helpers : {
					title : {
						type : 'inside'
					},
					buttons	: {}
				},

				afterLoad : function() {
					this.title = 'Image ' + (this.index + 1) + ' of ' + this.group.length + (this.title ? ' - ' + this.title : '');
				}
			});


			/*
			 *  Thumbnail helper. Disable animations, hide close button, arrows and slide to next gallery item if clicked
			 */

			$('.fancybox-thumbs').fancybox({
				prevEffect : 'none',
				nextEffect : 'none',

				closeBtn  : false,
				arrows    : false,
				nextClick : true,

				helpers : {
					thumbs : {
						width  : 50,
						height : 50
					}
				}
			});

			/*
			 *  Media helper. Group items, disable animations, hide arrows, enable media and button helpers.
			*/
			$('.fancybox-media')
				.attr('rel', 'media-gallery')
				.fancybox({
					openEffect : 'none',
					closeEffect : 'none',
					prevEffect : 'none',
					nextEffect : 'none',

					arrows : false,
					helpers : {
						media : {},
						buttons : {}
					}
				});

			/*
			 *  Open manually
			 */

			$("#fancybox-manual-a").click(function() {
				$.fancybox.open('1_b.jpg');
			});

			$("#fancybox-manual-b").click(function() {
				$.fancybox.open({
					href : 'iframe.html',
					type : 'iframe',
					padding : 5
				});
			});

			$("#fancybox-manual-c").click(function() {
				$.fancybox.open([
					{
						href : '1_b.jpg',
						title : 'My title'
					}, {
						href : '2_b.jpg',
						title : '2nd title'
					}, {
						href : '3_b.jpg'
					}
				], {
					helpers : {
						thumbs : {
							width: 75,
							height: 50
						}
					}
				});
			});

		});
		
	</script>
	<style type="text/css">
		.fancybox-custom .fancybox-skin {
			box-shadow: 0 0 50px #222;
		}
		
		var pageURL = $(location).attr("href");
            if(pageURL == 'https://prolastin.alphanetprofessionaled.org/dashboard'){
             $("#nav_utility").css({"top":"51px","right":"140px"});
            }
        

	</style>
    

</head>
<body class="<?php echo $page_class ?>">
	
<div id="container">
<div id="container_inside">

<div id="header">
	<h1 id="logo"><a href="/index.php">AlphaNet</a></h1>
	<h1 id="program">Continuing Nursing Education Programs</h1>
	
	<ul id="nav_utility">
		<?php if (isValidUser()) { ?>
			<li id="nav_utility_logout"><?=anchor($this->config->item('FAL_logout_uri'), 'Logout')?></li>
		<?php } else { ?>
			<li id="nav_utility_login"><?=anchor($this->config->item('FAL_login_uri'), 'login')?></li>
		<?php } ?>
	</ul>	
</div> <!-- close #header -->

<div id="wrap">

<div id="wrap_inside">

<?=$this->load->view($this->config->item('FAL_template_dir').'template_admin/nav');?>
		
<div id="content">