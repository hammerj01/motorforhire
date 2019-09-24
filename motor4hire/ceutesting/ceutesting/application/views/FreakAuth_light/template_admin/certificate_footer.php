</div> <!-- close #wrap_inside -->

<?php if ($page_class == 'prolastin') { ?>
<?=$this->load->view($this->config->item('FAL_template_dir').'template_admin/sidebar_prolastin');?> 
<?php } elseif ($page_class == 'dashboard') { ?>
<?=$this->load->view($this->config->item('FAL_template_dir').'template_admin/sidebar');?> 
<?php } elseif ($page_class == 'profile') { ?>
<?=$this->load->view($this->config->item('FAL_template_dir').'template_admin/sidebar_profile');?> 
<?php } ?>

</div> <!-- close #wrap -->	

<div id="foot">
	<p>Copyright &copy; <?= date("Y"); ?> AlphaNet. All Rights Reserved. By clicking on links to the educational program, you are agreeing to AlphaNet's <a href="http://www.alphanet.org/terms-of-use/">terms of use</a> and <a href="http://www.alphanet.org/privacy-policy/">privacy policy</a>.</p>
</div> <!-- close #foot -->
		
</div> <!-- close #container_inside -->
</div> <!-- close #container -->

<?=$this->load->view('template/analytics');?> 

</body>

</html>
