<?php if (isAdmin()) { ?>
	<div id="admin_dash">
		<h2>Admin Dashboard</h2>
		<h5><?php echo anchor('dashboard/reports/pass', 'Passed &raquo;'); ?></h5>
		<h2 id="reports_passed"><?php echo $pass; ?> people</h2>
		<h5><?php echo anchor('dashboard/reports/fail', 'Failed &raquo;'); ?></h5>
		<h2 id="reports_failed"><?php echo $fail; ?> people</h2>
		<h5><?php echo anchor('dashboard/reports/progress', 'In Progress &raquo;'); ?></h5>
		<h2 id="reports_progress"><?php echo $progress; ?> people</h2>
		<h5><?php echo anchor('dashboard/reports/all', 'View All &raquo;'); ?></h5>
		<h2><?php echo $total; ?> people</h2>
	</div>

<?php } else { 

?>
	<h2>User Dashboard</h2>
<?php
	switch ($status) {
		case "fail":
			echo '<h5>Test Results:</h5><h2>'.$score.'% FAIL</h2>';
			break;
		case "pass":
		case "complete":
		case "progress":
			echo '<h5>Test Results:</h5><h2>'.$score.'% PASS</h2>';
			break;
	}
	
	$getting_started = '<h3>Steps to earning your credits:</h3>';
	$getting_started .= '<ol>';
	$getting_started .= '<li>Watch the video &raquo</li>';
	$getting_started .= '<li>Pass the test &raquo;</li>';
	$getting_started .= '<li>Complete the post-test evaluation &raquo;</li>';
	$getting_started .= '<li>Print your certificate &raquo;</li>';
	$getting_started .= '</ol>';
	
	echo $getting_started;
	
 	switch ($status) {
		case "pass":
			echo '<div class="message"><ul><li>You passed! You have not completed your evaluation yet. Please ' . anchor('dashboard/evaluation', 'complete your evaluation to receive your certificate') . '.</li></ul>	</div> <!-- .message -->';
			echo '<p id="button_eval">' . anchor('dashboard/evaluation', 'Complete your evaluation to receive your certificate') . '</p>';
			break;
		case "fail":
// 			echo '<p id="button_video_dashboard">' . anchor_popup('https://vimeo.com/280238882', 'Watch the video', $this->config->item('atts')) . '</p>';
			//echo '<p id="button_video_dashboard">' . anchor_popup('video', 'Watch the video', $this->config->item('atts')) . '</p>';
		  
		    echo '<a href="https://vimeo.com/280238882" rel="media-gallery" class="fancybox-media btn btn-nvideo btn-lg"><span class="fa fa-film"></span>  Watch the video</a>'; 
			echo '<br />';
			echo '<a href="dashboard/prolastin/take_test_again" class="btn btn-register btn-lg"><span class="fa fa-pencil"></span>  Take Test Again</a>';
			break;
		case "complete":
// 			echo '<p id="button_certificate">' . anchor('dashboard/extendedcertificate', 'Get Certificate') . '</p>';
            echo '<a href="dashboard/extendedcertificate" class="fancybox-media btn btn-nvideo btn-lg"><span class="fa fa-certificate"></span>  Get Certificate</a>';
			// test again
// 			echo ' <br />';
// 			if(isset($expiration_date)){
// 			   if(date("Y-m-d") > $expiration_date){
// 			     echo '<a href="dashboard/prolastin/take_test_again" class="btn btn-register btn-lg"><span class="fa fa-pencil"></span>  Take Test Again</a>';
// 			    }  
// 			}
			
		
			
			break;
		case "page_one":
		case "page_two":
		case "page_three":
		case "page_four":
            echo '<a href="https://vimeo.com/280238882" rel="media-gallery" class="fancybox-media btn btn-nvideo btn-lg"><span class="fa fa-film"></span>  Watch the video</a>'; 
			echo ' <br />';
			echo '<a href="dashboard/prolastin" class="btn btn-register btn-lg"><span class="fa fa-pencil"></span>Resume Test </a>';
			//echo '<p id="button_resume">' . anchor('dashboard/prolastin', 'Resume Test') . '</p>';
			break;
		default:
		    
		    echo '<a href="https://vimeo.com/280238882" rel="media-gallery" class="fancybox-media btn btn-nvideo btn-lg"><span class="fa fa-film"></span>  Watch the video</a>';  

			echo '<br />';
			 echo '<a href="dashboard/prolastin/take_test_again" class="btn btn-register btn-lg"><span class="fa fa-pencil"></span>  Take Test </a>';
	}
} 
?>