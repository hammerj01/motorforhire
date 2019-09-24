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


<div id="sidebar">
	<?php
	if ( $page_class == 'about' ) {
		?>
	
<a href="http://prolastin.alphanetprofessionaled.org/about/methods" class="btn btn-mnu btn-lg"><span class="fa fa-external-link"></span> 3 Methods to Obtain<br>Contact Hours</a>
<a href="http://prolastin.alphanetprofessionaled.org/about/alphanet" class="btn btn-mnu btn-lg"><span class="fa fa-external-link"></span> About<br>AlphaNet and Alpha-1</a>

<!-- <a href="https://vimeo.com/148548414" class="fancybox-media btn btn-video btn-lg"><span class="fa fa-film"></span>  Watch Video</a>
	<div class="note-alpha note-video">
		Alpha-1 Antitrypsin Deficiency and Augmentation Therapy (Prolastin-C)<br />
	</div> -->
	
	<?php
	} elseif ( $page_class == 'library' ) {
			?>	
<a href="https://vimeo.com/280238882" class="fancybox-media btn btn-nvideo btn-lg"><span class="fa fa-film"></span>  Prolastin-C Liquid</a>
        <div class="note-alpha note-nvideo">
                Alpha-1 Antitrypsin Deficiency and Augmentation Therapy (Prolastin-C Liquid)<br>
        </div>

<!-- <a href="https://vimeo.com/148548414" class="fancybox-media btn btn-video btn-lg"><span class="fa fa-film"></span>  Watch Video</a>
	<div class="note-alpha note-video">
		Watch the video now to learn more about Alpha-1 Antitrypsin Deficiency and Augmentation Therapy. <em>Time: 51:53</em>
	</div> Jack -->


<!--	<a href="https://vimeo.com/280238882" class="fancybox-media btn btn-nvideo btn-lg"><span class="fa fa-film"></span>  Prolastin-C Liquid</a>
	<div class="note-alpha note-nvideo">
		Alpha-1 Antitrypsin Deficiency and Augmentation Therapy (Prolastin-C Liquid)<br>
	</div> -->

	<?php } else { ?>
	<?php if (!isValidUser()) { ?>

	<a href="http://prolastin.alphanetprofessionaled.org/auth/register" class="btn btn-register btn-lg"><span class="fa fa-file-text-o"></span>  Register Now</a>
	<div class="note-alpha note-register">
		Health Care Professionals register now to begin the on-line Continuing Education course.
	</div>
	<?php } ?>

<!--	<a href="https://vimeo.com/148548414" class="fancybox-media btn btn-video btn-lg"><span class="fa fa-film"></span>  Watch Video</a> 
	<div class="note-alpha note-video">
		Watch the video now to learn more about Alpha-1 Antitrypsin Deficiency and Augmentation Therapy. <em>Time: 51:53</em>
	</div> -->
	<a href="https://vimeo.com/280238882" class="fancybox-media btn btn-nvideo btn-lg"><span class="fa fa-film"></span>  Prolastin-C Liquid</a>
	<div class="note-alpha note-nvideo">
		Alpha-1 Antitrypsin Deficiency and Augmentation Therapy (Prolastin-C Liquid)<br>
	</div>

	<?php } ?>
</div> <!-- close #sidebar -->
