<?php $this->load->view('template/header'); ?> 

<h2>3 Methods to Obtain Contact Hours</h2>
		
		<ul>
			<li><a href="#online">Take the Course On-Line</a></li>
			<li><a href="#online-offline">View the Video On-Line and Complete the Course Off-Line</a></li>
			<li><a href="#offline">Take the Course Off-Line</a></li>
		</ul>
		
<h3 id="online">Take the Course On-Line</h3>
<ol>
<li>View the video (Running time: 54:48).</li>
<li>View the accompanying Library materials.</li>
<li>Complete and submit the on-line Registration Form.</li>
<li>Complete and submit the on-line Test.</li>
<li>Complete and submit the on-line Evaluation Form.</li>
</ol>
<p>You may view the video at your own pace. Although the entire video is approximately 55 minutes, you may choose to stop and return at your convenience.  You may find it helpful to print the accompanying Library materials to use as a reference.  Additionally, you may want to print the test and complete the questions as you view the video and then transfer the answer to the on-line test for submission.</p>
<p>Submission of the Registration Form, Test and Evaluation Form are required in order to obtain Contact Hours.  A score of 80% or better on the post-test is required for successful completion.   An electronic certificate will be sent to your provided email address upon successful completion.</p>
<p class="callout"><?=anchor($this->config->item('FAL_register_uri'), 'Start the On-Line Course now')?></p>


<h3 id="online-offline">View the Video On-Line and Complete the Course Off-Line</h3>
<ol>
<li>View the video (Running time: 54:48).</li>
<li>View and/or print the accompanying Library materials.</li>
<li>Print and complete the Registration Form.</li>
<li>Print and complete the Test.</li>
<li>Print and complete the Evaluation Form.</li>
<li>Mail or Fax the Registration Form, Test and Evaluation Form to AlphaNet.</li>
</ol>
<p>You may view the video at your own pace. Although the entire video is approximately 55 minutes, you may choose to stop and return at your convenience.</p>
<p>Submission of the Registration Form, Test and Evaluation Form are required in order to obtain Contact Hours.  A score of 80% or better on the post-test is required for successful completion.    A certificate will be mailed to your provided mailing address upon successful completion.</p>
<p class="callout"><?=anchor('library', 'View the video program now')?></p>


<h3 id="offline">Take the Course Off-Line</h3>
<ol>
<li>Request that a DVD program with accompanying Library materials is  	mailed to your designated address.</li>
<li>Complete the Registration Form.</li>
<li>Complete the Test.</li>
<li>Complete the Evaluation Form.</li>
<li>Mail or Fax the Registration Form, Test and Evaluation Form to AlphaNet.</li>
</ol>
<p>Submission of the Registration Form, Test and Evaluation Form are required in order to obtain Contact Hours.  A score of 80% or better on the post-test is required for successful completion.    A certificate will be mailed to your provided mailing address upon successful completion.</p>
<p class="callout"><?php echo safe_mailto('tkitchen@alphanet.org', 'Request a DVD program now'); ?></p>

<?php $this->load->view('template/footer'); ?> 