<h2>Reports: <?php echo $report_name; ?></h2>

<?php if ($total_rows == 0) { ?>

<div id="alpha_search"><?php $this->load->view($this->_search); ?></div>
<?php $this->load->view($this->_report_nav); ?>

<div class="message error">
	<ul><li>No reports at this time</li></ul>
</div> <!-- .message -->

<?php } else { ?>
	
<div id="alpha_search"><?php $this->load->view($this->_search); ?></div>

<?php $this->load->view($this->_report_nav); ?>
<?php echo $this->table->generate($results); ?>
<?php echo $this->pagination->create_links(); ?>
<?php } ?>